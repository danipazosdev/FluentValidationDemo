
namespace FluentValidationDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ValidateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PlateTextBox = new System.Windows.Forms.TextBox();
            this.LastnameTextBox = new System.Windows.Forms.TextBox();
            this.ErrorTextBox = new System.Windows.Forms.TextBox();
            this.HasCarCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ValidateButton
            // 
            this.ValidateButton.Location = new System.Drawing.Point(54, 259);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(113, 31);
            this.ValidateButton.TabIndex = 0;
            this.ValidateButton.Text = "Validar";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Matricula";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(31, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(169, 23);
            this.NameTextBox.TabIndex = 4;
            // 
            // PlateTextBox
            // 
            this.PlateTextBox.Location = new System.Drawing.Point(133, 196);
            this.PlateTextBox.Name = "PlateTextBox";
            this.PlateTextBox.Size = new System.Drawing.Size(67, 23);
            this.PlateTextBox.TabIndex = 5;
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.Location = new System.Drawing.Point(31, 87);
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.Size = new System.Drawing.Size(167, 23);
            this.LastnameTextBox.TabIndex = 6;
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.Location = new System.Drawing.Point(288, 38);
            this.ErrorTextBox.Multiline = true;
            this.ErrorTextBox.Name = "ErrorTextBox";
            this.ErrorTextBox.Size = new System.Drawing.Size(295, 252);
            this.ErrorTextBox.TabIndex = 7;
            // 
            // HasCarCheckBox
            // 
            this.HasCarCheckBox.AutoSize = true;
            this.HasCarCheckBox.Location = new System.Drawing.Point(33, 200);
            this.HasCarCheckBox.Name = "HasCarCheckBox";
            this.HasCarCheckBox.Size = new System.Drawing.Size(94, 19);
            this.HasCarCheckBox.TabIndex = 8;
            this.HasCarCheckBox.Text = "Tiene coche?";
            this.HasCarCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Errores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDatePicker.Location = new System.Drawing.Point(33, 142);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(109, 23);
            this.BirthDatePicker.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 303);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HasCarCheckBox);
            this.Controls.Add(this.ErrorTextBox);
            this.Controls.Add(this.LastnameTextBox);
            this.Controls.Add(this.PlateTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValidateButton);
            this.Name = "Form1";
            this.Text = "Fluent validation demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PlateTextBox;
        private System.Windows.Forms.TextBox LastnameTextBox;
        private System.Windows.Forms.TextBox ErrorTextBox;
        private System.Windows.Forms.CheckBox HasCarCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
    }
}

