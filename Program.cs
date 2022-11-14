internal class Program
{
    private static void Main(string[] args)
    {
        //List<T> Class
        //System.Collection.Generic namespace
        //T->object türündedir

        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(5);
        sayiListesi.Add(6);
        sayiListesi.Add(15);
        sayiListesi.Add(28);
        sayiListesi.Add(40);


        List<String> Renkler = new List<string>();
        Renkler.Add("Kırmızı");
        Renkler.Add("Sarı");
        Renkler.Add("Yeşil");
        Renkler.Add("Mavi");
        Renkler.Add("Turuncu");

        //Count
        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(Renkler.Count);


        //Elemanara erişim
        foreach (var c in sayiListesi)
        {
            Console.WriteLine(c);
        }
        foreach (var c in Renkler)
        {
            Console.WriteLine(c);
        }

        sayiListesi.ForEach(item => Console.WriteLine(item));
        Renkler.ForEach(item => Console.WriteLine(item));

        //Listeden eleman çıkarma
        sayiListesi.Remove(5);
        Renkler.Remove("Sarı");

        sayiListesi.RemoveAt(0);
        Renkler.RemoveAt(1);

        sayiListesi.ForEach(item => Console.WriteLine(item));
        Renkler.ForEach(item => Console.WriteLine(item));

        //Liste içerisinde arama
        if (sayiListesi.Contains(28))
            Console.WriteLine("28 Liste içerisinde bulundu.");

        //eleman ile indexe erişim
        Console.WriteLine(sayiListesi.BinarySearch(40));
        Console.WriteLine(Renkler.BinarySearch("Mavi"));


        //Diziyi List'e çevirme
        string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
        List<string> hayvanlarListesi = new List<string>(hayvanlar);

        //Listeyi temizleme
        hayvanlarListesi.Clear();


        //Liste içerisinde nesne tutmak
        //List<Class> listeAdı= new List<Class>();
        List<kullanıcılar> userList = new List<kullanıcılar>();

        kullanıcılar user1 = new kullanıcılar();
        user1.Isim = "Ali";
        user1.Soyisim = "Çınar";
        user1.Yas = 26;

        kullanıcılar user2 = new kullanıcılar();
        user2.Isim = "Deniz";
        user2.Soyisim = "Altay";
        user2.Yas = 26;

        userList.Add(user1);
        userList.Add(user2);

        Console.WriteLine("\nuserList'in nesneleri:");
        userList.ForEach(item => Console.WriteLine(item.Isim + " " + item.Soyisim + " " + item.Yas));

        Console.WriteLine("\nnewList'in nesneleri:");
        List<kullanıcılar> newList = new List<kullanıcılar>();
        newList.Add(new kullanıcılar() { Isim = "Taner", Soyisim = "Yıldız", Yas = 24 });
        newList.Add(new kullanıcılar() { Isim = "Oguzhan", Soyisim = "Yıldız", Yas = 24 });
        newList.ForEach(item => Console.WriteLine(item.Isim + " " + item.Soyisim + " " + item.Yas));

        newList.Clear();
        Console.WriteLine("\nnewList listesini getir: ");
        if (newList == null || !newList.Any())
            Console.WriteLine("Liste boş!");
        else
            newList.ForEach(item => Console.WriteLine(item.Isim + " " + item.Soyisim + " " + item.Yas));

        //new example
        // Creating an List<T> of Integers...
        List<int> firstlist = new List<int>();

        // Adding elements to List...
        firstlist.Add(17);
        firstlist.Add(19);
        firstlist.Add(21);
        firstlist.Add(9);
        firstlist.Add(75);
        firstlist.Add(19);
        firstlist.Add(73);

        Console.Write("\nfirstlist listesinde 4 elemanı var mı?: " + firstlist.Contains(4));
        Console.Write("\nfirstlist listesinde 9 elemanı var mı?: " + firstlist.Contains(9));
        Console.Write("\nfirstlist listesinde 9 elemanının indexi: " + firstlist.IndexOf(9));
        Console.Write("\nfirstlist listesinde 9 elemanının indexi: " + firstlist.BinarySearch(9) + "\n");

        Console.WriteLine("\nElements Present in List:\n");

        int p = 0;

        // Displaying the elements of List...
        foreach (int k in firstlist)
        {
            Console.Write("At Position {0}: ", p);
            Console.WriteLine(k);
            p++;
        }

        Console.WriteLine(" ");

        // Printing the Capacity of firstlist..
        Console.WriteLine("\nfirstlist Capacity Is: " + firstlist.Capacity);

        // Printing the Count of firstlist..
        Console.WriteLine("firstlist Count Is: " + firstlist.Count);


        // removing the element at index 3...
        Console.WriteLine("\nRemoving the element at index 3 and new element added \n");

        // 9 will remove from the List...
        // and 75 will come at index 3...
        firstlist.RemoveAt(3);
        firstlist.Add(85);
        firstlist.Add(88);
        firstlist.Add(95);

        int p1 = 0;

        // Displaying the elements of List...
        foreach (int n in firstlist)
        {
            Console.Write("At Position {0}: ", p1);
            Console.WriteLine(n);
            p1++;
        }


        // Printing the Capacity of firstlist
        // It will give output 8 as internally
        // List is resized
        Console.WriteLine("\nfirstlist Capacity Is: " + firstlist.Capacity);

        // Printing the Count of firstlist..
        Console.WriteLine("firstlist Count Is: " + firstlist.Count);


        Console.ReadKey();

    }
}

public class kullanıcılar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }


}



