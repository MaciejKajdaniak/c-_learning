using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_9_Interface.Klasy {
    internal class Music : Media
    {
        public override void Stop() 
        {
            Console.WriteLine("Klasa Music - metoda STOP");
        }
        public override void Pause() {
            Console.WriteLine("Klasa Music - metoda PAUSE");
        }

        public override void Play() {
            Console.WriteLine("Klasa Music - metoda PLAY");
        }
    }
}
