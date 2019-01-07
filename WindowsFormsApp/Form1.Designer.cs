namespace WindowsFormsApp
{
    partial class NewUser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxDataUrodzenia = new MetroFramework.Controls.MetroTextBox();
            this.checkPlec = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxAdress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxImieINazwisko = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtBoxStudentID = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnZmienZdjecie = new MetroFramework.Controls.MetroButton();
            this.btnDodajUzytkownika = new MetroFramework.Controls.MetroButton();
            this.btnEdytujUzytkownika = new MetroFramework.Controls.MetroButton();
            this.btnUsunUzytkownika = new MetroFramework.Controls.MetroButton();
            this.btnAnuluj = new MetroFramework.Controls.MetroButton();
            this.btnZapisz = new MetroFramework.Controls.MetroButton();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieINazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plecDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToDeleteRows = false;
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.AutoGenerateColumns = false;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imieINazwiskoDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn,
            this.plecDataGridViewCheckBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.metroGrid.DataSource = this.studentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(23, 335);
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.ReadOnly = true;
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(754, 218);
            this.metroGrid.TabIndex = 0;
            this.metroGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtBoxDataUrodzenia);
            this.metroPanel1.Controls.Add(this.checkPlec);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtBoxAdress);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtBoxEmail);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtBoxImieINazwisko);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtBoxStudentID);
            this.metroPanel1.Controls.Add(this.pictureBox);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(552, 252);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 76);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Data uruodzenia:";
            // 
            // txtBoxDataUrodzenia
            // 
            // 
            // 
            // 
            this.txtBoxDataUrodzenia.CustomButton.Image = null;
            this.txtBoxDataUrodzenia.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtBoxDataUrodzenia.CustomButton.Name = "";
            this.txtBoxDataUrodzenia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxDataUrodzenia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxDataUrodzenia.CustomButton.TabIndex = 1;
            this.txtBoxDataUrodzenia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxDataUrodzenia.CustomButton.UseSelectable = true;
            this.txtBoxDataUrodzenia.CustomButton.Visible = false;
            this.txtBoxDataUrodzenia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "DataUrodzenia", true));
            this.txtBoxDataUrodzenia.Lines = new string[0];
            this.txtBoxDataUrodzenia.Location = new System.Drawing.Point(122, 74);
            this.txtBoxDataUrodzenia.MaxLength = 32767;
            this.txtBoxDataUrodzenia.Name = "txtBoxDataUrodzenia";
            this.txtBoxDataUrodzenia.PasswordChar = '\0';
            this.txtBoxDataUrodzenia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxDataUrodzenia.SelectedText = "";
            this.txtBoxDataUrodzenia.SelectionLength = 0;
            this.txtBoxDataUrodzenia.SelectionStart = 0;
            this.txtBoxDataUrodzenia.ShortcutsEnabled = true;
            this.txtBoxDataUrodzenia.Size = new System.Drawing.Size(213, 23);
            this.txtBoxDataUrodzenia.TabIndex = 15;
            this.txtBoxDataUrodzenia.UseSelectable = true;
            this.txtBoxDataUrodzenia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxDataUrodzenia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkPlec
            // 
            this.checkPlec.AutoSize = true;
            this.checkPlec.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.studentBindingSource, "Plec", true));
            this.checkPlec.Location = new System.Drawing.Point(122, 107);
            this.checkPlec.Name = "checkPlec";
            this.checkPlec.Size = new System.Drawing.Size(38, 15);
            this.checkPlec.TabIndex = 14;
            this.checkPlec.Text = "???";
            this.checkPlec.UseSelectable = true;
            this.checkPlec.CheckedChanged += new System.EventHandler(this.checkPlec_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "Adress:";
            // 
            // txtBoxAdress
            // 
            // 
            // 
            // 
            this.txtBoxAdress.CustomButton.Image = null;
            this.txtBoxAdress.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtBoxAdress.CustomButton.Name = "";
            this.txtBoxAdress.CustomButton.Size = new System.Drawing.Size(75, 75);
            this.txtBoxAdress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxAdress.CustomButton.TabIndex = 1;
            this.txtBoxAdress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxAdress.CustomButton.UseSelectable = true;
            this.txtBoxAdress.CustomButton.Visible = false;
            this.txtBoxAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Adres", true));
            this.txtBoxAdress.Lines = new string[0];
            this.txtBoxAdress.Location = new System.Drawing.Point(122, 160);
            this.txtBoxAdress.MaxLength = 32767;
            this.txtBoxAdress.Multiline = true;
            this.txtBoxAdress.Name = "txtBoxAdress";
            this.txtBoxAdress.PasswordChar = '\0';
            this.txtBoxAdress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxAdress.SelectedText = "";
            this.txtBoxAdress.SelectionLength = 0;
            this.txtBoxAdress.SelectionStart = 0;
            this.txtBoxAdress.ShortcutsEnabled = true;
            this.txtBoxAdress.Size = new System.Drawing.Size(213, 77);
            this.txtBoxAdress.TabIndex = 12;
            this.txtBoxAdress.UseSelectable = true;
            this.txtBoxAdress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxAdress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 133);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            // 
            // 
            // 
            this.txtBoxEmail.CustomButton.Image = null;
            this.txtBoxEmail.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtBoxEmail.CustomButton.Name = "";
            this.txtBoxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxEmail.CustomButton.TabIndex = 1;
            this.txtBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxEmail.CustomButton.UseSelectable = true;
            this.txtBoxEmail.CustomButton.Visible = false;
            this.txtBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Email", true));
            this.txtBoxEmail.Lines = new string[0];
            this.txtBoxEmail.Location = new System.Drawing.Point(122, 131);
            this.txtBoxEmail.MaxLength = 32767;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.PasswordChar = '\0';
            this.txtBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxEmail.SelectedText = "";
            this.txtBoxEmail.SelectionLength = 0;
            this.txtBoxEmail.SelectionStart = 0;
            this.txtBoxEmail.ShortcutsEnabled = true;
            this.txtBoxEmail.Size = new System.Drawing.Size(213, 23);
            this.txtBoxEmail.TabIndex = 10;
            this.txtBoxEmail.UseSelectable = true;
            this.txtBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 104);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Płeć:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Imię i Nazwisko:";
            // 
            // txtBoxImieINazwisko
            // 
            // 
            // 
            // 
            this.txtBoxImieINazwisko.CustomButton.Image = null;
            this.txtBoxImieINazwisko.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtBoxImieINazwisko.CustomButton.Name = "";
            this.txtBoxImieINazwisko.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxImieINazwisko.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxImieINazwisko.CustomButton.TabIndex = 1;
            this.txtBoxImieINazwisko.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxImieINazwisko.CustomButton.UseSelectable = true;
            this.txtBoxImieINazwisko.CustomButton.Visible = false;
            this.txtBoxImieINazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "ImieINazwisko", true));
            this.txtBoxImieINazwisko.Lines = new string[0];
            this.txtBoxImieINazwisko.Location = new System.Drawing.Point(122, 45);
            this.txtBoxImieINazwisko.MaxLength = 32767;
            this.txtBoxImieINazwisko.Name = "txtBoxImieINazwisko";
            this.txtBoxImieINazwisko.PasswordChar = '\0';
            this.txtBoxImieINazwisko.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxImieINazwisko.SelectedText = "";
            this.txtBoxImieINazwisko.SelectionLength = 0;
            this.txtBoxImieINazwisko.SelectionStart = 0;
            this.txtBoxImieINazwisko.ShortcutsEnabled = true;
            this.txtBoxImieINazwisko.Size = new System.Drawing.Size(213, 23);
            this.txtBoxImieINazwisko.TabIndex = 6;
            this.txtBoxImieINazwisko.UseSelectable = true;
            this.txtBoxImieINazwisko.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxImieINazwisko.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Student ID";
            // 
            // txtBoxStudentID
            // 
            // 
            // 
            // 
            this.txtBoxStudentID.CustomButton.Image = null;
            this.txtBoxStudentID.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtBoxStudentID.CustomButton.Name = "";
            this.txtBoxStudentID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxStudentID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxStudentID.CustomButton.TabIndex = 1;
            this.txtBoxStudentID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxStudentID.CustomButton.UseSelectable = true;
            this.txtBoxStudentID.CustomButton.Visible = false;
            this.txtBoxStudentID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource, "Id", true));
            this.txtBoxStudentID.Lines = new string[0];
            this.txtBoxStudentID.Location = new System.Drawing.Point(122, 16);
            this.txtBoxStudentID.MaxLength = 32767;
            this.txtBoxStudentID.Name = "txtBoxStudentID";
            this.txtBoxStudentID.PasswordChar = '\0';
            this.txtBoxStudentID.ReadOnly = true;
            this.txtBoxStudentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxStudentID.SelectedText = "";
            this.txtBoxStudentID.SelectionLength = 0;
            this.txtBoxStudentID.SelectionStart = 0;
            this.txtBoxStudentID.ShortcutsEnabled = true;
            this.txtBoxStudentID.Size = new System.Drawing.Size(213, 23);
            this.txtBoxStudentID.TabIndex = 3;
            this.txtBoxStudentID.UseSelectable = true;
            this.txtBoxStudentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxStudentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(351, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(186, 215);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // btnZmienZdjecie
            // 
            this.btnZmienZdjecie.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnZmienZdjecie.Location = new System.Drawing.Point(582, 63);
            this.btnZmienZdjecie.Name = "btnZmienZdjecie";
            this.btnZmienZdjecie.Size = new System.Drawing.Size(196, 37);
            this.btnZmienZdjecie.TabIndex = 4;
            this.btnZmienZdjecie.Text = "Zmień zdjęcie";
            this.btnZmienZdjecie.UseSelectable = true;
            this.btnZmienZdjecie.Click += new System.EventHandler(this.btnZmienZdjecie_Click);
            // 
            // btnDodajUzytkownika
            // 
            this.btnDodajUzytkownika.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDodajUzytkownika.Location = new System.Drawing.Point(581, 106);
            this.btnDodajUzytkownika.Name = "btnDodajUzytkownika";
            this.btnDodajUzytkownika.Size = new System.Drawing.Size(196, 37);
            this.btnDodajUzytkownika.TabIndex = 5;
            this.btnDodajUzytkownika.Text = "Dodaj użytkownika";
            this.btnDodajUzytkownika.UseSelectable = true;
            this.btnDodajUzytkownika.Click += new System.EventHandler(this.btnDodajUzytkownika_Click);
            // 
            // btnEdytujUzytkownika
            // 
            this.btnEdytujUzytkownika.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEdytujUzytkownika.Location = new System.Drawing.Point(582, 149);
            this.btnEdytujUzytkownika.Name = "btnEdytujUzytkownika";
            this.btnEdytujUzytkownika.Size = new System.Drawing.Size(196, 37);
            this.btnEdytujUzytkownika.TabIndex = 6;
            this.btnEdytujUzytkownika.Text = "Edytuj użytkownika";
            this.btnEdytujUzytkownika.UseSelectable = true;
            this.btnEdytujUzytkownika.Click += new System.EventHandler(this.btnEdytujUzytkownika_Click);
            // 
            // btnUsunUzytkownika
            // 
            this.btnUsunUzytkownika.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUsunUzytkownika.Location = new System.Drawing.Point(581, 192);
            this.btnUsunUzytkownika.Name = "btnUsunUzytkownika";
            this.btnUsunUzytkownika.Size = new System.Drawing.Size(196, 37);
            this.btnUsunUzytkownika.TabIndex = 7;
            this.btnUsunUzytkownika.Text = "Usuń użytkownika";
            this.btnUsunUzytkownika.UseSelectable = true;
            this.btnUsunUzytkownika.Click += new System.EventHandler(this.btnUsunUzytkownika_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAnuluj.Location = new System.Drawing.Point(582, 235);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(196, 37);
            this.btnAnuluj.TabIndex = 8;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseSelectable = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnZapisz.Location = new System.Drawing.Point(581, 278);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(196, 37);
            this.btnZapisz.TabIndex = 9;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseSelectable = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(WindowsFormsApp.Student);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 25;
            // 
            // imieINazwiskoDataGridViewTextBoxColumn
            // 
            this.imieINazwiskoDataGridViewTextBoxColumn.DataPropertyName = "ImieINazwisko";
            this.imieINazwiskoDataGridViewTextBoxColumn.HeaderText = "Imie i Nazwisko";
            this.imieINazwiskoDataGridViewTextBoxColumn.Name = "imieINazwiskoDataGridViewTextBoxColumn";
            this.imieINazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "Data Urodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            this.dataUrodzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plecDataGridViewCheckBoxColumn
            // 
            this.plecDataGridViewCheckBoxColumn.DataPropertyName = "Plec";
            this.plecDataGridViewCheckBoxColumn.HeaderText = "Płeć";
            this.plecDataGridViewCheckBoxColumn.Name = "plecDataGridViewCheckBoxColumn";
            this.plecDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresDataGridViewTextBoxColumn.Width = 200;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 567);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnUsunUzytkownika);
            this.Controls.Add(this.btnEdytujUzytkownika);
            this.Controls.Add(this.btnDodajUzytkownika);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid);
            this.Controls.Add(this.btnZmienZdjecie);
            this.Name = "NewUser";
            this.Text = "Nowy student";
            this.Load += new System.EventHandler(this.NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtBoxAdress;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtBoxEmail;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtBoxImieINazwisko;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtBoxStudentID;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroButton btnZmienZdjecie;
        private MetroFramework.Controls.MetroButton btnDodajUzytkownika;
        private MetroFramework.Controls.MetroButton btnEdytujUzytkownika;
        private MetroFramework.Controls.MetroButton btnUsunUzytkownika;
        private MetroFramework.Controls.MetroButton btnAnuluj;
        private MetroFramework.Controls.MetroButton btnZapisz;
        private MetroFramework.Controls.MetroCheckBox checkPlec;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtBoxDataUrodzenia;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieINazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn plecDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}

