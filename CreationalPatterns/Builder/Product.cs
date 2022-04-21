using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Product
    {
         LinkedList<string> components = new LinkedList<string>();
         public void addComponent(string component){
             this.components.AddLast(component);
         }
        public string showComponents(){
            StringBuilder build = new StringBuilder();
            build.AppendLine("Product Component are :");
            foreach (var item in components)
            {
                build.AppendLine(item);
            }
            return build.ToString();
        }
    }
}