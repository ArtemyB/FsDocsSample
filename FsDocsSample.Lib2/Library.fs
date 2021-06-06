namespace FsDocsSample.Lib2



/// <summary>
/// Module #2
/// </summary>
/// <namespacedoc>
/// <summary>
/// Main namespace of Lib2
/// </summary>
/// </namespacedoc>
module MyModule2 =

    open FsDocsSample.Lib1

    /// Greetings function
    let hello name =
        printfn "Hello %s" name


    /// Function that creates an instance of <see cref="T:FsDocsSample.Lib1.IMyInterface1"/>
    let createObjOfInterface1 (prop1: string) (fun1: int -> string) =
        { new IMyInterface1 with
              member this.Method1(arg1: int): string =
                  fun1 arg1

              member this.Prop1: string = prop1 }


    /// <summary>
    /// Function that always throws an exception
    /// </summary>
    /// <exception cref="T:FsDocsSample.Lib1.MyException">
    /// Inevitable exception
    /// </exception>
    let alwaysFail () =
        raise <| MyException("Inevitable error")


/// My interface #2
type IMyInterface2 =
    /// Prop2
    abstract member Prop2 : System.DateTime
