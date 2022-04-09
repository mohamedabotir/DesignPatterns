using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class Counter
    {
        public int count=0;
        private static Counter Instance = null;
        private static object obj = new object();
        private Counter(){
            
        }
        public static Counter GetInstance(){
            if(Instance == null){
             lock (obj)
             {
                 if(Instance == null){
                 Instance = new Counter();
                 }
             }
            }
            return Instance;
        }
        public void AddOne(){

          count++;
          Console.WriteLine(count);
        }
    }
}