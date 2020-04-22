using System;
using System.Windows.Forms;

namespace areyesram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void numPage_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            numPage.Value = 1;
            RefreshData();
        }

        private void RefreshData()
        {
            var filter = txtFilter.Text;
            var page = (int)numPage.Value - 1;
            numPage.Maximum = Math.Ceiling((decimal)DB.Person.Count(filter) / Config.RowsPerPage);
            gridPersons.DataSource = DB.Person.List(page, filter);
        }
    }
}
