using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop
{
   public class order
    {
      private String item;
      private String quantity;
     
      public String name
        {
            set { this.item = value; }
            get { return item; }

        }
      public String quan
        {
            set { this.quantity= value; }
            get { return quantity; }

        }
      
    }
}

