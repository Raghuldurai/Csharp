class practical2n
{
	public static void Main(string[] args)
	{
		double f=System.Convert.ToDouble(args[0]);
		double c=System.Convert.ToDouble(args[0]);
		double r=System.Convert.ToDouble(args[0]);
		
		
		double d=System.Math.Sqrt(1/f*c)-((r*r)/(4*c*c));
		
		
		System.Console.WriteLine("{0} un ",d);
		
	}
}