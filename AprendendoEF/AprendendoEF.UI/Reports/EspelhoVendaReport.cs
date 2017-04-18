using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEF.UI.Reports
{
    public class EspelhoVendaReport
    {
        public int Id { get; set; }

        public string Cliente_Nome { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public List<EspelhoVenda_ItemReport> Itens { get; set; }
    }
}
