// Lab 2
// CIS 199-02-4222
// Due: 2/14/2022
// By: R2215
// drywall calculator
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double frontWall;
            double sideWall;
            double front;
            double side;
            double height;
            double ceiling;
            double totalCost;
            double dryWall;
            double extraCost;
            double laborCost;
            double materialCost;
            double num1;
            double num2;

            int window;
            window = 100;



            // connecting var to each textbox 
            double window2 = Convert.ToDouble(window); 
            front = double.Parse(frontLength.Text); 
            side = double.Parse(sideLength.Text);
            height = double.Parse(heightLength.Text);
            window2 = double.Parse(windowPrice.Text);
            num1 = Convert.ToDouble(costOfLabor.Text);
            num2 = Convert.ToDouble(costOfDrywall.Text);




            // math to calculate outputs
            frontWall = side * height * 2;
            sideWall = (front * height) * 2;
            ceiling = (side * front);
            dryWall = (sideWall + frontWall + ceiling);
            extraCost = dryWall * 1.1;
            laborCost = (num1 * dryWall) * 1.1;
            materialCost = (num2 * dryWall) * 1.1;


            // if else statement to add window cost
            if (window2 == 0) 
            {
                totalCost = laborCost + materialCost;
            }
            else
            {
                totalCost = (laborCost + materialCost) + 100;
            }


            //outputing calculatiosn to labels
            totalSQ.Text = $"{dryWall:F2}";
            percentExtra.Text = $"${extraCost:F2}";
            laborCostBox.Text = $"${laborCost:F2}";
            matCostBox.Text = $"${materialCost:F2}"; 
            totalCostBox.Text = $"${totalCost:F2}";

        }
    }
}
