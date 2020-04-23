namespace Mgasin
{
    partial class AddCharge
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Name_Pro = new System.Windows.Forms.Label();
            this.Marque_Pro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextDD = new System.Windows.Forms.TextBox();
            this.TextMM = new System.Windows.Forms.TextBox();
            this.TextYY = new System.Windows.Forms.TextBox();
            this.TextQua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name_Pro
            // 
            this.Name_Pro.AutoSize = true;
            this.Name_Pro.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.Name_Pro.Location = new System.Drawing.Point(112, 111);
            this.Name_Pro.Name = "Name_Pro";
            this.Name_Pro.Size = new System.Drawing.Size(60, 21);
            this.Name_Pro.TabIndex = 10;
            this.Name_Pro.Text = "label2";
            this.Name_Pro.Click += new System.EventHandler(this.Name_Pro_Click);
            // 
            // Marque_Pro
            // 
            this.Marque_Pro.AutoSize = true;
            this.Marque_Pro.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.Marque_Pro.Location = new System.Drawing.Point(112, 165);
            this.Marque_Pro.Name = "Marque_Pro";
            this.Marque_Pro.Size = new System.Drawing.Size(60, 21);
            this.Marque_Pro.TabIndex = 11;
            this.Marque_Pro.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.Location = new System.Drawing.Point(301, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "YY/MM/DD";
            // 
            // TextDD
            // 
            this.TextDD.Location = new System.Drawing.Point(268, 347);
            this.TextDD.Name = "TextDD";
            this.TextDD.Size = new System.Drawing.Size(27, 21);
            this.TextDD.TabIndex = 30;
            // 
            // TextMM
            // 
            this.TextMM.Location = new System.Drawing.Point(235, 347);
            this.TextMM.Name = "TextMM";
            this.TextMM.Size = new System.Drawing.Size(27, 21);
            this.TextMM.TabIndex = 29;
            // 
            // TextYY
            // 
            this.TextYY.Location = new System.Drawing.Point(202, 347);
            this.TextYY.Name = "TextYY";
            this.TextYY.Size = new System.Drawing.Size(27, 21);
            this.TextYY.TabIndex = 28;
            this.TextYY.TextChanged += new System.EventHandler(this.TextYY_TextChanged_1);
            // 
            // TextQua
            // 
            this.TextQua.Location = new System.Drawing.Point(202, 306);
            this.TextQua.Name = "TextQua";
            this.TextQua.Size = new System.Drawing.Size(56, 21);
            this.TextQua.TabIndex = 27;
            this.TextQua.TextChanged += new System.EventHandler(this.TextQua_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label7.Location = new System.Drawing.Point(122, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Date Ex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label6.Location = new System.Drawing.Point(122, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Quatite";
            // 
            // Next
            // 
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Location = new System.Drawing.Point(12, 459);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(466, 33);
            this.Next.TabIndex = 32;
            this.Next.Text = "Save";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // AddCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 504);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextDD);
            this.Controls.Add(this.TextMM);
            this.Controls.Add(this.TextYY);
            this.Controls.Add(this.TextQua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Marque_Pro);
            this.Controls.Add(this.Name_Pro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCharge";
            this.Text = "AddCharge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Name_Pro;
        private System.Windows.Forms.Label Marque_Pro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextDD;
        private System.Windows.Forms.TextBox TextMM;
        private System.Windows.Forms.TextBox TextYY;
        private System.Windows.Forms.TextBox TextQua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Next;
    }
}