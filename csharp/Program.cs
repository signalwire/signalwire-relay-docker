using System;
using System.Threading.Tasks;

namespace ConsumerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => {
                var pc = new PhoneConsumer
                {
                    Project = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                    Token = "PTXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",

                    Contexts = new System.Collections.Generic.List<string>() { "ExampleContext" }
                };
                pc.Run();
     
            });
            Console.WriteLine("Running...");
            Console.ReadKey();
        }
    }
}
