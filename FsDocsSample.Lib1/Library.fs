namespace FsDocsSample.Lib1

/// <summary>
/// Interface 1
/// </summary>
/// <namespacedoc>
/// <summary>
/// Main namespace of Lib1
/// </summary>
/// </namespacedoc>
type IMyInterface1 =
    abstract member Prop1 : string
    abstract member Method1 : int -> string


/// My exception type
type MyException(msg: string) =
    inherit System.Exception(msg)