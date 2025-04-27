namespace tpmodul10_103022300004.Models
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }

        public Mahasiswa(String nama, String Nim)
        {
            this.Nama = nama;
            this.Nim = Nim;
        }
    }
}
