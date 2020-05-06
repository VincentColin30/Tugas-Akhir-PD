using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makan_Kuy
{
    public partial class Home : Form
    {
       
        private void button1_Click(object sender, EventArgs e)
        {
            btnhome.Visible = true;
            btnshp.Visible = true;
            btnprf.Visible = true;
        }

        private void btnshp_Click(object sender, EventArgs e)
        {
            Shop shp = new Shop();
            shp.Show();
            this.Hide();
        }
    }
}
