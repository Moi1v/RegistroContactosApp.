using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RegistroContactosApp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string TextBoxName = this.TextBoxName.Text;
            string TextboxNumberPhone = this.TextBoxPhone.Text;
            string TextBoxEmail = this.TextBoxEmail.Text;


            string Afirmative = "Asset";
            string Negative = "Error";
            string Results = TextBoxName;

            if (!string.IsNullOrWhiteSpace(TextBoxName)
                && !string.IsNullOrWhiteSpace(TextboxNumberPhone)
                && !string.IsNullOrWhiteSpace(TextBoxEmail)
                && TextBoxName.All(char.IsLetter)
                && TextboxNumberPhone.All(char.IsDigit))
            {
                this.Status.Text = ($"Status: {Afirmative.ToString()}");
                this.listBoxContacts.Items.Add($"Contact: {Results.ToString()}");
            }
            else
            {
                this.Status.Text = Negative.ToString();
            }

        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            this.TextBoxName.Clear();
            this.TextBoxPhone.Clear();
            this.TextBoxEmail.Clear();
            this.listBoxContacts.Items.Clear();
        }
    }
}
