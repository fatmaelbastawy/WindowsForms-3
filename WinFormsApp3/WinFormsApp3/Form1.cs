namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
                label8.Visible = false;
            else
                label8.Visible = true;

            var userName = textBox1.Text;
            if (userName.Length < 5)
                label5.Visible = true;
            else
                label5.Visible = false;

            var email = textBox2.Text;
            if (email.Contains('@'))
                label6.Visible = false;
            else
                label6.Visible = true;

            if (userName.Length > 5 && email.Contains('@') == false && (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked) && (radioButton1.Checked || radioButton2.Checked))
            {
                label7.Visible = false;
            }
            else
                label7.Visible = true;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {





        }
    }
}
    
   
