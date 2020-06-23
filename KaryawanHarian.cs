using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab8pemograman.ClassInduk;
namespace lab8pemograman.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public int UpahPerjam { get; set; }
        public int JumlahJamKerja { get; set; }
        public override int Gaji() => UpahPerjam * JumlahJamKerja;
    }
}
