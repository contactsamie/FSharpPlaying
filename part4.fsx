let concat (a,b)=a+" : "+b
let concat2 a b=a+" : "+b
let concat3=fun(a,b)->a+" : "+b
let x="1"
let y="2"
(x,y) |> concat,
y|>(x|>concat2),
(x,y) |> concat3