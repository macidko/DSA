using DS;
using System.Collections; // Collections kütüphanesini dahil eder.
using System.Collections.Generic; // Generic Collections kütüphanesini dahil eder.

internal class Program
{
    private static void Main(string[] args)
    {
        // HastableBasics();
        // HashtableExample();
        // SortedListExample();
        // IComparableImplementation();
        // StackBasics();
        StackExample();

    }

    // Bir ayırıcı yazdıran metod.
    private static void Wrapper()
    {
        Console.WriteLine();
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();
    }

    // Hashtable temel işlemlerini gösteren metot.
    private static void HastableBasics()
    {
        // Hashtable tanımı.
        Hashtable hashTable = new Hashtable();

        // Hashtable'a eleman ekleme.
        hashTable[1] = "x";
        hashTable[2] = "y";
        hashTable[3] = "z";
        hashTable[4] = "x";

        // Hashtable elemanlarını yazdırma.
        Console.WriteLine("Hashtable elemanları");
        foreach (DictionaryEntry item in hashTable)
        {
            // Hashtable'daki her elemanın key ve value'sunu yazdırma.
            Console.WriteLine($"{item.Key} {item.Value}");
        }

        // 1 key'ine sahip elemanı erişme.
        Console.WriteLine("\n'1' Key Değerine Sahip Eleman:   " + hashTable[1]);

        // Eleman kaldırma işlemi.
        Console.WriteLine("\nEleman Kaldırma");
        hashTable.Remove(1);
        // Eleman kaldırıldıktan sonra tekrar yazdırma.
        foreach (DictionaryEntry item in hashTable)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }
    }

    // Kullanıcıdan alınan metni dönüştüren bir örnek.
    private static void HashtableExample()
    {
        // Kullanıcıdan metin alma.
        Console.WriteLine("Metin Giriniz.");
        string header = Console.ReadLine();

        // Metni küçük harfe dönüştürme.
        header = header.ToLower();

        // Dönüştürülecek karakterler ve dönüştürme değerleri.
        var characters = new Hashtable()
        {
            {'ç', 'c'},
            {'ı', 'i'},
            {'ö', 'o'},
            {'ü', 'u'},
            {' ', '-'},
            {'\'', '-'},
        };

        // Her karakter için dönüştürme işlemi.
        foreach (DictionaryEntry item in characters)
        {
            header = header.Replace((char)item.Key, (char)item.Value);
        }

        // Dönüştürülmüş metni yazdırma.
        Console.WriteLine(header);
    }

    // SortedList örneği.
    private static void SortedListExample()
    {
        // SortedList tanımı ve başlangıç elemanları.
        SortedList list = new SortedList()
        {
            {1, "Bir"},
            {2, "İki"},
            {12, "On İki"},
            {7, "Yedi"},
        };

        try
        {
            // SortedList'e eleman ekleme.
            list.Add(8, "Sekiz");
        }
        catch (Exception)
        {
            throw;
        }

        // SortedList elemanlarını yazdırma.
        foreach (DictionaryEntry item in list)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }

        // Listedeki eleman sayısını yazdırma.
        Console.WriteLine("Listedeki eleman sayısı:  {0}", list.Count);
        // Listedeki kapasiteyi yazdırma.
        Console.WriteLine("Listedeki eleman sayısı:  {0}", list.Capacity);
        // Kapasiteyi minimize etme.
        list.TrimToSize();
        Console.WriteLine("Listedeki eleman sayısı:  {0}", list.Capacity);

        // Key ile erişme.
        Console.WriteLine(list[2]);
        // Index ile erişme.
        Console.WriteLine(list.GetByIndex(0));
        // Index'e göre key alma.
        Console.WriteLine(list.GetKey(0));
        // Listedeki son elemanı alma.
        Console.WriteLine(list.GetByIndex(list.Count - 1));

        // Keys koleksiyonunu alma.
        var keys = list.Keys;

        // Eleman güncelleme.
        if (list.ContainsKey(1))
        {
            list[1] = "One";
        }
    }

    // IComparable implementasyonu örneği.
    private static void IComparableImplementation()
    {
        // Sayılar listesi ve sıralama.
        List<int> numbers = new List<int>() { 5, 11, 2, 45, 12, 44 };
        numbers.Sort();
        numbers.ForEach(s => Console.WriteLine(s));

        Wrapper();

        // Şehirler listesi ve sıralama.
        List<City> cities = new()
        {
            new(01, "Adana"),
            new(34, "İstanbul"),
            new(22, "Edirne"),
            new(02, "Adıyaman")
        };

        // Şehirler listesini sıralama.
        cities.Sort();
        cities.ForEach(s => Console.WriteLine(s));

        // Elle karşılaştırma ve sıralama
        /*
        for (int i = 0; i < cities.Count; i++)
        {
            for (int j = i + 1; j < cities.Count; j++)
            {
                if (cities[i].CompareTo(cities[j]) > 0)
                {
                    var temp = cities[i];
                    cities[i] = cities[j];
                    cities[j] = temp;
                }
            }
        }
        */
    }

    // Stack temel işlemleri.
    private static void StackBasics()
    {
        // Stack tanımı.
        Stack<char> stack = new();

        // Stack'e karakter ekleme ve yazdırma.
        stack.Push('A');
        Console.WriteLine($"{stack.Peek()} stack'e eklendi.");
        stack.Push('B');
        Console.WriteLine($"{stack.Peek()} stack'e eklendi.");
        stack.Push('C');
        Console.WriteLine($"{stack.Peek()} stack'e eklendi.");

        Wrapper();

        // Stack'ten karakter çıkarma ve yazdırma.
        Console.WriteLine(stack.Pop() + " stackten çıkartıldı");
        Console.WriteLine(stack.Pop() + " stackten çıkartıldı");
        Console.WriteLine(stack.Pop() + " stackten çıkartıldı");

        Wrapper();

        // ASCII karakter eklemesi ve yazdırma.
        for (int i = 65; i <= 90; i++)
        {
            stack.Push((char)i);
            Console.WriteLine($"{stack.Peek()} stack'e eklendi. (ASCII {i})");
        }
        Console.WriteLine($"Karakter Sayısı: {stack.Count}");

        Wrapper();

        char[] stackToArray = stack.ToArray();
        Console.WriteLine("Array");
        foreach (var item in stackToArray)
        {
            Console.Write($"{item},");
        }

        Wrapper();

        // Karakter çıkartmak için kullanıcıdan bir tuşa basmasını bekler.
        Console.WriteLine("\nKarakter çıkartmak için bir tuşa basınız");
        Console.ReadKey();
        Wrapper();

        // Stack'ten tüm karakterleri çıkarma ve yazdırma.
        while (stack.Count > 0)
        {
            Console.WriteLine($"{stack.Pop()} stack'ten çıkartıldı.");
        }
        Console.WriteLine($"Karakter Sayısı: {stack.Count}");

        Wrapper();
    }

    private static void StackExample()
    {
        Stack<int> numbers = new();
        Console.WriteLine("Bir Sayı Giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());

        while (number > 0)
        {
            int remainder = number % 10;
            numbers.Push(remainder);
            number /= 10;
        }

        int x = numbers.Count - 1;
        int result = 0;
        foreach (var n in numbers)
        {
            double raisedNumber = n * Math.Pow(10, x);
            Console.WriteLine($"\t{n,7} x {Math.Pow(10, x),7} : {raisedNumber,7}");
            result += Convert.ToInt32(raisedNumber);
            x--;
        }
        Console.WriteLine($"\t {"Result",20}: {result}");
    }
}