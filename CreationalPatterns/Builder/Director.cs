using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        IBuilder builder ;
        public void Construct(IBuilder builder){
         this.builder = builder;

         builder.AddCarbohydrates();
         builder.AddFat();
         builder.Protein();
        }
    }
}