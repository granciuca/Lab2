using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class BouquetDirector
    {
        public void BuildBouquet(IFloralBuilder builder)
        {
            builder.BuildBouquetFlower();
            builder.BuildBouquetProportions();
            builder.BuildBouquetColors();
        }
    }
}
