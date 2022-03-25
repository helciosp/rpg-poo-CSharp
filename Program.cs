using poo.src.Entities;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 24, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));
        }
    }
}