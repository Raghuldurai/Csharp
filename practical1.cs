class practical1
{
	public static void Main(string[] args)
	{
		double b=System.Convert.ToDouble(args[0]);
		decimal a=System.Convert.ToDecimal(args[1]);
		
		System.Console.WriteLine("{0} paisa ",a*100 );
		System.Console.WriteLine("{0} paisa ",b/100 );
		
	}
}