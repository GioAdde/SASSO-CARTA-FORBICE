using System.Text.RegularExpressions;






class Partita
{
    private Giocatore g1; // giocatore 1
    private Giocatore g2; // giocatore 2

    public Partita(Giocatore g1, Giocatore g2) // costruttore della classe Partita che prende in ingresso due giocatori
    {
        this.g1 = g1; // assegno il valore passato al costruttore alla variabile g1 della classe Partita
        this.g2 = g2; // assegno il valore passato al costruttore alla variabile g2 della classe Partita
    }

    public void Gioca() // metodo per giocare la partita
    {
        Console.WriteLine("Giocatore 1: " + this.g1.GetNome()); // stampo il nome del giocatore 1
        Console.WriteLine("Giocatore 2: " + this.g2.GetNome()); // stampo il nome del giocatore 2
        string scelta1, scelta2;


        do
        {
            Console.WriteLine(this.g1.GetNome() + " " + "E' il tuo turno: scegli sasso, carta o forbice?: "); // stampo il nome del giocatore 1
            scelta1 = Console.ReadLine(); // leggo la scelta del giocatore 1

            if (scelta1 != "sasso" && scelta1 != "carta" && scelta1 != "forbice")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input errato, scegli solo sasso, carta o forbice");
                Console.ResetColor();
            }

        } while (scelta1 != "sasso" && scelta1 != "carta" && scelta1 != "forbice");

        do
        {
            Console.WriteLine(this.g2.GetNome() + " " + "E' il tuo turno: scegli sasso, carta o forbice?: "); // stampo il nome del giocatore 1
            scelta2 = Console.ReadLine(); // leggo la scelta del giocatore 1

            if (scelta2 != "sasso" && scelta2 != "carta" && scelta2 != "forbice")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input errato, scegli solo sasso, carta o forbice");
                Console.ResetColor();
            }

        } while (scelta2 != "sasso" && scelta2 != "carta" && scelta2 != "forbice");



        if (scelta1 == scelta2) // se le scelte sono uguali
        {
            Console.WriteLine("Pareggio!"); // stampo pareggio
        }
        
		else if (scelta1 == "sasso" && scelta2 == "forbice" || scelta1 == "carta" && scelta2 == "sasso" || scelta1 == "forbice" && scelta2 == "carta") // se il giocatore 1 vince
                                                                                                                                                       

        {
            Console.WriteLine("Vince " + this.g1.GetNome()); // stampo vince il giocatore 1
            this.g1.SetPunteggio(this.g1.GetPunteggio() + 1); // assegno un punto al giocatore 1
        }
        else // se il giocatore 2 vince
        {
            Console.WriteLine("Vince " + this.g2.GetNome());
            this.g2.SetPunteggio(this.g2.GetPunteggio() + 1); // assegno un punto al giocatore 2
        }
    }
    public void StampaPunteggio() // metodo per stampare il punteggio dei giocatori
    {
        Console.WriteLine("Punteggio " + this.g1.GetNome() + " " + this.g1.GetPunteggio()); // stampo il punteggio del giocatore 1
        Console.WriteLine("Punteggio " + this.g2.GetNome() + " " + this.g2.GetPunteggio()); // stampo il punteggio del giocatore 2
    }



}