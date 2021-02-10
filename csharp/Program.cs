using System;
using System.Threading.Tasks;

namespace ConsumerExample
{
    class Program
    {
        static void Main(string[] args)
        {
	        var pc = new PhoneConsumer
                {
                    Project = Environment.GetEnvironmentVariable("SW_PROJECT"),
                    Token = Environment.GetEnvironmentVariable("SW_TOKEN"),

                    Contexts = new System.Collections.Generic.List<string>() { Environment.GetEnvironmentVariable("SW_CONTEXT") }
                };
		Console.WriteLine("Listening for context: ");
		Console.WriteLine(Environment.GetEnvironmentVariable("SW_CONTEXT"));
                pc.Run();
        }
    }
}
