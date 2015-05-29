namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("XtestFSharp1")>]
[<assembly: AssemblyProductAttribute("XtestFSharp1")>]
[<assembly: AssemblyDescriptionAttribute("Testing building with fsharp")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
