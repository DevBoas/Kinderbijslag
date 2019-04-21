using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Kinderbijslag
{
    public partial class Form1 : Form
    {
        int offset = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private Decimal AddPercent(Decimal geld, int kinderen)
        {
            int Procent = 0;
            if (kinderen > 2 && kinderen < 5)
                Procent = 102;
            else if (kinderen == 5)
                Procent = 103;
            else if (kinderen > 5)
                Procent = 105;
            Decimal toAdd = (geld * Procent) / 100;
            //MessageBox.Show(Procent.ToString() + " Procent van " + geld.ToString() + " is " + toAdd.ToString());
            geld = geld + toAdd;
            return geld; 
        }
        private Decimal calculateGeld()
        {
            Decimal geld = 0;
            int kinderen = 0;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(DateTimePicker))
                {
                    DateTimePicker persoonDate = (DateTimePicker)c;
                    DateTime zeroTime = new DateTime(1, 1, 1);
                    DateTime now = DateTime.Now;
                    TimeSpan span = now - persoonDate.Value;
                    int years = (zeroTime + span).Year - 1;
                    if (years < 12)
                        geld += 150;
                    else if (years >= 12 && years < 18)
                        geld += 235;
                    //MessageBox.Show(years.ToString());
                    kinderen++;
                }
            }
            geld = AddPercent(geld, kinderen);
            //MessageBox.Show("Geld = " + geld.ToString());
            return (geld);
        }
        private void AddChild_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() != typeof(DateTimePicker) && c.Name != "NO")
                {
                    c.Location += new Size(0, 21);
                    if (c.GetType() == typeof(Button))
                        c.Location += new Size(0, 1);
                }
            }
            offset += 22;
            Point loc = new Point(105, 12 + offset);
            Point loc2 = new Point(64, 16 + offset);
            DateTimePicker dateTimePick = new DateTimePicker();
            dateTimePick.Location = loc;
            Label persoon = new Label();
            persoon.Location = loc2;
            persoon.Name = "NO";
            persoon.Size = new Size(52, 15);
            persoon.Text = "Kind" + ((offset / 22) + 1).ToString();
            this.Controls.Add(dateTimePick);
            this.Controls.Add(persoon);
            this.Size += new Size(0, 20);
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            Output.Text = "Kinderbijslag: €" + calculateGeld().ToString();
        }
    }
}
