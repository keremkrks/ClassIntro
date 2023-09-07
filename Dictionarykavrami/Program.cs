using System;

namespace Dictionarykavrami
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string,int> AdYas = new Dictionary<string,int>();
            AdYas.Add("Amy", 25);
            AdYas.Add("Mehmet", 17);
            AdYas.Add("Birisi", 30);

            foreach(var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
           //
           //,deger sayma özelligi vardir
            var eleman = AdYas.Count();

            Console.WriteLine("eleman sayısı:" + eleman);

            //silme işlemi vardır

            AdYas.Remove("Birisi");
            Console.WriteLine();
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
        }
    }
}
