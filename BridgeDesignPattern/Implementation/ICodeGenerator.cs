namespace BridgeDesignPattern.Implementation;

public interface ICodeGenerator
{
    public string GetComment(string comment);
    public string GetVariable(string name, string type, string? value = null);
    public string GetAssignment(string variable, string value);
    
    public string GetArray(List<string> values);
    public string GetArrayLength(string array);
    public string GetArrayElementAtPosition(string array, string index);
    
    public List<string> GetIfStatement(string condition, List<string> body);
    public List<string> GetElseStatement(List<string> body);
    
    public string GetTrue();
    public string GetFalse();
    public string GetBreak();

    public List<string> GetForLoop(string loopVariable, string start, string end, string increment, List<string> body);
    
    public string GetPrintStatement(string value);
    
    public void AddCode(string code);
    public void AddCode(List<string> code);
    public string GetCode();
}