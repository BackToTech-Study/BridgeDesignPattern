using System.Text;
using BridgeDesignPattern.Implementation;

namespace BridgeDesignPattern.Abstraction;

public class BubbleSortExample : CodeSample
{
    public BubbleSortExample(ICodeGenerator codeGenerator) 
        : base(codeGenerator)
    {
        _codeGenerator.AddCode(_codeGenerator.GetComment("Bubble sort algorithm"));
        AddArrayInitialization();
        
        var arraySize = _codeGenerator.GetArrayLength("numbers");
        _codeGenerator.AddCode(_codeGenerator.GetVariable("array_size", "Number", arraySize));
        
        var falseValue = _codeGenerator.GetFalse();
        var outerLoopBody = new List<string>();
        outerLoopBody.Add(_codeGenerator.GetVariable("swapped", "Bool", falseValue));
        
        var swapBody = GetSwap();
        var swapConditionLeft = _codeGenerator.GetArrayElementAtPosition("numbers", "j");
        var swapConditionRight = _codeGenerator.GetArrayElementAtPosition("numbers", "j + 1");
        var swap = _codeGenerator.GetIfStatement($"{swapConditionLeft} > {swapConditionRight}", swapBody);
        var innerLoop = _codeGenerator.GetForLoop("j", "0", "array_size - i - 1", "1", swap);
        outerLoopBody.AddRange(innerLoop);
        
        var breakStatement = _codeGenerator.GetBreak();
        var breakCondition = _codeGenerator.GetIfStatement($"swapped == {falseValue}", new List<string> { breakStatement });
        outerLoopBody.AddRange(breakCondition);
        
        var outerLoop = _codeGenerator.GetForLoop("i", "0", "array_size - 1", "1", outerLoopBody);
        _codeGenerator.AddCode(outerLoop);
        
        _codeGenerator.AddCode(_codeGenerator.GetPrintStatement("numbers"));
    }
    
    private void AddArrayInitialization()
    {
        _codeGenerator.AddCode(_codeGenerator.GetComment("Array of numbers to sort"));
        var arrayValues = _codeGenerator.GetArray(new List<string> { "5", "3", "8", "4", "2" });
        _codeGenerator.AddCode(_codeGenerator.GetVariable("numbers", "Array", arrayValues));
    }

    private List<string> GetSwap()
    {
        List<string> code = new ();
        
        var tempValue = _codeGenerator.GetArrayElementAtPosition("numbers", "j");
        code.Add(_codeGenerator.GetVariable("temp", "Number", tempValue));
        
        var nextValue = _codeGenerator.GetArrayElementAtPosition("numbers", "j + 1");
        code.Add(_codeGenerator.GetAssignment($"numbers[j]", nextValue));
        
        code.Add(_codeGenerator.GetAssignment($"numbers[j + 1]", "temp"));
        
        var valueTrue = _codeGenerator.GetTrue();
        code.Add(_codeGenerator.GetAssignment("swapped", valueTrue));
        
        return code;
    }
}