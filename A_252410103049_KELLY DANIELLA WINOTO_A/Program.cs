class Sekolah
{
    public string idSekolah;
    public string namaSekolah;
    public int jumlahPaketDiterima;

    public Sekolah(string id, string nama, int paketditerima)
    {
        idSekolah = id;
        namaSekolah = nama;
        jumlahPaketDiterima = paketditerima;
    }

    public void TampilInfo()
    {
        Console.WriteLine($"Sekolah {namaSekolah} dengan id {idSekolah} telah menerima MBG sebanyak {jumlahPaketDiterima} paket.");
    }
}

abstract class paketMBG
{
    private string idPaket { get; set; }
    private string namaPaket { get; set; }
    private int stokDapur
    {
        get;
        set
        {
            value = stokDapur;
            if (value <= 0)
            {
                Console.WriteLine("Stok tidak boleh bernilai negatif.");
            }

            else
            {
                Console.WriteLine($"Terdapat sebanyak {stokDapur} stok di dapur.");
            }
        }
    }

    public paketMBG(string idpaket, string namapaket, int stokdapur)
    {
        this.idPaket = idpaket;
        this.namaPaket = namapaket;
        stokDapur = stokdapur;
    }

    public void KurangiStok(int jumlah)
    {
        if (stokDapur < jumlah)
        {
            Console.WriteLine("Tidak dapat mengurangi stok karena stok kurang.");
        }

        else
        {
            Console.WriteLine($"Stok berhasil dikurangi, sisa stok adalah {stokDapur - jumlah}.");
        }
    }

    virtual public void HitungBiaya(int jumlah)
    {

    }
}

//class PaketReguler : paketMBG
//{
//    public int Harga;
//    public string isiPaket;

//    public PaketReguler(string idpaket, string namapaket, int stokdapur, int harga, string isipaket)
//    {

//    }
//}

//class PaketKhusus : paketMBG
//{
//    public int Harga;
//    public string isiPaket;

//    public PaketKhusus(string idpaket, string namapaket, int stokdapur, int harga, string isipaket)
//    {
//        idPaket = idpaket;

//    }
//}

interface DapatDidistribusikan
{
    public void KirimPaket()
    {
        //if ()
    }
}

class DistribusiMBG
{

}

class Program
{
        private static void Main(string[] args)
        {
            Sekolah sekola1 = new Sekolah("ID-001", "Bakti Mulya", 55);
            Sekolah sekola2 = new Sekolah("ID-002", "Citra Husada", 90);

            sekola1.TampilInfo();
            sekola2.TampilInfo();

            
        }
}