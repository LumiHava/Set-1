﻿// Ex 1

            /* double x;
              Console.WriteLine("introduceti numarul a: ");
              double a = double.Parse(Console.ReadLine());
              Console.WriteLine("introduceti numarul b: ");
              double b = double.Parse(Console.ReadLine());
              Console.WriteLine("Nmarul x este egal cu: ");
              x = -b / a;
              Console.WriteLine(x);
            */

// Ex 2

/*Console.WriteLine("introduceti numarul a: ");
 double a = double.Parse(Console.ReadLine());

 Console.WriteLine("introduceti numarul b: ");
 double b = double.Parse(Console.ReadLine());

 Console.WriteLine("introduceti numarul c: ");
 double c = double.Parse(Console.ReadLine());

 double delta = b * b - 4 * a * c;
 double deltaRadical= Math.Sqrt(delta);

 double x1;
 double x2;
 double x;
 double deltaImag; 
 if (delta > 0)
 {
     x1 = (-b - deltaRadical) / (2 * a);
     x2 = (-b + deltaRadical) / (2 * a);
     Console.WriteLine($"x1 = {x1}");
     Console.WriteLine($"x2 = {x2}");

 }

// Ex 3

 else if (delta == 0)
 {
     x = -b / (2 * a);
     Console.WriteLine($"x = {x}");
 }

 else // delta < 0  
 {
     x = -b / (2 * a);
      deltaImag = Math.Abs(delta); // Abs valoarea absoluta/ functia pt modul.
      deltaImag = Math.Sqrt(deltaImag);// Sqrt functia pentru radical din ceva.
      deltaImag = deltaImag / (2 * a);
     Console.WriteLine($" x1 = {x} +  {deltaImag}i");
     Console.WriteLine($" x2 = {x} - {deltaImag}i");
 }
*/

/* double n = double.Parse(Console.ReadLine());
 double k = double.Parse(Console.ReadLine());

 if (n % k == 0)
 {
     Console.WriteLine("n divide pe k");
 }

 else
 {
     Console.WriteLine("n nu divide pe k");

 } */

// EX 4


/* int y = int.Parse(Console.ReadLine());

 if (y % 400 == 0 || (y % 4 == 0 & y % 100 != 0)) 
 {
     Console.WriteLine($" {y} Este un an Bisect ");
 } 

 else
 {
     Console.WriteLine($"{y} Nu este un an bisect");
 }
*/

// Ex 5

/*Console.WriteLine("Introduceti un numar");
 string n = Console.ReadLine();
 Console.WriteLine("introduceti pozitia k");
 int k = int.Parse(Console.ReadLine());
 if (k >= 0 && k <= n.Length)
 {
     char cif = n[n.Length - k];
     Console.WriteLine(cif);
 }
 else
     Console.WriteLine(" valoarea lui k nu exista");
*/


// Ex 6

/* Console.WriteLine("Introduceti lungimea laturii a");
 double a = double.Parse(Console.ReadLine());
 Console.WriteLine("Introduceti lungimea laturii b");
 double b = double.Parse(Console.ReadLine());
 Console.WriteLine("Introduceti lungimea laturii c");
 double c = double.Parse(Console.ReadLine());

 if (a + b >= c && b + c >= a && a + c >= b)
 {
     Console.WriteLine("Este lungimea laturii unui triunghi");
 }
 else
     Console.WriteLine("Nu este lungimea laturii unui triunghi");
*/

// Ex 7

/*Console.WriteLine("Numarul a");
 double a = Double.Parse(Console.ReadLine());
 Console.WriteLine("Numarul b");
 double b = Double.Parse(Console.ReadLine());


 double c = a;
 a = b;
 b = c;  

 Console.WriteLine("inversare");
 Console.WriteLine("inversul valorii a este" + b);
 Console.WriteLine("inversul valorii b este" + a);
*/

// Ex 8


/* Console.WriteLine("Introduceti numarul a");
 int a =int.Parse(Console.ReadLine());
 Console.WriteLine("Introduceti numarul b");
 int b =int.Parse(Console.ReadLine());

 Console.WriteLine("Inversul valorii a este: " + b);
 Console.WriteLine("Inversul valorii b este: " + a);
*/

// Ex 9

/* Console.WriteLine("Introduceti un numar n");
 long n = long.Parse(Console.ReadLine());

 Console.WriteLine("Divizorii numarului introdus sunt:");
 for (int i = 1; i <= n; i++)
 {

     if (n%i == 0)
     {
         Console.WriteLine(i + " ");
     }
 } 
           */// Ex 15                                     

/*Console.WriteLine("Introduceti numarul a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Introduceti numarul b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Introduceti numarul c: ");
int c = int.Parse(Console.ReadLine());

int temp;

if (a > b )  
{
  temp = a;
  a = b;
  b = temp;
}

if (b > c )
{
    temp = b;
    b = c;
    c = temp;
}

if (a > b)
{
    temp = a;
    a = b;
    b = temp;
}

Console.WriteLine($"Numerele afiste in ordine crescatoare sunt: {a} {b} {c}");
*/

// Ex 16

/*Console.WriteLine("Introduceti primul numar: ");
 int a = int .Parse(Console.ReadLine());
 Console.WriteLine("Introduceti al doilea numar: ");
 int b = int .Parse(Console.ReadLine());
 Console.WriteLine("Introduceti al treilea numar: ");
 int c = int .Parse(Console.ReadLine());
 Console.WriteLine("Introduceti al patrulea numar: ");
 int d = int .Parse(Console.ReadLine());
 Console.WriteLine("Introduceti al cincilea numar: ");
 int e = int .Parse(Console.ReadLine());

 List<int> numere = new List<int> { a, b, c, d, e };
 numere.Sort();
 foreach (int numar in numere)
 {
   Console.WriteLine(numar);
 }
 */

// Ex 17

/*Console.WriteLine("Introduceti numarul a: ");
  int a = int.Parse(Console.ReadLine());
  Console.WriteLine("Introduceti numarul b: ");
  int b = int.Parse(Console.ReadLine());

  int r,copyA = a, copyB = b;

  while (copyB != 0)
  {
      r = copyA % copyB;
      copyA = copyB;
      copyB = r;
  }
  System.Console.WriteLine("Cel mai mare divizor comun: " + copyA);
  System.Console.WriteLine("Cel mai mic multiplu comun: " + (a * b / copyA));
  */

// EX 18 

/* Console.WriteLine("Introduceti un număr întreg pozitiv:  ");
 int n = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine($"Descompunerea în factori primi a numărului {n} este: ");

  for (int i = 2; i <= n; i++)

  { int contor = 0;
   while (n % i == 0)
   {
     contor++;
     n /= i;
   }
   if (contor > 0)
   {
     Console.Write($"{i}^{contor} ");
     if (n > 1)
     {
         Console.Write("x ");
     }
   }

  }
*/

// Ex 19

/*{
   Console.WriteLine("Introduceti un număr întreg: ");
   int numar = Convert.ToInt32(Console.ReadLine());

   bool rezultat = VerificareDinDouaCifre(numar);

   if (rezultat)
   {
       Console.WriteLine($"Numărul {numar} este format doar din două cifre care se pot repeta.");
   }
   else
   {
       Console.WriteLine($"Numărul {numar} nu este format doar din două cifre care se pot repeta.");
   }
}

static bool VerificareDinDouaCifre(int numar)
{
   string numarString = numar.ToString();

   if (numarString.Length < 3)
   {
       return false;
   }

   char cifra1 = numarString[0];
   char cifra2 = numarString[1];

   return numarString.All(cifra => cifra == cifra1 || cifra == cifra2);
}
 /

