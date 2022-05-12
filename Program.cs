using desafio2.src.Entities;
using static System.Console;
public class Program 
{
    public static void Main(string[] args)
    {
        Knight arus = new Knight("Arus", 23, "Knight");
        WhiteWizard jennica = new WhiteWizard("Jennica", 23, "White Wizard");
        Ninja wedjge = new Ninja("Wedge", 42, "Ninja");
        BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard");

        
        WriteLine(wedjge.Attack());
        WriteLine(topapa.Attack(8));
        WriteLine(jennica.Attack(1));
        WriteLine(arus.Attack());

    }
}
