using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseNasabah.Models
{
    public abstract class VAS
    {
        public int HargaBarang { get; internal set; }
        public int Tenor { get; internal set; }
        public abstract int getPremi();
    }

    public class AMAN : VAS
    {
        public AMAN(int volume, int tenor)
        {
            HargaBarang = volume;
            Tenor = tenor;
        }

        public override int getPremi()
        {
            var premi = HargaBarang * Tenor * 0.077;
            // bulankan ribuan keatas
            return (int)Math.Ceiling(premi / 1000) * 1000;
        }
    }

    public class EASYCOVER24 : VAS
    {
        public EASYCOVER24(int volume, int tenor)
        {
            HargaBarang = volume;
            Tenor = tenor;
        }

        public override int getPremi()
        {
            return 0;
        }
    }

    public class EASYCOVER12 : VAS
    {
        public EASYCOVER12(int volume, int tenor)
        {
            HargaBarang = volume;
            Tenor = tenor;
        }

        public override int getPremi()
        {
            return 0;
        }
    }

    public class SANTAI : VAS
    {
        public SANTAI(int volume, int tenor)
        {
            HargaBarang = volume;
            Tenor = tenor;
        }

        public override int getPremi()
        {
            return 0;
        }
    }

    public class FLEXIPAY : VAS
    {
        public FLEXIPAY(int volume, int tenor)
        {
            HargaBarang = volume;
            Tenor = tenor;
        }

        public override int getPremi()
        {
            return 0;
        }
    }
}
