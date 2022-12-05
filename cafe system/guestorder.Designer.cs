
namespace cafe_system
{
    partial class guestorder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemsGV = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.Label();
            this.sellername = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderGV = new System.Windows.Forms.DataGridView();
            this.catg = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.itemsGV);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.sellername);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.number);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.orderGV);
            this.panel1.Controls.Add(this.catg);
            this.panel1.Location = new System.Drawing.Point(36, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 678);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cafe_system.Properties.Resources.refresh_flat_pink_color_icon_vector_60808041;
            this.pictureBox1.Location = new System.Drawing.Point(201, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // itemsGV
            // 
            this.itemsGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.itemsGV.Location = new System.Drawing.Point(441, 114);
            this.itemsGV.Name = "itemsGV";
            this.itemsGV.RowHeadersWidth = 62;
            this.itemsGV.RowTemplate.Height = 28;
            this.itemsGV.Size = new System.Drawing.Size(679, 254);
            this.itemsGV.TabIndex = 20;
            this.itemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsGV_CellContentClick);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.DeepPink;
            this.date.Location = new System.Drawing.Point(899, 61);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(221, 50);
            this.date.TabIndex = 19;
            this.date.Text = "Date";
            // 
            // sellername
            // 
            this.sellername.ForeColor = System.Drawing.Color.DeepPink;
            this.sellername.Location = new System.Drawing.Point(181, 251);
            this.sellername.Name = "sellername";
            this.sellername.ReadOnly = true;
            this.sellername.Size = new System.Drawing.Size(195, 26);
            this.sellername.TabIndex = 17;
            this.sellername.Text = "Guset";
            // 
            // quantity
            // 
            this.quantity.ForeColor = System.Drawing.Color.DeepPink;
            this.quantity.Location = new System.Drawing.Point(22, 493);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(195, 26);
            this.quantity.TabIndex = 16;
            // 
            // number
            // 
            this.number.ForeColor = System.Drawing.Color.DeepPink;
            this.number.Location = new System.Drawing.Point(181, 204);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(195, 26);
            this.number.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepPink;
            this.label8.Location = new System.Drawing.Point(444, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 50);
            this.label8.TabIndex = 14;
            this.label8.Text = "Your Order";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(581, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 55);
            this.button2.TabIndex = 13;
            this.button2.Text = "Place The Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(508, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "place order";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(22, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepPink;
            this.label7.Location = new System.Drawing.Point(17, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 50);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity";
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.DeepPink;
            this.amount.Location = new System.Drawing.Point(834, 602);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(190, 50);
            this.amount.TabIndex = 10;
            this.amount.Text = "Order Amount";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(17, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seller Name";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(19, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 50);
            this.label4.TabIndex = 8;
            this.label4.Text = "Order Number";
            // 
            // orderGV
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DeepPink;
            this.orderGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.orderGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orderGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.orderGV.Location = new System.Drawing.Point(441, 424);
            this.orderGV.Name = "orderGV";
            this.orderGV.RowHeadersWidth = 62;
            this.orderGV.RowTemplate.Height = 28;
            this.orderGV.Size = new System.Drawing.Size(679, 151);
            this.orderGV.TabIndex = 5;
            // 
            // catg
            // 
            this.catg.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catg.ForeColor = System.Drawing.Color.DeepPink;
            this.catg.FormattingEnabled = true;
            this.catg.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.catg.Location = new System.Drawing.Point(26, 151);
            this.catg.Name = "catg";
            this.catg.Size = new System.Drawing.Size(169, 36);
            this.catg.TabIndex = 4;
            this.catg.Text = "Category";
            this.catg.SelectionChangeCommitted += new System.EventHandler(this.catg_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(1215, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 50);
            this.label9.TabIndex = 15;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(1018, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "JD";
            // 
            // guestorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1362, 892);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "guestorder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "itemform";
            this.Load += new System.EventHandler(this.guestorder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView itemsGV;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox sellername;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView orderGV;
        private System.Windows.Forms.ComboBox catg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}