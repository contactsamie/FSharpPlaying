let seq1=seq{1..100}
let seq2= seq{0..2..50} // generating only even number

//1 5 9 13 17
let seqm=seq{1..5..17}
let seqml=seqm|> Seq.toList // he he he BAD GUESS val seqml : int list = [1; 6; 11; 16]
let seq3= seq{ 50 .. 1}

// seq is not generated until it is needed

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

printfn "%A" prime_seq

let res=prime_seq 5000
            |>Seq.toList 
            |> List.iter ( printfn "%i") 

prime_seq 500000 |> Seq.fold(fun ac item -> ac+1) 0 

