
let prod l=
  let  mutable acc=1
  for item in l do
      acc<-acc*item
  acc

let sum l=
  let  mutable acc=0
  for item in l do
      acc<-acc+item
  acc

let prodFold l=l|>Seq.fold(*) 1
let sumFold l=l|>Seq.fold(+) 0


let rec myprod p= match p with
                  |[] -> 1
                  |[h] -> h 
                  |[h;n] -> h*n
                  |h::t -> h * myprod t

let result= myprod [1..5] = Seq.fold(*) 1 [1..5]


let items=[1..5]
items |> prod,
items |> sum,
items |> prodFold,
items |> sumFold