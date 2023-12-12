namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;



        private void clear_Click(object sender, EventArgs e)
        {
            output.Clear();
            count = 0;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 0;
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void point_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + ".";
        }


        private void one_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 3;
        }



        private void four_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 9;
        }

        private void times_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(output.Text);
            output.Clear();
            output.Focus();
            count = 3;
        }
        private void plus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(output.Text);
            output.Clear();
            output.Focus();
            count = 2;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (output.Text != "")
            {
                num1 = float.Parse(output.Text);
                output.Clear();
                output.Focus();
                count = 1;
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(output.Text);
            output.Clear();
            output.Focus();
            count = 4;
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(output.Text);
                    output.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(output.Text);
                    output.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(output.Text);
                    output.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(output.Text);
                    output.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
