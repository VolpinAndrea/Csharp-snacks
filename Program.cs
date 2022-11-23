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
