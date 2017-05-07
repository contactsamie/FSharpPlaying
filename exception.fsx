open System
let divide x y=
     try 
        if y=0 then raise(DivideByZeroException "cant divide by zero")
        else 
         
         printfn "%i / %i = %i" x y (x/y)
     with
        | :? DivideByZeroException as ex -> 
                printfn "Sorry cant divide by zero"


divide 5 0

divide 5 6

//Sorry cant divide by zero
//5 / 6 = 0