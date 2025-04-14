namespace Zdarzenia
{
    internal class Program
    {
        //definicja delegata
        public delegate void MessageHandler(string message);

        //klasa wykonawcy

        public class Publisher
        {
            //delkaracja zdarzenia 
            public event MessageHandler MessageEvent;

            //metoda która wywołuje zdarzenie
            public void SendMessage(string message)
            {
                //sprawdzanie czy metoda ma subskrybenta
                if (MessageEvent != null)
                {
                    //wywołanie zdarzenia
                    MessageEvent(message);
                }
            }
        }

        public class Subscriber
        {
            //metoda obsługi zdarzenia
            public void OnMessageRecived(string message)
            {
                Console.WriteLine($"Otrzymałeś wiadomość: {message}");
            }
        }

        static void Main(string[] args)
        {
            //utworzenie obiektów wydawcy i subskrybenta
            Publisher pub = new Publisher();
            Subscriber sub = new Subscriber();

            //subskrypcja zdarzenia
            pub.MessageEvent += sub.OnMessageRecived;
            pub.SendMessage("Pierwsza wiadomość");
            pub.SendMessage("Druga wiadomość");
            pub.SendMessage("Trzecia wiadomość");

            //anulowanie subskrypcji zdartzenia
            pub.MessageEvent -= sub.OnMessageRecived;
            pub.SendMessage("Czwarta wiadomość");

            pub.MessageEvent += sub.OnMessageRecived;
            pub.SendMessage("Piąta wiadomość");

            Console.ReadKey();

        }
    }
}
/*
 * Zdefiniuj delegat MessageHandler, który przyjmuje string i zwraca void.
o Zdefiniuj klasę a z polem MessageEvent typu MessageHandler,
zadeklarowanym jako event.
o Zdefiniuj metodę SendMessage w klasie Publisher, która przyjmuje string i zwraca
void. Metoda ta ma wywoływać zdarzenie MessageEvent, jeśli ma subskrybentów.
*/

/*
 * Zdefiniuj klasę Subscriber z metodą OnMessageReceived, która przyjmuje string i
zwraca void. Metoda ta ma wypisywać na konsolę wiadomość otrzymaną od
wydawcy.
o Zdefiniuj klasę Program z metodą Main, która jest punktem wejścia programu.
o W metodzie Main utwórz obiekty klasy Publisher i klasy Subscriber.
o Zasubskrybuj zdarzenie MessageEvent za pomocą metody OnMessageReceived.
o Wywołaj metodę SendMessage kilka razy z różnymi parametrami i sprawdź, czy
subskrybent otrzymuje wiadomości.
o Anuluj subskrypcję zdarzenia i wywołaj metodę SendMessage ponownie. Sprawdź,
czy subskrybent nadal otrzymuje wiadomości
*/