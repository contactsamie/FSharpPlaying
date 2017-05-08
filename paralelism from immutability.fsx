open System
let is_prime n=
     let rec check i=
            i> n/2 || (n % i <> 0 && check(i+1))
     check 2

let prime_seq n=seq {
    for n in 1 ..n 
        do
            if is_prime n
            then yield n 
}
let _t =fun f a -> 
     let startTime= DateTime.UtcNow
     printfn "Starting at %A .." startTime
     let result= f a
     printfn "It took %.5f Seconds to run" (DateTime.UtcNow-startTime).TotalSeconds
     result


_t prime_seq 50000000 |> _t Seq.fold (fun ac item -> ac+1) 0 