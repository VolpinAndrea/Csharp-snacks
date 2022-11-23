// See https://aka.ms/new-console-template for more information
//Snack 1
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