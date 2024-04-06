// See https://aka.ms/new-console-template for more information


using BridgeDesignPattern.Abstraction;
using BridgeDesignPattern.Implementation;

var jsCodeGenerator = new JSCodeGenerator();
var pythonCodeGenerator = new PythonCodeGenerator();

var jsBubbleSortExample = new BubbleSortExample(jsCodeGenerator);
var pythonBubbleSortExample = new BubbleSortExample(pythonCodeGenerator);
Console.WriteLine(jsBubbleSortExample.GetCode());
Console.WriteLine(pythonBubbleSortExample.GetCode());


var jsSwapExample = new SwapExample(jsCodeGenerator);
var pythonSwapExample = new SwapExample(pythonCodeGenerator);
Console.WriteLine(jsSwapExample.GetCode());
Console.WriteLine(pythonSwapExample.GetCode());
