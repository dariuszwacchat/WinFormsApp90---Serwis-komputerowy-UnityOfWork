
namespace WinFormsApp90.Forms.DzialaniaSerwisowe
{
    partial class DzialanieSerwisoweCreate
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewWykonawcy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label118 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label122 = new System.Windows.Forms.Label();
            this.buttonBazaWiedzy = new System.Windows.Forms.Button();
            this.checkBoxCzySprawaZakonczona = new System.Windows.Forms.CheckBox();
            this.listBoxZalaczniki = new System.Windows.Forms.ListBox();
            this.textBoxSzczegolowyOpis = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.textBoxGodzinaZakonczenia = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxGodzinaRozpoczecia = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWykonawcy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1393, 100);
            this.panel3.TabIndex = 124; 
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1393, 5);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 742);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1393, 100);
            this.panel2.TabIndex = 123; 
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(948, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 95);
            this.panel4.TabIndex = 107; 
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1393, 5);
            this.panel5.TabIndex = 108; 
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridViewWykonawcy);
            this.panel1.Controls.Add(this.buttonUsun);
            this.panel1.Controls.Add(this.buttonDodaj);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label118);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label122);
            this.panel1.Controls.Add(this.buttonBazaWiedzy);
            this.panel1.Controls.Add(this.checkBoxCzySprawaZakonczona);
            this.panel1.Controls.Add(this.listBoxZalaczniki);
            this.panel1.Controls.Add(this.textBoxSzczegolowyOpis);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label35);
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
            this.panel1.Size = new System.Drawing.Size(1393, 642);
            this.panel1.TabIndex = 125; 
            // 
            // dataGridViewWykonawcy
            // 
            this.dataGridViewWykonawcy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWykonawcy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewWykonawcy.Location = new System.Drawing.Point(371, 519);
            this.dataGridViewWykonawcy.Name = "dataGridViewWykonawcy";
            this.dataGridViewWykonawcy.RowHeadersWidth = 72;
            this.dataGridViewWykonawcy.RowTemplate.Height = 37;
            this.dataGridViewWykonawcy.Size = new System.Drawing.Size(899, 191);
            this.dataGridViewWykonawcy.TabIndex = 148; 
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Wybierz";
            this.Column1.HeaderText = "Wybierz";
            this.Column1.MinimumWidth = 9;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 175;
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(1153, 876);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(119, 40);
            this.buttonUsun.TabIndex = 147;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(1028, 876);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(119, 40);
            this.buttonDodaj.TabIndex = 147;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(23, 791);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(371, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(899, 38);
            this.comboBox1.TabIndex = 143;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(371, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(899, 38);
            this.comboBox2.TabIndex = 144;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            this.buttonBazaWiedzy.Location = new System.Drawing.Point(962, 461);
            this.buttonBazaWiedzy.Name = "buttonBazaWiedzy";
            this.buttonBazaWiedzy.Size = new System.Drawing.Size(308, 40);
            this.buttonBazaWiedzy.TabIndex = 104;
            this.buttonBazaWiedzy.Text = "Dodaj do bazy wiedzy";
            this.buttonBazaWiedzy.UseVisualStyleBackColor = true; 
            // 
            // checkBoxCzySprawaZakonczona
            // 
            this.checkBoxCzySprawaZakonczona.AutoSize = true;
            this.checkBoxCzySprawaZakonczona.Location = new System.Drawing.Point(960, 966);
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
            this.listBoxZalaczniki.Location = new System.Drawing.Point(371, 716);
            this.listBoxZalaczniki.Name = "listBoxZalaczniki";
            this.listBoxZalaczniki.ScrollAlwaysVisible = true;
            this.listBoxZalaczniki.Size = new System.Drawing.Size(899, 154);
            this.listBoxZalaczniki.TabIndex = 101; 
            // 
            // textBoxSzczegolowyOpis
            // 
            this.textBoxSzczegolowyOpis.Location = new System.Drawing.Point(371, 299);
            this.textBoxSzczegolowyOpis.Multiline = true;
            this.textBoxSzczegolowyOpis.Name = "textBoxSzczegolowyOpis";
            this.textBoxSzczegolowyOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSzczegolowyOpis.Size = new System.Drawing.Size(899, 156);
            this.textBoxSzczegolowyOpis.TabIndex = 100; 
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(49, 716);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(105, 30);
            this.label36.TabIndex = 97;
            this.label36.Text = "Załączniki"; 
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(49, 300);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(256, 30);
            this.label35.TabIndex = 96;
            this.label35.Text = "Szczegółowy opis zlecenia"; 
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(49, 519);
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
            // DzialanieSerwisoweCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 842);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "DzialanieSerwisoweCreate";
            this.Text = "DzialanieSerwisoweCreate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DzialanieSerwisoweCreate_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWykonawcy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBazaWiedzy;
        private System.Windows.Forms.CheckBox checkBoxCzySprawaZakonczona;
        private System.Windows.Forms.ListBox listBoxZalaczniki;
        private System.Windows.Forms.TextBox textBoxSzczegolowyOpis;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.TextBox textBoxGodzinaZakonczenia;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxGodzinaRozpoczecia;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridView dataGridViewWykonawcy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}