/*
 * Created by: Taishaun Johnson 
 * Created on: Oct.7, 2019 
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program...
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

namespace ChocolateBoxesTaishaun
{
    public partial class FrmChocolateBoxes : Form
    {
        public FrmChocolateBoxes()
        {
            InitializeComponent();
        }


        private void BtnGetReward_Click(object sender, EventArgs e)
        {
            double numBoxes;
            numBoxes = double.Parse(txtNumBoxes.Text);

            if (numBoxes > 20)

                lblUserReward.Text = " You get a prize";

        }
    }
}
