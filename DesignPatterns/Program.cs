
namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            new Strategy.Client().Run();
            new AbstractFactory.Client().Run();
            new Composite.Client().Run();

        }

    }

}
