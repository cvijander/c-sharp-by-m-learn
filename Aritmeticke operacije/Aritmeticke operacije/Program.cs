// See https://aka.ms/new-console-template for more information


int suma = 7 + 5;

int razlika = 7 - 5;

int mnozenje = 7 * 5;

int deljenje = 18 / 5;

// []   =   double[18/5 ]   3.6

// [double[6/3]]   =   
////////////////////////////////////////
///
// prezicna vrednost  = manje precizna vrednost
// prezicna vrednost  = () precizna vrednost < manje precizna 

double deljenjeSaOstatkom = (double)18 / 5;

// prezicna vrednost  = manje precizna vrednost 

// []   =   [18/5 ]   3

// [[6/3]]   =   

// prezicna vrednost  = manje precizna vrednost
// proglasi da je double  [[6/3]]   =  
double deljenjeSaOstatkom1 = 18 / 5;

double moduoSaOstatkom = 18 % 5 ;



Console.WriteLine("Sabiranje " + suma);
Console.WriteLine("Razlika {0}",razlika);
Console.WriteLine($"Mnozenje {mnozenje}");
Console.WriteLine($"Deljenje {deljenje}");
Console.WriteLine($"Deljenje sa ostatkom - double  {deljenjeSaOstatkom}");
Console.WriteLine($"Deljenje sa ostatkom - celi broj na pola  {deljenjeSaOstatkom1}");

Console.WriteLine("Moduo " +moduoSaOstatkom);

// int celi projevi kad se dele oni nemaju ostatak 

int broj1 = 10;
int broj2 = 3;
int broj3 = 4;

Console.WriteLine(broj1 + broj2 * broj3 );
Console.WriteLine((broj1 + broj2) *broj3);
