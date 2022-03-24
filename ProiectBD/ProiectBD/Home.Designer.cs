namespace ProiectBD
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.extButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAngajati = new System.Windows.Forms.Button();
            this.btnServicii = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnCartiere = new System.Windows.Forms.Button();
            this.btnOrase = new System.Windows.Forms.Button();
            this.btnACS = new System.Windows.Forms.Button();
            this.delServicii = new System.Windows.Forms.Button();
            this.updServicii = new System.Windows.Forms.Button();
            this.insertOrase = new System.Windows.Forms.Button();
            this.updOrase = new System.Windows.Forms.Button();
            this.iCleanDataSet = new ProiectBD.iCleanDataSet();
            this.iCleanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiTableAdapter = new ProiectBD.iCleanDataSetTableAdapters.AngajatiTableAdapter();
            this.cartiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartiereTableAdapter = new ProiectBD.iCleanDataSetTableAdapters.CartiereTableAdapter();
            this.angajatiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiClientiServiciiTableAdapter = new ProiectBD.iCleanDataSetTableAdapters.AngajatiClientiServiciiTableAdapter();
            this.angajatiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.insertServicii = new System.Windows.Forms.Button();
            this.delOrase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleqButton = new System.Windows.Forms.Button();
            this.complexqButton = new System.Windows.Forms.Button();
            this.fKAngajatiClientiServiciiAngajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iCleanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCleanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAngajatiClientiServiciiAngajatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // extButton
            // 
            this.extButton.BackColor = System.Drawing.Color.LightCoral;
            this.extButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extButton.ForeColor = System.Drawing.Color.Black;
            this.extButton.Location = new System.Drawing.Point(694, 10);
            this.extButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(51, 24);
            this.extButton.TabIndex = 5;
            this.extButton.Text = "Exit";
            this.extButton.UseVisualStyleBackColor = false;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.PowderBlue;
            this.logoutButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.Black;
            this.logoutButton.Location = new System.Drawing.Point(621, 10);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(69, 24);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Home Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hello, admin!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAngajati
            // 
            this.btnAngajati.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAngajati.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAngajati.Location = new System.Drawing.Point(17, 93);
            this.btnAngajati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAngajati.Name = "btnAngajati";
            this.btnAngajati.Size = new System.Drawing.Size(104, 28);
            this.btnAngajati.TabIndex = 9;
            this.btnAngajati.Text = "Angajati";
            this.btnAngajati.UseVisualStyleBackColor = false;
            this.btnAngajati.Click += new System.EventHandler(this.btnAngajati_Click);
            // 
            // btnServicii
            // 
            this.btnServicii.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnServicii.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicii.Location = new System.Drawing.Point(18, 152);
            this.btnServicii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnServicii.Name = "btnServicii";
            this.btnServicii.Size = new System.Drawing.Size(104, 28);
            this.btnServicii.TabIndex = 9;
            this.btnServicii.Text = "Servicii";
            this.btnServicii.UseVisualStyleBackColor = false;
            this.btnServicii.Click += new System.EventHandler(this.btnServicii_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnClienti.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienti.Location = new System.Drawing.Point(18, 251);
            this.btnClienti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(104, 28);
            this.btnClienti.TabIndex = 9;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = false;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // btnCartiere
            // 
            this.btnCartiere.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCartiere.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartiere.Location = new System.Drawing.Point(18, 403);
            this.btnCartiere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCartiere.Name = "btnCartiere";
            this.btnCartiere.Size = new System.Drawing.Size(104, 28);
            this.btnCartiere.TabIndex = 9;
            this.btnCartiere.Text = "Cartiere";
            this.btnCartiere.UseVisualStyleBackColor = false;
            this.btnCartiere.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnOrase
            // 
            this.btnOrase.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnOrase.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrase.Location = new System.Drawing.Point(18, 312);
            this.btnOrase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrase.Name = "btnOrase";
            this.btnOrase.Size = new System.Drawing.Size(104, 28);
            this.btnOrase.TabIndex = 9;
            this.btnOrase.Text = "Orase";
            this.btnOrase.UseVisualStyleBackColor = false;
            this.btnOrase.Click += new System.EventHandler(this.btnOrase_Click);
            // 
            // btnACS
            // 
            this.btnACS.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnACS.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACS.Location = new System.Drawing.Point(18, 464);
            this.btnACS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnACS.Name = "btnACS";
            this.btnACS.Size = new System.Drawing.Size(104, 28);
            this.btnACS.TabIndex = 9;
            this.btnACS.Text = "Info Angajati";
            this.btnACS.UseVisualStyleBackColor = false;
            this.btnACS.Click += new System.EventHandler(this.btnACS_Click);
            // 
            // delServicii
            // 
            this.delServicii.BackColor = System.Drawing.Color.Cyan;
            this.delServicii.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delServicii.Location = new System.Drawing.Point(80, 184);
            this.delServicii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delServicii.Name = "delServicii";
            this.delServicii.Size = new System.Drawing.Size(58, 28);
            this.delServicii.TabIndex = 9;
            this.delServicii.Text = "Delete";
            this.delServicii.UseVisualStyleBackColor = false;
            this.delServicii.Click += new System.EventHandler(this.delServicii_Click);
            // 
            // updServicii
            // 
            this.updServicii.BackColor = System.Drawing.Color.PaleGreen;
            this.updServicii.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updServicii.Location = new System.Drawing.Point(142, 184);
            this.updServicii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updServicii.Name = "updServicii";
            this.updServicii.Size = new System.Drawing.Size(60, 28);
            this.updServicii.TabIndex = 9;
            this.updServicii.Text = "Update";
            this.updServicii.UseVisualStyleBackColor = false;
            this.updServicii.Click += new System.EventHandler(this.updServicii_Click);
            // 
            // insertOrase
            // 
            this.insertOrase.BackColor = System.Drawing.Color.Orange;
            this.insertOrase.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertOrase.Location = new System.Drawing.Point(18, 344);
            this.insertOrase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertOrase.Name = "insertOrase";
            this.insertOrase.Size = new System.Drawing.Size(58, 28);
            this.insertOrase.TabIndex = 9;
            this.insertOrase.Text = "Insert";
            this.insertOrase.UseVisualStyleBackColor = false;
            this.insertOrase.Click += new System.EventHandler(this.insertOrase_Click);
            // 
            // updOrase
            // 
            this.updOrase.BackColor = System.Drawing.Color.PaleGreen;
            this.updOrase.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updOrase.Location = new System.Drawing.Point(141, 344);
            this.updOrase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updOrase.Name = "updOrase";
            this.updOrase.Size = new System.Drawing.Size(60, 28);
            this.updOrase.TabIndex = 9;
            this.updOrase.Text = "Update";
            this.updOrase.UseVisualStyleBackColor = false;
            this.updOrase.Click += new System.EventHandler(this.updOrase_Click);
            // 
            // iCleanDataSet
            // 
            this.iCleanDataSet.DataSetName = "iCleanDataSet";
            this.iCleanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iCleanDataSetBindingSource
            // 
            this.iCleanDataSetBindingSource.DataSource = this.iCleanDataSet;
            this.iCleanDataSetBindingSource.Position = 0;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this.iCleanDataSetBindingSource;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // cartiereBindingSource
            // 
            this.cartiereBindingSource.DataMember = "Cartiere";
            this.cartiereBindingSource.DataSource = this.iCleanDataSetBindingSource;
            // 
            // cartiereTableAdapter
            // 
            this.cartiereTableAdapter.ClearBeforeFill = true;
            // 
            // angajatiBindingSource1
            // 
            this.angajatiBindingSource1.DataMember = "Angajati";
            this.angajatiBindingSource1.DataSource = this.iCleanDataSetBindingSource;
            // 
            // angajatiClientiServiciiTableAdapter
            // 
            this.angajatiClientiServiciiTableAdapter.ClearBeforeFill = true;
            // 
            // angajatiBindingSource2
            // 
            this.angajatiBindingSource2.DataMember = "Angajati";
            this.angajatiBindingSource2.DataSource = this.iCleanDataSetBindingSource;
            // 
            // angajatiBindingSource3
            // 
            this.angajatiBindingSource3.DataMember = "Angajati";
            this.angajatiBindingSource3.DataSource = this.iCleanDataSetBindingSource;
            // 
            // insertServicii
            // 
            this.insertServicii.BackColor = System.Drawing.Color.Orange;
            this.insertServicii.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertServicii.Location = new System.Drawing.Point(18, 184);
            this.insertServicii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.insertServicii.Name = "insertServicii";
            this.insertServicii.Size = new System.Drawing.Size(58, 28);
            this.insertServicii.TabIndex = 10;
            this.insertServicii.Text = "Insert";
            this.insertServicii.UseVisualStyleBackColor = false;
            this.insertServicii.Click += new System.EventHandler(this.insertServicii_Click);
            // 
            // delOrase
            // 
            this.delOrase.BackColor = System.Drawing.Color.Cyan;
            this.delOrase.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delOrase.Location = new System.Drawing.Point(79, 344);
            this.delOrase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delOrase.Name = "delOrase";
            this.delOrase.Size = new System.Drawing.Size(58, 28);
            this.delOrase.TabIndex = 9;
            this.delOrase.Text = "Delete";
            this.delOrase.UseVisualStyleBackColor = false;
            this.delOrase.Click += new System.EventHandler(this.delOrase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Coral;
            this.dataGridView1.Location = new System.Drawing.Point(248, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(497, 488);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // simpleqButton
            // 
            this.simpleqButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.simpleqButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleqButton.Location = new System.Drawing.Point(248, 28);
            this.simpleqButton.Name = "simpleqButton";
            this.simpleqButton.Size = new System.Drawing.Size(110, 51);
            this.simpleqButton.TabIndex = 12;
            this.simpleqButton.Text = "Simple Queries";
            this.simpleqButton.UseVisualStyleBackColor = false;
            this.simpleqButton.Click += new System.EventHandler(this.simpleqButton_Click);
            // 
            // complexqButton
            // 
            this.complexqButton.BackColor = System.Drawing.Color.Aquamarine;
            this.complexqButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complexqButton.Location = new System.Drawing.Point(385, 28);
            this.complexqButton.Name = "complexqButton";
            this.complexqButton.Size = new System.Drawing.Size(113, 51);
            this.complexqButton.TabIndex = 12;
            this.complexqButton.Text = "Complex Queries";
            this.complexqButton.UseVisualStyleBackColor = false;
            this.complexqButton.Click += new System.EventHandler(this.complexqButton_Click);
            // 
            // fKAngajatiClientiServiciiAngajatiBindingSource
            // 
            this.fKAngajatiClientiServiciiAngajatiBindingSource.DataMember = "FK_AngajatiClientiServicii_Angajati";
            this.fKAngajatiClientiServiciiAngajatiBindingSource.DataSource = this.angajatiBindingSource1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.complexqButton);
            this.Controls.Add(this.simpleqButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertServicii);
            this.Controls.Add(this.btnOrase);
            this.Controls.Add(this.btnACS);
            this.Controls.Add(this.btnCartiere);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.delOrase);
            this.Controls.Add(this.updOrase);
            this.Controls.Add(this.insertOrase);
            this.Controls.Add(this.updServicii);
            this.Controls.Add(this.delServicii);
            this.Controls.Add(this.btnServicii);
            this.Controls.Add(this.btnAngajati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.extButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iCleanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCleanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAngajatiClientiServiciiAngajatiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAngajati;
        private System.Windows.Forms.Button btnServicii;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnCartiere;
        private System.Windows.Forms.Button btnOrase;
        private System.Windows.Forms.Button btnACS;
        private System.Windows.Forms.Button delServicii;
        private System.Windows.Forms.Button updServicii;
        private System.Windows.Forms.Button insertOrase;
        private System.Windows.Forms.Button updOrase;
        private System.Windows.Forms.BindingSource iCleanDataSetBindingSource;
        private iCleanDataSet iCleanDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private iCleanDataSetTableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private System.Windows.Forms.BindingSource cartiereBindingSource;
        private iCleanDataSetTableAdapters.CartiereTableAdapter cartiereTableAdapter;
        private System.Windows.Forms.BindingSource angajatiBindingSource1;
        private System.Windows.Forms.BindingSource fKAngajatiClientiServiciiAngajatiBindingSource;
        private iCleanDataSetTableAdapters.AngajatiClientiServiciiTableAdapter angajatiClientiServiciiTableAdapter;
        private System.Windows.Forms.BindingSource angajatiBindingSource3;
        private System.Windows.Forms.BindingSource angajatiBindingSource2;
        private System.Windows.Forms.Button insertServicii;
        private System.Windows.Forms.Button delOrase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button simpleqButton;
        private System.Windows.Forms.Button complexqButton;
    }
}