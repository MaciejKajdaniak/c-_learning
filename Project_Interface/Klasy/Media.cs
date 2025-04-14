using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_9_Interface.Klasy 
{
    internal abstract class Media 
    {
        public virtual void Stop() 
        {
            Console.WriteLine("Klasa Media - metoda STOP");
        }

        public virtual void Pause() {
            Console.WriteLine("Klasa Media - metoda PAUSE");
        }

        public virtual void Play() {
            Console.WriteLine("Klasa Media - metoda PLAY");
        }
    }
}
