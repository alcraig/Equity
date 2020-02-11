namespace Equity
{
    partial class frmMain
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
            this.inputAddress1 = new System.Windows.Forms.TextBox();
            this.inputAddress2 = new System.Windows.Forms.TextBox();
            this.inputTown = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputAddress1
            // 
            this.inputAddress1.Location = new System.Drawing.Point(91, 9);
            this.inputAddress1.Name = "inputAddress1";
            this.inputAddress1.Size = new System.Drawing.Size(100, 20);
            this.inputAddress1.TabIndex = 0;
            // 
            // inputAddress2
            // 
            this.inputAddress2.Location = new System.Drawing.Point(91, 35);
            this.inputAddress2.Name = "inputAddress2";
            this.inputAddress2.Size = new System.Drawing.Size(100, 20);
            this.inputAddress2.TabIndex = 1;
            // 
            // inputTown
            // 
            this.inputTown.Location = new System.Drawing.Point(91, 61);
            this.inputTown.Name = "inputTown";
            this.inputTown.Size = new System.Drawing.Size(100, 20);
            this.inputTown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Town";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inputCountry
            // 
            this.inputCountry.Location = new System.Drawing.Point(91, 87);
            this.inputCountry.Name = "inputCountry";
            this.inputCountry.Size = new System.Drawing.Size(100, 20);
            this.inputCountry.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Country";
            // 
            // buttonAddress
            // 
            this.buttonAddress.Location = new System.Drawing.Point(115, 114);
            this.buttonAddress.Name = "buttonAddress";
            this.buttonAddress.Size = new System.Drawing.Size(75, 23);
            this.buttonAddress.TabIndex = 8;
            this.buttonAddress.Text = "Submit";
            this.buttonAddress.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 152);
            this.Controls.Add(this.buttonAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTown);
            this.Controls.Add(this.inputAddress2);
            this.Controls.Add(this.inputAddress1);
            this.Name = "frmMain";
            this.Text = "Equity 1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputAddress1;
        private System.Windows.Forms.TextBox inputAddress2;
        private System.Windows.Forms.TextBox inputTown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddress;
    }
}