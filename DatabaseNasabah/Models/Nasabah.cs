using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseNasabah.Models
{
    public class Nasabah
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public string Alamat { get; set; }
        public string NoTelp { get; set; }
        public (int, DateTime) Limit { get; set; }
    }
}
