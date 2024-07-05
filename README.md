
# Data Structures and Algorithms
- [Bit](#bit)
- [Byte](#byte)
- [İkilik sayıyı(binary) ondalık sayıya(decimal) çevirme](#ondalık-sayıyıdecimal-ikilik-sayıyabinary-çevirme)
- [Ondalık sayıyı(decimal) ikilik sayıya(binary) çevirme](#ondalık-sayıyıdecimal-ikilik-sayıyabinary-çevirme)
- [Struct](#struct)
- [Class ve Struct Farkı](#class-ve-struct-farkı)
- [Hashtable ve Dictionary](#hashtable-ve-dictionary)
- [Boxing / Unboxing](#boxing--unboxing)

## Bit

Bit, dijital bilgisayar sistemlerinde en küçük veri birimidir ve "binary digit" (ikili rakam) teriminin kısaltmasıdır. Bit, yalnızca iki değerden birini alabilir: 0 veya 1. Bu iki durum...


## Bit

Bit, dijital bilgisayar sistemlerinde en küçük veri birimidir ve "binary digit" (ikili rakam) teriminin kısaltmasıdır. Bit, yalnızca iki değerden birini alabilir: 0 veya 1. Bu iki durum, elektronik cihazlarda açık (1) veya kapalı (0) gibi durumları temsil eder ve bilgisayarların veri işleme ve saklama işlevlerinde temel bir rol oynar.

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

**C#'ta `struct` Yapısı**

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
---
