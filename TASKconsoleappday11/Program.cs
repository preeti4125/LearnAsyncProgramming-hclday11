
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        LearnAsyncProgramming obj = new LearnAsyncProgramming();

        await obj.Run();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
