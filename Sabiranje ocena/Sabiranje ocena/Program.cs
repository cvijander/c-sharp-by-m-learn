// See https://aka.ms/new-console-template for more information


// 4 studenta sa nekim ocenama 
//  Milica 8 ,9 10, 6 ,8

// Nikola 7,6,7,8,9

//Petar 8,8,8,6,9

// Ana  9,8,7,8,6

int brojOcena = 5;

int milica1 = 8;
int milica2 = 9;
int milica3 = 10;
int milica4 = 6;
int milica5 = 8;


int nikola1 = 10;
int nikola2 = 6;
int nikola3 = 7;
int nikola4 = 8;
int nikola5 = 9;

int petar1 = 8;
int petar2 = 8;
int petar3 = 8;
int petar4 = 6;
int petar5 = 9;

int ana1 = 9;
int ana2 = 8;
int ana3 = 7;
int ana4 = 8;
int ana5 = 10;



int zbirOcenaMilice = 0; 
int zbirOcenaNikole = 0;
int zbirOcenaPetra = 0;
int zbirOcenaAne = 0;

Console.WriteLine("Milica " + zbirOcenaMilice);
Console.WriteLine("Ana " + zbirOcenaAne);
Console.WriteLine("Petar " +zbirOcenaPetra);
Console.WriteLine("Nikola " +zbirOcenaNikole);

zbirOcenaMilice = milica1 + milica2 + milica3 + milica4 + milica5;

zbirOcenaAne = ana1 + ana2 + ana3 + ana4 + ana5;

zbirOcenaNikole = nikola1 + nikola2 + nikola3 + nikola4 + nikola5;

zbirOcenaPetra = petar1 + petar2 + petar3 + petar4 + petar5;


Console.WriteLine("Milica " + zbirOcenaMilice);
Console.WriteLine("Ana " + zbirOcenaAne);
Console.WriteLine("Petar " + zbirOcenaPetra);
Console.WriteLine("Nikola " + zbirOcenaNikole);

decimal prosekOcenaodMilice = (zbirOcenaMilice /(decimal) brojOcena);
decimal prosekOcenaodAne = (zbirOcenaAne / (decimal)brojOcena);
decimal prosekOcenaodNikole = zbirOcenaNikole /(decimal)brojOcena;
decimal prosekOcenaodPetra = zbirOcenaPetra /(decimal) brojOcena;

Console.WriteLine("Prosek ocena od Milice: "+prosekOcenaodMilice);
Console.WriteLine("Prosek ocena od Ane: " + prosekOcenaodAne);
Console.WriteLine("Prosek ocena od Nikole: " + prosekOcenaodNikole);
Console.WriteLine("Prosek ocena od Petra: " + prosekOcenaodPetra);