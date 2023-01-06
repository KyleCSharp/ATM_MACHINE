namespace ATM_Machine
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pin1 = new System.Windows.Forms.Button();
            this.pin4 = new System.Windows.Forms.Button();
            this.pin2 = new System.Windows.Forms.Button();
            this.pin3 = new System.Windows.Forms.Button();
            this.pin5 = new System.Windows.Forms.Button();
            this.pin6 = new System.Windows.Forms.Button();
            this.pin7 = new System.Windows.Forms.Button();
            this.pin8 = new System.Windows.Forms.Button();
            this.pin9 = new System.Windows.Forms.Button();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Yu Gothic", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(960, 43);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Kyle America Bank please enter your 4 digit pin";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(4, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(31, 61);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // pin1
            // 
            this.pin1.BackColor = System.Drawing.Color.Silver;
            this.pin1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pin1.Location = new System.Drawing.Point(201, 408);
            this.pin1.Name = "pin1";
            this.pin1.Size = new System.Drawing.Size(192, 82);
            this.pin1.TabIndex = 3;
            this.pin1.Text = "1";
            this.pin1.UseVisualStyleBackColor = false;
            this.pin1.Click += new System.EventHandler(this.button_Click);
            // 
            // pin4
            // 
            this.pin4.BackColor = System.Drawing.Color.Silver;
            this.pin4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pin4.Location = new System.Drawing.Point(201, 496);
            this.pin4.Name = "pin4";
            this.pin4.Size = new System.Drawing.Size(192, 82);
            this.pin4.TabIndex = 6;
            this.pin4.Text = "4";
            this.pin4.UseVisualStyleBackColor = false;
            this.pin4.Click += new System.EventHandler(this.button_Click);
            // 
            // pin2
            // 
            this.pin2.BackColor = System.Drawing.Color.Silver;
            this.pin2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pin2.Location = new System.Drawing.Point(399, 408);
            this.pin2.Name = "pin2";
            this.pin2.Size = new System.Drawing.Size(192, 82);
            this.pin2.TabIndex = 7;
            this.pin2.Text = "2";
            this.pin2.UseVisualStyleBackColor = false;
            this.pin2.Click += new System.EventHandler(this.button_Click);
            // 
            // pin3
            // 
            this.pin3.BackColor = System.Drawing.Color.Silver;
            this.pin3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pin3.Location = new System.Drawing.Point(597, 408);
            this.pin3.Name = "pin3";
            this.pin3.Size = new System.Drawing.Size(192, 82);
            this.pin3.TabIndex = 8;
            this.pin3.Text = "3";
            this.pin3.UseVisualStyleBackColor = false;
            this.pin3.Click += new System.EventHandler(this.button_Click);
            // 
            // pin5
            // 
            this.pin5.BackColor = System.Drawing.Color.Silver;
            this.pin5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pin5.Location = new System.Drawing.Point(399, 496);
            this.pin5.Name = "pin5";
            this.pin5.Size = new System.Drawing.Size(192, 82);
            this.pin5.TabIndex = 9;
            this.pin5.Text = "5";
            this.pin5.UseVisualStyleBackColor = false;
            this.pin5.Click += new System.EventHandler(this.button_Click);
            // 
            // pin6
            // 
            this.pin6.BackColor = System.Drawing.Color.Silver;
            this.pin6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pin6.Location = new System.Drawing.Point(597, 496);
            this.pin6.Name = "pin6";
            this.pin6.Size = new System.Drawing.Size(192, 82);
            this.pin6.TabIndex = 10;
            this.pin6.Text = "6";
            this.pin6.UseVisualStyleBackColor = false;
            this.pin6.Click += new System.EventHandler(this.button_Click);
            // 
            // pin7
            // 
            this.pin7.BackColor = System.Drawing.Color.Silver;
            this.pin7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin7.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pin7.Location = new System.Drawing.Point(201, 584);
            this.pin7.Name = "pin7";
            this.pin7.Size = new System.Drawing.Size(192, 82);
            this.pin7.TabIndex = 11;
            this.pin7.Text = "7";
            this.pin7.UseVisualStyleBackColor = false;
            this.pin7.Click += new System.EventHandler(this.button_Click);
            // 
            // pin8
            // 
            this.pin8.BackColor = System.Drawing.Color.Silver;
            this.pin8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin8.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pin8.Location = new System.Drawing.Point(399, 584);
            this.pin8.Name = "pin8";
            this.pin8.Size = new System.Drawing.Size(192, 82);
            this.pin8.TabIndex = 12;
            this.pin8.Text = "8";
            this.pin8.UseVisualStyleBackColor = false;
            this.pin8.Click += new System.EventHandler(this.button_Click);
            // 
            // pin9
            // 
            this.pin9.BackColor = System.Drawing.Color.Silver;
            this.pin9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pin9.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pin9.Location = new System.Drawing.Point(597, 584);
            this.pin9.Name = "pin9";
            this.pin9.Size = new System.Drawing.Size(192, 82);
            this.pin9.TabIndex = 13;
            this.pin9.Text = "9";
            this.pin9.UseVisualStyleBackColor = false;
            this.pin9.Click += new System.EventHandler(this.button_Click);
            // 
            // pinTextBox
            // 
            this.pinTextBox.BackColor = System.Drawing.Color.Silver;
            this.pinTextBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pinTextBox.Location = new System.Drawing.Point(201, 324);
            this.pinTextBox.Multiline = true;
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(588, 78);
            this.pinTextBox.TabIndex = 14;
            this.pinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pinTextBox.TextChanged += new System.EventHandler(this.pinTextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(201, 672);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(192, 82);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "CLAER";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 796);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.pin9);
            this.Controls.Add(this.pin8);
            this.Controls.Add(this.pin7);
            this.Controls.Add(this.pin6);
            this.Controls.Add(this.pin5);
            this.Controls.Add(this.pin3);
            this.Controls.Add(this.pin2);
            this.Controls.Add(this.pin4);
            this.Controls.Add(this.pin1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.welcomeLabel);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private MonthCalendar monthCalendar1;
        private Button pin1;
        private Button pin4;
        private Button pin2;
        private Button pin3;
        private Button pin5;
        private Button pin6;
        private Button pin7;
        private Button pin8;
        private Button pin9;
        private TextBox pinTextBox;
        private Button clearButton;
    }
}