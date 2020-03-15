using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMyProject
{
    public class CalculatingPremium
    {

        public float CalcPremium(int age, string gender)
        {
            float premium;

            if (gender == "urban")
                if ((age >= 18) && (age <= 30))
                    premium = 5.0f;
              
            else
                if (age >= 31)
                    premium = 2.50f;
            else
                    premium = 0;

            else
                if (gender == "rural")
                if ((age >= 18) && (age <= 35))
                    premium = 6.0f;
                else
                    if (age >= 36)
                    premium = 5.0f;
            else
                    premium = 0;
            else
                premium = 0;

            if (age >= 50)
                premium = premium * 0.15f;
            return premium;
        }
    


        static void Main(string[] args)
        {

        }





    }
}
