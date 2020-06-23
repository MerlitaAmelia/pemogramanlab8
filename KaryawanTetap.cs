using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab8pemograman.ClassInduk;
namespace lab8pemograman.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public int GajiBulanan { get; set; }
        public override int Gaji() => GajiBulanan;
    }
}
