using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator_Intretinere
{
    public partial class Form1 : Form
    {
        Form2 frm;
        Form3 frm1;
        double pret;
        double test;
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            frm = new Form2(this);
            frm1 = new Form3(this);
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\stoic\source\repos\Calculator Intretinere\Calculator Intretinere\Database1.mdf"";Integrated Security=True");
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\stoic\source\repos\Calculator Intretinere\Calculator Intretinere\Database1.mdf";Integrated Security=True
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pret = double.Parse(textBox1.Text); 
        }

        private void calculeazaConsum()
        {
            con.Open();
            string selectquery = "SELECT SUM(ore*consum) AS cTotal FROM [dbo].[Table]";
            SqlCommand cmd = new SqlCommand(selectquery, con);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {

                test = double.Parse(reader1.GetValue(0).ToString());
                Console.WriteLine(reader1.GetValue(0).ToString());
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            calculeazaConsum();
           textBox2.Text = (test * pret).ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
