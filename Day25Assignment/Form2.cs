namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dob = dateTimePicker1.Value;
            TimeSpan tm = (DateTime.Now - dob);
            int age = (tm.Days / 365);
            MessageBox.Show($"{age}", "Your Age");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
