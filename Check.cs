class Check
{
	int a = 25;
	char b = 'H';
	float c = 2.3F;
	byte d = 2;
	short e = 3; 
	bool f = true;
	double g = 33.2D;
	public static void Main(string[] args)
	{
		Check obj = new Check(); 
		System.Console.WriteLine(obj.a);
		System.Console.WriteLine(obj.b);
		System.Console.WriteLine(obj.c +"\n"+ obj.d +"\n"+ obj.e);
		System.Console.WriteLine(obj.f);
		System.Console.WriteLine(obj.g);
		System.Console.WriteLine("min value of int = "+int.MinValue +" and max value for int ="+int.Maxvalue);
		System.Console.WriteLine("min value of byte = "+byte.MinValue +" and max value for byte="+byte.Maxvalue);



		
	}
 
}
