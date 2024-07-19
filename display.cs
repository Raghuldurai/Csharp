using System;

class first{
	public string c = "C#";
}

class second{
	public string prg = "programming";
}

class display{

	public static void field(){
		first fst = new first();
		second scnd = new second();
		Console.WriteLine(fst.c + scnd.prg);
	}

	public static void Main(string[] args){

		field();
	}

}