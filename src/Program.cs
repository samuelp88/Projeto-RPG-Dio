using src.Entities;
namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args) {
            Knight arus = new Knight("Arus", 0, "Knight");
            Wizard wizard = new Wizard("Jennica", 0, "White Wizard");
            arus.Attack();
            wizard.Attack();
        }
    }
}
