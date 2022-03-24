namespace ProiectBD
{
    partial class UpdateServicii
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
            this.backButton = new System.Windows.Forms.Button();
            this.extButton = new System.Windows.Forms.Button();
            this.sbmButton = new System.Windows.Forms.Button();
            this.pret_serviciu_box = new System.Windows.Forms.TextBox();
            this.buget_alocat_box = new System.Windows.Forms.TextBox();
            this.nume_serviciu_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insrtTextbox = new System.Windows.Forms.Label();
            this.serv_vechi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PowderBlue;
            this.backButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(640, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(69, 24);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // extButton
            // 
            this.extButton.BackColor = System.Drawing.Color.LightCoral;
            this.extButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extButton.ForeColor = System.Drawing.Color.Black;
            this.extButton.Location = new System.Drawing.Point(724, 11);
            this.extButton.Margin = new System.Windows.Forms.Padding(2);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(51, 24);
            this.extButton.TabIndex = 12;
            this.extButton.Text = "Exit";
            this.extButton.UseVisualStyleBackColor = false;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // sbmButton
            // 
            this.sbmButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmButton.Location = new System.Drawing.Point(362, 398);
            this.sbmButton.Name = "sbmButton";
            this.sbmButton.Size = new System.Drawing.Size(105, 41);
            this.sbmButton.TabIndex = 21;
            this.sbmButton.Text = "Submit";
            this.sbmButton.UseVisualStyleBackColor = true;
            this.sbmButton.Click += new System.EventHandler(this.sbmButton_Click);
            // 
            // pret_serviciu_box
            // 
            this.pret_serviciu_box.Location = new System.Drawing.Point(298, 321);
            this.pret_serviciu_box.Name = "pret_serviciu_box";
            this.pret_serviciu_box.Size = new System.Drawing.Size(169, 20);
            this.pret_serviciu_box.TabIndex = 18;
            // 
            // buget_alocat_box
            // 
            this.buget_alocat_box.Location = new System.Drawing.Point(298, 278);
            this.buget_alocat_box.Name = "buget_alocat_box";
            this.buget_alocat_box.Size = new System.Drawing.Size(169, 20);
            this.buget_alocat_box.TabIndex = 19;
            // 
            // nume_serviciu_box
            // 
            this.nume_serviciu_box.Location = new System.Drawing.Point(298, 235);
            this.nume_serviciu_box.Name = "nume_serviciu_box";
            this.nume_serviciu_box.Size = new System.Drawing.Size(169, 20);
            this.nume_serviciu_box.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pret nou serviciu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Bugetul nou alocat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nume nou serviciu:";
            // 
            // insrtTextbox
            // 
            this.insrtTextbox.AutoSize = true;
            this.insrtTextbox.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insrtTextbox.Location = new System.Drawing.Point(97, 177);
            this.insrtTextbox.Name = "insrtTextbox";
            this.insrtTextbox.Size = new System.Drawing.Size(664, 22);
            this.insrtTextbox.TabIndex = 14;
            this.insrtTextbox.Text = "Introduceti datele noi despre serviciul cu numele introdus mai sus:";
            // 
            // serv_vechi
            // 
            this.serv_vechi.Location = new System.Drawing.Point(298, 131);
            this.serv_vechi.Name = "serv_vechi";
            this.serv_vechi.Size = new System.Drawing.Size(169, 20);
            this.serv_vechi.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nume serviciu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(603, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "Introduceti NUMELE serviciului ce se doreste a fi actualizat:";
            // 
            // UpdateServicii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.serv_vechi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sbmButton);
            this.Controls.Add(this.pret_serviciu_box);
            this.Controls.Add(this.buget_alocat_box);
            this.Controls.Add(this.nume_serviciu_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insrtTextbox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.extButton);
            this.MaximizeBox = false;
            this.Name = "UpdateServicii";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateServicii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.Button sbmButton;
        private System.Windows.Forms.TextBox pret_serviciu_box;
        private System.Windows.Forms.TextBox buget_alocat_box;
        private System.Windows.Forms.TextBox nume_serviciu_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label insrtTextbox;
        private System.Windows.Forms.TextBox serv_vechi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}