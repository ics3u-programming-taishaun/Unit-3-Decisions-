using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeTaishaunJ
{
    public partial class UnicodeForm : Form
    {
        public UnicodeForm()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Declare local variables
            string aletter;
            int counter;
            const int MAX_COUNTER = 90;

            // Clear the list box 
            this.lstFactorial.Items.Clear();

            // Create a for loop that repeats until Capital letters A-Z are displayes
            for (counter = 65; counter <= MAX_COUNTER; counter += 1)
            {
                // convert the value of the counter to unicode
                aletter = Char.ConvertFromUtf32(counter);

                // adds the letter and the current value of counter to list box 
                this.lstFactorial.Items.Add(aletter + "=" + counter);

                // Refresh the form
                this.Refresh(); 
        }

            //
          //  private void UnicodeForm_Load(object sender, EventArgs e)
            //{

          // }

        }
    }
}
