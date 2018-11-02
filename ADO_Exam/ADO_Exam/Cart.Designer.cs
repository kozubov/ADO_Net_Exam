namespace ADO_Exam
{
    partial class Cart
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
            this.listBox_Cart = new System.Windows.Forms.ListBox();
            this.label28 = new System.Windows.Forms.Label();
            this.button_CartDelete = new System.Windows.Forms.Button();
            this.button_CartOk = new System.Windows.Forms.Button();
            this.label_TotalCart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Cart
            // 
            this.listBox_Cart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Cart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Cart.FormattingEnabled = true;
            this.listBox_Cart.ItemHeight = 16;
            this.listBox_Cart.Location = new System.Drawing.Point(26, 52);
            this.listBox_Cart.Name = "listBox_Cart";
            this.listBox_Cart.Size = new System.Drawing.Size(512, 178);
            this.listBox_Cart.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label28.Location = new System.Drawing.Point(22, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 19);
            this.label28.TabIndex = 4;
            this.label28.Text = "Cart";
            // 
            // button_CartDelete
            // 
            this.button_CartDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CartDelete.Location = new System.Drawing.Point(337, 289);
            this.button_CartDelete.Name = "button_CartDelete";
            this.button_CartDelete.Size = new System.Drawing.Size(82, 24);
            this.button_CartDelete.TabIndex = 11;
            this.button_CartDelete.Text = "Delete";
            this.button_CartDelete.UseVisualStyleBackColor = true;
            // 
            // button_CartOk
            // 
            this.button_CartOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_CartOk.Location = new System.Drawing.Point(456, 289);
            this.button_CartOk.Name = "button_CartOk";
            this.button_CartOk.Size = new System.Drawing.Size(82, 24);
            this.button_CartOk.TabIndex = 12;
            this.button_CartOk.Text = "Order";
            this.button_CartOk.UseVisualStyleBackColor = true;
            // 
            // label_TotalCart
            // 
            this.label_TotalCart.AutoSize = true;
            this.label_TotalCart.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TotalCart.Location = new System.Drawing.Point(382, 256);
            this.label_TotalCart.Name = "label_TotalCart";
            this.label_TotalCart.Size = new System.Drawing.Size(15, 16);
            this.label_TotalCart.TabIndex = 14;
            this.label_TotalCart.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(334, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total:";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 338);
            this.Controls.Add(this.label_TotalCart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_CartOk);
            this.Controls.Add(this.button_CartDelete);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.listBox_Cart);
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Cart;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button_CartDelete;
        private System.Windows.Forms.Button button_CartOk;
        private System.Windows.Forms.Label label_TotalCart;
        private System.Windows.Forms.Label label4;
    }
}