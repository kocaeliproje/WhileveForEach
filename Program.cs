namespace donguler
{

class Program
{
    static void Main(string[]args)
    {
        //while
        // 1 den başlayarak consoldan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp consola yazdıran program
        Console.Write("Lütfen Bir Sayı Giriniz");
        int sayi =int.Parse(Console.ReadLine());
        int sayac =1;
        int toplam= 0;
       while (sayac<=sayi)
       {
        toplam += sayac;
        sayac ++;
        }
        Console.WriteLine(toplam/sayi) ;
        // a dan z ye kadar olan tüm harfleri consol a yazdır.
        char character ='a';
        while(character<='z')
        {
            Console.Write(character);
            character ++;
        }
        Console.Write("****foreach****");
        string [] arabalar = {"bmw","audi","toyota"};
   foreach (var araba in arabalar)
        {
            Console.Write(arabalar);
        }
    }
}

}