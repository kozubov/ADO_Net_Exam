namespace ADO_Exam
{
    partial class Shop_Edit
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
            this.listView1_Disc = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Izdat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltrec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label28 = new System.Windows.Forms.Label();
            this.button_AddSinger = new System.Windows.Forms.Button();
            this.button_EditSinger = new System.Windows.Forms.Button();
            this.button_DeleteSinger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1_Disc
            // 
            this.listView1_Disc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1_Disc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Pic,
            this.disc,
            this.colect,
            this.Izdat,
            this.coltrec,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1_Disc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1_Disc.FullRowSelect = true;
            this.listView1_Disc.GridLines = true;
            this.listView1_Disc.Location = new System.Drawing.Point(12, 71);
            this.listView1_Disc.MultiSelect = false;
            this.listView1_Disc.Name = "listView1_Disc";
            this.listView1_Disc.Size = new System.Drawing.Size(991, 318);
            this.listView1_Disc.TabIndex = 3;
            this.listView1_Disc.UseCompatibleStateImageBehavior = false;
            this.listView1_Disc.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 31;
            // 
            // Pic
            // 
            this.Pic.Text = "Cover";
            this.Pic.Width = 130;
            // 
            // disc
            // 
            this.disc.Text = "Title";
            this.disc.Width = 129;
            // 
            // colect
            // 
            this.colect.Text = "Singer";
            this.colect.Width = 144;
            // 
            // Izdat
            // 
            this.Izdat.Text = "Publisher ";
            this.Izdat.Width = 103;
            // 
            // coltrec
            // 
            this.coltrec.Text = "Tracks";
            this.coltrec.Width = 55;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Genre ";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DatePublishing ";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Income_Price";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price ";
            this.columnHeader4.Width = 89;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label28.Location = new System.Drawing.Point(8, 23);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 19);
            this.label28.TabIndex = 4;
            this.label28.Text = "Shop Edit";
            // 
            // button_AddSinger
            // 
            this.button_AddSinger.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddSinger.Location = new System.Drawing.Point(934, 18);
            this.button_AddSinger.Name = "button_AddSinger";
            this.button_AddSinger.Size = new System.Drawing.Size(69, 24);
            this.button_AddSinger.TabIndex = 10;
            this.button_AddSinger.Text = "Add";
            this.button_AddSinger.UseVisualStyleBackColor = true;
            // 
            // button_EditSinger
            // 
            this.button_EditSinger.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EditSinger.Location = new System.Drawing.Point(850, 18);
            this.button_EditSinger.Name = "button_EditSinger";
            this.button_EditSinger.Size = new System.Drawing.Size(69, 24);
            this.button_EditSinger.TabIndex = 11;
            this.button_EditSinger.Text = "Edit";
            this.button_EditSinger.UseVisualStyleBackColor = true;
            // 
            // button_DeleteSinger
            // 
            this.button_DeleteSinger.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_DeleteSinger.Location = new System.Drawing.Point(766, 18);
            this.button_DeleteSinger.Name = "button_DeleteSinger";
            this.button_DeleteSinger.Size = new System.Drawing.Size(69, 24);
            this.button_DeleteSinger.TabIndex = 12;
            this.button_DeleteSinger.Text = "Delete";
            this.button_DeleteSinger.UseVisualStyleBackColor = true;
            // 
            // Shop_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 404);
            this.Controls.Add(this.button_DeleteSinger);
            this.Controls.Add(this.button_EditSinger);
            this.Controls.Add(this.button_AddSinger);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.listView1_Disc);
            this.Name = "Shop_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop_Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1_Disc;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Pic;
        private System.Windows.Forms.ColumnHeader disc;
        private System.Windows.Forms.ColumnHeader colect;
        private System.Windows.Forms.ColumnHeader Izdat;
        private System.Windows.Forms.ColumnHeader coltrec;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button_AddSinger;
        private System.Windows.Forms.Button button_EditSinger;
        private System.Windows.Forms.Button button_DeleteSinger;
    }
}