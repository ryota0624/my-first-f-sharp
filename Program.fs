open System;

type UserId = UserId of string
type ConstructedUser(id: UserId) = 
    member this.toStr() = id

type User = NotRegistered | Registered of ConstructedUser

let printUser user = 
    match user with
    | NotRegistered -> printfn "iam not registered"
    | Registered constructedUser -> printfn $"iam constructed user ({constructedUser.toStr()})"


// For more information see https://aka.ms/fsharp-console-apps
printUser User.NotRegistered
Guid.NewGuid().ToString() 
    |> UserId
    |> ConstructedUser 
    |> Registered 
    |> printUser 