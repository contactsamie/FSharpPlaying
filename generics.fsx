open System

let addstuff<'T> x y=
     printfn "%A" (x+y)
let genericstuff()=
    addstuff<int> 5 2

addstuff 5 2
addstuff<float> 5.9 2.0 // error

genericstuff()