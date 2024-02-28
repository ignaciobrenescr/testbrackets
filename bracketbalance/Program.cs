// See https://aka.ms/new-console-template for more information
using bracketbalance;

//var test = "{}{}}";

//var test = "{}{";
//var test = "{}{}}";
//var test = "{}{}";
///var test = "{{}}";
var test = "{}}}}}";

Console.WriteLine(test + ":" +  Balance.isBalance(test));
Console.ReadLine();