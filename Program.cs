using System.Net;

Console.Write("Imie Bohatera:");
string bohater1 = Console.ReadLine()!;

Console.Write("Klasa:");
string klasa1 = Console.ReadLine()!;

Console.Write("Ile masz HP:");
string wpisanaLiczba = Console.ReadLine()!;
int hp1 = int.Parse(wpisanaLiczba);

Console.Write("Siła:");
string wpisanaLiczba2 = Console.ReadLine()!;
int sila1 =int.Parse(wpisanaLiczba2);

Console.Write("Ile masz złota:");
string wpisanaLiczba3 = Console.ReadLine()!;
decimal zloto1 = decimal.Parse(wpisanaLiczba3);


const int maxZdrowie = 100;
double procentZdrowia = (double)hp1/maxZdrowie*100;


const int pojemnoscPlecaka = 10;
int zajetyPlecak = 1;
int wolneMiejsce = pojemnoscPlecaka - zajetyPlecak;

int iloscDruzyny = 5;

bool zyje = hp1 > 0;
bool chceLeczenia = !(hp1 == maxZdrowie);
bool miejscePlecak = wolneMiejsce > 0;
bool gotowyDoWyprawy = zyje && miejscePlecak;

int premiaBroni = 5;

int premia = 20;
int podatek = 5;

zloto1 += premia;
zloto1 -= podatek;

string statusZdrowia;
if (hp1<=0)
{
    statusZdrowia = "Martwy";
}
else if (hp1<=50)
{
    statusZdrowia = "Ranny";
}
else
{
    statusZdrowia = "Zdrowy";
}

string bogactwo;
if (zloto1 > 50)
{
    bogactwo = "Tak";
}
else
{
    bogactwo = "Nie";
}

 string gotowaDoWalki;
 if (hp1>0 && sila1>20)
{
    gotowaDoWalki = "Tak";
}
else
{
    gotowaDoWalki = "Nie";
}





Console.WriteLine("+================================+");
Console.WriteLine("|        HELLOADVENTURER         |");
Console.WriteLine("+================================+");
Console.WriteLine($"| Bohater:\t{bohater1}\t\t |");
Console.WriteLine($"| Klasa:\t{klasa1}\t |");
Console.WriteLine("+================================+");
Console.WriteLine($"| HP:\t\t{hp1}/{maxZdrowie} ({procentZdrowia:F2}%)|");
Console.WriteLine($"| Siła:\t\t{sila1}\t\t |");
Console.WriteLine($"| Złoto:\t{zloto1}\t\t |");
Console.WriteLine("+================================+");
Console.WriteLine($"| Łączna moc:\t{hp1*sila1}\t\t |");
Console.WriteLine($"| Obrażenia: \t{sila1 + premiaBroni}\t\t |");
Console.WriteLine("+================================+");
Console.WriteLine($"| Plecak: \t {zajetyPlecak}/{pojemnoscPlecaka}\t\t |");
Console.WriteLine($"| Wolne miejsca: {wolneMiejsce}/{pojemnoscPlecaka}\t\t |");
Console.WriteLine($"| Liczba członków drużyny: {iloscDruzyny} \t |");
Console.WriteLine($"| Ilośc złota na członka: {(int)(zloto1/iloscDruzyny)}\t |");
Console.WriteLine($"| Złoto pozostałe w skarbcu: {zloto1%iloscDruzyny}\t |");
Console.WriteLine($"| Wymagane leczenie: {chceLeczenia}\t |");
Console.WriteLine($"| Miejsce w plecaku: {miejscePlecak}\t |");
Console.WriteLine($"| Gotowy: {gotowyDoWyprawy}\t\t\t |");
Console.WriteLine("+================================+");
Console.WriteLine($"| Poziom zdrowia: \t{statusZdrowia}\t |");
Console.WriteLine($"| Czy postac jest bogata: \t{bogactwo} |");
Console.WriteLine($"| Gotowa do walki: \t{gotowaDoWalki}");

Console.WriteLine("Wybierz opcje: 1 - Sprawdz zdrowie, 2 - otwórz mape, 3 - zakończ gre");
int opcja = int.Parse(Console.ReadLine()!);

switch (opcja)
{
    case 1:
    Console.WriteLine($"Zdrowie:{hp1}");
    break;
    case 2:
    Console.WriteLine("Mapa otwarta");
    break;
    case 3:
    Console.WriteLine("Gra zakończona");
    break;
    default:
    Console.WriteLine("Nie ma takiej opcji");
    break;
}
























