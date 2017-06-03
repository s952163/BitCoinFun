#r @"..\packages\FSharp.Data.2.3.3\lib\net40\FSharp.Data.dll"

open System.Net
open FSharp.Data
open FSharp.Data.JsonExtensions

let url = """http://api.coindesk.com/v1/bpi/currentprice/USD.json"""
let client =  new WebClient()
let result = client.DownloadString(url)
printfn "%s" result

let json = JsonValue.Parse(result)
let fx = json?bpi?USD?rate_float

