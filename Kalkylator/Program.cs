
Console.WriteLine("Vad vill du räkna");
Console.WriteLine("Skriv ditt nummer");
string nummer1 = Console.ReadLine();

while (!int.TryParse(nummer1, out int heltal1))
{
    Console.WriteLine("Skriv ett heltal");
    nummer1 = Console.ReadLine();

}

int numer1 = Convert.ToInt32(nummer1);


Console.WriteLine("Skriv in ditt tecken");
string tecken = Console.ReadLine();

while (tecken != "+" && tecken != "-" && tecken != "*" && tecken != "/")
{
    Console.WriteLine("Välj tecken utav + - * /"); 
    tecken = Console.ReadLine();

}

Console.WriteLine("Skriv ett tal");
string nummer2 = Console.ReadLine();

while (!int.TryParse(nummer2, out int heltal2))
{ 
    Console.WriteLine("skriv ett heltal");
    nummer2 = Console.ReadLine();

}
    int numer2 = Convert.ToInt32(nummer2);

Berakna();

 void Berakna()

{
    if (tecken == "+")
    {
        var resultat = numer1 + numer2;
        Console.WriteLine(resultat);

    }
    else if (tecken == "-")
    {
        var resultat1 = numer1 - numer2;
        Console.WriteLine(resultat1);

    }
    else if (tecken == "*")
    {
        var resulat2 = numer1 * numer2;
        Console.WriteLine(resulat2);
    }
    else if (tecken == "/")
    {
        var resultat3 = numer1 / numer2;
        Console.WriteLine(resultat3);
    }
}