using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobch telephone1 = new Mobch();
            telephone1.call();
            telephone1.getCall();

            Console.WriteLine("----------");
            Knop Knoptelephone1 = new Knop();
            Knoptelephone1.getCall();

            Console.WriteLine("-----------");
            Mobch chornotelephone1 = new Mobch();
            chornotelephone1.sendsms();
            chornotelephone1.getsms();

            Console.WriteLine("----------");
            Mobkol kolortelephone1 = new Mobkol();
            kolortelephone1.sendmms();
            kolortelephone1.getmms();
            kolortelephone1.call(false);

            Console.WriteLine("---------");
            smartfon smartphone1 = new smartfon();
            smartphone1.Photo(1);
            smartphone1.Video(2);

            Console.ReadKey();

        }
    }
}
