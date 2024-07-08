
namespace WinFormsApp90.Forms.DzialaniaSerwisowe
{
    partial class DzialanieSerwisoweEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows BaseForm Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.dataGridViewWykonawcy = new System.Windows.Forms.DataGridView();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label118 = new System.Windows.Forms.Label();
            this.comboBoxSprzet = new System.Windows.Forms.ComboBox();
            this.comboBoxFirmy = new System.Windows.Forms.ComboBox();
            this.label122 = new System.Windows.Forms.Label();
            this.buttonBazaWiedzy = new System.Windows.Forms.Button();
            this.checkBoxCzySprawaZakonczona = new System.Windows.Forms.CheckBox();
            this.listBoxZalaczniki = new System.Windows.Forms.ListBox();
            this.textBoxSzczegolowyOpis = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.textBoxCzasTrwaniaSerwisu = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.textBoxGodzinaZakonczenia = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxGodzinaRozpoczecia = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWykonawcy)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewWykonawcy
            // 
            this.dataGridViewWykonawcy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWykonawcy.Location = new System.Drawing.Point(371, 562);
            this.dataGridViewWykonawcy.Name = "dataGridViewWykonawcy";
            this.dataGridViewWykonawcy.RowHeadersWidth = 72;
            this.dataGridViewWykonawcy.RowTemplate.Height = 37;
            this.dataGridViewWykonawcy.Size = new System.Drawing.Size(899, 191);
            this.dataGridViewWykonawcy.TabIndex = 148;
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(1153, 939);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(119, 40);
            this.buttonUsun.TabIndex = 147;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(1028, 939);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(119, 40);
            this.buttonDodaj.TabIndex = 147;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(23, 854);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(26, 276);
            this.panel7.TabIndex = 146;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(49, 88);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(150, 30);
            this.label118.TabIndex = 145;
            this.label118.Text = "Nazwa sprzętu";
            // 
            // comboBoxSprzet
            // 
            this.comboBoxSprzet.Enabled = false;
            this.comboBoxSprzet.FormattingEnabled = true;
            this.comboBoxSprzet.Location = new System.Drawing.Point(371, 85);
            this.comboBoxSprzet.Name = "comboBoxSprzet";
            this.comboBoxSprzet.Size = new System.Drawing.Size(899, 38);
            this.comboBoxSprzet.TabIndex = 143;
            this.comboBoxSprzet.SelectedIndexChanged += new System.EventHandler(this.comboBoxSprzet_SelectedIndexChanged);
            // 
            // comboBoxFirmy
            // 
            this.comboBoxFirmy.Enabled = false;
            this.comboBoxFirmy.FormattingEnabled = true;
            this.comboBoxFirmy.Location = new System.Drawing.Point(371, 41);
            this.comboBoxFirmy.Name = "comboBoxFirmy";
            this.comboBoxFirmy.Size = new System.Drawing.Size(899, 38);
            this.comboBoxFirmy.TabIndex = 144;
            this.comboBoxFirmy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirmy_SelectedIndexChanged);
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(49, 44);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(216, 30);
            this.label122.TabIndex = 142;
            this.label122.Text = "Skrócona nazwa firmy";
            // 
            // buttonBazaWiedzy
            // 
            this.buttonBazaWiedzy.Location = new System.Drawing.Point(962, 504);
            this.buttonBazaWiedzy.Name = "buttonBazaWiedzy";
            this.buttonBazaWiedzy.Size = new System.Drawing.Size(308, 40);
            this.buttonBazaWiedzy.TabIndex = 104;
            this.buttonBazaWiedzy.Text = "Dodaj do bazy wiedzy";
            this.buttonBazaWiedzy.UseVisualStyleBackColor = true;
            this.buttonBazaWiedzy.Click += new System.EventHandler(this.buttonBazaWiedzy_Click);
            // 
            // checkBoxCzySprawaZakonczona
            // 
            this.checkBoxCzySprawaZakonczona.AutoSize = true;
            this.checkBoxCzySprawaZakonczona.Location = new System.Drawing.Point(960, 1029);
            this.checkBoxCzySprawaZakonczona.Name = "checkBoxCzySprawaZakonczona";
            this.checkBoxCzySprawaZakonczona.Size = new System.Drawing.Size(312, 34);
            this.checkBoxCzySprawaZakonczona.TabIndex = 102;
            this.checkBoxCzySprawaZakonczona.Text = "Sprawa zakończona - Tak/Nie";
            this.checkBoxCzySprawaZakonczona.UseVisualStyleBackColor = true;
            // 
            // listBoxZalaczniki
            // 
            this.listBoxZalaczniki.FormattingEnabled = true;
            this.listBoxZalaczniki.ItemHeight = 30;
            this.listBoxZalaczniki.Location = new System.Drawing.Point(371, 779);
            this.listBoxZalaczniki.Name = "listBoxZalaczniki";
            this.listBoxZalaczniki.ScrollAlwaysVisible = true;
            this.listBoxZalaczniki.Size = new System.Drawing.Size(899, 154);
            this.listBoxZalaczniki.TabIndex = 101;
            this.listBoxZalaczniki.DoubleClick += new System.EventHandler(this.listBoxZalaczniki_DoubleClick);
            // 
            // textBoxSzczegolowyOpis
            // 
            this.textBoxSzczegolowyOpis.Location = new System.Drawing.Point(371, 342);
            this.textBoxSzczegolowyOpis.Multiline = true;
            this.textBoxSzczegolowyOpis.Name = "textBoxSzczegolowyOpis";
            this.textBoxSzczegolowyOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSzczegolowyOpis.Size = new System.Drawing.Size(899, 156);
            this.textBoxSzczegolowyOpis.TabIndex = 100;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(49, 779);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(105, 30);
            this.label36.TabIndex = 97;
            this.label36.Text = "Załączniki";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(49, 343);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(256, 30);
            this.label35.TabIndex = 96;
            this.label35.Text = "Szczegółowy opis zlecenia";
            // 
            // textBoxCzasTrwaniaSerwisu
            // 
            this.textBoxCzasTrwaniaSerwisu.Location = new System.Drawing.Point(371, 301);
            this.textBoxCzasTrwaniaSerwisu.Name = "textBoxCzasTrwaniaSerwisu";
            this.textBoxCzasTrwaniaSerwisu.Size = new System.Drawing.Size(899, 35);
            this.textBoxCzasTrwaniaSerwisu.TabIndex = 99;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(49, 302);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(204, 30);
            this.label34.TabIndex = 98;
            this.label34.Text = "Czas trwania serwisu";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(49, 562);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(188, 30);
            this.label32.TabIndex = 92;
            this.label32.Text = "Kto wykonał serwis";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(371, 176);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(899, 35);
            this.dateTimePickerData.TabIndex = 90;
            // 
            // textBoxGodzinaZakonczenia
            // 
            this.textBoxGodzinaZakonczenia.Location = new System.Drawing.Point(371, 258);
            this.textBoxGodzinaZakonczenia.Name = "textBoxGodzinaZakonczenia";
            this.textBoxGodzinaZakonczenia.Size = new System.Drawing.Size(899, 35);
            this.textBoxGodzinaZakonczenia.TabIndex = 88;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(49, 262);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(209, 30);
            this.label28.TabIndex = 86;
            this.label28.Text = "Godzina zakończenia";
            // 
            // textBoxGodzinaRozpoczecia
            // 
            this.textBoxGodzinaRozpoczecia.Location = new System.Drawing.Point(371, 217);
            this.textBoxGodzinaRozpoczecia.Name = "textBoxGodzinaRozpoczecia";
            this.textBoxGodzinaRozpoczecia.Size = new System.Drawing.Size(899, 35);
            this.textBoxGodzinaRozpoczecia.TabIndex = 89;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(49, 221);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(205, 30);
            this.label29.TabIndex = 87;
            this.label29.Text = "Godzina rozpoczęcia";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(49, 180);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(57, 30);
            this.label30.TabIndex = 85;
            this.label30.Text = "Data";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1464, 5);
            this.panel5.TabIndex = 108;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(230, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 52);
            this.button2.TabIndex = 93;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(39, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 52);
            this.button1.TabIndex = 94;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1019, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 95);
            this.panel4.TabIndex = 107;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 651);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1464, 100);
            this.panel2.TabIndex = 126;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1464, 5);
            this.panel6.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 38);
            this.label2.TabIndex = 87;
            this.label2.Text = "Dodawanie nowej firmy";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1464, 100);
            this.panel3.TabIndex = 127;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridViewWykonawcy);
            this.panel1.Controls.Add(this.buttonUsun);
            this.panel1.Controls.Add(this.buttonDodaj);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label118);
            this.panel1.Controls.Add(this.comboBoxSprzet);
            this.panel1.Controls.Add(this.comboBoxFirmy);
            this.panel1.Controls.Add(this.label122);
            this.panel1.Controls.Add(this.buttonBazaWiedzy);
            this.panel1.Controls.Add(this.checkBoxCzySprawaZakonczona);
            this.panel1.Controls.Add(this.listBoxZalaczniki);
            this.panel1.Controls.Add(this.textBoxSzczegolowyOpis);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.textBoxCzasTrwaniaSerwisu);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.dateTimePickerData);
            this.panel1.Controls.Add(this.textBoxGodzinaZakonczenia);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.textBoxGodzinaRozpoczecia);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 551);
            this.panel1.TabIndex = 128;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DzialanieSerwisoweEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 751);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "DzialanieSerwisoweEdit";
            this.Text = "DzialanieSerwisoweEdit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DzialanieSerwisoweEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWykonawcy)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWykonawcy;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.ComboBox comboBoxSprzet;
        private System.Windows.Forms.ComboBox comboBoxFirmy;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Button buttonBazaWiedzy;
        private System.Windows.Forms.CheckBox checkBoxCzySprawaZakonczona;
        private System.Windows.Forms.ListBox listBoxZalaczniki;
        private System.Windows.Forms.TextBox textBoxSzczegolowyOpis;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBoxCzasTrwaniaSerwisu;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.TextBox textBoxGodzinaZakonczenia;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxGodzinaRozpoczecia;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}