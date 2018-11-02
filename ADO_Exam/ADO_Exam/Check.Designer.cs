namespace ADO_Exam
{
    partial class Check
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
            this.listView1_Check = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.button_SellingYear = new System.Windows.Forms.Button();
            this.button_SellingMonth = new System.Windows.Forms.Button();
            this.button_SellingDay = new System.Windows.Forms.Button();
            this.button_SellingTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label28.Location = new System.Drawing.Point(29, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 19);
            this.label28.TabIndex = 9;
            this.label28.Text = "Selling";
            // 
            // listView1_Check
            // 
            this.listView1_Check.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1_Check.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.listView1_Check.FullRowSelect = true;
            this.listView1_Check.GridLines = true;
            this.listView1_Check.Location = new System.Drawing.Point(12, 61);
            this.listView1_Check.MultiSelect = false;
            this.listView1_Check.Name = "listView1_Check";
            this.listView1_Check.Size = new System.Drawing.Size(875, 330);
            this.listView1_Check.TabIndex = 10;
            this.listView1_Check.UseCompatibleStateImageBehavior = false;
            this.listView1_Check.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "DataSale ";
            this.columnHeader6.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Album";
            this.columnHeader2.Width = 204;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Singer";
            this.columnHeader3.Width = 173;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Buyer_FirstName";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Buyer_LastName";
            this.columnHeader5.Width = 123;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Summ";
            this.columnHeader7.Width = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(507, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Selling per";
            // 
            // button_SellingYear
            // 
            this.button_SellingYear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SellingYear.Location = new System.Drawing.Point(818, 23);
            this.button_SellingYear.Name = "button_SellingYear";
            this.button_SellingYear.Size = new System.Drawing.Size(69, 24);
            this.button_SellingYear.TabIndex = 14;
            this.button_SellingYear.Text = "Year";
            this.button_SellingYear.UseVisualStyleBackColor = true;
            // 
            // button_SellingMonth
            // 
            this.button_SellingMonth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SellingMonth.Location = new System.Drawing.Point(743, 23);
            this.button_SellingMonth.Name = "button_SellingMonth";
            this.button_SellingMonth.Size = new System.Drawing.Size(69, 24);
            this.button_SellingMonth.TabIndex = 15;
            this.button_SellingMonth.Text = "Month";
            this.button_SellingMonth.UseVisualStyleBackColor = true;
            // 
            // button_SellingDay
            // 
            this.button_SellingDay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SellingDay.Location = new System.Drawing.Point(668, 23);
            this.button_SellingDay.Name = "button_SellingDay";
            this.button_SellingDay.Size = new System.Drawing.Size(69, 24);
            this.button_SellingDay.TabIndex = 16;
            this.button_SellingDay.Text = "Day";
            this.button_SellingDay.UseVisualStyleBackColor = true;
            // 
            // button_SellingTotal
            // 
            this.button_SellingTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SellingTotal.Location = new System.Drawing.Point(593, 23);
            this.button_SellingTotal.Name = "button_SellingTotal";
            this.button_SellingTotal.Size = new System.Drawing.Size(69, 24);
            this.button_SellingTotal.TabIndex = 17;
            this.button_SellingTotal.Text = "Total";
            this.button_SellingTotal.UseVisualStyleBackColor = true;
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 410);
            this.Controls.Add(this.button_SellingTotal);
            this.Controls.Add(this.button_SellingDay);
            this.Controls.Add(this.button_SellingMonth);
            this.Controls.Add(this.button_SellingYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1_Check);
            this.Controls.Add(this.label28);
            this.Name = "Check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ListView listView1_Check;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_SellingYear;
        private System.Windows.Forms.Button button_SellingMonth;
        private System.Windows.Forms.Button button_SellingDay;
        private System.Windows.Forms.Button button_SellingTotal;
    }
}