using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_9_Interface.Klasy {
    internal class Film : Media
    {
        public override void Stop() 
        {
            Console.WriteLine("Klasa Film - metoda STOP");
        }
        public override void Pause() {
            Console.WriteLine("Klasa Film - metoda PAUSE");
        }

        public override void Play() {
            Console.WriteLine("Klasa Film - metoda PLAY");
        }
    }
}
