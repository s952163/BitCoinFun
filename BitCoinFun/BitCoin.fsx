#r @"..\packages\FSharp.Data.2.3.3\lib\net40\FSharp.Data.dll"

open System
open System.Net
open FSharp.Data
open FSharp.Data.JsonExtensions

let getBitCoinPx() = 

    let url = """http://api.coindesk.com/v1/bpi/currentprice/USD.json"""
    use client =  new WebClient()
    let result = client.DownloadString(url)

    let json = JsonValue.Parse(result)
    let fx = (json?bpi?USD?rate_float).AsFloat()                                  
    let time = (json?time?updatedISO).AsDateTime()
    (fx,time.ToString())

getBitCoinPx()


