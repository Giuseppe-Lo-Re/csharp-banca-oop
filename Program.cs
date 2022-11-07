//Ciao a tutti.
//Oggi cerchiamo di migliorare un pochino l’approccio nella costruzione di un codice ad oggetti, ben suddiviso tra diverse responsabilità.
//Il program.cs si occuperà quindi di gestire tutti i console.writeline/readline mentre le classi di dominio del nostro progetto devono
//occuparsi solo della logica applicativa e fare dei controlli dei dati quando questi violano qualche logica.
//Esempio, quando un cliente non può chiedere più prestiti? quale entità potrebbe occuparsi di questo controllo?
//Non dimentichiamoci però che abbiamo aggiunto la keyword static, quale parametro di quale entità potrebbe essere trasformato in STATIC così come abbiamo visto negli esempi?
//Consegna:
//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.
//La banca è caratterizzata da
//un nome
//un insieme di clienti (una lista)
//un insieme di prestiti concessi ai clienti (una lista)
//I clienti sono caratterizzati da
//nome,
//cognome,
//codice fiscale
//stipendio
//I prestiti sono caratterizzati da
//ID
//intestatario del prestito (il cliente),
//un ammontare,
//una rata,
//una data inizio,
//una data fine.
//Per la banca deve essere possibile:
//aggiungere, modificare e ricercare un cliente.
//aggiungere un prestito.
//effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.
//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.

using System.Net.Security;
using System.Xml.Serialization;

Banca banca = new Banca("Banca Etica");

Console.WriteLine("Vuoi accedere al menù?");
string sceltaUtente = "si";

if (sceltaUtente.Equals("si"))
{
    IndiceMenu();

    switch (sceltaUtente)
    {
        case "1":
            AggiungiCliente();
            break;
        case "2":
            ModificaCliente(banca);
            break;
        case "3":
            RicercaCliente(banca);
            break;
        case "4":
            RegistraPrestito(banca);
        case "7":
            InfoCliente();

        default:
            break;

    }
}
else
{
    Console.WriteLine("Grazie e Arriverci");
}

void IndiceMenu()
{
    Console.WriteLine("Benvenuto in " + banca.Nome);
    Console.WriteLine("Che operazioni vorresti eseguire?");

    Menu();

    sceltaUtente = Console.ReadLine();
}

void Menu()
{
    Console.WriteLine("1. Aggiungere un nuovo cliente");
    Console.WriteLine("2. Modificare un cliente");
    Console.WriteLine("3. Ricercare un cliente");
    Console.WriteLine("4. Registrare un prestito");
    Console.WriteLine("5. Ricercare un prestito");
    Console.WriteLine("6. Ricercare il totale prestiti concessi");
    Console.WriteLine("7. Ricercare le rate rimanenti da pagare");
    Console.WriteLine("8. Stampare il prospetto riassuntivo clienti");
    Console.WriteLine("9. Stampare il prospetto riassuntivo prestiti");
}

void InfoCliente(Cliente cliente)
{
    Console.WriteLine("Nome: " + cliente.Nome);
    Console.WriteLine("Cognome: " + cliente.Cognome);
    Console.WriteLine("Codice Fiscale: " + cliente.CodiceFiscale);
    Console.WriteLine("Stipendio: " + cliente.Stipendio);
}

Cliente AggiungiCliente()
{
    Console.WriteLine("Inserire nome cliente");
    string nome = Console.ReadLine();
    Console.WriteLine("Inserire cognome cliente");
    string cognome = Console.ReadLine();
    Console.WriteLine("Inserire codice fiscale cliente");
    string codiceFiscale = Console.ReadLine();
    Console.WriteLine("Inserire stipendio cliente");
    int stipendio = Convert.ToInt32(Console.ReadLine());

    return new Cliente(nome, cognome, codiceFiscale, stipendio);
}

void ModificaCliente(Banca banca)
{
    Console.WriteLine("Inserire il codice fiscale del cliente da modificare");
    Cliente clienteDaModificare = banca.RicercaCliente(Console.ReadLine());

    if(clienteDaModificare != null)
    {
        InfoCliente(clienteDaModificare);
        Cliente clienteModificato = AggiungiCliente();
        banca.ModificaCliente(clienteDaModificare, clienteModificato);
    }
    else
    {
        Console.WriteLine("Il cliente ricercato non è presente");
    }
}

void RicercaCliente(Banca banca)
{
    Console.WriteLine("Inserire il codice fiscale del cliente");
    Cliente clienteDaRicercare = banca.RicercaCliente(Console.ReadLine());

    if(clienteDaRicercare != null)
    {
        InfoCliente(clienteDaRicercare);
    }
    else
    {
        Console.WriteLine("Il cliente ricercato non è presente");
    }
}

void RegistraPrestito(Banca banca)
{
    Console.WriteLine("Inserire il codice fiscale del cliente a cui registrare il nuovo prestito");
    
    if(Cliente != null)
    {
        Console.WriteLine("Inserire L'importo del prestito");
        int importoPrestito = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserire L'importo della rata del prestito");
        int importoRata = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserire La data dell'inizio del prestito");
        DateOnly dataInizio =
        Console.WriteLine("Inserire La data della fine del prestito");
        DateOnly dataFine =
        
    }
}