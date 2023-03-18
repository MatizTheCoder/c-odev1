//Sort

int[] sayilar = {9, 6, 15, 26, 71, 34, 55, 75};

Console.WriteLine("****** Sırasız Dizi ******");

foreach (var sayi in sayilar)
    Console.WriteLine(sayi);

Console.WriteLine("***** Sıralı Dizi ******");
Array.Sort(sayilar);

foreach (var sayi in sayilar)
    Console.WriteLine(sayi);

//Clear
Console.WriteLine("****** Array Clear ******");
Array.Clear(sayilar, 3, 2);

foreach (var sayi in sayilar)
    Console.WriteLine(sayi);

//Reverse
Console.WriteLine("****** Array Reverse ******");
Array.Reverse(sayilar);

foreach (var sayi in sayilar)
    Console.WriteLine(sayi);

//IndexOf
Console.WriteLine("****** Array IndexOf *****");
Console.WriteLine(Array.IndexOf(sayilar, 55));

//Resize
Console.WriteLine("****** Array Resize *****");
Array.Resize<int>(ref sayilar, 9);
sayilar[8] = 88;

foreach (var sayi in sayilar);
    Console.WriteLine(sayi);