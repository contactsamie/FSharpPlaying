open System

let mapstuff()=
     let customers=
          Map.empty.
             Add("first",6928.9).
             Add("yo",7635.2)

     printfn "# of Customers %i" customers.Count
     let cust= customers.TryFind "yo"
     match cust with 
      | Some x -> printfn "Balance : %.2f" x
      | None -> printfn "Not found"

     printfn "Customers :%A" customers

     printfn "Bobs Balance : %.2f" customers.["first"]

     let cust2= Map.remove "yo"  customers
     printfn "# of customers %i" cust2.Count


mapstuff()

//# of Customers 2
//Balance : 7635.20
//Customers :map [("first", 6928.9); ("yo", 7635.2)]
//Bobs Balance : 6928.90
//# of customers 1
//val it : unit = ()