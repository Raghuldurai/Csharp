class Ty1
{
	public static void Main(string[] args)
	{
		int a=101;
		object ob1=(object)a;
		
		int b=102;
		object ob2=b;
	
		int c=(int)ob2;
			
		System.Console.WriteLine(ob1);
		System.Console.WriteLine(ob2);
		System.Console.WriteLine(c);
	}
}