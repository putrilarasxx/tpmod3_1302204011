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
            kodePos Jatisari = new kodePos("Jatisari", 40286);
            kodePos Margasari = new kodePos("Margasari", 40286);
            kodePos Sekejati = new kodePos("Sekejati", 40286);
            kodePos Kebonwaru = new kodePos("Kebonwaru", 40272);
            kodePos Maleer = new kodePos("Maleer", 40274);
            kodePos Samoja = new kodePos("Samoja", 40273);
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

    public class doorMachine
    {
        string terkunci, terbuka;

        if (terkunci == true)
    }
}
