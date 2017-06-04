(*
open FSharp.Azure.StorageTypeProvider

type Live =
    AzureTypeProvider< @"DefaultEndpointsProtocol=https;AccountName=bitcoinfunabcb;AccountKey=BMgRS8M78kjc9qj+fx6UslFHwvGwwIICY/EcAtvKpwOqeCMaSL48aXMeanTDGO7zLWlxDUrVlfB7cFdi185HpQ==;">

let employee = Local.Tables.employee.Get(Row "1", Partition "somepartition")
*)


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
