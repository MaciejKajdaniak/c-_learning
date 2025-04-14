using Project_9_Interface.Klasy;

namespace Project_9_Interface 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            Media media = new Media();
            //media.Stop();

            Film film = new Film();
            //film.Stop();

            Media[] tabMedia = new Media[4];

            tabMedia[0] = new Media();
            tabMedia[0].Play();

            tabMedia[1] = new Film();
            tabMedia[1].Play();

            tabMedia[2] = new Music();
            tabMedia[2].Play();
            Console.WriteLine();

            tabMedia[3] = new Media();

            for (int i = 0; i<tabMedia.Length; i++) 
            {
                tabMedia[i].Pause();
            }
            Console.WriteLine();

            foreach (Media item in tabMedia) 
            {
                item.Pause();
            }
        }
    }
}