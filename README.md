
# Data Structures and Algorithms
- [Bit](#bit)
- [Byte](#byte)
- [İkilik sayıyı(binary) ondalık sayıya(decimal) çevirme](#ondalık-sayıyıdecimal-ikilik-sayıyabinary-çevirme)
- [Ondalık sayıyı(decimal) ikilik sayıya(binary) çevirme](#ondalık-sayıyıdecimal-ikilik-sayıyabinary-çevirme)
- [Struct](#struct)
- [Class ve Struct Farkı](#class-ve-struct-farkı)
- [Hashtable ve Dictionary](#hashtable-ve-dictionary)
- [Boxing / Unboxing](#boxing--unboxing)
- [Class](#class)
- [HashTable](#hashtable)
- [SortedList](#sortedlist)
- [List](#list)
- [Stack](#stack)
- [Queue](#queue)
- [LinkedList](#linkedlist)
- [Dictionary](#dictionary)
- [SortedDictionary](#sorteddictionary)
- [SortedSet](#sortedset)


## Bit

Bit, dijital bilgisayar sistemlerinde en küçük veri birimidir ve "binary digit" (ikili rakam) teriminin kısaltmasıdır. Bit, yalnızca iki değerden birini alabilir: 0 veya 1. Bu iki durum...


## Byte

**Byte**: Byte, dijital bilgisayar sistemlerinde veri depolama ve işleme için kullanılan temel birimdir. 1 byte, 8 bitten oluşur ve bu sayede 256 farklı değeri (0-255) temsil edebilir. Byte, karakterlerin, küçük veri miktarlarının ve çeşitli veri türlerinin saklanmasında yaygın olarak kullanılır.

**SByte**: `sbyte`, "signed byte" teriminin kısaltmasıdır ve işaretli bir bayttır. Bu veri türü, 8 bitlik bir alana sahiptir ve pozitif veya negatif değerler alabilir. `sbyte`, -128 ile 127 arasında değerler depolayabilir. Genellikle, sayısal verilerin işaretli (negatif veya pozitif) olarak saklanması gerektiğinde kullanılır.

## İkilik sayıyı(binary) ondalık sayıya(decimal) çevirme
İkili sayı: **1011**

1. **İkili sayıyı yaz ve basamakları belirle**:
    - Basamak değerleri, en sağdan sola doğru 2'nin kuvvetleri olarak artar.
    - Sağdan sola: 2^0, 2^1, 2^2, 2^3.
    
    ```
    1    0    1    1
    2^3  2^2  2^1  2^0
    
    ```
    
2. **Her bitin değerini hesapla**:
    - Sağdan en soldaki bit (1): 1 x 2^3 = 1 x 8 = 8
    - İkinci bit (0): 0 x 2^2 = 0 x 4 = 0
    - Üçüncü bit (1): 1 x 2^1 = 1 x 2 = 2
    - Sağdan en sağdaki bit (1): 1 x 2^0 = 1 x 1 = 1

3. **Tüm değerleri topla**:
    - Toplam = 8 + 0 + 2 + 1 = 11

### Sonuç

İkili sayı **1011** ondalık olarak **11**'e eşittir.

### Görsel Gösterim

```
  Bitler:  1    0    1    1
          2^3  2^2  2^1  2^0
          8    0    2    1

  Toplam:  8 + 0 + 2 + 1 = 11

```

### 8 Bitlik Örnek

İkili sayı: **00001011**

1. **İkili sayıyı yaz ve basamakları belirle**:
    - Basamak değerleri, en sağdan sola doğru 2'nin kuvvetleri olarak artar.
    - Sağdan sola: 2^0, 2^1, 2^2, 2^3, 2^4, 2^5, 2^6, 2^7.
    
    ```
    0    0    0    0    1    0    1    1
    2^7  2^6  2^5  2^4  2^3  2^2  2^1  2^0
    
    ```
    
2. **Her bitin değerini hesapla**:
    - Sağdan en soldaki bit (0): 0 x 2^7 = 0
    - İkinci bit (0): 0 x 2^6 = 0
    - Üçüncü bit (0): 0 x 2^5 = 0
    - Dördüncü bit (0): 0 x 2^4 = 0
    - Beşinci bit (1): 1 x 2^3 = 8
    - Altıncı bit (0): 0 x 2^2 = 0
    - Yedinci bit (1): 1 x 2^1 = 2
    - Sekizinci bit (1): 1 x 2^0 = 1

3. **Tüm değerleri topla**:
    - Toplam = 0 + 0 + 0 + 0 + 8 + 0 + 2 + 1 = 11

### Sonuç

8 bitlik ikili sayı **00001011** ondalık olarak **11**'e eşittir.

### Görsel Gösterim

```
  Bitler:  0    0    0    0    1    0    1    1
          2^7  2^6  2^5  2^4  2^3  2^2  2^1  2^0
          0    0    0    0    8    0    2    1

  Toplam:  0 + 0 + 0 + 0 + 8 + 0 + 2 + 1 = 11
```

## Ondalık sayıyı(decimal) ikilik sayıya(binary) çevirme

1. **Ondalık sayıyı 2'ye böl** ve kalanı yaz. (Bu kalan ya 0 ya da 1 olacaktır.)
2. **Bölüm sonucu** tekrar 2'ye böl ve kalanı yaz.
3. Bu işlemi, bölüm 0 olana kadar devam ettir.
4. **Kalanları tersten** yaz (en son kalandan en ilk kalana doğru).

### Örnek: 11 Ondalık Sayısını İkili Sayıya Çevirme

1. **11'i 2'ye böl**:
    - Bölüm = 5, Kalan = 1
2. **5'i 2'ye böl**:
    - Bölüm = 2, Kalan = 1
3. **2'yi 2'ye böl**:
    - Bölüm = 1, Kalan = 0
4. **1'i 2'ye böl**:
    - Bölüm = 0, Kalan = 1

### Kalanları Tersten Yazma

- Kalanlar: 1, 0, 1, 1

Bu kalanları tersten yazarsak, 11 ondalık sayısının ikili karşılığı **1011** olur.

### Görsel Gösterim

```
  Adım 1: 11 ÷ 2 = 5, kalan 1
  Adım 2:  5 ÷ 2 = 2, kalan 1
  Adım 3:  2 ÷ 2 = 1, kalan 0
  Adım 4:  1 ÷ 2 = 0, kalan 1

  Kalanlar (tersten): 1011
```

### Sonuç

11 ondalık sayısı, ikili olarak **1011**'e eşittir.

## Struct

`struct` yapısı, C# dilinde değer türü oluşturmak için kullanılan bir veri tipidir. Bu yapı, farklı veri tiplerini bir araya getirerek bir değişkenin birden fazla veri türünü saklamasına izin verir. Yapılar parametreli constructor, statik constructor, sabitler, alanlar, metotlar, özellikler, indexerler, operatörler ve iç yapılar gibi öğeleri içerebilir.

**Yapı Tanımlama ve Kullanım**

Yapılar `struct` anahtar sözcüğüyle tanımlanır. Yeni bir değişken oluşturmak için `new` operatörü kullanılabileceği gibi, kullanılmadan da oluşturulabilir; bu durumda üy

eler varsayılan değerlerle başlatılır.

```csharp
public struct Coordinate
{
    public double X { get; }
    public double Y { get; }

    public Coordinate(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString() => $"({X}, {Y})";
}

public static class StructWithoutNew
{
    public static void Main()
    {
        Coordinate p;
        p.X = 3;
        p.Y = 4;
        Console.WriteLine(p.ToString()); // Çıktı: (3, 4)
    }
}
```

## Class ve Struct Farkı

### Class (Sınıf)

- **Referans türüdür**.
- Heap bellekte tutulur.
- Bir nesnenin referansını (adresini) saklar.
- Değerleri `null` olabilir.
- Genellikle daha büyük ve karmaşık veri yapılarını temsil etmek için kullanılır.
- Oluşturulan nesneler üzerinde yapılan değişiklikler, tüm referansların üzerinde etki gösterir.

### Struct (Yapı)

- **Değer türüdür**.
- Stack bellekte tutulur.
- Değerin kendisini saklar.
- Değerleri `null` olamaz (varsayılan değerlerle başlatılır).
- Genellikle küçük ve basit veri yapılarını temsil etmek için kullanılır.
- Oluşturulan nesneler kopyalandığında, her kopya bağımsız olarak değiştirilebilir.

### Görsel Gösterim

| Özellik | Class | Struct |
|---------|-------|--------|
| Tür     | Referans Türü | Değer Türü |
| Bellek  | Heap | Stack |
| Null Olabilirlik | Evet | Hayır |
| Kullanım | Karmaşık Veri Yapıları | Basit Veri Yapıları |
| Kopyalama | Referans Kopyalama | Değer Kopyalama |

## Hashtable ve Dictionary

### Hashtable

- **Thread-Safety**: Hashtable, thread-safe (iş parçacığı güvenli) değildir.
- **Nullable Anahtarlar ve Değerler**: Null olmayan anahtar ve değerleri kabul eder.
- **Performans**: Arama, ekleme ve silme işlemleri genellikle O(1) zaman karmaşıklığına sahiptir.
- **Legacy Tip**: Eski .NET versiyonlarından beri kullanılmaktadır.

### Dictionary

- **Thread-Safety**: Varsayılan olarak thread-safe değildir.
- **Nullable Anahtarlar ve Değerler**: Null anahtarları ve değerleri kabul eder.
- **Performans**: Genellikle hashtable kadar hızlı olmasına rağmen, performans thread-safety mekanizmalarıyla değişebilir.
- **Modern C# Standartı**: C# dilinde modern ve yaygın kullanılan bir yapıdır.

### Kullanılabilecek Metotlar

Her iki yapı da anahtar ekleme (`Add`), anahtar kontrolü (`ContainsKey`), değer kontrolü (`ContainsValue`), değer alma (`this[key]` veya `TryGetValue`), değer silme (`Remove`) gibi ortak metotlara sahiptir.

### Görsel Gösterim

| Özellik             | Hashtable                | Dictionary |
|---------------------|--------------------------|------------|
| **Thread-Safety**   | Hayır                    | Hayır       |
| **Nullable Anahtar**| Hayır                    | Evet        |
| **Performans**      | O(1)                     | O(1)        |
| **Kullanım Alanı**  | Eski .NET uygulamaları   | Modern C# uygulamaları |

## Boxing / Unboxing

### Boxing

Boxing, değer türlerinin referans türlerine dönüştürülmesi işlemidir. Bu işlem sırasında, bir değer türü nesnesi, heap'te bir object veya interface türünde bir kutu (box) içine alınır. Boxing işlemi, performans açısından pahalıdır çünkü heap'te yeni bir nesne oluşturmayı gerektirir.

**Örnek**:

```csharp
int num = 123;
object obj = num; // Boxing işlemi
```

### Unboxing

Unboxing, referans türlerinin değer türlerine dönüştürülmesi işlemidir. Bu işlem sırasında, bir kutu (box) içindeki değer türü nesnesi, stack'te bir değere dönüştürülür. Unboxing işlemi, boxing işlemine kıyasla daha az maliyetlidir, ancak yine de dikkatli kullanılmalıdır.

**Örnek**:

```csharp
object obj = 123;
int num = (int)obj; // Unboxing işlemi
```

### Görsel Gösterim

| İşlem      | Açıklama                                                | Performans          |
|------------|---------------------------------------------------------|---------------------|
| **Boxing** | Değer türünden referans türüne dönüştürme               | Yüksek maliyetli    |
| **Unboxing**| Referans türünden değer türüne dönüştürme               | Daha az maliyetli   |
## Class

C# dilinde sınıf (class), nesne yönelimli programlamanın (OOP) temel yapı taşıdır. Sınıflar, nesnelerin özelliklerini (fields/properties) ve davranışlarını (methods) tanımlamak için kullanılır. Sınıflar, kodun yeniden kullanılabilirliğini, modülerliğini ve organizasyonunu sağlar.

### Sınıf Tanımlama

C#'ta bir sınıf tanımlamak için `class` anahtar kelimesi kullanılır. Sınıflar, genellikle namespace içinde tanımlanır ve erişim belirleyicileri (public, private, internal, protected) ile erişim seviyeleri belirlenir.

```csharp
public class Person
{
    // Fields (Alanlar)
    private string name;
    private int age;

    // Properties (Özellikler)
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
            else
                throw new ArgumentException("Age cannot be negative.");
        }
    }

    // Constructor (Kurucu Metot)
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Methods (Metotlar)
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}


```

### Sınıf Özellikleri

1.  **Fields (Alanlar)**: Bir sınıfın verilerini saklayan değişkenlerdir. Genellikle private olarak tanımlanır.
2.  **Properties (Özellikler)**: Alanlara erişimi sağlayan get ve set metotlarını içeren üyeler.
3.  **Methods (Metotlar)**: Bir sınıfın davranışlarını tanımlayan fonksiyonlardır.
4.  **Constructors (Kurucu Metotlar)**: Bir sınıfın yeni bir örneği oluşturulduğunda çalışan özel metotlardır.
5.  **Destructors (Yıkıcı Metotlar)**: Bir sınıfın örneği bellekten kaldırıldığında çalışan metotlardır (nadir kullanılır).

### Sınıflar ve Struct'lar Arasındaki Farklar

1.  **Bellek Yönetimi**:
    -   **Class**: Heap bellekte tutulur ve referans türüdür.
    -   **Struct**: Stack bellekte tutulur ve değer türüdür.
2.  **Kalıtım**:
    -   **Class**: Kalıtım alabilir (inheritance) ve türetilmiş sınıflar oluşturabilir.
    -   **Struct**: Kalıtım alamaz, sadece interface'lerden kalıtım alabilir.
3.  **Null Olabilme**:
    -   **Class**: Null olabilir.
    -   **Struct**: Varsayılan olarak null olamaz, ancak `Nullable<T>` ile kullanılabilir.
4.  **Performans**:
    -   **Class**: Referans türü olduğu için heap bellekte yer kaplar ve bellek yönetimi (GC) tarafından yönetilir.
    -   **Struct**: Değer türü olduğu için stack bellekte yer kaplar ve genellikle daha performanslıdır.

### Sınıf Kullanım Örneği

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Alice", 30);
        person.DisplayInfo();  // Çıktı: Name: Alice, Age: 30

        // Property kullanımı
        person.Name = "Bob";
        person.Age = 25;
        person.DisplayInfo();  // Çıktı: Name: Bob, Age: 25
    }
}


```

### Class İle İlgili Diğer Kavramlar

1.  **Inheritance (Kalıtım)**:
    
    -   Bir sınıf başka bir sınıftan türetilebilir.
    -   Örnek:
    
    ```csharp
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; }
    
        public Employee(string name, int age, int employeeId, string department)
            : base(name, age)
        {
            EmployeeId = employeeId;
            Department = department;
        }
    
        public void DisplayEmployeeInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Employee ID: {EmployeeId}, Department: {Department}");
        }
    }
    
    
    ```
    
2.  **Polymorphism (Çok Biçimlilik)**:
    
    -   Bir sınıfın metodunun, türetilmiş sınıfta farklı şekillerde davranmasını sağlar.
    -   Örnek:
    
    ```csharp
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }
    
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();
    
            myDog.MakeSound();  // Çıktı: Bark
            myCat.MakeSound();  // Çıktı: Meow
        }
    }
    
    
    ```
    
3.  **Encapsulation (Kapsülleme)**:
    
    -   Sınıfın iç verilerinin dışarıdan erişime kapatılması ve kontrollü erişim sağlanması.
    -   Örnek:
    
    ```csharp
    public class BankAccount
    {
        private decimal balance;
    
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0)
                    balance = value;
                else
                    throw new ArgumentException("Balance cannot be negative");
            }
        }
    
        public void Deposit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                throw new ArgumentException("Deposit amount must be positive");
        }
    
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
                Balance -= amount;
            else
                throw new ArgumentException("Invalid withdraw amount");
        }
    }
    
    
    ```
    

Bu örnekler ve açıklamalar, C#'ta sınıf kavramını ve onun temel özelliklerini kapsamlı bir şekilde ele alır. Sınıflar, nesne yönelimli programlamanın temel taşıdır ve yazılım geliştirme sürecinde kodun yeniden kullanılabilirliği ve organizasyonu için kritik öneme sahiptir.

## Class ve Struct Farkı

### 1. İçerik ve Kullanım Amaçları

-   **Class (Sınıf)**:
    -   Referans türüdür.
    -   Heap bellekte tutulur.
    -   Bir nesnenin referansını (adresini) saklar.
    -   Değerleri null olabilir.
    -   Genellikle daha büyük ve karmaşık veri yapılarını temsil etmek için kullanılır.
    -   Oluşturulan nesneler üzerinde yapılan değişiklikler, tüm referansların üzerinde etki gösterir.
-   **Struct (Yapı)**:
    -   Değer türüdür.
    -   Stack bellekte tutulur.
    -   Değerin kendisini saklar.
    -   Değerleri null olamaz (varsayılan değerlerle başlatılır).
    -   Genellikle küçük ve basit veri yapılarını temsil etmek için kullanılır.
    -   Oluşturulan nesneler kopyalandığında, her kopya bağımsız olarak değiştirilebilir.

### 2. Bellek Kullanımı

-   **Class**:
    -   Referans türü olduğu için bellekte daha fazla yer kaplar.
    -   Referansları ve nesne verilerini (heap'te) saklar.
-   **Struct**:
    -   Değer türü olduğu için bellekte daha az yer kaplar.
    -   Veriler doğrudan stack bellekte saklanır.

### 3. Kopyalama ve Performans

-   **Class**:
    -   Referanslar üzerinden erişildiği için kopyalama maliyeti daha düşüktür.
    -   Nesneler referanslarını paylaştıkları için kopyalandığında aynı nesneye erişim sağlar.
-   **Struct**:
    -   Değerler doğrudan kopyalandığı için kopyalama maliyeti daha yüksektir.
    -   Oluşturulan her kopya, bağımsız bir veri kümesini temsil eder.

### 4. Null Olabilme

-   **Class**:
    -   Referanslar null olabilir.
    -   Yani bir class nesnesi oluşturulduğunda, o nesne null olarak atanabilir.
-   **Struct**:
    -   Değerler null olamaz.
    -   Struct tipleri, varsayılan değerlerle (0, false, null vb.) başlatılır.

### 5. Inheritance (Miras Alma)

-   **Class**:
    -   Kalıtım alabilir (inheritance) ve türetilmiş sınıflar (derived classes) oluşturabilir.
    -   Birden fazla sınıf tarafından uygulanabilen bir arayüz (interface) sağlayabilir.
-   **Struct**:
    -   Kalıtım alamaz.
    -   Struct'lar, System.ValueType sınıfından kalıtım alır ve başka bir sınıftan kalıtım alamazlar.

### Hangi Durumda Hangisini Kullanmalı?

-   **Class**:
    -   Karmaşık nesneler, referanslar üzerinden paylaşılması gereken veriler için.
    -   Kalıtım, arayüzler ve nesne yaşam döngüsü yönetimi gerektiren durumlar için.
-   **Struct**:
    -   Küçük ve basit veri yapıları, değer tipi performans avantajlarından faydalanmak isteyen durumlar için.
    -   Heap'te yer ayırmak yerine stack belleği kullanmak isteyen durumlar için.

Özetle, `class` ve `struct` farklı bellek yönetimi, kopyalama davranışı ve kullanım senaryolarına sahip veri yapılarıdır. Seçim, projenin gereksinimlerine ve performans beklentilerine bağlı olarak yapılmalıdır.

## HashTable

### Tanım

`HashTable`, anahtar-değer (key-value) çiftlerini depolamak için kullanılan bir veri yapısıdır. C#'ta `System.Collections` namespace'i altında bulunur. `HashTable`, anahtarların benzersiz olmasını gerektirir ve anahtarlara hızlı erişim sağlar.

### HashTable Tanımlama

1.  **Varsayılan Tanımlama:**
    
    ```csharp
    Hashtable hashtable = new Hashtable();
    
    
    ```
    
2.  **İlk Kapasite ile Tanımlama:**
    
    ```csharp
    Hashtable hashtable = new Hashtable(100);  // 100 eleman için önceden ayarlanmış kapasite
    
    
    ```
    
3.  **Başka Bir Koleksiyonla Tanımlama:**
    
    ```csharp
    IDictionary initialData = new Dictionary<string, string>
    {
        { "key1", "value1" },
        { "key2", "value2" }
    };
    Hashtable hashtable = new Hashtable(initialData);
    
    
    ```
    

### HashTable Kullanım Örnekleri

1.  **Eleman Ekleme:**
    
    ```csharp
    hashtable.Add("id", 1);
    hashtable.Add("name", "Alice");
    hashtable.Add("age", 30);
    
    
    ```
    
2.  **Eleman Erişimi:**
    
    ```csharp
    int id = (int)hashtable["id"];
    string name = (string)hashtable["name"];
    int age = (int)hashtable["age"];
    
    
    ```
    
3.  **Eleman Silme:**
    
    ```csharp
    hashtable.Remove("age");
    
    
    ```
    
4.  **Kontrol:**
    
    ```csharp
    bool containsKey = hashtable.ContainsKey("name");
    bool containsValue = hashtable.ContainsValue("Alice");
    
    
    ```
    
5.  **Güncelleme:**
    
    ```csharp
    hashtable["name"] = "Bob";
    
    
    ```
    
6.  **Döngü ile Elemanlara Erişim:**
    
    ```csharp
    foreach (DictionaryEntry entry in hashtable)
    {
        Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
    }
    
    
    ```
    

### HashTable Kullanım Nedenleri

-   **Hızlı Erişim:** Hashing algoritması sayesinde anahtarlara hızlı erişim sağlar.
-   **Esneklik:** Heterojen veri tiplerini (farklı veri türlerini) depolayabilir.
-   **Anahtar-Benzersizliği:** Aynı anahtar iki kez eklenemez, bu da veri tutarlılığını sağlar.

### HashTable ve Benzer Veri Yapıları

1.  **Dictionary (System.Collections.Generic.Dictionary<TKey, TValue>):**
    
    -   **Farklar:**
        
        -   `Dictionary`, `HashTable`'a göre daha performanslı ve tür güvenli bir yapı sunar.
        -   Generics kullanılarak tür güvenliği sağlar.
    -   **Kullanım:**
        
        ```csharp
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("id", 1);
        dictionary.Add("age", 30);
        int age = dictionary["age"];
        
        
        ```
        
2.  **SortedList:**
    
    -   **Farklar:**
        
        -   Anahtar-değer çiftlerini sıralı bir şekilde tutar.
        -   `SortedList`, hem anahtara hem de değere göre sıralama yapabilir.
    -   **Kullanım:**
        
        ```csharp
        SortedList sortedList = new SortedList();
        sortedList.Add("id", 1);
        sortedList.Add("name", "Alice");
        
        
        ```
        
3.  **HashSet (System.Collections.Generic.HashSet<T>):**
    
    -   **Farklar:**
        
        -   Sadece benzersiz değerleri tutar (anahtar-değer çiftleri yerine tekil değerler).
        -   Performans olarak hızlıdır ve set işlemlerini destekler (birleşim, kesişim vb.).
    -   **Kullanım:**
        
        ```csharp
        HashSet<int> hashSet = new HashSet<int>();
        hashSet.Add(1);
        hashSet.Add(2);
        bool contains = hashSet.Contains(2);
        
        
        ```
        

### Örnek Kod: HashTable Kullanımı

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Hashtable tanımlama
        Hashtable hashtable = new Hashtable();

        // Eleman ekleme
        hashtable.Add("id", 1);
        hashtable.Add("name", "Alice");
        hashtable.Add("age", 30);

        // Eleman erişimi ve güncelleme
        Console.WriteLine("Name: " + hashtable["name"]);
        hashtable["name"] = "Bob";
        Console.WriteLine("Updated Name: " + hashtable["name"]);

        // Elemanları listeleme
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // Eleman silme
        hashtable.Remove("age");

        // Kalan elemanları listeleme
        Console.WriteLine("After removal:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
```
## SortedList

`SortedList`, anahtar-değer çiftlerini saklayan ve anahtarlarına göre sıralanmış bir koleksiyon sağlayan bir veri yapısıdır. `SortedList`, `System.Collections` namespace'inde bulunur. `SortedList`'in generic versiyonu ise `SortedList<TKey, TValue>` olarak `System.Collections.Generic` namespace'inde bulunur.

### SortedList Tanımlama ve Kullanım Örnekleri

### SortedList Tanımlama

1.  **Varsayılan Tanımlama:**
    
    ```csharp
    SortedList sortedList = new SortedList();
    
    
    ```
    
2.  **Başlangıç Kapasitesi ile Tanımlama:**
    
    ```csharp
    SortedList sortedList = new SortedList(10);
    
    
    ```
    
3.  **Dictionary'den Kopyalama ile Tanımlama:**
    
    ```csharp
    Hashtable hashtable = new Hashtable();
    SortedList sortedList = new SortedList(hashtable);
    
    
    ```
    

### SortedList Kullanım Örnekleri

1.  **Eleman Ekleme:**
    
    ```csharp
    sortedList.Add(1, "Bir");
    sortedList.Add(3, "Üç");
    sortedList.Add(2, "İki");
    
    
    ```
    
2.  **Eleman Erişimi:**
    
    ```csharp
    var value = sortedList[1]; // "Bir" döner
    
    
    ```
    
3.  **Eleman Güncelleme:**
    
    ```csharp
    sortedList[2] = "İkincisi";
    
    
    ```
    
4.  **Eleman Silme:**
    
    ```csharp
    sortedList.Remove(1);
    
    
    ```
    
5.  **Elemanları Listeleme:**
    
    ```csharp
    foreach (DictionaryEntry entry in sortedList)
    {
        Console.WriteLine($"{entry.Key}: {entry.Value}");
    }
    
    
    ```
    

### SortedList<TKey, TValue> Tanımlama ve Kullanım Örnekleri

### SortedList<TKey, TValue> Tanımlama

1.  **Varsayılan Tanımlama:**
    
    ```csharp
    SortedList<int, string> sortedList = new SortedList<int, string>();
    
    
    ```
    
2.  **Başlangıç Kapasitesi ile Tanımlama:**
    
    ```csharp
    SortedList<int, string> sortedList = new SortedList<int, string>(10);
    
    
    ```
    
3.  **Dictionary'den Kopyalama ile Tanımlama:**
    
    ```csharp
    Dictionary<int, string> dictionary = new Dictionary<int, string>
    {
        { 1, "Bir" },
        { 3, "Üç" },
        { 2, "İki" }
    };
    SortedList<int, string> sortedList = new SortedList<int, string>(dictionary);
    
    
    ```
    

### SortedList<TKey, TValue> Kullanım Örnekleri

1.  **Eleman Ekleme:**
    
    ```csharp
    sortedList.Add(1, "Bir");
    sortedList.Add(3, "Üç");
    sortedList.Add(2, "İki");
    
    
    ```
    
2.  **Eleman Erişimi:**
    
    ```csharp
    var value = sortedList[1]; // "Bir" döner
    
    
    ```
    
3.  **Eleman Güncelleme:**
    
    ```csharp
    sortedList[2] = "İkincisi";
    
    
    ```
    
4.  **Eleman Silme:**
    
    ```csharp
    sortedList.Remove(1);
    
    
    ```
    
5.  **Elemanları Listeleme:**
    
    ```csharp
    foreach (KeyValuePair<int, string> entry in sortedList)
    {
        Console.WriteLine($"{entry.Key}: {entry.Value}");
    }
    
    
    ```
    

### Neden SortedList Kullanılır?

1.  **Sıralı Veri Saklama:** `SortedList`, verileri anahtarlarına göre sıralı şekilde saklar. Bu, verilerin sıralı olarak tutulmasının önemli olduğu durumlarda avantaj sağlar.
2.  **Hızlı Arama ve Erişim:** `SortedList`, `O(log n)` zaman karmaşıklığı ile hızlı arama ve eleman erişimi sağlar.

### Benzer Diğer Veri Yapılarıyla Farklar

1.  **Dictionary<TKey, TValue>:**
    -   **Tür Güvenliği:** Hem `Dictionary` hem de `SortedList` tür güvenliği sağlar.
    -   **Sıralama:** `Dictionary` elemanları sıralı tutmaz, `SortedList` ise anahtarlara göre sıralı tutar.
    -   **Performans:** `Dictionary`, ekleme ve erişim işlemlerinde `O(1)` zaman karmaşıklığına sahiptir, `SortedList` ise `O(log n)` zaman karmaşıklığına sahiptir.
2.  **Hashtable:**
    -   **Tür Güvenliği:** `Hashtable` tür güvenliği sağlamaz, `SortedList` ise generic versiyonunda tür güvenliği sağlar.
    -   **Sıralama:** `Hashtable` elemanları sıralı tutmaz, `SortedList` ise anahtarlara göre sıralı tutar.
    -   **Performans:** `Hashtable`, ekleme ve erişim işlemlerinde `O(1)` zaman karmaşıklığına sahiptir, `SortedList` ise `O(log n)` zaman karmaşıklığına sahiptir.
3.  **SortedDictionary<TKey, TValue>:**
    -   **Sıralama:** Hem `SortedList` hem de `SortedDictionary` anahtarlara göre sıralı veri saklar.
    -   **Veri Erişimi:** `SortedList` anahtar ve değerleri dizilerde saklar ve daha az bellek kullanımı sağlar, `SortedDictionary` ise bir ikili ağaç yapısı kullanır.
    -   **Performans:** Genellikle `SortedList` küçük veri kümeleri için daha hızlıdır, `SortedDictionary` ise büyük veri kümeleri için daha iyi performans gösterir.

## List

C#'da `List<T>`, sıklıkla kullanılan ve esnek bir koleksiyon türüdür. `List<T>`, aynı türden elemanların dinamik bir listesini tutar ve elemanlara sıralı bir şekilde erişim sağlar. `System.Collections.Generic` namespace'i altında bulunur ve `ArrayList` gibi diğer eski koleksiyon türlerine kıyasla daha performanslı ve tip güvenlidir.

### `List<T>` Nedir?

`List<T>`, genellikle boyutu değişken olan bir dizi olarak düşünülebilir. İçerisindeki elemanların sıralı bir şekilde tutulmasını sağlar ve eleman ekleme, çıkarma, arama gibi işlemleri oldukça verimli bir şekilde gerçekleştirir.

### `List<T>` Tanımlama Örnekleri

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Boş bir List<T> oluşturma
        List<int> numbers = new List<int>();

        // Başlangıç elemanları ile List<T> oluşturma
        List<string> fruits = new List<string> { "Elma", "Muz", "Çilek" };

        // Başka bir koleksiyondan List<T> oluşturma
        int[] initialNumbers = { 1, 2, 3, 4, 5 };
        List<int> numberList = new List<int>(initialNumbers);
    }
}


```

### `List<T>` Kullanım Örnekleri

### Eleman Ekleme

```csharp
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

// Aynı anda birden fazla eleman ekleme
numbers.AddRange(new int[] { 4, 5, 6 });


```

### Eleman Erişimi

```csharp
List<string> fruits = new List<string> { "Elma", "Muz", "Çilek" };

string firstFruit = fruits[0]; // "Elma"
string secondFruit = fruits[1]; // "Muz"


```

### Eleman Güncelleme

```csharp
List<string> fruits = new List<string> { "Elma", "Muz", "Çilek" };

fruits[1] = "Kivi"; // "Muz" yerine "Kivi" eklenir


```

### Eleman Silme

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

numbers.Remove(3); // Değer 3 olan elemanı siler
numbers.RemoveAt(0); // İlk elemanı (1) siler
numbers.RemoveRange(1, 2); // İkinci ve üçüncü elemanları siler


```

### Elemanları Listeleme

```csharp
List<string> fruits = new List<string> { "Elma", "Muz", "Çilek" };

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}


```

### `List<T>`'in Kullanım Nedenleri

-   **Dinamik Boyut:** `List<T>`, boyutu dinamik olarak değişebilen bir veri yapısıdır. Eleman ekledikçe veya çıkardıkça otomatik olarak genişler veya daralır.
-   **Performans:** `List<T>`, ekleme, çıkarma ve erişim işlemlerinde oldukça performanslıdır.
-   **Tip Güvenliği:** `List<T>`, belirli bir türdeki elemanları tutar, bu da derleme zamanında tip kontrolü sağlar ve tip hatalarını önler.
-   **Zengin Metot ve Özellikler:** `List<T>`, eleman ekleme, çıkarma, arama, sıralama gibi birçok yerleşik metot ve özellik sunar.

### `List<T>` ve Benzer Veri Yapıları

### `List<T>` vs `Array`

-   **Boyut:** Dizilerin boyutu sabittir ve oluşturulduktan sonra değiştirilemezken, `List<T>` dinamik olarak boyut değiştirebilir.
-   **Performans:** Dizi elemanlarına erişim genellikle `List<T>`'den daha hızlıdır, çünkü diziler doğrudan hafıza adreslerine erişir.
-   **Kullanım Kolaylığı:** `List<T>`, eleman ekleme ve çıkarma işlemlerinde daha fazla esneklik sağlar ve kullanımı daha kolaydır.

### `List<T>` vs `LinkedList<T>`

-   **Erişim Süresi:** `List<T>`, belirli bir indeksdeki elemanlara erişim için `O(1)` zaman karmaşıklığına sahipken, `LinkedList<T>` `O(n)` zaman karmaşıklığına sahiptir.
-   **Ekleme ve Çıkarma:** `LinkedList<T>`, listenin başına veya ortasına eleman ekleme ve çıkarma işlemlerinde `List<T>`'den daha etkilidir (çünkü `List<T>`'de bu işlemler kaydırma gerektirir).

### `List<T>` vs `ArrayList`

-   **Tip Güvenliği:** `ArrayList`, `object` türünde elemanlar tutar ve tip güvenliği sağlamazken, `List<T>` belirli bir türdeki elemanları tutar ve tip güvenliği sağlar.
-   **Performans:** `List<T>`, `ArrayList`'ten daha performanslıdır çünkü boxing/unboxing işlemlerinden kaçınır.

### Kapsamlı Bir `List<T>` Örneği

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> students = new List<string> { "Ahmet", "Mehmet", "Ayşe", "Fatma" };

        // Yeni öğrenciler ekle
        students.Add("Ali");
        students.AddRange(new string[] { "Veli", "Zeynep" });

        // Öğrenci listesini yazdır
        Console.WriteLine("Öğrenciler:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // Belirli bir indeksten öğrenciyi sil
        students.RemoveAt(2); // "Ayşe"yi siler

        // Öğrenci listesini güncelle
        students[0] = "Ahmet Yılmaz";

        // Öğrencilerden birini ara
        int index = students.IndexOf("Fatma");

        Console.WriteLine("\\\\nFatma'nın İndeksi: " + index);

        // Öğrenci listesini tekrar yazdır
        Console.WriteLine("\\\\nGüncellenmiş Öğrenci Listesi:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}


```

## Stack

C#'da `Stack<T>` veri yapısı, LIFO (Last In, First Out) prensibine göre çalışan bir koleksiyondur. Bu veri yapısında, en son eklenen eleman en önce çıkarılır. `Stack<T>`, `System.Collections.Generic` namespace'i altında bulunur ve belirli bir türdeki elemanları saklayabilir.

### `Stack<T>` Nedir?

`Stack<T>`, son giren ilk çıkar (LIFO) mantığıyla çalışan bir veri yapısıdır. Bir yığın düşüncesiyle çalışır; yani en üstteki eleman ilk olarak çıkarılır.

### `Stack<T>` Tanımlama Örnekleri

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Boş bir Stack<T> oluşturma
        Stack<int> numbers = new Stack<int>();

        // Başlangıç elemanları ile Stack<T> oluşturma
        Stack<string> books = new Stack<string>(new string[] { "Kitap 1", "Kitap 2", "Kitap 3" });
    }
}


```

### `Stack<T>` Kullanım Örnekleri

### Eleman Ekleme

```csharp
Stack<int> numbers = new Stack<int>();
numbers.Push(1);
numbers.Push(2);
numbers.Push(3);


```

### Eleman Çıkarma

```csharp
int top = numbers.Pop(); // 3'ü çıkarır ve döner
int nextTop = numbers.Pop(); // 2'yi çıkarır ve döner


```

### Zirvedeki Elemanı Görüntüleme

```csharp
int top = numbers.Peek(); // Zirvedeki eleman olan 1'i döner fakat çıkarmaz


```

### Eleman Sayısı

```csharp
int count = numbers.Count; // Stack'teki eleman sayısını döner


```

### Elemanları Listeleme

```csharp
Stack<string> books = new Stack<string>(new string[] { "Kitap 1", "Kitap 2", "Kitap 3" });

foreach (string book in books)
{
    Console.WriteLine(book);
}


```

### `Stack<T>` Kullanım Nedenleri

-   **Basitlik:** `Stack<T>`, belirli bir sıralama gereksinimi olmayan, sadece en son eklenen elemanı önce çıkarmak isteyen durumlar için basit ve etkili bir çözümdür.
-   **Fonksiyon Çağrıları:** Fonksiyon çağrılarını takip etmek, geri izleme işlemleri veya derinlik öncelikli arama algoritmaları gibi durumlarda kullanılabilir.
-   **Geri Alma İşlemleri:** Kullanıcı tarafından yapılan işlemleri geri almak veya tekrarlamak için ideal bir yapıdır.
-   **Geçici Depolama:** Geçici olarak veri saklamak ve işlemek için kullanılır.

### `Stack<T>` ve Benzer Veri Yapıları

### `Stack<T>` vs `Queue<T>`

-   **Erişim Düzeni:** `Stack<T>`, LIFO (Last In, First Out) mantığıyla çalışırken `Queue<T>`, FIFO (First In, First Out) mantığıyla çalışır.
-   **Kullanım Senaryoları:** `Stack<T>`, geri alma işlemleri veya fonksiyon çağrıları için kullanılırken, `Queue<T>` sıra tabanlı işlemler (örneğin, iş kuyruğu) için kullanılır.

### `Stack<T>` vs `LinkedList<T>`

-   **Performans:** `Stack<T>`, belirli bir amaç için optimize edilmiştir ve LIFO mantığıyla çalışır. `LinkedList<T>` ise daha genel amaçlıdır ve hem LIFO hem de FIFO işlemleri destekleyebilir.
-   **Kullanım Kolaylığı:** `Stack<T>`, basit LIFO işlemleri için daha kolay bir arayüz sunar.

### Kapsamlı Bir `Stack<T>` Örneği

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> browserHistory = new Stack<string>();

        // Yeni sayfalar ziyaret ediliyor
        browserHistory.Push("Anasayfa");
        browserHistory.Push("Haberler");
        browserHistory.Push("Teknoloji");

        Console.WriteLine("Geçmiş:");

        // Geçmişi yazdırma
        foreach (string page in browserHistory)
        {
            Console.WriteLine(page);
        }

        // Bir sayfa geri gitme
        string lastVisitedPage = browserHistory.Pop();
        Console.WriteLine($"\\\\nSon ziyaret edilen sayfa: {lastVisitedPage}");

        // Mevcut sayfayı görüntüleme
        string currentPage = browserHistory.Peek();
        Console.WriteLine($"Mevcut sayfa: {currentPage}");

        Console.WriteLine("\\\\nGüncellenmiş Geçmiş:");
        foreach (string page in browserHistory)
        {
            Console.WriteLine(page);
        }
    }
}


```

### Stack Kullanım Senaryoları

-   **Geri Alma (Undo) İşlemleri:** Kullanıcıların yaptıkları işlemleri geri alma veya eski duruma döndürme işlemlerinde stack sıklıkla kullanılır. Örneğin, metin düzenleyicilerinde geri alma işlevi stack kullanılarak yönetilir.
-   **Derinlik Öncelikli Arama (Depth-First Search, DFS):** Grafik ve ağaç yapılarında gezinme işlemlerinde stack sıklıkla kullanılır. DFS algoritması stack kullanılarak derinlik öncelikli olarak uygulanır.

### Stack ve Recursive Fonksiyonlar

-   Recursive (Özyinelemeli) fonksiyonlar, her çağrıldıklarında bir çağrı yığını (call stack) oluştururlar. Bu yığın, fonksiyonların çağrılma sırasını ve iç içe geçmiş çağrıları tutar. Örneğin, faktöriyel hesaplama veya fibonacci sayıları gibi rekürsif algoritmalar, stack kullanılarak işlenir.

### Exception Handling ve Stack

-   Exception handling süreçlerinde (hata işleme) stack, hata anında programın hangi noktada olduğunu ve hangi fonksiyonların çağrıldığını izlemek için kullanılır. Stack trace olarak bilinen bu bilgiler, hataların nedenini belirlemede ve giderilmesinde önemli rol oynar.

### Array ve LinkedList İmplementasyonu

-   **Array İmplementasyonu:** Stack, genellikle dinamik boyut gerektirmeyen ve sabit bellek kullanımı sağlamak için array (dizi) veri yapısıyla implemente edilir. Array kullanımı, eleman ekleme ve çıkarma işlemlerinde sabit zaman karmaşıklığı (O(1)) sağlar.
-   **LinkedList İmplementasyonu:** Bazı durumlarda, dinamik boyut gereksinimi olan ve esnek bellek kullanımı sağlayan linked list yapıları stack implementasyonunda tercih edilebilir. Linked list kullanımı, özellikle eleman ekleme ve çıkarma işlemlerinde daha esnek bir yapı sunar.

## Queue

Queue, verilerin FIFO (First In, First Out - İlk giren, ilk çıkan) prensibine göre işlendiği bir veri yapısıdır. Bu yapıda, ilk eklenen eleman ilk çıkarılır. C# programlama dilinde `Queue<T>` sınıfı, System.Collections.Generic namespace'i altında sağlanır. İşte Queue yapısının daha detaylı açıklaması:

### 1. Tanımlama Örnekleri

### Temel Tanımlama

```csharp
Queue<int> queue = new Queue<int>();


```

### Başlangıçta Elemanlarla İnitiliaze Etme

```csharp
Queue<string> names = new Queue<string>(new string[] { "Alice", "Bob", "Charlie" });


```

### 2. Kullanım Örnekleri

### Eleman Ekleme (Enqueue)

```csharp
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);


```

### Eleman Çıkarma (Dequeue)

```csharp
int dequeuedItem = queue.Dequeue(); // dequeuedItem = 10


```

### İlk Elemana Bakma (Peek)

```csharp
int firstItem = queue.Peek(); // firstItem = 20 (çıkarılmadan)


```

### 3. Neden Kullanılır?

-   **Sıralı İşlemler:** Queue, işlemleri sıraya almak ve sırayla işlemek için idealdir. Örneğin, bir iş parçacığı havuzunda (thread pool) bekleyen işlemleri yönetmek için kullanılabilir.
-   **Bekleme Kuyrukları:** Birçok senaryoda, gelen talepleri sıraya almak ve ilk gelenin ilk hizmet vermesini sağlamak için kullanılır. Örneğin, işlemci sırası bekleyen müşteri çağrıları gibi.
-   **Algoritma Uygulamaları:** BFS (Breadth-First Search) gibi algoritmalarda genişleme sırasını takip etmek için kullanılabilir.

### 4. Diğer Veri Yapılarıyla Farkları

-   **Stack (Yığın) ile Farkı:** Stack veri yapısında elemanlar LIFO (Last In, First Out) prensibiyle işlenirken, Queue'da FIFO prensibi geçerlidir.
-   **LinkedList ile Farkı:** Queue genellikle sadece başa veya sona ekleme ve çıkarma işlemlerinde etkilidir. LinkedList ise herhangi bir konuma ekleme veya silme işlemleri için daha uygun bir seçenek olabilir.

### 5. Özel Durumlar ve Ek Detaylar

-   **ConcurrentQueue:** Eşzamansız (thread-safe) işlemler için .NET Framework ve .NET Core'da `ConcurrentQueue` sınıfı sağlanır. Birden fazla iş parçacığı tarafından güvenli bir şekilde erişilebilir.
-   **PriorityQueue:** C# standard kütüphanesinde PriorityQueue doğrudan bulunmamaktadır. Ancak öncelikli işlemler gerektiren durumlar için, ekstra kodlama ile Queue yapısı öncelikli kuyruk olarak kullanılabilir.

### Queue<T> Kapsamlı Örnek

```csharp
csharpKodu kopyala
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Bir Queue oluşturma
        Queue<string> queue = new Queue<string>();

        // Queue'ye eleman ekleme
        queue.Enqueue("Öğrenci 1");
        queue.Enqueue("Öğrenci 2");
        queue.Enqueue("Öğrenci 3");

        // Queue'den eleman çıkarma ve yazdırma
        while (queue.Count > 0)
        {
            string student = queue.Dequeue();
            Console.WriteLine("Öğrenci çıkarıldı: " + student);
        }
    }
}


```

## LinkedList

LinkedList, verilerin çift yönlü bağlı listeler şeklinde organize edildiği bir veri yapısıdır. C# programlama dilinde `LinkedList<T>` sınıfı, System.Collections.Generic namespace'i altında sağlanır. İşte LinkedList yapısının detaylı açıklaması:

### 1. Tanımlama Örnekleri

### Boş Bir LinkedList Oluşturma

```csharp
LinkedList<int> linkedList = new LinkedList<int>();


```

### Başlangıçta Elemanlarla İnitiliaze Etme

```csharp
LinkedList<string> names = new LinkedList<string>(new string[] { "Alice", "Bob", "Charlie" });


```

### 2. Kullanım Örnekleri

### Eleman Ekleme

```csharp
linkedList.AddLast(10); // Listenin sonuna eleman ekleme
linkedList.AddFirst(5); // Listenin başına eleman ekleme


```

### Eleman Çıkarma

```csharp
linkedList.Remove(10); // Değerine göre eleman çıkarma
linkedList.RemoveFirst(); // Listenin başındaki elemanı çıkarma
linkedList.RemoveLast(); // Listenin sonundaki elemanı çıkarma


```

### İterasyon (Döngü ile Gezinme)

```csharp
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}


```

### 3. Neden Kullanılır?

-   **Esnek Boyutlama:** LinkedList, elemanların bellekte rastgele yerleştirildiği ve elemanların dinamik olarak eklenebildiği veya çıkarılabildiği bir veri yapısıdır. Bu özelliği sayesinde, koleksiyon boyutunun dinamik olarak büyümesine veya küçülmesine izin verir.
-   **Performans:** Belirli durumlarda, özellikle listenin ortasından veya sonundan eleman ekleme ve çıkarma işlemlerinde, LinkedList bazı durumlarda daha iyi performans gösterebilir. Çünkü bu işlemler bağlı listelerde daha hızlı gerçekleştirilebilir.

### 4. Diğer Veri Yapılarıyla Farkları

-   **ArrayList ile Farkı:** ArrayList, elemanların ardışık bellek bölgesinde depolandığı bir dizi yapısıdır. LinkedList ise elemanlar bağlantılı düğümler halinde depolanır. Bu nedenle, ArrayList eleman erişimi ve dizinleme için daha hızlı olabilirken, LinkedList ekleme ve çıkarma işlemleri için daha avantajlı olabilir.
-   **Queue ve Stack ile Farkı:** Queue ve Stack veri yapıları sırasıyla FIFO (First In, First Out) ve LIFO (Last In, First Out) prensiplerine göre çalışırken, LinkedList daha genel amaçlı bir veri yapısıdır ve elemanların sırası önemlidir.

### 5. Özel Durumlar ve Ek Detaylar

-   **DoublyLinkedList:** `LinkedList<T>` sınıfı C# standard kütüphanesinde çift yönlü bağlı listeleri temsil eder. Her düğümün hem bir önceki hem de bir sonraki düğümü işaret ettiği çift yönlü bağlı listelerdir.
-   **Performans:** LinkedList'in performans avantajı, eleman ekleme ve çıkarma işlemleri sırasında ortaya çıkar. Ancak eleman erişimi (indeksleme) ArrayList gibi dizilere göre daha yavaş olabilir.

### LinkedList<T> Kapsamlı Örnek

```csharp
csharpKodu kopyala
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Bir LinkedList oluşturma
        LinkedList<string> linkedList = new LinkedList<string>();

        // LinkedList'e eleman ekleme
        linkedList.AddLast("Öğrenci 1");
        linkedList.AddLast("Öğrenci 2");
        linkedList.AddLast("Öğrenci 3");

        // Bir elemanı araya ekleme
        LinkedListNode<string> node = linkedList.Find("Öğrenci 2");
        linkedList.AddAfter(node, "Yeni Öğrenci");

        // LinkedList üzerinde döngü ve yazdırma
        foreach (string student in linkedList)
        {
            Console.WriteLine("Öğrenci: " + student);
        }
    }
}


```

## Dictionary

Dictionary, anahtar-değer çiftlerini depolayan ve hızlı erişim sağlayan bir koleksiyon yapısıdır. C# programlama dilinde `Dictionary<TKey, TValue>` sınıfı olarak sunulur ve System.Collections.Generic namespace'i altında bulunur. İşte Dictionary yapısının detaylı açıklaması:

### 1. Tanımlama Örnekleri

### Boş Bir Dictionary Oluşturma

```csharp
Dictionary<string, int> ages = new Dictionary<string, int>();


```

### Başlangıçta Elemanlarla İnitiliaze Etme

```csharp
Dictionary<string, string> capitals = new Dictionary<string, string>()
{
    { "Turkey", "Ankara" },
    { "France", "Paris" },
    { "UK", "London" }
};


```

### 2. Kullanım Örnekleri

### Eleman Ekleme ve Güncelleme

```csharp
ages["Alice"] = 30; // Anahtar "Alice" ile değer ekleme veya güncelleme
ages["Bob"] = 25;
ages["Charlie"] = 40;


```

### Eleman Silme

```csharp
ages.Remove("Bob"); // Anahtara göre eleman silme


```

### Değer Erişimi

```csharp
int charliesAge = ages["Charlie"]; // Anahtar üzerinden değere erişim


```

### Anahtarların ve Değerlerin Gezinilmesi

```csharp
foreach (var country in capitals.Keys)
{
    Console.WriteLine($"Capital of {country} is {capitals[country]}");
}

```

### 3. Neden Kullanılır?

-   **Hızlı Erişim:** Anahtarlar üzerinden hızlı erişim sağlar. Anahtar-değer çiftleri, hash tablosu gibi bir yapıda yönetilir, bu da arama ve erişim işlemlerinin genellikle O(1) karmaşıklığında olmasını sağlar.
-   **Veri Yapısı İle Uyumluluk:** Veri yapılarından biri olarak, anahtar-değer çiftleriyle ilişkili verileri gruplamak ve organize etmek için kullanılır.

### 4. Diğer Veri Yapılarıyla Farkları

-   **Hashtable ile Farkı:** Dictionary, hashtable'ın generic bir versiyonudur ve genellikle daha tip güvenli ve kullanımı kolaydır. Hashtable'da anahtarlar ve değerler object türünde saklanırken, Dictionary'de tür güvenliği sağlayan generic yapı kullanılır.
-   **List, Stack, ve Queue ile Farkı:** List, Stack, ve Queue sırasıyla dinamik bir dizi, LIFO (Last In, First Out) ve FIFO (First In, First Out) prensiplerine göre çalışan veri yapılarıdır. Dictionary ise anahtar-değer çiftleri için özel olarak optimize edilmiş bir yapıdır ve arama, ekleme ve çıkarma işlemlerinde farklı bir performans profili sunar.

### 5. Özel Durumlar ve Ek Detaylar

-   **Performance ve İşlem Karmaşıklığı:** Dictionary, anahtarların hash değerlerine dayalı olarak organize edildiği için arama, ekleme ve çıkarma işlemlerinde genellikle O(1) zaman karmaşıklığına sahiptir. Ancak, bu performans genellikle yüksek doluluk oranlarına sahipse azalabilir.
-   **Null Anahtarlar ve Değerler:** Dictionary'de anahtarlar null olamaz, ancak değerler null olabilir.
-   **ValueCollection ve KeyCollection:** Dictionary sınıfı, değerlerin ve anahtarların koleksiyonlarını (ValueCollection ve KeyCollection) sağlar, bu koleksiyonlar üzerinde işlemler yapılabilir.

### Dictionary<TKey, TValue> Kapsamlı Örnek

```csharp
csharpKodu kopyala
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Bir Dictionary oluşturma
        Dictionary<string, string> capitals = new Dictionary<string, string>();

        // Dictionary'ye eleman ekleme
        capitals["Turkey"] = "Ankara";
        capitals["France"] = "Paris";
        capitals["Germany"] = "Berlin";

        // Dictionary üzerinde döngü ve yazdırma
        foreach (KeyValuePair<string, string> kvp in capitals)
        {
            Console.WriteLine("Ülke: " + kvp.Key + ", Başkent: " + kvp.Value);
        }

        // Bir değeri güncelleme
        capitals["Turkey"] = "İstanbul";

        // Bir değeri silme
        capitals.Remove("France");

        // Dictionary'den bir değeri arama
        if (capitals.ContainsKey("Germany"))
        {
            string capital = capitals["Germany"];
            Console.WriteLine("\\nAlmanya'nın Başkenti: " + capital);
        }
    }
}


```

## SortedDictionary

SortedList, anahtar-değer çiftlerini sıralı bir şekilde saklayan bir koleksiyon yapısıdır. Her anahtarın tek bir değeri vardır ve anahtarlar sıralı bir şekilde tutulur.

### SortedList Yapısının Açıklanması

**1. Tanımlama Örnekleri:**

```csharp
// SortedList tanımlama ve ilk değerlerle başlatma
SortedList<int, string> sortedList = new SortedList<int, string>();
sortedList.Add(3, "Üç");
sortedList.Add(1, "Bir");
sortedList.Add(2, "İki");


```

**2. Kullanım Örnekleri:**

-   Anahtarlarla değerlere erişim:
    
    ```csharp
    Console.WriteLine(sortedList[1]); // "Bir" çıktısını verir
    
    
    ```
    
-   Anahtar-değer ekleme:
    
    ```csharp
    sortedList.Add(4, "Dört");
    
    
    ```
    
-   Değer güncelleme:
    
    ```csharp
    sortedList[2] = "Two";
    
    
    ```
    
-   Anahtarları ve değerleri döngü ile işleme:
    
    ```csharp
    foreach (var key in sortedList.Keys)
    {
        Console.WriteLine($"Anahtar: {key}, Değer: {sortedList[key]}");
    }
    
    
    ```
    

**3. Neden Kullanılır?**

SortedList, anahtarların sıralı bir şekilde tutulmasını sağlar ve bu nedenle anahtarlar arası arama işlemleri hızlıdır. Özellikle sıralı erişim gerektiren durumlarda tercih edilir.

**4. Benzer Diğer Veri Yapılarıyla Farkları:**

-   **Dictionary:** Dictionary, anahtarlar arasında sıralama yapmaz ve sıralı erişim sağlamaz. Ancak, anahtar bazında hızlı erişim sunar.
-   **List:** Liste sıralı değilken, SortedList sıralı bir yapıdır. Listeler genelde sıralı erişim veya sıralama gerektirmeyen durumlar için kullanılır.

### Kapsamlı Örnek: Telefon Rehberi Uygulaması

Aşağıda, bir telefon rehberi uygulaması için SortedList kullanımını gösteren kapsamlı bir örnek verilmiştir:

```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList<string, string> phoneBook = new SortedList<string, string>();

        // Telefon rehberine kişi ekleme
        phoneBook.Add("Ali", "555-1234");
        phoneBook.Add("Veli", "555-5678");
        phoneBook.Add("Zeynep", "555-2468");

        // Kişileri listeleme
        Console.WriteLine("Telefon Rehberi:");
        foreach (var person in phoneBook)
        {
            Console.WriteLine($"İsim: {person.Key}, Telefon: {person.Value}");
        }

        // Yeni kişi ekleme
        phoneBook.Add("Ahmet", "555-7890");

        // Kişileri tekrar listeleme
        Console.WriteLine("\\\\nYeni Telefon Rehberi:");
        foreach (var person in phoneBook)
        {
            Console.WriteLine($"İsim: {person.Key}, Telefon: {person.Value}");
        }

        // Belirli bir kişiyi güncelleme
        phoneBook["Ali"] = "555-4321";

        // Güncellenmiş kişileri listeleme
        Console.WriteLine("\\\\nGüncellenmiş Telefon Rehberi:");
        foreach (var person in phoneBook)
        {
            Console.WriteLine($"İsim: {person.Key}, Telefon: {person.Value}");
        }
    }
}


```

## SortedSet

SortedSet, benzersiz öğeleri sıralı bir şekilde tutan bir koleksiyon yapısıdır. Bu yapının en büyük özelliği, içindeki öğelerin sıralı bir şekilde tutulması ve her öğenin sadece bir kez bulunabilmesidir.

### SortedSet Yapısının Açıklanması

**1. Tanımlama Örnekleri:**

```csharp
// SortedSet tanımlama
SortedSet<int> numbers = new SortedSet<int>();

// İlk değerlerle başlatma
SortedSet<string> names = new SortedSet<string>(new string[] { "Alice", "Bob", "Charlie" });


```

**2. Kullanım Örnekleri:**

-   Öğe ekleme:
    
    ```csharp
    numbers.Add(5);
    numbers.Add(3);
    numbers.Add(8);
    
    
    ```
    
-   Öğe silme:
    
    ```csharp
    numbers.Remove(3);
    
    
    ```
    
-   Öğe varlığını kontrol etme:
    
    ```csharp
    if (numbers.Contains(8))
    {
        Console.WriteLine("Listede 8 var.");
    }
    
    
    ```
    
-   Sıralı öğeleri döngü ile işleme:
    
    ```csharp
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
    }
    
    
    ```
    

**3. Neden Kullanılır?**

SortedSet, öğelerin sıralı bir şekilde tutulmasını sağlar ve her öğenin yalnızca bir kez bulunabileceği garantisini verir. Bu özellikle sıralama gerektiren durumlarda ve benzersiz öğelerin tutulmasında kullanılır.

**4. Benzer Diğer Veri Yapılarıyla Farkları:**

-   **HashSet:** HashSet de benzersiz öğeleri tutar ancak sıralı bir yapı sunmaz. SortedSet ise öğeleri sıralı tutar.
-   **List:** List sıralı değilken, SortedSet sıralı bir yapıdır ve benzersiz öğeler içerir.

### Kapsamlı Örnek: Puan Takip Uygulaması

Aşağıda, bir puan takip uygulaması için SortedSet kullanımını gösteren kapsamlı bir örnek verilmiştir:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedSet<int> highScores = new SortedSet<int>();

        // Yüksek skorları ekleyelim
        highScores.Add(450);
        highScores.Add(670);
        highScores.Add(300);
        highScores.Add(800);
        highScores.Add(550);

        // En yüksek skoru bulalım
        int highestScore = highScores.Max;
        Console.WriteLine($"En yüksek skor: {highestScore}");

        // En düşük skoru bulalım ve silelim
        int lowestScore = highScores.Min;
        highScores.Remove(lowestScore);
        Console.WriteLine($"En düşük skor: {lowestScore}");

        // Sıralı skorları listeleme
        Console.WriteLine("\\\\nSıralı Skorlar:");
        foreach (var score in highScores)
        {
            Console.WriteLine(score);
        }
    }
}
```
