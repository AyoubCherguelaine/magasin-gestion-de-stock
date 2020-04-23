namespace Mgasin
{
    partial class Sell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Listb = new System.Windows.Forms.ListBox();
            this.ShowLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.button1.Location = new System.Drawing.Point(458, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.button2.Location = new System.Drawing.Point(458, 169);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "New Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Listb
            // 
            this.Listb.FormattingEnabled = true;
            this.Listb.ItemHeight = 16;
            this.Listb.Location = new System.Drawing.Point(3, 59);
            this.Listb.Name = "Listb";
            this.Listb.Size = new System.Drawing.Size(434, 340);
            this.Listb.TabIndex = 4;
            this.Listb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Listb_KeyDown);
            // 
            // ShowLab
            // 
            this.ShowLab.AutoSize = true;
            this.ShowLab.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.ShowLab.Location = new System.Drawing.Point(502, 273);
            this.ShowLab.Name = "ShowLab";
            this.ShowLab.Size = new System.Drawing.Size(0, 31);
            this.ShowLab.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.label1.Location = new System.Drawing.Point(239, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "facture :";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.Money.ForeColor = System.Drawing.Color.OrangeRed;
            this.Money.Location = new System.Drawing.Point(362, 13);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(21, 31);
            this.Money.TabIndex = 7;
            this.Money.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "N : new Client , B : sell";
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowLab);
            this.Controls.Add(this.Listb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sell";
            this.Size = new System.Drawing.Size(745, 421);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sell_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sell_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Sell_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Listb;
        private System.Windows.Forms.Label ShowLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Label label2;
    }
}
