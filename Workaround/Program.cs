using System;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //SelamVer("salih");
            //SelamVer("Melek");
            //SelamVer("Engin");
            //SelamVer();

            //Topla(5,7);
            //Topla();


            Person person1 = new Person();
            person1.FirstName = "Salih";
            person1.LastName = "Gül";
            person1.NationalIdentity = 123;
            person1.DateOfBirthYear = 2000;

            Person person2 = new Person();
            person2.FirstName = "Derya";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadKey();
        }
        //static void SelamVer(string isim="İsimsiz")
        //{
        //    Console.WriteLine("Merhaba "+ isim);
        //}
        //static int Topla(int s1=1, int s2=3)
        //{
        //    int sonuc = s1 + s2;
        //    Console.WriteLine("Toplam: " + sonuc.ToString());
        //    return sonuc;
        //}
    }
}
