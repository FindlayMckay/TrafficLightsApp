using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private async void btnStart_Click(object sender, EventArgs e)
        {
            Sequence seq = new Sequence();
            while (true)
            {
                foreach (Stage s in seq)
                {
                    btnRed.Visible = btnAmber.Visible = btnGreen.Visible = false;

                    foreach (Light l in s.Lights)
                    {
                        switch (l.Colour)
                        {
                            case LightColour.Red:
                                btnRed.Visible = true;
                                break;

                            case LightColour.Amber:
                                btnAmber.Visible = true;
                                break;

                            case LightColour.Green:
                                btnGreen.Visible = true;
                                break;
                        }
                    }
                    await Task.Delay(s.Time * 1000);

                }
            }
        }
    }
}
