using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nabava.Podaci;
using DBLayer;

namespace Nabava
{
    public partial class promjeni_stanje : Form
    {
        public promjeni_stanje()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void spremi_btn_Click(object sender, EventArgs e)
        {
            DB.SetConfiguration("huzjaknikola_baza", "huzjaknikola_baza", "nikola55");
            DB.OpenConnection();
            DB.ExecuteCommand("UPDATE dbo.zahtjevi SET dekan_potvrda=" + Convert.ToInt32(id_za_promjenu.Value) + " WHERE id= " + int.Parse(stanje_zahtjeva.Text.ToString()) + ";");
            DB.CloseConnection();
            MessageBox.Show("Obavijest", "Podaci su uneseni", MessageBoxButtons.OK);
            Lista_zahtjeva fr = new Lista_zahtjeva();
            Hide();
            fr.ShowDialog();
            Close();
        }
    }
}
