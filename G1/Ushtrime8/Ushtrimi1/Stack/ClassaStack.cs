using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class ClassaStack
    {
        public int StackSize { set; private get; }
        public int count { set; private get; }
        public int Stack { set; private get; }
        public  Object[] Stack1;
        public int element { set; private get; }
        public int MadhesiStive { set; private get; }
        public int ElementStive { set; private get; }
        

        public int Push()
        {
            if(count != Stack1.Length)
            
                Stack1[++count] = element;

            return element;
    }

      public int Pop ()
      {
          if(count == StackSize -1)
          
              Stack1[--count] = element;

          return element;
      
      }
       
        public object Top ()
        {
            
                return Stack1[count];
            
            }

    
    }
    }

