namespace Rock__Paper__Scissor_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //Adding Form2 when Button is Click
            form2.Show(); //Show Form2
            this.Hide(); //Hiding Form1
        }
    }
}