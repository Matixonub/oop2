using System;

namespace oop2
{
    public partial class Form1 : Form
    {
        private Person? person;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = FirstNameTextBox.Text;
                string lastName = LastNameTextBox.Text;
                string dateText = DateTextBox.Text;

                if (!DateTime.TryParse(dateText, out DateTime birthDate))
                {
                    MessageBox.Show("Netinkamas gimimo datos formatas. Naudokite yyyy-MM-dd formata.");
                    return;
                }

                person = new Person(firstName, lastName, birthDate);

                MessageBox.Show("Asmuo issaugotas sekmingai.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Klaida: {ex.Message}");
            }
        }

        private void GetPerson_Click(object sender, EventArgs e)
        {
            if (person == null)
            {
                MessageBox.Show("Pirmiausia reikia issaugoti asmeni!");
                return;
            }

            int age = person.GetAge();
            MessageBox.Show($"Asmens amzius: {age} metai.");
        }

        private void GetDaysTillBirthdayButton_Click(object sender, EventArgs e)
        {
            if (person == null)
            {
                MessageBox.Show("Pirmiausia reikia issaugoti asmeni!");
                return;
            }

            int DaysLeft = person.DaysUntilBirthday();
            MessageBox.Show($"Iki gimtadienio liko: {DaysLeft} dienu.");
        }
    }
}