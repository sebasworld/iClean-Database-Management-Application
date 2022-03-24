namespace ProiectBD
{
    partial class InsertOrase
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
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.PowderBlue;
            this.backButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(629, 20);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(69, 24);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // extButton
            // 
            this.extButton.BackColor = System.Drawing.Color.LightCoral;
            this.extButton.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extButton.ForeColor = System.Drawing.Color.Black;
            this.extButton.Location = new System.Drawing.Point(713, 20);
            this.extButton.Margin = new System.Windows.Forms.Padding(2);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(51, 24);
            this.extButton.TabIndex = 8;
            this.extButton.Text = "Exit";
            this.extButton.UseVisualStyleBackColor = false;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // sbmButton
            // 
            this.sbmButton.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbmButton.Location = new System.Drawing.Point(379, 266);
            this.sbmButton.Name = "sbmButton";
            this.sbmButton.Size = new System.Drawing.Size(105, 41);
            this.sbmButton.TabIndex = 19;
            this.sbmButton.Text = "Submit";
            this.sbmButton.UseVisualStyleBackColor = true;
            this.sbmButton.Click += new System.EventHandler(this.sbmButton_Click);
            // 
            // judet_box
            // 
            this.judet_box.Location = new System.Drawing.Point(315, 186);
            this.judet_box.Name = "judet_box";
            this.judet_box.Size = new System.Drawing.Size(169, 20);
            this.judet_box.TabIndex = 17;
            this.judet_box.TextChanged += new System.EventHandler(this.judet_box_TextChanged);
            // 
            // nume_oras_box
            // 
            this.nume_oras_box.Location = new System.Drawing.Point(315, 143);
            this.nume_oras_box.Name = "nume_oras_box";
            this.nume_oras_box.Size = new System.Drawing.Size(169, 20);
            this.nume_oras_box.TabIndex = 18;
            this.nume_oras_box.TextChanged += new System.EventHandler(this.nume_serviciu_box_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Judetul orasului:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nume oras:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // insrtTextbox
            // 
            this.insrtTextbox.AutoSize = true;
            this.insrtTextbox.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insrtTextbox.Location = new System.Drawing.Point(114, 85);
            this.insrtTextbox.Name = "insrtTextbox";
            this.insrtTextbox.Size = new System.Drawing.Size(334, 22);
            this.insrtTextbox.TabIndex = 12;
            this.insrtTextbox.Text = "Introduceti datele unui nou Oras:";
            this.insrtTextbox.Click += new System.EventHandler(this.insrtTextbox_Click);
            // 
            // InsertOrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.sbmButton);
            this.Controls.Add(this.judet_box);
            this.Controls.Add(this.nume_oras_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insrtTextbox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.extButton);
            this.MaximizeBox = false;
            this.Name = "InsertOrase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InsertOrase";
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
    }
}