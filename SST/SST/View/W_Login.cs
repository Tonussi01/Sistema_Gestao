using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SST.View
{
    public partial class W_Login : Form
    {
        public W_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GU62G9L;Initial Catalog=sst_server;Integrated Security=True");  
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM ACESS WHERE usuario='" + textBox1.Text + "' AND senha='" + textBox2.Text + "'", con);
           
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                entrar();         
            }
            else
                MessageBox.Show("Usuario ou Senha inválidos");
        }        

        private void entrar()
        {
            
            W_Produtos form = new W_Produtos();
            form.Show();    

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void W_Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
