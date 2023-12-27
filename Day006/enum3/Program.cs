class Program
{
	static void Main()
	{
		int result = (int)HTTPStatus.OK;
		Console.WriteLine(result);
		
		HTTPStatus resultenum = (HTTPStatus)500;
		//HTTPStatus resultenum = (HTTPStatus)1001; out: 1001
		Console.WriteLine(resultenum);
	}
}
public enum HTTPStatus
{
	OK = 200,
	NotFOund = 404,
	Redirect = 300,
	InternalServerError = 500
}
