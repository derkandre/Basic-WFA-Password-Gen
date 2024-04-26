using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PasswordGenWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Length_Click(object sender, EventArgs e)
        {

        }

        private void outputField_Click(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            outputField.Text = GeneratePassword();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form1 home = new Form1();
            About about = new About();


            if (e.ClickedItem == aboutToolStripMenuItem)
            {
                about.Show();
            }
            else;
            {
                
            }
        }
        public static bool IsOpen = false;
        private string GeneratePassword()
        {
            List<char> lowercase = new List<char>();
            lowercase = "abcdefghijklmnopqrstuvwxyz".ToList();
            List<char> uppercase = new List<char>();
            uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
            List<char> numbers = new List<char>();
            numbers = "1234567890".ToList();
            List<char> symbols = new List<char>();
            symbols = "~`!@#$%^&*()_-+=[]\\/:;<>,.".ToList();

            Random random = new Random();
            
            StringBuilder password = new StringBuilder();

            try
            {
                if (lengthField.Value > 17 || lengthField.Value < 1)
                    throw new Exception("Please input only from 1-17.");

                for (int i = 0; i < (int)lengthField.Value; i++)
                {
                    int choice = random.Next(0, 4);

                    if (choice == 0)
                    {
                        choice = random.Next(lowercase.Count);
                        password.Append(lowercase[choice]);
                    }
                    else if (choice == 1)
                    {
                        choice = random.Next(uppercase.Count);
                        password.Append(uppercase[choice]);
                    }
                    else if (choice == 2)
                    {
                        choice = random.Next(numbers.Count);
                        password.Append(numbers[choice]);
                    }
                    else
                    {
                        choice = random.Next(symbols.Count);
                        password.Append(symbols[choice]);
                    }
                }

                if (lengthField.Value < 8)
                {
                    outputField.ForeColor = Color.Black;
                    outputField.BackColor = Color.Yellow;
                    panel2.BackColor = Color.Yellow;
                }
                else
                {
                    outputField.BackColor = Color.Green;
                    outputField.ForeColor = Color.White;
                    panel2.BackColor = Color.Green;
                }

                return password.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                outputField.BackColor = Color.White;
                panel2.BackColor = Color.White;
                outputField.ForeColor = Color.Red;

                return "            Try Again";
            }
        }
    }
}
