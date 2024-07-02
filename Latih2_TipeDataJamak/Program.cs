namespace Latih2_TipeDataJamak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* // Deklarasi dan inisialisasi Dictionary
             Dictionary<string, int> nilaiSiswa = new Dictionary<string, int>
         {
             { "Budi", 85 },
             { "Siti", 90 },
             { "Adi", 78 }
         };

             // Akses nilai berdasarkan kunci
             Console.WriteLine("Nilai Budi: " + nilaiSiswa["Budi"]);

             Console.WriteLine("Nilai Siti:" + nilaiSiswa["Siti"]);
             Console.WriteLine("Niai Adi: " + nilaiSiswa["Adi"]);

             // Menambah pasangan kunci-nilai baru
             nilaiSiswa["Dina"] = 92;
             Console.WriteLine("Nilai Dina: " + nilaiSiswa["Dina"]);

             // Mengubah nilai berdasarkan kunci
             nilaiSiswa["Adi"] = 80;
             Console.WriteLine("Nilai Adi setelah diubah: " + nilaiSiswa["Adi"]);*/

            Dictionary<string, int> nilaimurid = new Dictionary<string, int>
            {
                { "Budi", 86 },
                { "Siti", 91 },
                { "Adit", 100 }
            };
            Console.WriteLine("Nilai Budi: " + nilaimurid ["Budi"]);
            Console.WriteLine("Nilai Siti: " + nilaimurid ["Siti"]);
            Console.WriteLine("Nilai Adit: " + nilaimurid ["Adit"]);
            nilaimurid["Mamad"] = 95;
            Console.WriteLine("Nilai Mamad: " + nilaimurid["Mamad"]);
        }
    }
}
