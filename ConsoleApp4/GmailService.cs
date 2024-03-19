using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class GmaileService
    {
        public GmaileService(string? gmail)
        {
            this.gmail = gmail;
        }

        public string? gmail { get; set; }

        public override string ToString()
        {
            return $"{gmail}";
        }
    }
}
