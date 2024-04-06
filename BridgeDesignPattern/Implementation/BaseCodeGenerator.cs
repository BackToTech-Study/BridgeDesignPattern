using System.Text;

namespace BridgeDesignPattern.Implementation;

public class BaseCodeGenerator
{
    private StringBuilder _stringBuilder = new StringBuilder();
    
    public void AddCode(string code)
    {
        _stringBuilder.AppendLine($"{code}");
    }

    public void AddCode(List<string> code)
    {
        foreach (var line in code)
        {
            _stringBuilder.AppendLine($"{line}");
        }
    }

    public string GetCode()
    {
        return _stringBuilder.ToString();
    }
    
    public List<string> IndentCodeSection(List<string> body)
    {
        var result = new List<string>();
        foreach (var line in body)
        {
            result.Add($"\t{line}");
        }
        return result;
    }
}