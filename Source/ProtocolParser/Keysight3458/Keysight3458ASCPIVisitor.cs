//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Develop\Open-SCPI-Protocol-Emulator\ProtocolParser\Keysight3458\Keysight3458ASCPI.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace ProtocolParser.Keysight3458A {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="Keysight3458ASCPIParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public interface IKeysight3458ASCPIVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="Keysight3458ASCPIParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommand([NotNull] Keysight3458ASCPIParser.CommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Keysight3458ASCPIParser.identificationQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentificationQuery([NotNull] Keysight3458ASCPIParser.IdentificationQueryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Keysight3458ASCPIParser.readQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReadQuery([NotNull] Keysight3458ASCPIParser.ReadQueryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Keysight3458ASCPIParser.abortCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAbortCommand([NotNull] Keysight3458ASCPIParser.AbortCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Keysight3458ASCPIParser.configureCurrentCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConfigureCurrentCommand([NotNull] Keysight3458ASCPIParser.ConfigureCurrentCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Keysight3458ASCPIParser.configureVoltageCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConfigureVoltageCommand([NotNull] Keysight3458ASCPIParser.ConfigureVoltageCommandContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Keysight3458ASCPIParser.measureCurrentQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMeasureCurrentQuery([NotNull] Keysight3458ASCPIParser.MeasureCurrentQueryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Keysight3458ASCPIParser.measureVoltageQuery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMeasureVoltageQuery([NotNull] Keysight3458ASCPIParser.MeasureVoltageQueryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Keysight3458ASCPIParser.currentParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCurrentParameters([NotNull] Keysight3458ASCPIParser.CurrentParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="Keysight3458ASCPIParser.voltageParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVoltageParameters([NotNull] Keysight3458ASCPIParser.VoltageParametersContext context);
}
} // namespace ProtocolParser.Keysight3458A
