//this is a moniod coz all elements are moniods
//rule 1:closure 1+2=2+1
//rule 2: associativity (1+2)+3=1+(2+3)
//rule 3: identity element 0+1=1+0,""+"hi"="hi"+"" etc
type OtderLine={qty:int;amount:float}

let orderLines=[
    {qty=2; amount=10.0};
    {qty=1; amount=10.2};
    {qty=22; amount=10.7}
]


let addPair x  y={qty=(x.qty+y.qty);amount= (x.amount+y.amount)}

orderLines |> Seq.reduce addPair

// a monad is a monoid in the category of endofunctors