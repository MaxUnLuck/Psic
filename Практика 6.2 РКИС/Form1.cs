using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_6._2_РКИС
{
    public partial class Form1 : Form
    {
        private readonly Facade car;
        public Form1()
        {
            InitializeComponent();
            car = new Facade(UpdateLog);
        }
        private void statuseBtn_Click(object sender, EventArgs e)
        {
           string stat = car.GetStatus();
            UpdateLog(stat);
        }
        private void engainBtnOn_Click(object sender, EventArgs e)
        {

        }
        private void engineBtnOff_Click(object sender, EventArgs e)
        {

        }
        private void fariBtnOn_Click(object sender, EventArgs e)
        {

        }
        private void fariBtnOff_Click(object sender, EventArgs e)
        {

        }
        private void fuelBtnOn_Click(object sender, EventArgs e)
        {

        }
        private void fuelBtnOff_Click(object sender, EventArgs e)
        {

        }
        private void tBInfa_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateLog(string message)
        {
            if (tBInfa.InvokeRequired)
                tBInfa.Invoke(new Action(() => { tBInfa.AppendText(message); tBInfa.ScrollToCaret(); }));
            else
                tBInfa.AppendText(message);
        }

    }
}
