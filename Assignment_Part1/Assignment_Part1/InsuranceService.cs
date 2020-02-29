using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part1
{


    public class InsuranceService
    {


        public double CalcPremium(int age, string location)
        {

            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter location");
            location = Convert.ToString(Console.ReadLine());


            double premium;

            if (location == “urban”)
	if ((age > = 18) && (age <= 30))
                premium = 5.0;
            else
        if (age >= 31)
                premium = 2.50;
            else
                premium = 0.0;
else
	if (location == “rural”)
	    if ((age > = 18) && (age <= 35))
                premium = 60;
            else
           if (age >= 36)
                premium = 50;
            else
                premium = 0.0;
else
		premium = 0.0;

            if (age >= 50)
                premium = premium * 0.15;
            return premium;
        }
    }


}



