using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12_DizeDegismezleriVeSabitTanimlama
{
    class VarDegiskeniKullanimi
    {
        static void Main(string[] args)
        {
            /*
        ASCII: 7bitlik bir kodlama sistemidir.Bilgisayarlarda herşey ikilik sayı sistemine göre çalışır.
        ikilikl sayı sistemi 1 veya 0 olma durumudur.7 bit kavramı 2 üzeri 7 ifadesiyle 128e denk geliyor.
        Yani 128 ifade bu yapı içinde kodlanabilir.
        128 ifade neleri kapsar. küçük a'dan küçük z'ye, büyük a'dan büyük z2ye. 
        0dan 9da kadar olan rakamlar,simgeler,boşluk yani space, özel karakterler olabilir.
        Bit ifadesi bilgisayar dilinde en küçük birimdir.8 bit ifadesi 1 byte'a eşittir.
        1024 byte yan yana geldiğinde ise i kilobayt olur.
        1024 kilobayt 1 megabayt, 1024 megabayt ise 1 gigabyte'tır. dolyasıyla herşey bitten oluşıur.
        */
            //string ifade = Console.ReadLine();//ifade eklenir.
            //eşitliğin her iki tarafıda aynı türden veri kapsamalıdır. bunu öğrenmek için fonskyion
            //üzerine gelindiğinde bir metin kutusu açılıyor.oradan detaylar okunabilir.
            //Console.ReadKey();

        var ifade = "Gizem";
            Console.WriteLine(ifade);
            Console.ReadLine();
            
        //ifade eklenir.
        //örtülü değişken var ifadesi ile gösterilir. type'e çalıştığında
        //karar vermek için kullanılır.
            
            Console.ReadKey();
        //eğer 28. satırda console.readline yerine readkey kullanırsak hata alırız.
        //bunun sebebi readkey consoleKeyInfo type'dandır. bu nedenle type farkı olur ve hata alırız.
        //EŞİTLİĞİN İKİ TARAFINDA AYNI TÜR VERİ OLMASI GEREKTİĞİNDEN READKEY KULLANILDIĞINDA ONA UYGUN
        //TYPE KULLANILMALI. VAR VEYA ConsoleKeyInfo kullanılmalı.        
        }
    }
}
