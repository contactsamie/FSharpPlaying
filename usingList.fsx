open System

let list1=[1;2;3;4]
list1 
       |> List.iter ( printfn "Num : %i")   



let k=5::6::7::[]

k

let list5=List.init 5 (fun i-> i*2)
printfn "%A" list5

// generating list using yield

let list6=[
             for a in 1..3 
              do yield (a*a)
           ]

printfn "%A" list6 //val list6 : int list = [1; 4; 9]

let list66=[
             for a in 1..3 
              do yield [a]
           ]

printfn "%A" list66 //val list66 : int list list = [[1]; [2]; [3]]



let list7=[
             for a in 1..3 
              do yield! [a..a+2]
           ]

printfn "%A" list7 //val list7 : int list = [1; 2; 3; 2; 3; 4; 3; 4; 5]
printfn "Head : %i" list7.Head //Head : 1
printfn "Tail : %A" list7.Tail //Tail : [2; 3; 2; 3; 4; 3; 4; 5]
// in fold you are passed an accumulator, but you need to provide an accumultor value
printfn "SumA :%i" (List.fold(fun sum elem ->sum+elem) 0 [1;2;3;4])
printfn "SumB :%i" (List.fold(+) 0 [1;2;3;4])
let ($)=fun x y -> x+y

printfn "SumC :%i" (List.fold($) 0 [1;2;3;4])