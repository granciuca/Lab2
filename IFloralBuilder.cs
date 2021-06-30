using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface IFloralBuilder
    {
        IFloralBuilder BuildBouquetFlower();
        IFloralBuilder BuildBouquetColors();
        IFloralBuilder BuildBouquetProportions();
        Bouquet GetBouquet();
    }


}

