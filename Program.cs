// See https://aka.ms/new-console-template for more information
//Snack 1
Console.WriteLine("-----ARRAY MESI-----");
String[] mesi = { "gennaio", "febbraio", "marzo", "aprile", "maggio", "giugno", "luglio", "agosto", "settembre", "ottobre", "novembre", "dicembre" };
for(int i = 0; i < mesi.Length; i++)  //><
{
    Console.WriteLine((i+1)+ " "+mesi[i]);
}
//Snack 1b
mesi[6] = "Luglio-Estate";
foreach (string mese in mesi)
{
    Console.WriteLine(mese);
}
//Snack 2
Console.WriteLine("-----ARRAY NUMERI-----");
int[] numeri = {1,2,45,23,54,65,87,234,657,1243,6,765,8,35,7,8,35,7,8,686};
foreach(int numero in numeri)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("il numero è pari:" + numero);
    }
    else
    {

        Console.WriteLine("il numero è dispari:" + numero);
    }
}
for(int i = 0; i < numeri.Length; i++)
{
    if (numeri[i] % 2 != 0)
    {
        numeri[i]++;

    }
}
foreach (int numero in numeri)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("il numero è pari:" + numero);
    }
    else
    {

        Console.WriteLine("il numero è dispari:" + numero);
    }
}
// snack 3
Console.WriteLine("-----CONTROLLA PAROLE-----");
int controllo;
do
{
    Console.WriteLine("Inserisci una parola");
    int pUno = Console.ReadLine().Length;
    Console.WriteLine("Inserisci una parola");
    int pDue = Console.ReadLine().Length;

    if(pUno < pDue)
    {
        Console.WriteLine("la prima parola è piu CORTA della seconda");
    }else if(pDue == pUno)
    {
        Console.WriteLine("le parole sono lunghe uguali");
    }
    else
    {
        Console.WriteLine("la prima parola è piu LUNGA della seconda");
    }
    Console.WriteLine("per riprovare inserire in numero diverso da 0");
    controllo = int.Parse(Console.ReadLine());

}while(controllo != 0);
// snack 4
Console.WriteLine("----SCOMMESA /3----");
Random generatore = new Random();
int numRandom = generatore.Next(1,99);
bool controlloUtente = true;

bool divisibileX3 = numRandom%3 == 0 ? true : false;

do
{
    Console.WriteLine("Il numero generato è divisibile per 3? si o no?");
    string risposta = Console.ReadLine().ToLower();

    //bool controlloUtente = (risposta == "si" || risposta == "no") ? true : false;
    if(risposta == "si" || risposta == "no")
    {
         controlloUtente= false;

    }


    if (risposta == "no")
    {
        if (divisibileX3)
        {
            Console.WriteLine("Hai sbagliato");
        }
        else
        {
            Console.WriteLine("Hai idovinato");
        }
    }
    else if(risposta == "si"){
        if (divisibileX3)
        {
            Console.WriteLine("Hai indovinato");
        }
        else
        {
            Console.WriteLine("Hai sbagliato");
        }
    }
    else
    {
        Console.WriteLine("Non hai inserito una risposta valida");
    }

} while(controlloUtente);
Console.WriteLine(numRandom);
