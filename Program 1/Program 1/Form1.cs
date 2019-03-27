// Program 1
// Grading ID: B5992
// Due: Tuesday, February 14th, 2017
// CIS 199-02
// This is a program designed to generate numbers for total square feet, gallons of paint,
// hours of labor, cost of labor, and total cost of paint job when the user inputs square feet,
// coats of paint desired, and cost of paint per gallon.
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

        const float LABOR_COST_PER_HOUR = 10.50f; // Constant for labor cost.
        const float SQUARE_FEET_PER_GALLON = 330.0f; // Constant for square feet per gallon.
        const int LABOR_PER_GALLON = 6; // Constant for labor per gallon.

        public program1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            float squareFeet; // To hold square feet.
            int numberOfCoats; // To hold number of coats desired.
            float paintPrice; // To hold price of paint.
            float totalSquareFeet; // To hold total square feet to be painted.
            double paintRequired; // To hold paint required.
            float hoursOfLabor; // To hold hours of labor required.
            double costOfPaint; // To hold total cost of paint needed.
            double costOfLabor; // To hold cost of labor required.
            double totalCost; // To hold total cost of paint job.

            // Get the number of square feet.
            squareFeet = float.Parse(squareFeetTextBox.Text);
            // Get the number of coats desired
            numberOfCoats = int.Parse(coatsOfPaintTextBox.Text);
            // Get the price of paint per gallon.
            paintPrice = float.Parse(priceOfPaintTextBox.Text);

            // Calculate total square feet to be painted and assign to variable.
            totalSquareFeet = squareFeet * numberOfCoats;
            // Display total square feet in label.
            totalSquareFeetOutputLabel.Text = totalSquareFeet.ToString("f1");

            // Calculate gallons of paint required.
            paintRequired = totalSquareFeet / SQUARE_FEET_PER_GALLON;
            // Round paint required to next highest integer.
            paintRequired = Math.Ceiling(paintRequired);
            //Display paint required in label.
            gallonsOfPaintOutputLabel.Text = paintRequired.ToString("f0");

            // Calculate hours of labor required.
            hoursOfLabor = totalSquareFeet / SQUARE_FEET_PER_GALLON * LABOR_PER_GALLON;
            //Display hours of labor required in label.
            hoursOfLaborOutputLabel.Text = hoursOfLabor.ToString("f1");

            // Calculate total cost of paint.
            costOfPaint = paintPrice * paintRequired;
            // Display total cost of paint in label.
            costOfPaintOutputLabel.Text = costOfPaint.ToString("c");

            // Calculate cost of labor.
            costOfLabor = LABOR_COST_PER_HOUR * hoursOfLabor;
            // Display cost of labor
            costOfLaborOutputLabel.Text = costOfLabor.ToString("c");

            // Calculate total cost of paint job.
            totalCost = costOfLabor + costOfPaint;
            // Display total cost of paint job.
            totalCostOutputLabel.Text = totalCost.ToString("c");

        }
    }
}
