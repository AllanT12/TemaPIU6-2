namespace FORMULAR
{
    partial class admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCauta = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Salvare_ca_excel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saortareDupaBugetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saraciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bogatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(20, 438);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 1;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 441);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Salvare_ca_excel
            // 
            this.Salvare_ca_excel.Location = new System.Drawing.Point(532, 438);
            this.Salvare_ca_excel.Name = "Salvare_ca_excel";
            this.Salvare_ca_excel.Size = new System.Drawing.Size(114, 23);
            this.Salvare_ca_excel.TabIndex = 3;
            this.Salvare_ca_excel.Text = "Salvare ca excel";
            this.Salvare_ca_excel.UseVisualStyleBackColor = true;
            this.Salvare_ca_excel.Click += new System.EventHandler(this.Salvare_ca_excel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(674, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saortareDupaBugetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "sotare dupa buget";
            // 
            // saortareDupaBugetToolStripMenuItem
            // 
            this.saortareDupaBugetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saraciToolStripMenuItem,
            this.bogatiToolStripMenuItem});
            this.saortareDupaBugetToolStripMenuItem.Name = "saortareDupaBugetToolStripMenuItem";
            this.saortareDupaBugetToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.saortareDupaBugetToolStripMenuItem.Text = "saortare dupa buget";
            this.saortareDupaBugetToolStripMenuItem.Click += new System.EventHandler(this.saortareDupaBugetToolStripMenuItem_Click);
            // 
            // saraciToolStripMenuItem
            // 
            this.saraciToolStripMenuItem.Name = "saraciToolStripMenuItem";
            this.saraciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saraciToolStripMenuItem.Text = "saraci";
            this.saraciToolStripMenuItem.Click += new System.EventHandler(this.saraciToolStripMenuItem_Click);
            // 
            // bogatiToolStripMenuItem
            // 
            this.bogatiToolStripMenuItem.Name = "bogatiToolStripMenuItem";
            this.bogatiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bogatiToolStripMenuItem.Text = "bogati";
            this.bogatiToolStripMenuItem.Click += new System.EventHandler(this.bogatiToolStripMenuItem_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(337, 438);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 6;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(418, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 7;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salvare_ca_excel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Salvare_ca_excel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saortareDupaBugetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saraciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bogatiToolStripMenuItem;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label label2;
    }
}