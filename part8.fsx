type Animal(name:string)=
    member this.Name=name

type Human()=

    // private immutable value
    let mutable privateValue =1
    let worker=fun()->(privateValue<-privateValue+1)|>ignore
    //The “do” code can also call any let-bound functions defined before it
    do worker()
    member this.Work=fun()->worker()

    member this.GetCount=fun()->privateValue
     // standalone method
    member this.AddOne x =
        x + 1

    // calls another method
    member this.AddTwo x =
        this.AddOne x |> this.AddOne

    // parameterless method
    member this.Pi() =
        3.14159


type World={people:Human;animal:Animal}

let earth={people=Human(); animal=Animal("yuppy")}

earth.people.Work()
earth.people.Work()
earth.people.Work()
earth.people.GetCount()
