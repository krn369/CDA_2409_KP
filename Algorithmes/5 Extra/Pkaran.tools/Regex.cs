using System;
using System.Text.RegularExpressions;


string pattern = "Karan";
// string toSearch = "Karan Pariyar";

Console.WriteLine("Karan PARIYAR : " + Regex.IsMatch("Karan PARIYAR", pattern));
Console.WriteLine("Karanmaharjan PARIYAR : " + Regex.IsMatch("Karanmaharjan PARIYAR", pattern));
Console.WriteLine("ByaKaran : " + Regex.IsMatch("ByaKaran", pattern));
