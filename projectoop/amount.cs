using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop
{
    class amount
    {
        public amount()
        {
            newfrice = 0;
            newfrice2 = 0;
            newburger = 0;
            newburger2 = 0;
            newburger3 = 0;
            newpizza = 0;
            newpizza2 = 0;
            newpizza3 = 0;
           

            newsand = 0;
            newsand3 = 0;
            newsand2 = 0;

            newdessert= 0;
            newdessert2 = 0;
            newdessert3 = 0;
             newdessert= 0;
     

            newteacof = 0;
            newteacof2 = 0;
            newteacof3= 0;
            newteacof4 = 0;
            newteacof5 = 0;
         
        }

        //Set Method
        public amount(double frice, double burger, double pizza, double sand, double dessert, double teacof, double frice2, double burger2, double pizza2, double sand2, double dessert2,double teacof2,
          double sand3, double dessert3, double teacof3)
        {
            newfrice = frice;
            newburger = burger;
            newpizza = pizza;
            newsand = sand;
            newdessert = dessert;
            newteacof= teacof;

            newfrice2 = frice2;
            newburger2 = burger2;
            newpizza2 = pizza2;
            newsand2 = sand2;
            newdessert2 = dessert2;
            newteacof2 = teacof2;


            
            newpizza3 = pizza3;
            newsand3 = sand3;
            newdessert3 = dessert3;
            newteacof3 = teacof3;

            


       
       
        }

        public amount(double frice, double burger, double pizza, double sand, double dessert, double teacof, double frice2, double burger2, double pizza2, double sand2, double dessert2, double teacof2, double pizza3, double sand3, double dessert3, double teacof3)
        {
          
            this.frice = frice;
            this.burger = burger;
            this.pizza = pizza;
            this.sand = sand;
            this.dessert = dessert;
            this.teacof = teacof;
            this.frice2 = frice2;
            this.burger2 = burger2;
            this.pizza2 = pizza2;
            this.sand2 = sand2;
            this.dessert2 = dessert2;
            this.teacof2 = teacof2;
            
            this.pizza3 = pizza3;
            this.sand3 = sand3;
            this.dessert3 = dessert3;
            this.teacof3 = teacof3;
            
        }

        //get Method
        public double getfrice() { return newfrice; }
        public double getburger() { return newburger; }
        public double getpizza() { return newpizza; }
        public double getsand() { return newsand; }
        public double getdessert() { return newdessert; }
        public double getteacof() { return newteacof; }


        public double getfrice2() { return newfrice2; }
        public double getburger2() { return newburger2; }
        public double getpizza2() { return newpizza2; }
        public double getsand2() { return newsand2; }
        public double getdessert2() { return newdessert2; }
        public double getteacof2() { return newteacof2; }


       // public double getfrice3() { return newfrice3; }
        public double getburger3() { return newburger3; }
        public double getpizza3() { return newpizza3; }
        public double getsand3() { return newsand3; }
        public double getdessert3() { return newdessert3; }
        public double getteacof3() { return newteacof3; }

        public double getteacof4() { return newteacof4; }
        public double getteacof5() { return newteacof5; }

        //public double getpizza4() { return newpizza4; }



       
        private double newfrice;
        private double newburger;
        private double newpizza;
        private double newsand;
        private double newdessert;
        private double newteacof;


        private double newfrice2;
        private double newburger2;
        private double newpizza2;
        private double newsand2;
        private double newdessert2;
        private double newteacof2;


       // private double newfrice3;
        private double newburger3;
        private double newpizza3;
        private double newsand3;
        private double newdessert3;
        private double newteacof3;

        private double newteacof4;
        private double newteacof5;

      //  private double newpizza4;
        private double frice;
        private double burger;
        private double pizza;
        private double sand;
        private double dessert;
        private double teacof;
        private double frice2;
        private double burger2;
        private double pizza2;
        private double sand2;
        private double dessert2;
        private double teacof2;
       
        private double pizza3;
        private double sand3;
        private double dessert3;
        private double teacof3;
        
       
    }
}

    

//burger, pizza, sand, dessert, teacof, frice2, burger2, pizza2, sand2, dessert2, teacof2,pizza3, sand3, dessert3, teacof3);
