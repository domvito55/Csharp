using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace PrimeMinisters
{
    public partial class frmPrimeMinisters : Form
    {
        //Dictionary
        private Dictionary<string, PrimeMinister> primeMinisters =
            new Dictionary<string, PrimeMinister>();
        public frmPrimeMinisters()
        {
            InitializeComponent();
        }

        private void frmPrimeMinisters_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("../../../lab10-files/PrimeMinisters.json");
            primeMinisters =
                JsonSerializer.Deserialize
                <Dictionary<string, PrimeMinister>>(file.ReadToEnd());

            lstPrimeMinisters.DataSource = primeMinisters.Keys.ToList<string>();
        }

        private void lstPrimeMinisters_SelectedValueChanged(object sender, EventArgs e)
        {
            PrimeMinister aMinister;
            aMinister = primeMinisters[lstPrimeMinisters.SelectedValue.ToString()];

            lblName.Text = aMinister.FirstName + " " + aMinister.LastName;
            lblTerm.Text = aMinister.Term;
            lblParty.Text = aMinister.Party;
            picPhoto.ImageLocation = "../../../lab10-files/" + aMinister.LastName + ".jpg";
        }
    }
}
