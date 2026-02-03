using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = label1.Text +":" + textBox1.Text;
            str += "\nFather's Name:" + textBox2.Text;
            str += "\nDate of Birth:" + dateTimePicker1.Text;
            str += "\nPreferences in Life:" + comboBox1.Text;
            MessageBox.Show(str);
        }
    }
}
