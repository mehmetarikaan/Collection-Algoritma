using System.Collections;
Console.WriteLine("************ Soru 2 ***********");
Console.WriteLine("Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)");

ArrayList liste = new ArrayList();
ArrayList kucuk = new ArrayList();
ArrayList buyuk = new ArrayList();

Console.WriteLine("***20 Adet sayı giriniz: ***");

for (int i = 1; i <= 6; i++)
{
    Console.Write("{0}. sayiyi giriniz: ", i);
    int sayi = Convert.ToInt32(Console.ReadLine());
    liste.Add(sayi);
}

liste.Sort(); // Küçükten büyüğe sıraladım.
int kucukToplam = 0;

for (int i = 0; i < 3; i++)
{
    kucuk.Add(liste[i]);
    kucukToplam = kucukToplam + Convert.ToInt32(liste[i]); // 
}
int kucukOrt = (kucukToplam / 3);
Console.WriteLine("En küçük 3 sayının ortalaması: "+ kucukOrt);


liste.Reverse(); // Tersten sıraladım. Böylelikle büyükten küçüğe sıralmış oldum.
int buyukToplam = 0;

for (int i = 0; i < 3; i++)
{
    buyuk.Add(liste[i]);
    buyukToplam = buyukToplam + Convert.ToInt32(liste[i]);
}

int buyukOrt = (buyukToplam / 3);
Console.WriteLine("En Büyük 3 sayının ortalaması: "+ buyukOrt);

Console.WriteLine("İki ortalamanın Toplamı: " + (buyukOrt + kucukOrt));
