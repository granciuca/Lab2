using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Bouquet
    {
        public string Plan { get; set; }
        public string Color { get; set; }
        public string Proportions { get; set; }

        public override string ToString() =>
            new StringBuilder()
            .AppendLine(Plan)
            .AppendLine(Color)
            .AppendLine(Proportions)
        .ToString();
    }
}

