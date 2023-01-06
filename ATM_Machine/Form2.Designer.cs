namespace ATM_Machine
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.depo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enterAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentAmountBox = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // depo
            // 
            this.depo.BackColor = System.Drawing.Color.Silver;
            this.depo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depo.Location = new System.Drawing.Point(638, 269);
            this.depo.Name = "depo";
            this.depo.Size = new System.Drawing.Size(245, 81);
            this.depo.TabIndex = 0;
            this.depo.Text = "Deposit";
            this.depo.UseVisualStyleBackColor = false;
            this.depo.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(638, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Sub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(56, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current amount";
            // 
            // enterAmount
            // 
            this.enterAmount.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterAmount.Location = new System.Drawing.Point(56, 351);
            this.enterAmount.Multiline = true;
            this.enterAmount.Name = "enterAmount";
            this.enterAmount.Size = new System.Drawing.Size(400, 92);
            this.enterAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please Enter Amount and click deposit or withdraw";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(12, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 86);
            this.label3.TabIndex = 5;
            this.label3.Text = "$";
            // 
            // currentAmountBox
            // 
            this.currentAmountBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.currentAmountBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentAmountBox.Image = ((System.Drawing.Image)(resources.GetObject("currentAmountBox.Image")));
            this.currentAmountBox.Location = new System.Drawing.Point(300, 91);
            this.currentAmountBox.Name = "currentAmountBox";
            this.currentAmountBox.Size = new System.Drawing.Size(661, 31);
            this.currentAmountBox.TabIndex = 6;
            this.currentAmountBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.Silver;
            this.logOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOut.Location = new System.Drawing.Point(881, 722);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(91, 62);
            this.logOut.TabIndex = 7;
            this.logOut.Text = "Log out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.LogOut);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 796);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.currentAmountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.depo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button depo;
        private Button button1;
        private Label label1;
        private TextBox enterAmount;
        private Label label2;
        private Label label3;
        private Label currentAmountBox;
        private Button logOut;
    }
}