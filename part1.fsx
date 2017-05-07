let items = [1..4]
let square x = x*x
//regular
let sumOfSquaresRegular nums =
    let mutable acc=0
    for x in nums do  acc <- acc+square x
    acc

//recursive
let rec sumOfSquaresMaths nums =
    match nums with
    | []         -> 0
    | [h]        -> square h
    | [h;t]      -> square h + square t
    | h::t       -> square h + sumOfSquaresRegular t

//sequence
let rec sumOfSquaresDeclarative1 nums = nums  |> Seq.map square |> Seq.sum
let rec sumOfSquaresDeclarative2 nums = nums  |> Seq.map square |> Seq.reduce(+)
let rec sumOfSquaresDeclarative3 nums = nums  |> Seq.map square |> Seq.fold(+) 0
let rec sumOfSquaresDeclarative4 nums = nums  |> Seq.map square |> Seq.reduce (fun s x->s+x)
let rec sumOfSquaresDeclarative5 nums = nums  |> Seq.map square |> Seq.fold (fun s a-> s+a) 0
let addup1 x=fun(y)->x+y
let addup2 x y=fun()->x+y
let addup3 x y=x+y
let addup4 (x,y)=x+y
let addup5 (x:int, y:int)=x+y

sumOfSquaresRegular items,
sumOfSquaresMaths items,
sumOfSquaresDeclarative1 items,
sumOfSquaresDeclarative2 items,
sumOfSquaresDeclarative3 items,
[1..10]|>Seq.sum,
addup1 1 2,
addup2 1 2,
(addup2 1 2)(),
addup3 1 2,
addup4 (1,2),
addup5 (1,2)