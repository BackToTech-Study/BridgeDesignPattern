using System.Text;

namespace BridgeDesignPattern.Implementation;

public class PythonCodeGenerator : BaseCodeGenerator, ICodeGenerator
{
    public string GetComment(string comment)
    {
        return $"# {comment}";
    }

    public string GetVariable(string name, string type, string? value = null)
    {
        var result = $"{name}";
        return value == null ? $"{result}" : $"{result} = {value}";
    }

    public string GetAssignment(string variable, string value)
    {
        return $"{variable} = {value}";
    }
    
    public string GetArray(List<string> values)
    {
        return $"[{string.Join(", ", values)}]";
    }
    
    public string GetArrayLength(string array)
    {
        return $"len({array})";
    }
    
    public string GetArrayElementAtPosition(string array, string index)
    {
        return $"{array}[{index}]";
    }    

    public List<string> GetIfStatement(string condition, List<string> body)
    {
        var result = new List<string>();
        var nestedCode = IndentCodeSection(body);
        result.Add($"if {condition}:");
        result.AddRange(nestedCode);    
        return result;
    }

    public List<string> GetElseStatement(List<string> body)
    {
        var result = new List<string>();
        var nestedCode = IndentCodeSection(body);
        result.Add("else:");
        result.AddRange(nestedCode);
        return result;
    }

    public string GetTrue()
    {
        return "True";
    }
    
    public string GetFalse()
    {
        return "False";
    }
    
    public string GetBreak()
    {
        return "break";
    }

    public List<string> GetForLoop(string loopVariable, string start, string end, string increment, List<string> body)
    {
        var result = new List<string>();
        var nestedCode = IndentCodeSection(body);
        result.Add($"for {loopVariable} in range({start}, {end}, {increment}):");
        result.AddRange(nestedCode);
        return result;
    }
    
    public string GetPrintStatement(string value)
    {
        return $"print({value})";
    }
}