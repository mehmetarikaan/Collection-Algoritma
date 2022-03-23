using System.Collections;

Console.WriteLine("************ Soru 3 ***********");
Console.WriteLine("Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.");

List<string> sesliListe = new List<string>();
List<string> girilenCumle = new List<string>();
string[] sesli = { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U", "ü", "Ü", "ö", "Ö" };

Console.Write("Bir cümle giriniz: ");

girilenCumle.Add(Console.ReadLine());


for (int i = 0; i < girilenCumle.Count; i++)
    for (int j = 0; j < sesli.Length; j++)
    {
        if (girilenCumle[i].Contains(sesli[j]))
        {
            sesliListe.Add(sesli[j]);
        }
    }

sesliListe.ForEach(item => Console.WriteLine(item));