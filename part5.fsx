
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

let items=[1..5]
items |> prod,
items |> sum,
items |> prodFold,
items |> sumFold