namespace _5M05SortowanieWybieranie
{
    class Tablica
    {
        private const int N = 50;
        private int[] tablica = new int[N];
        public Tablica()
        {

        }
        public void sortujTablice()
        {
            for(int i = 0; i < N; i++)
            {
                int pozMaks = znajdzMaks(i);
                int temp = tablica[pozMaks];
                for (int j = pozMaks; j > i; j--)
                    tablica[j] = tablica[j - 1];
                tablica[i] = temp;
            }
        }
        private int znajdzMaks(int n)
        {
            int pozMaks = n;
            for (int i = 0; i < N;i++)
                if (tablica[i]> tablica[pozMaks])
                    pozMaks = i;
            return pozMaks;
        }
        public void wczytajTablice()
        {
            //do testów - losowanie
            Random r = new Random();
            Console.WriteLine("Wczytanie elementów tablicy");
            for(int i = 0; i < N; i++)
            {
                tablica[i] = r.Next(0,101);
                
                //zakładamy, że będzie to liczba całkowita, nie sprawdzamy
                //czy użytkownik nie podał niewłasciwej wartości
                //Console.Write($"element {i}: ");
                //tablica[i] = int.Parse( Console.ReadLine() );
            }
        }
        public void wypiszTablice()
        {
            Console.WriteLine("elementy tablicy nieposortowanej:");
            foreach (int i in tablica)
                Console.Write($"{i}, ");
            Console.WriteLine();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Tablica tablica = new Tablica();
            tablica.wczytajTablice();
            Console.WriteLine("tablica nieposortowana");
            tablica.sortujTablice();
            Console.WriteLine("tablica posortowana");
            tablica.wypiszTablice();

        }
    }
}
