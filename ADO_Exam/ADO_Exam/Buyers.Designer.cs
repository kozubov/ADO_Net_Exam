namespace ADO_Exam
{
    partial class Buyers
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
            this.listView1_Buyers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label28 = new System.Windows.Forms.Label();
            this.button_BuyersOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1_Buyers
            // 
            this.listView1_Buyers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1_Buyers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1_Buyers.FullRowSelect = true;
            this.listView1_Buyers.GridLines = true;
            this.listView1_Buyers.Location = new System.Drawing.Point(12, 81);
            this.listView1_Buyers.MultiSelect = false;
            this.listView1_Buyers.Name = "listView1_Buyers";
            this.listView1_Buyers.Size = new System.Drawing.Size(762, 330);
            this.listView1_Buyers.TabIndex = 4;
            this.listView1_Buyers.UseCompatibleStateImageBehavior = false;
            this.listView1_Buyers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FirstName";
            this.columnHeader2.Width = 260;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LastName";
            this.columnHeader3.Width = 229;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity_Buy";
            this.columnHeader4.Width = 162;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label28.Location = new System.Drawing.Point(12, 25);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 19);
            this.label28.TabIndex = 5;
            this.label28.Text = "Buyers";
            // 
            // button_BuyersOk
            // 
            this.button_BuyersOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_BuyersOk.Location = new System.Drawing.Point(705, 37);
            this.button_BuyersOk.Name = "button_BuyersOk";
            this.button_BuyersOk.Size = new System.Drawing.Size(69, 24);
            this.button_BuyersOk.TabIndex = 14;
            this.button_BuyersOk.Text = "Ok";
            this.button_BuyersOk.UseVisualStyleBackColor = true;
            // 
            // Buyers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 428);
            this.Controls.Add(this.button_BuyersOk);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.listView1_Buyers);
            this.Name = "Buyers";
            this.Text = "Buyers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1_Buyers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button_BuyersOk;
    }
}