class Giocatore
{
	private string nome; // nome del giocatore
	private int punteggio; // punteggio del giocatore

	public Giocatore(string nome) // costruttore della classe Giocatore che prende in ingresso il nome del giocatore
	{
		this.nome = nome; // assegno il valore passato al costruttore alla variabile nome della classe Giocatore
		this.punteggio = 0; // inizializzo il punteggio del giocatore a 0
	}

	public void SetPunteggio(int punteggio) // metodo per assegnare un punteggio al giocatore
	{
		this.punteggio = punteggio; // assegno il valore passato al metodo alla variabile punteggio della classe Giocatore
	}

	public int GetPunteggio() // metodo per ottenere il punteggio del giocatore
	{
		return this.punteggio; // ritorno il punteggio del giocatore
	}

	public string GetNome() // metodo per ottenere il nome del giocatore
	{
		return this.nome; // ritorno il nome del giocatore
	}
}
