open System

type Animal = class
     val Name : string
     val Height : float

     new (name, height)=
          {Name=name; Height =  height;}
     member this.Run = 
          printfn "%s Runs" this.Name
end

type Dog(name, height) =
     inherit Animal(name, height)
     member x.Bark =
       printfn "%s Barks" x.Name
       
let classStuff()=
     let spot= new Animal("Yo", 2.2)

     spot.Run
     let bowser = new Dog("yoyo", 3.3)
     bowser.Run


classStuff()




