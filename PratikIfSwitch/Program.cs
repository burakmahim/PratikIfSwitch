//açıkcası ikisinin yazımını da gayet kolay sadece if yapısı bir tık daha uzun

// if ile yapılmış hali


Console.WriteLine("Rüya Manavina Hoş Geldiniz! ");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");
Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
string meyve = Console.ReadLine().ToLower();  // Kullanıcı girişi küçük harfe dönüştürülüyor

if (meyve == "elma")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
}
else if (meyve == "armut")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
}
else if (meyve == "çilek")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
}
else if (meyve == "muz")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
}
else if (meyve == "diğer" || meyve == "diger")  // Hem Ğ hemde G'yi kabul etmesi için
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
}
else
{
    Console.WriteLine("Geçersiz bir meyve seçtiniz.");
}


// switch case hali


switch (meyve)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;

    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;

    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;

    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;

    case "diger":
    case "diğer":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
        break;

    default:
        Console.WriteLine("Geçersiz bir meyve seçtiniz.");
        break;
}


