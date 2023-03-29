open System
open System.IO

let renameAllFiles searchStr replaceStr confirmed =
    let renameFile (oldFileName: string) =
        let newFileName = oldFileName.Replace(searchStr, replaceStr, StringComparison.CurrentCultureIgnoreCase)
        if confirmed then
            File.Move(oldFileName, newFileName)
        else
            printfn $" {oldFileName} -> {newFileName}"
    Directory.GetFiles(".", $"*{searchStr}*")
    |> Array.map (fun f -> f.Substring(2))
    |> Array.iter renameFile

[<EntryPoint>]
let main args =
    match args with
    | [| searchStr; replaceStr |] -> 
        renameAllFiles searchStr replaceStr false
        1
    | [| searchStr; replaceStr; "CONFIRM" |] ->
        renameAllFiles searchStr replaceStr true
        0
    | _ ->
        printfn "Renames all files in a directory. Syntax:"
        printfn "RenameAllFiles.exe searchString replaceString [CONFIRM]"
        1