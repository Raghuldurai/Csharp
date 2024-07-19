using System;

class Pattern{
	string a = "*";
	string b = "***";
	string c = "*****";
	public static void Main(string[] args){
		Pattern obj = new Pattern();
		Console.WriteLine("  {0}\n {1}\n{2}\n {3}\n  {4}",obj.a,obj.b,obj.c,obj.b,obj.a);
	}
}