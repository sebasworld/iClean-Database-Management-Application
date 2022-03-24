namespace ProiectBD
{
    partial class UpdateOrase
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
            this.judet_box = new System.Windows.Forms.TextBox();
            this.nume_oras_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insrtTextbox = new System.Windows.Forms.Label();
            this.oras_vechi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PowderBlue;
            this.backButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(638, 11);
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
            this.extButton.Location = new System.Drawing.Point(722, 11);
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
            this.sbmButton.Location = new System.Drawing.Point(353, 367);
            this.sbmButton.Name = "sbmButton";
            this.sbmButton.Size = new System.Drawing.Size(105, 41);
            this.sbmButton.TabIndex = 25;
            this.sbmButton.Text = "Submit";
            this.sbmButton.UseVisualStyleBackColor = true;
            this.sbmButton.Click += new System.EventHandler(this.sbmButton_Click);
            // 
            // judet_box
            // 
            this.judet_box.Location = new System.Drawing.Point(289, 288);
            this.judet_box.Name = "judet_box";
            this.judet_box.Size = new System.Drawing.Size(169, 20);
            this.judet_box.TabIndex = 23;
            // 
            // nume_oras_box
            // 
            this.nume_oras_box.Location = new System.Drawing.Point(289, 245);
            this.nume_oras_box.Name = "nume_oras_box";
            this.nume_oras_box.Size = new System.Drawing.Size(169, 20);
            this.nume_oras_box.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Judetul nou:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nume nou oras:";
            // 
            // insrtTextbox
            // 
            this.insrtTextbox.AutoSize = true;
            this.insrtTextbox.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insrtTextbox.Location = new System.Drawing.Point(88, 187);
            this.insrtTextbox.Name = "insrtTextbox";
            this.insrtTextbox.Size = new System.Drawing.Size(639, 22);
            this.insrtTextbox.TabIndex = 20;
            this.insrtTextbox.Text = "Introduceti datele noi despre orasul cu numele introdus mai sus:";
            // 
            // oras_vechi
            // 
            this.oras_vechi.Location = new System.Drawing.Point(289, 110);
            this.oras_vechi.Name = "oras_vechi";
            this.oras_vechi.Size = new System.Drawing.Size(169, 20);
            this.oras_vechi.TabIndex = 28;
            this.oras_vechi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nume oras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(578, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Introduceti NUMELE orasului ce se doreste a fi actualizat:";
            // 
            // UpdateOrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.oras_vechi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sbmButton);
            this.Controls.Add(this.judet_box);
            this.Controls.Add(this.nume_oras_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insrtTextbox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.extButton);
            this.MaximizeBox = false;
            this.Name = "UpdateOrase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateOrase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.Button sbmButton;
        private System.Windows.Forms.TextBox judet_box;
        private System.Windows.Forms.TextBox nume_oras_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label insrtTextbox;
        private System.Windows.Forms.TextBox oras_vechi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}