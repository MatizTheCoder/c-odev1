string sayi = "999";
int outSayi;

bool sonuc = int.TryParse(sayi, out outSayi);
if(sonuc)
{
    Console.WriteLine("İşlem Başarılı");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("İşlem Başarısız");
}

Metotlar inst = new Metotlar();
inst.Topla(4,4, out int toplamSonuc);
Console.WriteLine(toplamSonuc);

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a+b;
    }
}