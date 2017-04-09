open System.Net
open System.IO

//let ticker ="msft"
let loadPrices ticker=
        let url ="http://ichart.finance.yahoo.com/table.csv?s="+ ticker
        let req =WebRequest.Create(url)
        let resp = req.GetResponse();
        let stream=resp.GetResponseStream()
        let reader = new StreamReader(stream)
        let csv=reader.ReadToEnd()
        let prices =
            csv.Split([|'\n'|])
            |> Seq.skip 1
            |> Seq.map (fun line -> line.Split([|','|]))
            |> Seq.filter (fun values -> values
                                            |> Seq.length = 7 )
            |> Seq.map (fun values ->
                            System.DateTime.Parse(values.[0]),
                            float values.[6]
                        )
        prices


loadPrices "msft"