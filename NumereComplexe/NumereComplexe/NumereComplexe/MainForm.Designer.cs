namespace NumereComplexe
{
    partial class MainForm
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
            this.camp_a = new System.Windows.Forms.TextBox();
            this.camp_b = new System.Windows.Forms.TextBox();
            this.camp_c = new System.Windows.Forms.TextBox();
            this.camp_d = new System.Windows.Forms.TextBox();
            this.btnRezolva = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // camp_a
            // 
            this.camp_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camp_a.Location = new System.Drawing.Point(58, 41);
            this.camp_a.Name = "camp_a";
            this.camp_a.Size = new System.Drawing.Size(163, 22);
            this.camp_a.TabIndex = 0;
            this.camp_a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // camp_b
            // 
            this.camp_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camp_b.Location = new System.Drawing.Point(58, 96);
            this.camp_b.Name = "camp_b";
            this.camp_b.Size = new System.Drawing.Size(163, 22);
            this.camp_b.TabIndex = 1;
            this.camp_b.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // camp_c
            // 
            this.camp_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camp_c.Location = new System.Drawing.Point(288, 41);
            this.camp_c.Name = "camp_c";
            this.camp_c.Size = new System.Drawing.Size(163, 22);
            this.camp_c.TabIndex = 2;
            // 
            // camp_d
            // 
            this.camp_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camp_d.Location = new System.Drawing.Point(289, 96);
            this.camp_d.Name = "camp_d";
            this.camp_d.Size = new System.Drawing.Size(163, 22);
            this.camp_d.TabIndex = 3;
            // 
            // btnRezolva
            // 
            this.btnRezolva.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRezolva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezolva.Location = new System.Drawing.Point(25, 143);
            this.btnRezolva.Name = "btnRezolva";
            this.btnRezolva.Size = new System.Drawing.Size(426, 74);
            this.btnRezolva.TabIndex = 4;
            this.btnRezolva.Text = "Rezolva";
            this.btnRezolva.UseVisualStyleBackColor = false;
            this.btnRezolva.Click += new System.EventHandler(this.btnRezolva_Click);
            // 
            // rez
            // 
            this.rez.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rez.Location = new System.Drawing.Point(17, 325);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(589, 263);
            this.rez.TabIndex = 5;
            this.rez.TextChanged += new System.EventHandler(this.rez_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "a=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "b=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(252, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "c=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(251, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "d=";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(20, 236);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(328, 25);
            this.label.TabIndex = 10;
            this.label.Text = "Introduceti coeficientii complecsi.";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.picBox.Location = new System.Drawing.Point(639, 36);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(600, 600);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 12;
            this.picBox.TabStop = false;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopToolStripMenuItem.Text = "stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(12, 20);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripMenuItem9});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1261, 24);
            this.mainMenu.TabIndex = 13;
            this.mainMenu.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1261, 661);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.btnRezolva);
            this.Controls.Add(this.camp_d);
            this.Controls.Add(this.camp_c);
            this.Controls.Add(this.camp_b);
            this.Controls.Add(this.camp_a);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ecuatia de gradul 3 cu coeficienti complecsi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComplexForm_FormClosing);
            this.Load += new System.EventHandler(this.ComplexForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComplexForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox camp_a;
        private System.Windows.Forms.TextBox camp_b;
        private System.Windows.Forms.TextBox camp_c;
        private System.Windows.Forms.TextBox camp_d;
        private System.Windows.Forms.Button btnRezolva;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.MenuStrip mainMenu;
    }
}