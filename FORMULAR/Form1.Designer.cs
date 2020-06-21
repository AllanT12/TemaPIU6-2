namespace FORMULAR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LNume = new System.Windows.Forms.Label();
            this.LPrenume = new System.Windows.Forms.Label();
            this.LBuget = new System.Windows.Forms.Label();
            this.BAdauga = new System.Windows.Forms.Button();
            this.tNume = new System.Windows.Forms.TextBox();
            this.tPrenume = new System.Windows.Forms.TextBox();
            this.tBuget = new System.Windows.Forms.TextBox();
            this.lAfisare = new System.Windows.Forms.Label();
            this.afis = new System.Windows.Forms.Button();
            this.lblPreferinte = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxRestaurant = new System.Windows.Forms.CheckBox();
            this.boxParcare = new System.Windows.Forms.CheckBox();
            this.boxWIFI = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radIeftin = new System.Windows.Forms.RadioButton();
            this.radScump = new System.Windows.Forms.RadioButton();
            this.cmbTara = new System.Windows.Forms.ComboBox();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.dtpUtilizator = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LNume
            // 
            this.LNume.AutoSize = true;
            this.LNume.Location = new System.Drawing.Point(25, 51);
            this.LNume.Name = "LNume";
            this.LNume.Size = new System.Drawing.Size(35, 13);
            this.LNume.TabIndex = 0;
            this.LNume.Text = "Nume";
            // 
            // LPrenume
            // 
            this.LPrenume.AutoSize = true;
            this.LPrenume.Location = new System.Drawing.Point(25, 87);
            this.LPrenume.Name = "LPrenume";
            this.LPrenume.Size = new System.Drawing.Size(49, 13);
            this.LPrenume.TabIndex = 1;
            this.LPrenume.Text = "Prenume";
            // 
            // LBuget
            // 
            this.LBuget.AutoSize = true;
            this.LBuget.Location = new System.Drawing.Point(28, 121);
            this.LBuget.Name = "LBuget";
            this.LBuget.Size = new System.Drawing.Size(35, 13);
            this.LBuget.TabIndex = 2;
            this.LBuget.Text = "Buget";
            // 
            // BAdauga
            // 
            this.BAdauga.Location = new System.Drawing.Point(28, 391);
            this.BAdauga.Name = "BAdauga";
            this.BAdauga.Size = new System.Drawing.Size(75, 23);
            this.BAdauga.TabIndex = 3;
            this.BAdauga.Text = "Adauga";
            this.BAdauga.UseVisualStyleBackColor = true;
            this.BAdauga.Click += new System.EventHandler(this.BAdauga_Click);
            // 
            // tNume
            // 
            this.tNume.Location = new System.Drawing.Point(131, 48);
            this.tNume.Name = "tNume";
            this.tNume.Size = new System.Drawing.Size(194, 20);
            this.tNume.TabIndex = 4;
            // 
            // tPrenume
            // 
            this.tPrenume.Location = new System.Drawing.Point(131, 80);
            this.tPrenume.Name = "tPrenume";
            this.tPrenume.Size = new System.Drawing.Size(194, 20);
            this.tPrenume.TabIndex = 5;
            // 
            // tBuget
            // 
            this.tBuget.Location = new System.Drawing.Point(131, 121);
            this.tBuget.Name = "tBuget";
            this.tBuget.Size = new System.Drawing.Size(194, 20);
            this.tBuget.TabIndex = 6;
            // 
            // lAfisare
            // 
            this.lAfisare.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lAfisare.Location = new System.Drawing.Point(128, 391);
            this.lAfisare.Name = "lAfisare";
            this.lAfisare.Size = new System.Drawing.Size(197, 23);
            this.lAfisare.TabIndex = 7;
            // 
            // afis
            // 
            this.afis.Location = new System.Drawing.Point(169, 457);
            this.afis.Name = "afis";
            this.afis.Size = new System.Drawing.Size(75, 23);
            this.afis.TabIndex = 8;
            this.afis.Text = "Afisare";
            this.afis.UseVisualStyleBackColor = true;
            this.afis.Click += new System.EventHandler(this.afis_Click);
            // 
            // lblPreferinte
            // 
            this.lblPreferinte.AutoSize = true;
            this.lblPreferinte.Location = new System.Drawing.Point(28, 164);
            this.lblPreferinte.Name = "lblPreferinte";
            this.lblPreferinte.Size = new System.Drawing.Size(52, 13);
            this.lblPreferinte.TabIndex = 14;
            this.lblPreferinte.Text = "Preferinte";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxRestaurant);
            this.groupBox1.Controls.Add(this.boxParcare);
            this.groupBox1.Controls.Add(this.boxWIFI);
            this.groupBox1.Location = new System.Drawing.Point(131, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 87);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // boxRestaurant
            // 
            this.boxRestaurant.AutoSize = true;
            this.boxRestaurant.Location = new System.Drawing.Point(13, 53);
            this.boxRestaurant.Name = "boxRestaurant";
            this.boxRestaurant.Size = new System.Drawing.Size(78, 17);
            this.boxRestaurant.TabIndex = 2;
            this.boxRestaurant.Text = "Restaurant";
            this.boxRestaurant.UseVisualStyleBackColor = true;
            this.boxRestaurant.CheckedChanged += new System.EventHandler(this.box_CheckedChanged);
            // 
            // boxParcare
            // 
            this.boxParcare.AutoSize = true;
            this.boxParcare.Location = new System.Drawing.Point(103, 20);
            this.boxParcare.Name = "boxParcare";
            this.boxParcare.Size = new System.Drawing.Size(63, 17);
            this.boxParcare.TabIndex = 1;
            this.boxParcare.Text = "Parcare";
            this.boxParcare.UseVisualStyleBackColor = true;
            this.boxParcare.CheckedChanged += new System.EventHandler(this.box_CheckedChanged);
            // 
            // boxWIFI
            // 
            this.boxWIFI.AutoSize = true;
            this.boxWIFI.Location = new System.Drawing.Point(16, 20);
            this.boxWIFI.Name = "boxWIFI";
            this.boxWIFI.Size = new System.Drawing.Size(49, 17);
            this.boxWIFI.TabIndex = 0;
            this.boxWIFI.Text = "WIFI";
            this.boxWIFI.UseVisualStyleBackColor = true;
            this.boxWIFI.CheckedChanged += new System.EventHandler(this.box_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radIeftin);
            this.groupBox2.Controls.Add(this.radScump);
            this.groupBox2.Location = new System.Drawing.Point(131, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 47);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // radIeftin
            // 
            this.radIeftin.AutoSize = true;
            this.radIeftin.Location = new System.Drawing.Point(120, 20);
            this.radIeftin.Name = "radIeftin";
            this.radIeftin.Size = new System.Drawing.Size(48, 17);
            this.radIeftin.TabIndex = 1;
            this.radIeftin.TabStop = true;
            this.radIeftin.Text = "Ieftin";
            this.radIeftin.UseVisualStyleBackColor = true;
            // 
            // radScump
            // 
            this.radScump.AutoSize = true;
            this.radScump.Location = new System.Drawing.Point(16, 20);
            this.radScump.Name = "radScump";
            this.radScump.Size = new System.Drawing.Size(58, 17);
            this.radScump.TabIndex = 0;
            this.radScump.TabStop = true;
            this.radScump.Text = "Scump";
            this.radScump.UseVisualStyleBackColor = true;
            // 
            // cmbTara
            // 
            this.cmbTara.FormattingEnabled = true;
            this.cmbTara.Items.AddRange(new object[] {
            "Romania",
            "Spania",
            "Grecia"});
            this.cmbTara.Location = new System.Drawing.Point(131, 324);
            this.cmbTara.Name = "cmbTara";
            this.cmbTara.Size = new System.Drawing.Size(194, 21);
            this.cmbTara.TabIndex = 17;
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.Location = new System.Drawing.Point(378, 77);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(462, 316);
            this.lstAfisare.TabIndex = 18;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(497, 434);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 19;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // dtpUtilizator
            // 
            this.dtpUtilizator.Location = new System.Drawing.Point(128, 355);
            this.dtpUtilizator.Name = "dtpUtilizator";
            this.dtpUtilizator.Size = new System.Drawing.Size(197, 20);
            this.dtpUtilizator.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Rezervat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tara de Preferinta";
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpUtilizator);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.cmbTara);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPreferinte);
            this.Controls.Add(this.afis);
            this.Controls.Add(this.lAfisare);
            this.Controls.Add(this.tBuget);
            this.Controls.Add(this.tPrenume);
            this.Controls.Add(this.tNume);
            this.Controls.Add(this.BAdauga);
            this.Controls.Add(this.LBuget);
            this.Controls.Add(this.LPrenume);
            this.Controls.Add(this.LNume);
            this.Name = "Form1";
            this.Text = "Generator De Sejur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblBuget;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label LNume;
        private System.Windows.Forms.Label LPrenume;
        private System.Windows.Forms.Label LBuget;
        private System.Windows.Forms.Button BAdauga;
        private System.Windows.Forms.TextBox tNume;
        private System.Windows.Forms.TextBox tPrenume;
        private System.Windows.Forms.TextBox tBuget;
        private System.Windows.Forms.Label lAfisare;
        private System.Windows.Forms.Button afis;
        private System.Windows.Forms.Label lblPreferinte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox boxParcare;
        private System.Windows.Forms.CheckBox boxWIFI;
        private System.Windows.Forms.CheckBox boxRestaurant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radScump;
        private System.Windows.Forms.RadioButton radIeftin;
        private System.Windows.Forms.ComboBox cmbTara;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.DateTimePicker dtpUtilizator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

