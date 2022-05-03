using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M001Cargo
{
    public partial class Dashboard : Form
    {
        CargoDbContext db = new();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var countries = db.Countries.ToList();
            var packages = db.Packages.ToList();

            foreach (var package in packages)
            {
                cmbPackages.Items.Add(package.Name);
            }

            foreach (var country in countries)
            {
                cmbCountry.Items.Add(country.Name);
            }
        }

       
    }
}
