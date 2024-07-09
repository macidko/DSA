using System.Collections; // Collections kütüphanesini dahil eder.
using System.Collections.Generic;
using System.Linq; // Generic Collections kütüphanesini dahil eder.

internal partial class Program
{
    private static void Main(string[] args)
    {

        // Data Structures

        // HastableBasics();
        // HashtableExample();
        // SortedListExample();
        // IComparableImplementation();
        // StackBasics();
        // StackExample();
        // QueueBasics();
        // QueueExample();
        // LinkedListExample();
        // DictionaryBasics();
        //DictionaryExample();
        //SortedSetBasics();
        //SortedSetExample();
        //SortedSetClusterExample();
        HasSetExample();

        // Algorithms
        //CalculateCharacterFrequency();
        //UniqueCharacters();

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
    private static void QueueBasics()
    {
        Queue<char> queue = new Queue<char>();
        queue.Enqueue('a');
        queue.Enqueue('b');


        char[] chars = queue.ToArray();
        Console.WriteLine($"Array Uzunluğu: {chars.Length}");

        Console.WriteLine($"Eleman Sayısı: {queue.Count}");
        Console.WriteLine($"Kuyruğun başındaki eleman: {queue.Peek()}");
        Console.WriteLine($"Kuyruktan çıkarılan eleman: {queue.Dequeue()}");

    }
    private static void QueueExample()
    {
        List<char> chars = new()
    {
        'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'
    };

        Queue<char> charQueue = new Queue<char>();

        ConsoleKeyInfo selected;
        foreach (var c in chars)
        {
            Console.WriteLine();
            Console.WriteLine($"{c} kuyruğa eklensin mi? [e/h]");

            selected = Console.ReadKey(true);
            Console.WriteLine(); // Tuşu konsola yazdırmayı engellemek için

            if (selected.Key == ConsoleKey.E && selected.Key != ConsoleKey.H)
            {
                charQueue.Enqueue(c);
                Console.WriteLine($"{c} kuyruğa eklendi");
                Console.WriteLine($"Kuyruktaki eleman sayısı: {charQueue.Count}");
            }
            else
            {
                Console.WriteLine("Yanlış bir tuşa bastınız.");
            }
        }

        Console.WriteLine("Elemanları kuyruktan çıkartmak için ESC tuşuna basınız.");
        selected = Console.ReadKey(true);

        if (selected.Key == ConsoleKey.Escape)
        {

            while (charQueue.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"{charQueue.Peek()} kuyruktan çıkartılıyor.");
                Console.WriteLine($"{charQueue.Dequeue()} çıkartıldı.");
                Console.WriteLine($"Kuyruktaki eleman sayısı: {charQueue.Count}");
            }
        }
        else
        {
            Console.WriteLine("\nYanlış bir tuşa bastınız. Program sonlandırıldı.");
        }
    }
    private static void LinkedListExample()
    {
        LinkedList<string> cities = new();
        cities.AddFirst("Ordu");
        cities.AddFirst("Trabzon");
        cities.AddLast("İstanbul");

        cities.AddAfter(cities.Find("Ordu"), "Samsun");
        cities.AddBefore(cities.First.Next.Next, "Giresun");
        cities.AddAfter(cities.Last.Previous, "Sinop");
        cities.AddAfter(cities.Find("Sinop"), "Zonguldak");

        //foreach (var c in cities)
        //{
        //    Console.WriteLine(c);
        //}

        Console.WriteLine("Gidiş Güzergahı\n");

        //var departureRoad = cities.First;
        LinkedListNode<string> departureRoad = cities.First;
        while (departureRoad != null)
        {
            Console.WriteLine(departureRoad.Value);
            departureRoad = departureRoad.Next;
        }
        Wrapper();
        Console.WriteLine("Dönüş Güzergahı\n");
        //var returnRoad = cities.First;
        LinkedListNode<string> returnRoad = cities.Last;
        while (returnRoad != null)
        {
            Console.WriteLine(returnRoad.Value);
            returnRoad = returnRoad.Previous;
        }
    }
    private static void DictionaryBasics()
    {
        Dictionary<int, string> phones = new()
        {
            {332, "Konya"},
            {424, "Elazığ"}
        };

        //ekleme
        phones.Add(466, "Artvin");
        phones.Add(322, "Adana");
        phones.Add(212, "İstanbul");

        //erişme
        Console.WriteLine($"212 kodlu şehir: {phones[212]}");

        //ContainsKey
        if (!phones.ContainsKey(312))
        {
            Console.WriteLine("\aAnkaranın Kod Bilgisi Tanımlı Değil.");
            phones.Add(312, "Ankara");
            Console.WriteLine($"{phones[312]} Eklendi.");

            Wrapper();
        }

        // ContainsValue
        if (!phones.ContainsValue("Malatya"))
        {
            Console.WriteLine("\aMalatyanın Kod Bilgisi Tanımlı Değil!");
            phones.Add(342, "Malatya");
            Console.WriteLine($"{phones[342]} Eklendi.");

            Wrapper();
        }

        // IOrderedEnumerable<KeyValuePair<int, string>> sortedDictionary = phones.OrderBy(p => p.Key);
        // dictionary<tkey, tvalue> ifadesinin orderby ile sıralanması IOrderedEnumerable<KeyValuePair<int, string>> veri tipini döndürür.
        var sortedDictionary = phones.OrderBy(p => p.Key);

        //dictonary<TKey, TValue> ifadesi KeyValuePair<tkey,tvalue> tipini döndürür
        foreach (KeyValuePair<int, string> phone in phones)
        {
            Console.WriteLine(phone);
        }
    }
    private static void DictionaryExample()
    {
        Dictionary<int, Personel> personelList = new()
        {
            {2, new Personel(110, "Tame", "Impala", 6000)},
            {3, new Personel(120, "Mac", "DeMarco", 7000)},
        };

        personelList.Add(1, new Personel(100, "Arctic", "Monkeys", 5000));

        foreach (var p in personelList)
        {
            Console.WriteLine(p);
        }
    }
    private static void SortedDictionaryExample()
    {
        SortedDictionary<string, List<int>> bookIndex = new()
        {
            {"HTML", new List<int>(){8, 10, 12} },
            {"CSS", new List<int>(){ 70, 80, 90} },
            {"jQuery", new List<int>() {30, 40, 50 } },
            {"SQL", new List<int>(){21, 11, 31} }
        };

        bookIndex.Add("FTP", new List<int>() { 15, 17, 19 });

        foreach (var b in bookIndex)
        {
            Console.WriteLine(b.Key);
            b.Value.ForEach(i => Console.WriteLine($"\t > {i}"));
            //foreach (var index in b.Value)
            //{
            //    Console.WriteLine($"\t > {index}");
            //}
        }
    }
    private static void SortedSetBasics()
    {
        SortedSet<string> nameList = new()
        {
            "Ahmet",
            "Mehmet"
        };

        //ekleme
        nameList.Add("Şule");
        nameList.Add("Neslihan");
        nameList.Add("Fahrettin");
        nameList.Add("Fatih");
        nameList.Add("Nalan");

        Console.WriteLine("Ekleme işleminden sonra liste\n");
        foreach (var i in nameList)
        {
            Console.WriteLine(i);
        }

        Wrapper();

        //kaldırma
        nameList.Remove("Şule");
        nameList.RemoveWhere(i => i.Contains("N"));
        nameList.RemoveWhere(i => i.StartsWith("A"));

        Console.WriteLine("Kaldırma işleminden sonra liste\n");
        foreach (var i in nameList)
        {
            Console.WriteLine(i);
        }
    }
    private static void SortedSetExample()
    {
        List<int> numbers = new();
        var rand = new Random();

        for (int i = 0; i < 100; i++)
        {
            numbers.Add(rand.Next(0, 50));
            Console.WriteLine($"{numbers[i]} : Listeye eklendi.");
        }

        Wrapper();

        SortedSet<int> uniqueNumbers = new(numbers);

        Console.WriteLine("Unique sayılar;");
        foreach (var number in uniqueNumbers)
        {
            Console.Write(number + " ");
        }
    }
    private static void SortedSetClusterExample()
    {
        SortedSet<int> numbersA = new() { 1, 2, 4, 6, 7 };
        SortedSet<int> numbersB = new() { 1, 2, 3, 5, 7 };

        //yazdırma
        Console.WriteLine("Küme A;");
        foreach (var a in numbersA)
        {
            Console.Write(a);
        }
        Wrapper();
        Console.WriteLine("Küme B;");
        foreach (var b in numbersB)
        {
            Console.Write(b);
        }

        Wrapper();

        //ortak
        Console.WriteLine("Ortak Elemanlar");
        //numbersA.IntersectWith(numbersB);
        foreach (var ab in numbersA)
        {
            Console.Write(ab);
        }

        Wrapper();

        //hariç
        Console.WriteLine("B'de olan elemanları hariç tutma");
        //numbersA.ExceptWith(numbersB);
        foreach (var a in numbersA)
        {
            Console.Write(a);
        }

        Wrapper();

        //kesişim dışındaki elemanlar
        Console.WriteLine("Kesişim dışındaki elemanlar");
        numbersA.SymmetricExceptWith(numbersB);
        foreach (var item in numbersA)
        {
            Console.Write(item);
        }
        Wrapper();

        //birleşim
        Console.WriteLine("A ve B kümesinin birleşimi");
        //numbersA.UnionWith(numbersB);
        foreach (var ab in numbersA)
        {
            Console.Write(ab);
        }

        Wrapper();

    }
    private static void HashSet()
    {

    }
    // CalculateCharacterFrequency
    private static void CalculateCharacterFrequency()
    {
        string text = "asfqWFqwfAsfQWFqwgqwGqwgASdQWgqWGasGqwGqwFqwG";

        // Her karakterin tekrar sayısını saklamak için Dictionary oluştur
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Metindeki her bir karakteri kontrol et
        foreach (char c in text)
        {
            if (charCount.ContainsKey(c))
            {
                // Eğer karakter zaten Dictionary'de varsa, sayısını artır
                charCount[c]++;
            }
            else
            {
                // Eğer karakter Dictionary'de yoksa, onu ekle ve sayısını 1 yap
                charCount[c] = 1;
            }
        }

        // Dictionary içindeki karakterleri ve tekrar sayılarını ekrana yazdır
        foreach (var item in charCount)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
    private static void UniqueCharacters()
    {
        string text = "aaaabbbbbddddddaaaaawwwwwwwwwwttttttt";

        SortedSet<char> chars = new(text);

        foreach (char c in chars)
        {
            Console.WriteLine(c);
        }

        // Built-in metotlar olmadan
        //string text = "aaaabbbbbddddddaaaaawwwwwwwwwwttttttt";
        //List<char> uniqueChars = new List<char>();

        //foreach (char c in text)
        //{
        //    bool found = false;
        //    foreach (char existingChar in uniqueChars)
        //    {
        //        if (existingChar == c)
        //        {
        //            found = true;
        //            break;
        //        }
        //    }

        //    if (!found)
        //    {
        //        uniqueChars.Add(c);
        //    }
        //}

        //// Sıralama işlemi için basit bir mantıksal sıralama algoritması kullanabiliriz
        //for (int i = 0; i < uniqueChars.Count - 1; i++)
        //{
        //    for (int j = i + 1; j < uniqueChars.Count; j++)
        //    {
        //        if (uniqueChars[i] > uniqueChars[j])
        //        {
        //            char temp = uniqueChars[i];
        //            uniqueChars[i] = uniqueChars[j];
        //            uniqueChars[j] = temp;
        //        }
        //    }
        //}

        //// Sıralanmış karakterleri ekrana yazdırma
        //foreach (char c in uniqueChars)
        //{
        //    Console.WriteLine(c);
        //}
    }
}