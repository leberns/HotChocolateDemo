# HotChocolateDemo

## Hot Chocolate Basic Demo (GraphQL Server)

- https://chillicream.com/docs/hotchocolate/get-started

´´´
cd C:\Dev\GitHub\leberns\HotChocolateDemo\SimpleDemo

dotnet add package HotChocolate.AspNetCore
´´´

Start VS Code on HotChocolateDemo\SimpleDemo and debug it

## Crypto Workshop App

- https://crypto-workshop.chillicream.com/docs/Hot%20Chocolate

´´´
mkdir BasicServer
C:\Dev\GitHub\leberns\HotChocolateDemo\BasicServer
dotnet new globaljson
dotnet new -i HotChocolate.Templates::13.0.0-preview.19

dotnet new graphql
dotnet restore

dotnet run
´´´

browse https://localhost:5001/graphql/
