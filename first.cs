using System;

class first{
	string c = "C#";
}

class second{
	string prg = "programming";
}

class display{
	public static void Main(string[] args){

		field();
	}
	public void field(){
		first fst = new first();
		second scnd = new second();
		Console.WriteLine(fst.c + scnd.prg);
	}
}