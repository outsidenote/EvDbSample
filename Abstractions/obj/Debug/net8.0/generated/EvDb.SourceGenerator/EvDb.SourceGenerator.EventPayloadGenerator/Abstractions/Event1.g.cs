#nullable enable
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
#pragma warning disable CS0108 // hides inherited member.

using System.Collections.Immutable;
using System.Text.Json;
// ####################  GENERATED AT: 2025-12-04 20:05:38 ####################
namespace Abstractions;
using EvDb.Core;
#pragma warning disable SYSLIB1037 // Deserialization of init-only properties is currently not supported in source generation mode.

// ReSharper disable once UnusedType.Global

[System.CodeDom.Compiler.GeneratedCode("EvDb.SourceGenerator","4.0.25.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]

partial record Event1: IEvDbPayload
{
    public static string PAYLOAD_TYPE => "Event1";
    [System.Text.Json.Serialization.JsonIgnore]
    string IEvDbPayload.PayloadType => PAYLOAD_TYPE;


} 
