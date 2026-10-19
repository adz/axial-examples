namespace Axial.ReferenceApp.Tests

open Reified.Schema.Testing
open Axial.ReferenceApp
open Xunit

/// Schema-derived test data: the same declaration that parses boundary input also
/// generates valid boundary input, so property tests need no hand-written fixtures.
module SchemaGenTests =

    [<Fact>]
    let ``schema-generated structured data survives a JSON round trip`` () =
        SchemaGen.roundTrip Contracts.workspaceV2
        |> Result.defaultWith (fun error -> failwithf "%A" error)
