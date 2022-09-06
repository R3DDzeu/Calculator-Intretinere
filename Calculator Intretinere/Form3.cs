using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Intretinere
{
    public partial class Form3 : Form
    {
        Form1 frm;
        public Form3(Form1 fr)
        {
            InitializeComponent();
            frm= fr;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
