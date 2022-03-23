using System.Collections;
Console.WriteLine("************ Soru 1 ***********");
Console.WriteLine("Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.ArrayList sınıfını kullanara yazınız.Negatif ve numeric olmayan girişleri engelleyin.Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.");

ArrayList liste = new ArrayList();
ArrayList asal = new ArrayList();
ArrayList asaldegil = new ArrayList();


for (int i = 1; i <= 20; i++)
{
    Console.Write("{0}. sayıyı gir: ", i);
    int sayi = Convert.ToInt32(Console.ReadLine());


    if (sayi < 0)
    {
        Console.WriteLine("Negafit bir sayı girdiniz.");
        break;
    }
    liste.Add(sayi);
}

foreach (int n in liste)
{
    if (n == 1)
    {
        asaldegil.Add(n);
    }
    else if (n == 2)
    {
        asal.Add(n);
    }
    else
    {
        int sayac = 0;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                sayac++;
            }
        }
        if (sayac == 0)
        {
            asal.Add(n);
        }
        else
        {
            asaldegil.Add(n);
        }

    }

}

Console.WriteLine("******** Büyükten Küçüğe Sırala *********");
asal.Sort();
asaldegil.Sort();

Console.WriteLine("************* Asal Sayilar: ************");
foreach (int sayi in asal)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("************ Asal olmayan sayılar: ***********");
foreach (int sayi in asaldegil)
{
    Console.WriteLine(sayi);
}


int asalElemanSayisi = asal.Count;
double asalElemanSayisiToplami = 0;
foreach (int sayi in asal)
{
    asalElemanSayisiToplami += sayi;
}
double asalOrtalama = (asalElemanSayisiToplami / asalElemanSayisi);
Console.WriteLine("Asal Listenin Eleman Sayısı: {0} Ortalaması: {1}", asalElemanSayisi.ToString(), Math.Round(asalOrtalama, 2).ToString());

int asalOlmayan = asaldegil.Count;
double asalOlmayanToplami = 0;
foreach (int sayi in asaldegil)
{
    asalOlmayanToplami += sayi;
}
double asaldegilOrtalama = (asalOlmayanToplami / asalOlmayan);
Console.WriteLine("Asal Olmayan Listenin Eleman Sayısı: {0} Ortalaması: {1}", asalOlmayan.ToString(), Math.Round(asaldegilOrtalama, 2).ToString());


