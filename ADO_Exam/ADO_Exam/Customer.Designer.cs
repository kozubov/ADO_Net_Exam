namespace ADO_Exam
{
    partial class Customer
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
            this.label28 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_BuyerOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_BuyerFName = new System.Windows.Forms.TextBox();
            this.textBox_BuyerLName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label28.Location = new System.Drawing.Point(26, 27);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 19);
            this.label28.TabIndex = 5;
            this.label28.Text = "Buyer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "First Name";
            // 
            // button_BuyerOk
            // 
            this.button_BuyerOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_BuyerOk.Location = new System.Drawing.Point(274, 180);
            this.button_BuyerOk.Name = "button_BuyerOk";
            this.button_BuyerOk.Size = new System.Drawing.Size(82, 24);
            this.button_BuyerOk.TabIndex = 14;
            this.button_BuyerOk.Text = "Ok";
            this.button_BuyerOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Last Name";
            // 
            // textBox_BuyerFName
            // 
            this.textBox_BuyerFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_BuyerFName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BuyerFName.Location = new System.Drawing.Point(128, 70);
            this.textBox_BuyerFName.Name = "textBox_BuyerFName";
            this.textBox_BuyerFName.Size = new System.Drawing.Size(228, 23);
            this.textBox_BuyerFName.TabIndex = 17;
            // 
            // textBox_BuyerLName
            // 
            this.textBox_BuyerLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_BuyerLName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_BuyerLName.Location = new System.Drawing.Point(128, 116);
            this.textBox_BuyerLName.Name = "textBox_BuyerLName";
            this.textBox_BuyerLName.Size = new System.Drawing.Size(228, 23);
            this.textBox_BuyerLName.TabIndex = 18;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 227);
            this.Controls.Add(this.textBox_BuyerLName);
            this.Controls.Add(this.textBox_BuyerFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_BuyerOk);
            this.Controls.Add(this.label28);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_BuyerOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_BuyerFName;
        private System.Windows.Forms.TextBox textBox_BuyerLName;
    }
}