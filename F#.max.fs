let max2 x y =
   if x>y then x
   else y

let p1_1 = 
  let b = System.Convert.ToInt32(System.Console.ReadLine())
  let c = System.Convert.ToInt32(System.Console.ReadLine())
  max2 b c

[<EntryPoint>]
let main argv =
 let Ans=p1_1
 System.Console.Write(Ans)
 let z = System.Console.ReadKey()
 0