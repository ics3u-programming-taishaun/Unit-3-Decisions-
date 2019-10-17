using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectSquaresWhileTaishaun
{
    public partial class FrmPerfectSquares : Form
    {
        public FrmPerfectSquares()
        {
            InitializeComponent();
        }

        private object BtnStart_Click(object sender, EventArgs e)
        {
            // declare variables and constants
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            // set the initial values 
            value = 0;

            // clear all items from the list box
            this.lstPerfectSquares.Hide();

            // get the user's end value selection from the number up-down box 
            endingValue = Convert.ToInt32(this.nudEndValue.Value);

            // continue stating any perfect squares between the minimum value and the user's selected and value
            while (value <= endingValue)
            {
                // take the square root of the value 
                squareRootAsDouble = Math.Sqrt(value);

                // convert the double to an integar 
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                // Make both decimal and integer to be equal if the value was a perfect square
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstPerfectSquares.Items.Add(value + "is a perfect square");
                    // this.lstPerfectSquares.SetSelected(numberofPerfectsquares)
                    this.Refresh();
                }
                // code to increment the value by 1
                value = value + 1;
        }
    }

        private void LstPerfectSquares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
