using BridgeDesignPattern.Implementation;

namespace BridgeDesignPattern.Abstraction;

public class CodeSample
{
    protected ICodeGenerator _codeGenerator;
    
    public CodeSample(ICodeGenerator codeGenerator)
    {
        _codeGenerator = codeGenerator;
    }
    
    public string GetCode()
    {
        return _codeGenerator.GetCode();
    }
}