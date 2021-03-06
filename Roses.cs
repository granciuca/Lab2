using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Roses : IFloralBuilder
    {
        private Bouquet _bouquet;

        public Roses()
        {
            _bouquet = new Bouquet();
        }

        public Bouquet Bouquet
        {
            get => default;
            set
            {
            }
        }

        public IFloralBuilder BuildBouquetFlower()
        {
            _bouquet.Plan = "Flower: " + Flower.Rose;
            return this;
        }


        public IFloralBuilder BuildBouquetColors()
        {
            _bouquet.Color = "Color: " + Colors.White;
            return this;
        }

        public IFloralBuilder BuildBouquetProportions()
        {
            _bouquet.Proportions = "Proportions: " + Proportions.Large;
            return this;
        }


        public Bouquet GetBouquet()
        {
            var bouquet = _bouquet;
            Clear();
            return bouquet;
        }

        private void Clear() => _bouquet = new Bouquet();
    }
}
