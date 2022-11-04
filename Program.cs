// See https://aka.ms/new-console-template for more information

Dvd Disco1 = new Dvd(new Random().Next(1, 99999), "Big Brain dvd");
Dvd Disco2 = new Dvd(new Random().Next(1, 99999), "Big Brain dvd1");


Libro Libro1 = new Libro(new Random().Next(1, 99999), "Big Brain libro");
Libro Libro2 = new Libro(new Random().Next(1, 99999), "Big Brain libro1");



Console.WriteLine(Disco1.ToString());
Console.WriteLine(Libro1.ToString());


List<Item> ItemList = new List<Item>();

ItemList.Add(Libro1);
ItemList.Add(Libro2);
ItemList.Add(Disco1);
ItemList.Add(Disco2);

Console.WriteLine("Scrivi un libro o un Dvd da cercare");
string input = Console.ReadLine();

foreach (Item item in ItemList)
{
    if (input == item.Titolo)
    {
        Console.WriteLine("ho trovato il libro " + item.Titolo);
    }
    else
        Console.WriteLine("non ho trovato quello che cerchi");
    return;
}




public class Utente
{
    public string cognome { get; set; }
    public string nome { get; set; }
    public string mail { get; set; }
    public string telefono { get; set; }

    public Utente(string Cognome, string Nome)
    {
        Cognome = cognome;
        Nome = nome;

    }
}

public class Prestito : Utente
{
    public Prestito(string cognome, string nome) : base(cognome, nome)
    {
    }
}


public class Item
{
    public int Id { get; set; }
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public string Stato { get; set; }
    public string Scaffale { get; set; }
    public string Autore { get; set; }

    public Item(int id, string titolo)
    {
        Id = id;
        titolo = Titolo;
    }

    public override string ToString()
    {
        return Titolo + Id;
    }
}

public class Dvd : Item
{
    public int durata;

    public Dvd(int id, string titolo) : base(id, titolo)
    {
        Id = id;
        Titolo = titolo;
    }

    public override string ToString()
    {
        return "I dati del tuo Dvd sono Id: " + Id + "; Titolo: " + Titolo;
    }
}

public class Libro : Item
{
    public int pagine;

    public Libro(int id, string titolo) : base(id, titolo)
    {
        Id = id;
        Titolo = titolo;
    }

    public override string ToString()
    {
        return "I dati del tuo Libro sono Id: " + Id + "; Titolo: " + Titolo;
    }
}
