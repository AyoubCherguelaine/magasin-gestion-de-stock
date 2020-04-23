namespace Mgasin
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sell_button = new System.Windows.Forms.Button();
            this.Stock_button = new System.Windows.Forms.Button();
            this.stockUI1 = new Mgasin.StockUI();
            this.sell1 = new Mgasin.Sell();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 29);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(938, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Sell_button);
            this.panel2.Controls.Add(this.Stock_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 426);
            this.panel2.TabIndex = 1;
            // 
            // Sell_button
            // 
            this.Sell_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sell_button.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.Sell_button.ForeColor = System.Drawing.Color.Black;
            this.Sell_button.Location = new System.Drawing.Point(4, 185);
            this.Sell_button.Margin = new System.Windows.Forms.Padding(4);
            this.Sell_button.Name = "Sell_button";
            this.Sell_button.Size = new System.Drawing.Size(175, 58);
            this.Sell_button.TabIndex = 3;
            this.Sell_button.Text = "Sell";
            this.Sell_button.UseVisualStyleBackColor = true;
            this.Sell_button.Click += new System.EventHandler(this.Sell_button_Click);
            // 
            // Stock_button
            // 
            this.Stock_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stock_button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_button.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Stock_button.Location = new System.Drawing.Point(4, 119);
            this.Stock_button.Margin = new System.Windows.Forms.Padding(4);
            this.Stock_button.Name = "Stock_button";
            this.Stock_button.Size = new System.Drawing.Size(175, 58);
            this.Stock_button.TabIndex = 2;
            this.Stock_button.Text = "Stock";
            this.Stock_button.UseVisualStyleBackColor = true;
            this.Stock_button.Click += new System.EventHandler(this.Stock_button_Click);
            // 
            // stockUI1
            // 
            this.stockUI1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stockUI1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.stockUI1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stockUI1.Location = new System.Drawing.Point(217, 29);
            this.stockUI1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stockUI1.Name = "stockUI1";
            this.stockUI1.Size = new System.Drawing.Size(745, 421);
            this.stockUI1.TabIndex = 2;
            this.stockUI1.Load += new System.EventHandler(this.stockUI1_Load);
            // 
            // sell1
            // 
            this.sell1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sell1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.sell1.Location = new System.Drawing.Point(217, 29);
            this.sell1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sell1.Name = "sell1";
            this.sell1.Size = new System.Drawing.Size(745, 421);
            this.sell1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1025, 455);
            this.Controls.Add(this.sell1);
            this.Controls.Add(this.stockUI1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Sell_button;
        private System.Windows.Forms.Button Stock_button;
        private System.Windows.Forms.Button button1;
        private StockUI stockUI1;
        private Sell sell1;
    }
}

