// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let rec algorithmE m n =
  if n = 0 then m
  else algorithmE n (m % n)

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
