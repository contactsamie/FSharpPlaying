open System.Net
open System.IO
let loadPrices ticker=
    let netWorkisAvailable= System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()
    if netWorkisAvailable then
            let url ="http://ichart.finance.yahoo.com/table.csv?s="+ ticker
            let req = url |> WebRequest.Create
            let resp =  req.GetResponse()
            let stream=resp.GetResponseStream()
            let reader = new StreamReader(stream)
            let csv=reader.ReadToEnd()
            let prices =
                csv.Split([|'\n'|])
                |> Seq.skip 1
                |> Seq.map (fun line -> line.Split([|','|]))
                |> Seq.filter (fun values -> values |> Seq.length = 7 )
                |> Seq.map (fun values -> values.[0] |> System.DateTime.Parse,values.[6] |> float)
            prices
    else
        [0.0] |> Seq.map (fun values ->  (System.DateTime.UtcNow,values))
loadPrices "msft"