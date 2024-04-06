namespace BridgeDesignPattern.Implementation;

public class JSCodeGenerator : BaseCodeGenerator, ICodeGenerator
{
    public string GetComment(string comment)
    {
        return $"// {comment}";
    }

    public string GetVariable(string name, string type, string? value = null)
    {
        var result = $"var {name}";
        return value == null ? $"{result};" : $"{result} = {value};";
    }

    public string GetAssignment(string variable, string value)
    {
        return $"{variable} = {value};";
    }
    
    public string GetArray(List<string> values)
    {
        return $"[{string.Join(", ", values)}]";
    }
    
    public string GetArrayLength(string array)
    {
        return $"{array}.length";
    }
    
    public string GetArrayElementAtPosition(string array, string index)
    {
        return $"{array}[{index}]";
    }
    
    public List<string> GetIfStatement(string condition, List<string> body)
    {
        var result = new List<string>();
        var nestedCode = IndentCodeSection(body);
        result.Add($"if ({condition}) {{");
        result.AddRange(nestedCode);
        result.Add("}");
        return result;
    }
    
    public List<string> GetElseStatement(List<string> body)
    {
        var result = new List<string>();
        var nestedCode = IndentCodeSection(body);
        result.Add("else {");
        result.AddRange(nestedCode);
        result.Add("}");
        return result;
    }

    public string GetTrue()
    {
        return "true";
    }
    
    public string GetFalse()
    {
        return "false";
    }
    
    public string GetBreak()
    {
        return "break;";
    }

    public List<string> GetForLoop(string loopVariable, string start, string end, string increment, List<string> body)
    {
        var result = new List<string>();
        var nestedCode = IndentCodeSection(body);
        result.Add($"for (var {loopVariable} = {start}; {loopVariable} < {end}; {loopVariable} += {increment}) {{");
        result.AddRange(nestedCode);
        result.Add("}");
        return result;
    }
    
    public string GetPrintStatement(string value)
    {
        return $"console.log({value});";
    }
}