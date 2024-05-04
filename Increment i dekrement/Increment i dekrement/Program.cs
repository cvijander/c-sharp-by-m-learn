// See https://aka.ms/new-console-template for more information



/*


int mojBroj = 10;

Console.WriteLine(mojBroj);
mojBroj = mojBroj + 5;

Console.WriteLine(mojBroj);

mojBroj += 5;

Console.WriteLine(mojBroj);

mojBroj = mojBroj * 2;
Console.WriteLine(mojBroj);
mojBroj *= 2;

Console.WriteLine(mojBroj);

mojBroj /= 8;

Console.WriteLine(mojBroj);*/

int vrednost = 0;

/*
Console.WriteLine(vrednost);
vrednost += 1;

Console.WriteLine(vrednost );

vrednost = vrednost + 1;

Console.WriteLine(vrednost);
*/
//vrednost++;
/*
Console.WriteLine(vrednost);

// increment operator   ++broj    broj++
int broj = vrednost++;

Console.WriteLine(vrednost++); // on je 1 ispisuje 1 ali se posle toga povecava i postaje 2 

Console.WriteLine("Vrednost je " +vrednost );
Console.WriteLine("Broj je " +broj);
*/


int kolicina = 0;
Console.WriteLine(kolicina);
Console.WriteLine(++kolicina);


int slicice = 100;
Console.WriteLine("Pocinjemo sa " + slicice);
Console.WriteLine("Umanjujemo pa ispisujemo " + --slicice);
Console.WriteLine("Ispisujemo " +slicice);
Console.WriteLine("Ispisujemo pa umanjujemo " +slicice--);
Console.WriteLine("Ispisujemo " + slicice);



int fare = 94;
decimal res = (decimal)((fare - 32m) *(decimal) (5m / 9m));
Console.WriteLine("The temperature is " + res);