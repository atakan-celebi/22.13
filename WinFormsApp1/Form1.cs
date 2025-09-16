namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float ms))
            {
                float kmh = ms * 3.6f;
                label1.Text = kmh.ToString("F2");
                textBox1.BackColor = Color.White;
            }
            else
            {               
                textBox1.BackColor = Color.Red;
            }
        }
    } }

