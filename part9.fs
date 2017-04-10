//If you are defining classes that need to interop with other .NET code, do not define them
//inside a module! Define them in a namespace instead, outside of any module.

//The reason for this is that F# modules are exposed as static classes, and any F# classes defined
//inside a module are then defined as nested classes within the static class,
//which can mess up your interop. For example, some unit test runners don’t like static classes.


// Note: this code will not work in an .FSX script,
// only in an .FS source file.
namespace MyNamespace

type TopLevelClass() =
    let nothing = 0

module MyModule =

    type NestedClass() =
        let nothing = 0


//To declare that a class inherits from another class, use the syntax:
type DerivedClass(param1, param2) =
    inherit TopLevelClass()



//to define an abstract method, we use the signature syntax, along with the abstract member keywords:
[<AbstractClass>]
type Animal() =
    abstract member MakeNoise: unit -> unit

type Dog() =
    inherit Animal()
    override this.MakeNoise () = printfn "woof"

// test
// let animal = new Animal()  // error creating ABC