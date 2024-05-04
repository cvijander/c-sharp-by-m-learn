// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string ime = "Milica";
string prezime = "Jokic";
int godine = 21;


Console.WriteLine("Moje ime je " + ime +" i prezivam se " +prezime +" i imam "+godine+" godinu. ");


Console.WriteLine("Moje ime je {0} i prezivam se {1} i imam {2} godinu. ", ime,prezime ,godine);


Console.WriteLine($"Moje ime je {ime} i prezivam se {prezime} i imam { godine} godinu. ");

string naziv = "Moj_racunar";

Console.WriteLine($@"C:\{naziv}\nesto\dalje");