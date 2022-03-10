using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod3_1302204011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kodePos Batununggal = new kodePos("Batunggal", 40266);
            kodePos Kujangsari = new kodePos("Kujangsari", 40287);
            kodePos Mengger = new kodePos("Mengger", 40267);
            kodePos Wates = new kodePos("Wates", 40256);
            kodePos Cijaura = new kodePos("Cijaura", 40287);
            kodePos Jatisari = new kodePos("Kujangsari", 40286);
            kodePos Margasari = new kodePos("Kujangsari", 40286);
            kodePos Sekejati = new kodePos("Kujangsari", 40286);
            kodePos Kebonwaru = new kodePos("Kujangsari", 40272);
            kodePos Maleer = new kodePos("Kujangsari", 40274);
            kodePos Samoja = new kodePos("Kujangsari", 40273);
        }
    }
    public class kodePos
    {
        string kelurahan;
        int kodepos, jumKelurahan, listKelurahan;

        public kodePos(string kelurahan, int kodepos)
        {
            this.kelurahan = kelurahan;
            this.kodepos = kodepos;
        }
        public kodePos()
        {
            this.kelurahan = "";
            this.kodepos = 0;
        }

        public void getKodePos()
        {
            return;
        }
    }
}
