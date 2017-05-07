open System

let items=[5;6;7;8]

let newItem=items
                |>List.filter(fun x->x%2=0)
                |>List.map(fun x-> printfn "its %d" x)
                |>printfn "SO we have %O" 


let add x=x+1
let mult x=x*5

let stuff=add>>mult
stuff 200

let str1="this is a random string"
let str2= @"I ignore backlsashes \we ae \\\"
let str3=""" "I ignore doble quites" but i can do this as well \iu "y\o" """


let str4= String.collect(fun c-> sprintf "%c,  " c) " commas"
str1,str2,str3,str4
