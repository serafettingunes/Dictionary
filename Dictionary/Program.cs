using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string, string> myDictionary = new Dictionary.MyDictionary<int, string,string>();
            myDictionary.Ekle(1, "Şerafettin","Güneş");
            
        }
    }
    class MyDictionary <T1,T2,T3>
    {
        public void Ekle(T1 item,T2 item2, T3 item3)
        {
            Console.WriteLine(item+" "+item2+" "+item3);
        }
    }
}
