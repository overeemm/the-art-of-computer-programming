// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let algorithmM x =
  let lastIndex = (Array.length x) - 1
  let rec findMax j k m =
    if k = 0 
      then (j, m)
      elif x.[k] <= m 
        then findMax j (k - 1) m
        else findMax k k x.[k]
  findMax lastIndex (lastIndex - 1) x.[lastIndex]

[<EntryPoint>]
let main argv = 
    printfn "%A" (algorithmM [| 1; 2; 8; 4; 5; 6 |])
    0 // return an integer exit code
