 Console.Write("Bir Sayı Giriniz: ");
 int sayi = Convert.ToInt32(Console.ReadLine());
 int sayac = 1;
 int toplam = 0;

 while (sayac <= sayi)
 {
     toplam += sayac;
     sayac++;
 }
  Console.WriteLine(toplam/sayi);

char charackter = 'a';
while (charackter < 'z')
{
    Console.Write(charackter);
    charackter++;
}