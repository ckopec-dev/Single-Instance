
class Program
{
    static void Main()
    {
        const string mutexName = "Global\\MyUniqueDotNet8AppMutex";

        using var mutex = new Mutex(initiallyOwned: true, name: mutexName, out bool createdNew);

        if (!createdNew)
        {
            Console.WriteLine("Another instance of this program is already running.");
            return;
        }

        Console.WriteLine("Program started. Press Enter to exit...");
        Console.ReadLine();
    }
}