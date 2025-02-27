namespace tutoria_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Label AverageLabel1 { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            double distance, gas, average;
            if (double.TryParse(distanceTextBox.Text, out distance))
            {
                if (double.TryParse(gasTextBox.Text, out gas))
                {
                    average = distance / gas;
                    averageLabel1.Text = "¥­§¡ªo¯Ó:" + average.ToString("f2") + "¤½¤É/¤½¨½";
                    ¥­§¡ªo¯Ó¬ö¿ý.Items.Add(average.ToString("f2") + "¤½¤É/¤½¨½");
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for gas");
                    gasTextBox.Focus();
                    distanceTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number for distance");
                distanceTextBox.Focus();
                gasTextBox.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ¥­§¡ªo¯Ó¬ö¿ý.Items.Clear();
            ¥­§¡ªo¯Ó¬ö¿ý.Items.Add("¥­§¡ªo¯Ó¬ö¿ý");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (¥­§¡ªo¯Ó¬ö¿ý.Items.Count > 1)
            {
                double sum = 0;
                for (int i = 1; i < ¥­§¡ªo¯Ó¬ö¿ý.Items.Count; i++)
                {
                    sum += double.Parse(¥­§¡ªo¯Ó¬ö¿ý.Items[i].ToString().Replace("¤½¤É/¤½¨½", ""));
                }
                ¥­§¡ªo¯Ó¬ö¿ý.Items.Add("¥­§¡ªo¯Ó:" + (sum / (¥­§¡ªo¯Ó¬ö¿ý.Items.Count - 1)).ToString("f2") + "¤½¤É/¤½¨½");
            }
            else
            {
                MessageBox.Show("¨S¦³¬ö¿ý");
            }
        }
    }
        }
    

