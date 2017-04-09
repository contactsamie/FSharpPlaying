let items= [1..10]

let sumA =items |> Seq.sum
let sumB=items |>Seq.reduce(+)
let sumC=items |> Seq.fold(+) 0
sumA,sumB,sumC