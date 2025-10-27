namespace JSTModule.Api;

class Program
{
    static void Main(string[] args)
    {
        var now = JSTModule.domain.JST.Now();
        Console.WriteLine(now.ToJapaneseString());
    }
}