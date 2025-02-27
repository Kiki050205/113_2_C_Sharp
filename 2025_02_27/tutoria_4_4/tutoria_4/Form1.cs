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
                    averageLabel1.Text = "�����o��:" + average.ToString("f2") + "����/����";
                    �����o�Ӭ���.Items.Add(average.ToString("f2") + "����/����");
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
            �����o�Ӭ���.Items.Clear();
            �����o�Ӭ���.Items.Add("�����o�Ӭ���");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (�����o�Ӭ���.Items.Count > 1)
            {
                double sum = 0;
                for (int i = 1; i < �����o�Ӭ���.Items.Count; i++)
                {
                    sum += double.Parse(�����o�Ӭ���.Items[i].ToString().Replace("����/����", ""));
                }
                �����o�Ӭ���.Items.Add("�����o��:" + (sum / (�����o�Ӭ���.Items.Count - 1)).ToString("f2") + "����/����");
            }
            else
            {
                MessageBox.Show("�S������");
            }
        }
    }
        }
    

