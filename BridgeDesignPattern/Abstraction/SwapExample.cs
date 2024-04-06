using BridgeDesignPattern.Implementation;

namespace BridgeDesignPattern.Abstraction;

public class SwapExample : CodeSample
{
    public SwapExample(ICodeGenerator codeGenerator) : base(codeGenerator)
    {
        _codeGenerator.AddCode(_codeGenerator.GetComment("Swap two numbers"));
        
        var firstValue = _codeGenerator.GetVariable("first", "Number", "5");
        var secondValue = _codeGenerator.GetVariable("second", "Number", "3");
        var swap1 = _codeGenerator.GetVariable("temp", "Number","first");
        var swap2 = _codeGenerator.GetAssignment("first", "second");
        var swap3 = _codeGenerator.GetAssignment("second", "temp");
        
        _codeGenerator.AddCode(firstValue);
        _codeGenerator.AddCode(secondValue);
        _codeGenerator.AddCode(swap1);
        _codeGenerator.AddCode(swap2);
        _codeGenerator.AddCode(swap3);
        
        _codeGenerator.AddCode(_codeGenerator.GetPrintStatement("first"));
        _codeGenerator.AddCode(_codeGenerator.GetPrintStatement("second"));
    }
}