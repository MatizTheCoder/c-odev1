     Console.WriteLine("Bir sayı giriniz.");
     int sayac = 50; 

         for (int i = 1; i < sayac; i++)
         {
             if(i%2 == 1)
                 Console.WriteLine(i);
            
         }

        int tekToplam = 0;
        int ciftToplam = 0;

        for (int i = 1; i <= 1000; i++)
        {
            if(i%2 == 1)
            tekToplam += 1;
            else
            ciftToplam += 1;
        }

        Console.WriteLine("Tek Toplam: " + tekToplam);
        Console.WriteLine("Çift Toplam: " + ciftToplam);