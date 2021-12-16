using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class Quote
    {

        public const double BASEMONTH = 50.0;                                       // a base of $50 / month.

        private double _total;

        public double total { get { return _total; } set { _total = value; } }

        public Quote()
        {
            total = BASEMONTH;
        }
        public void checkAge(DateTime age)
        {
            int years = DateTime.Now.Year - age.Year;

            if (years <= 0) return;
            if( years < 18)                                                         // If the user is 18 and under, add $100 to the monthly total
            {
                total += 100.00;
            }
            else if( years < 25)                                                    // If the user is between 19 and 25, add $50 to the monthly total.
            {
                total += 50.00;
            }
            else
            {                                                                       // If the user is over 25, add $25 to the monthly total.
                total += 25.00;
            }
        }

        public void checkCarsYear(int year)
        {
            if (year < +0) return;
            if ( year < 2000 || year > 2015)                                        // If the car's year is before 2000, add $25 to the monthly total
            {
                total += 25.00;                                                     // If the car's year is after 2015, add $25 to the monthly total.
            }
        }

        public void checkCar(string manufacturing, string model)
        {
            if ( manufacturing.ToUpper() == "PORSCHE")                              // If the car's Make is a Porsche, add $25 to the price.
            {
                total += 25.00;
                if ( model.ToUpper() == "911 CARRERA")                             // If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                {
                    total += 25.00;
                }
            }
            if (manufacturing == "" || model == "") return;
        }

        public void checkSpeedingTickets(int tickets)                               // Add $10 to the monthly total for every speeding ticket the user has
        {
            if (tickets <= 0) return;
            total += (10.0 * (double)tickets);
        }

        public void checkDUI(bool DUI)                                              // If the user has ever had a DUI, add 25% to the total.
        {
            if ( DUI )
            {
                total += (total * 0.25);
            }
        }

        public void checkFullCoverage(bool coverage)                                // If it's full coverage, add 50% to the total.
        {
            if (coverage )
            {
                total += (total * 0.5);
            }
        }

        /*public ActionResult Quote(FormCollection form)
        {
            decimal principle = Convert.ToDecimal(form["txtAmount"].ToString());
            decimal rate = Convert.ToDecimal(form["txtRate"].ToString());
            int time = Convert.ToInt32(form["txtYear"].ToString());

            decimal simpleInteresrt = (principle * time * rate) / 100;

            StringBuilder sbInterest = new StringBuilder();
            sbInterest.Append("<b>Amount :</b> " + principle + "<br/>");
            sbInterest.Append("<b>Rate :</b> " + rate + "<br/>");
            sbInterest.Append("<b>Time(year) :</b> " + time + "<br/>");
            sbInterest.Append("<b>Interest :</b> " + simpleInteresrt);
            return view();
        }*/
    }

}