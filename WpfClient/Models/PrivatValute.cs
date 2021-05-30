using System;
using System.Collections.Generic;
using System.Text;

namespace WpfClient.Models
{
    public class PrivatValute
    {
        public string ccy { get; set; }
        public string base_ccy { get; set; }
        public decimal buy { get; set; }
        public decimal sale { get; set; }
    }
}
