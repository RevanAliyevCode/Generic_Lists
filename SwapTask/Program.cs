// See https://aka.ms/new-console-template for more information
using SwapTask;

string value = "name";
string value1 = "My";

Swap.SwapValues(ref value, ref value1);
Console.WriteLine($"{value} {value1}");