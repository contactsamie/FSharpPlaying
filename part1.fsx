let items = [1..4]
let square x = x*x
let sumOfSquaresRegular nums =
    let mutable acc=0
    for x in nums do
        acc <- acc+square x
    acc
let rec sumOfSquaresMaths nums =
    match nums with
    | []         -> 0
    | [h]        -> square h
    | [h;t]      -> square h + square t
    | h::t       -> square h + sumOfSquaresRegular t

let rec sumOfSquaresDeclarative nums =
    nums
    |> Seq.map square
    |> Seq.sum


sumOfSquaresRegular items
sumOfSquaresMaths items
sumOfSquaresDeclarative items
