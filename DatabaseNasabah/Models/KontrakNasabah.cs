using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseNasabah.Models
{
    public class KontrakNasabah
    {
        public VAS[] VAS { get; set; }
        public string NoKontrak { get; set; }
        public POS POS { get; set; }
        public int TotalHarga { get; set; }
        public int TotalPembiyayaan { get; set; }
        public int UangMuka { get; set; }
        public int Tenor { get; set; }
        public int Angsuran { get; set; }
        public string NoKontrak_ { get; set; }
        public DateTime TanggalKontrak { get; set; }
        public DateTime TanggalSelesai { get; set; }
        public DateTime JatuhTempo { get; set; }
    }
}
