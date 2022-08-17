using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_ENTRADAS
{

    public partial class REG_ENTR : Form
    {
        public REG_ENTR()
        {
            InitializeComponent();
        }

        private void bt_adm_Click(object sender, EventArgs e)
        {
            pn_gingreso.Visible = true;
            bt_adm.Visible = false;
            pn_reg.Visible = false;
            bt_reg.Visible = true;

        }

        private void bt_csu_Click(object sender, EventArgs e)
        {
            pn_gingreso.Visible = false;
            bt_adm.Visible = true;
        }

        private void bt_lg_Click(object sender, EventArgs e)
        {
            if ((tb_us.Text == "ADM") && (tb_usc.Text == "TUE01"))
            {
                pn_admc.Visible = true;
                tb_us.Text = "";
                tb_usc.Text = "";
                pn_gingreso.Visible = false;
            }
            else
            {
                tb_us.Text = "";
                tb_usc.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pn_admc.Visible = false;
            bt_adm.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pn_nueus.Visible = false;
            bt_nu.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pn_breg.Visible = false;
            bt_bu.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pn_reg.Visible = true;
            pn_gingreso.Visible = false;
            pn_admc.Visible = false;
            bt_reg.Visible = false;
            bt_adm.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pn_reg.Visible = false;
            bt_reg.Visible = true;
        }

        private void bt_bu_Click(object sender, EventArgs e)
        {
            pn_breg.Visible = true;
            bt_bu.Visible = false;
            pn_nueus.Visible = false;
            bt_nu.Visible = true;
        }
        private void bt_nu_Click(object sender, EventArgs e)
        {
            pn_nueus.Visible = true;
            pn_breg.Visible = false;
            bt_nu.Visible = false;
            bt_bu.Visible = true;
        }
    }
}
