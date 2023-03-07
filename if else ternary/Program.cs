// See https://aka.ms/new-console-template for more information

int time = DateTime.Now.Hour;

    if(time <= 18){
        Console.WriteLine("İyi günler");
    }
    else{
        Console.WriteLine("İyi geceler");
    }

    string sonuc = time <= 18 ? "iyi günler" : "iyi geceler";

    Console.WriteLine(sonuc);
