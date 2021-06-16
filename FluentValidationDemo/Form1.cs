using FluentValidation.Results;
using System;
using System.Windows.Forms;

/// <summary>
/// Código de ejemplo para el artículo de "Valida tu modelo de datos con FluentValidation en C#" en Mi local funciona
/// https://enmilocalfuncion.io/valida-tu-modelo-de-datos-con-fluentvalidation-en-c
/// </summary>
namespace FluentValidationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            ErrorTextBox.Clear();

            var user = new UserModel()
            {
                Name = NameTextBox.Text,
                LastName = LastnameTextBox.Text,
                BirthDate= BirthDatePicker.Value,
                HasCar = HasCarCheckBox.Checked,
                PlateNumber = PlateTextBox.Text
            };

            var validator = new UserValidator();

            ValidationResult result = validator.Validate(user);

            if (result.IsValid)
            {
                ErrorTextBox.AppendText("Todo correcto");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ErrorTextBox.AppendText(error.ErrorMessage);
                    ErrorTextBox.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
