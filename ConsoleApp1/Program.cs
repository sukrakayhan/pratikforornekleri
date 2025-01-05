//sorun 1 Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("kendime inanıyorum ben bu yazılım işini hallederim");

}

// soru 2 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

for (int i = 0; i < 21; i++)

{
    Console.WriteLine(i);

}

//soru 3 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
for (int i = 0;  i < 21; i++)
{ if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//soru 4  50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0;
for (int i = 50; i < 150; i++)
{
    toplam += i;
}
Console.WriteLine(toplam);

//soru 5 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int tekToplam = 0;
int ciftToplam = 0;
for(int i=1; i<121; i++)
{  if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
    Console.WriteLine("1-120 arasında ki çift sayıların toplamı" + ciftToplam);
    Console.WriteLine("1-120 arasında ki tek sayıların toplamı" + tekToplam);


}
