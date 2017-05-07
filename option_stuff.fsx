open System

let option_stuff a b=
      let divide x y =
                    match y with
                    | 0 -> None
                    | _ -> Some(x/y)
      printfn "%A" (divide a b )


option_stuff 5 8