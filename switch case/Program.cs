int month = DateTime.Now.Month;

switch (month)
{
    case 1:
        Console.WriteLine("Ocak ayındasınız");
        break;
    case 2:
        Console.WriteLine("Şubat Ayındasınız");
        break;
    case 3:
        Console.WriteLine("Mart Ayındasınız");
        break;
    default:
        Console.WriteLine("Bir hata oluştu.");
        break;
}

switch (month)
{
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Bahar aylarındasınız.");
        break;
    default:
    break;
}
