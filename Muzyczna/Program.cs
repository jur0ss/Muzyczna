List<Album> lista = Album.WczytajZPliku("Data.txt");

Album.WypiszAlbumy(lista);

public class Album
{
    public string NazwaZespolu;
    public string TytulAlbumu;
    public int LiczbaUtworow;
    public int RokWydania;
    public long LiczbaPobran;

    public Album(string nazwaZespolu, string tytulAlbumu, int liczbaUtworow, int rokWydania, long liczbaPobran)
    {
        this.NazwaZespolu = nazwaZespolu;
        this.TytulAlbumu = tytulAlbumu;
        this.LiczbaUtworow = liczbaUtworow;
        this.RokWydania = rokWydania;
        this.LiczbaPobran = liczbaPobran;
    }
    
    
    public static List<Album> WczytajZPliku(string sciezka)
    {

        string[] linie = File.ReadAllLines(sciezka);

        List<Album> listaAlbumow = new List<Album>();

        for (int i = 0; i < linie.Length; i += 6)
        {
            string nazwaZespolu = linie[i];
            string tytulAlbumu = linie[i + 1];
            int liczbaUtworow = int.Parse(linie[i + 2]);
            int rokWydania = int.Parse(linie[i + 3]);
            long liczbaPobran = long.Parse(linie[i + 4]);

            Album album = new Album(nazwaZespolu, tytulAlbumu, liczbaUtworow, rokWydania, liczbaPobran);
    
            listaAlbumow.Add(album);
    
        }

        return listaAlbumow;
    }
    
    public static void WypiszAlbumy(List<Album> listaAlbumow)
    {
        foreach (var album in listaAlbumow)
        {
            Console.WriteLine(album.NazwaZespolu);
            Console.WriteLine(album.TytulAlbumu);
            Console.WriteLine(album.LiczbaUtworow);
            Console.WriteLine(album.RokWydania);
            Console.WriteLine(album.LiczbaPobran);
            Console.WriteLine(); 
        }
    }
    
}