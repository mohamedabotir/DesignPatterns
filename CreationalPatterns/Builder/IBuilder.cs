using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        void AddCarbohydrates();

        void AddFat();

        void Protein();

        void ShowComponents();

    }
}