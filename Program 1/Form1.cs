/* Codey Von Vreckin
 * 2/14/16
 * CIS 199-01
 * Program 1
 *  this program calculates the total cost of painting a room with the given square footage, number of coats, and the price per gallon of paint.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class program1 : Form
    {
        public program1()
        {
            InitializeComponent();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            double sqFt; //declares the double variable to hold the square feet
            double pricePerGallon; //declares the double variable to hold the sqft
            int coats; //declares the int variable to hold the number of coats
            double numberOfCoats; //declares the double variable to hold the number of coats
            double totalSqFt; //declares the double variable to hold the total square feet
            double numberOFGallons; //declares the double variable to hold the number of gallons
            double timeRequired; //declares the double variable to hold the amount of time required
            double costOfPaint; //declares the double variable to hold the cost of the paint
            double laborCost; //declares the double variable to hold the labor cost
            double totalCost; //declares the double variable to hold the total cost
            const double FT_PER_GALL = 325; //deaclares the constant double variable to hold the square feet per gallon 
            const double HOURS_REQUIRED_PER_GAL = 8; //deaclares the constant double variable to hold the hours of work per gallon 
            const double PRICE_PER_HOUR = 10.50; //deaclares the constant double variable to hold the price of labor per hour.

            sqFt = double.Parse(sqFtTxtBox.Text); // converts the text string from the sqft text box into a double
            pricePerGallon = double.Parse(pricePerGallonTxtBox.Text); // converts the text string from the price per gallon text box into a double
            coats = int.Parse(numberOfCoatsTxtBox.Text); // converts the text string from the number of coats text box into a int
            numberOfCoats = (double)coats; // converts the int coats into a double variable
            totalSqFt = sqFt * numberOfCoats; // sets the value of the totalSqFt to equal the sqft * the number of coats
            numberOFGallons = totalSqFt / FT_PER_GALL; // sets the value of the number of gallons to equal the total sqft / square feet per gallon
            timeRequired = totalSqFt / FT_PER_GALL * HOURS_REQUIRED_PER_GAL; // sets the value of the time required to equal the total sqft / the square feet per gallon * the hours of work required per gallon
            costOfPaint = pricePerGallon * Math.Ceiling(numberOFGallons); // sets the value of the cost of paint to equal the price per gallon* the number of gallons (rounded up to the next whole number)
            laborCost = timeRequired * PRICE_PER_HOUR; // sets the value of the labor cost to equal the time required * the price of labor per hour
            totalCost = costOfPaint + laborCost; // sets the value of the total cost to equal the cost of paint + the labor cost

            totalSqFtAnswerLabel.Text = totalSqFt.ToString("n1"); // displays the total square feet in the adjacent answer label
            gallonsAnswerLabel.Text = Math.Ceiling(numberOFGallons).ToString(""); // displays the number of gallons required (rounded up to the next whole number) in the adjacent answer label
            timeRequiredAnswerLabel.Text = timeRequired.ToString("n1"); // displays the amount of hours required in the adjacent answer label
            costOfPaintAnswerLabel.Text = costOfPaint.ToString("C"); // displays the total cost of paint in the adjacent answer label
            totalLaborCostAnswerLabel.Text = laborCost.ToString("C"); // displays the total cost of labor in the adjacent answer label
            totalCostAnswerLabel.Text = totalCost.ToString("C"); // displays the total cost of the job in the adjacent answer label
        }
    }
}
