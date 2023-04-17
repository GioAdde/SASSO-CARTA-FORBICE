using System.Text.RegularExpressions;
class Program
{
	static void Main(string[] args)
	{
        Console.WriteLine("Inserisci il tuo nome");
		Giocatore g1 = new Giocatore(Console.ReadLine()); // creo un oggetto di tipo Giocatore con un nome da input
		 Console.WriteLine("Inserisci il nome del tuo avversario");
        Giocatore g2 = new Giocatore(Console.ReadLine()); // creo un oggetto di tipo Giocatore con un nome da input
		Partita p1 = new Partita(g1, g2); // creo un oggetto di tipo Partita con i giocatori g1 e g2
		p1.Gioca(); // gioco la partita
		p1.StampaPunteggio(); // stampo il punteggio dei giocatori
	}
}
