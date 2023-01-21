namespace TEST123123
{
    partial class LS_Admin_Panel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LS_Admin_Panel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Berechtigungen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtusrid = new System.Windows.Forms.TextBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.txtBenutzername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SpeichernBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 331);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Berechtigungen);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtusrid);
            this.groupBox1.Controls.Add(this.checkBox24);
            this.groupBox1.Controls.Add(this.checkBox25);
            this.groupBox1.Controls.Add(this.txtBenutzername);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SpeichernBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 359);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Berechtigungen
            // 
            this.Berechtigungen.AutoSize = true;
            this.Berechtigungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Berechtigungen.Location = new System.Drawing.Point(335, 18);
            this.Berechtigungen.Name = "Berechtigungen";
            this.Berechtigungen.Size = new System.Drawing.Size(155, 25);
            this.Berechtigungen.TabIndex = 67;
            this.Berechtigungen.Text = "Berechtigungen:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(813, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 42);
            this.button1.TabIndex = 66;
            this.button1.Text = "Benutzer Löschen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(745, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "User ID";
            // 
            // txtusrid
            // 
            this.txtusrid.Location = new System.Drawing.Point(748, 79);
            this.txtusrid.Multiline = true;
            this.txtusrid.Name = "txtusrid";
            this.txtusrid.Size = new System.Drawing.Size(59, 20);
            this.txtusrid.TabIndex = 63;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox24.Location = new System.Drawing.Point(496, 17);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(56, 29);
            this.checkBox24.TabIndex = 57;
            this.checkBox24.Text = "LS";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox25.Location = new System.Drawing.Point(573, 19);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(87, 29);
            this.checkBox25.TabIndex = 56;
            this.checkBox25.Text = "Admin";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // txtBenutzername
            // 
            this.txtBenutzername.Location = new System.Drawing.Point(12, 29);
            this.txtBenutzername.Name = "txtBenutzername";
            this.txtBenutzername.Size = new System.Drawing.Size(129, 20);
            this.txtBenutzername.TabIndex = 25;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(170, 31);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(132, 20);
            this.txtPass.TabIndex = 23;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Benutzername:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Passwort:";
            // 
            // SpeichernBtn
            // 
            this.SpeichernBtn.BackColor = System.Drawing.Color.Lime;
            this.SpeichernBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeichernBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SpeichernBtn.Location = new System.Drawing.Point(813, 9);
            this.SpeichernBtn.Name = "SpeichernBtn";
            this.SpeichernBtn.Size = new System.Drawing.Size(242, 42);
            this.SpeichernBtn.TabIndex = 7;
            this.SpeichernBtn.Text = "Benutzer Erstellen";
            this.SpeichernBtn.UseVisualStyleBackColor = false;
            this.SpeichernBtn.Click += new System.EventHandler(this.SpeBtn_Click);
            // 
            // LS_Admin_Panel
            // 
            this.AcceptButton = this.SpeichernBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LS_Admin_Panel";
            this.Text = "LS Admin Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtusrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.TextBox txtBenutzername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SpeichernBtn;
        private System.Windows.Forms.Label Berechtigungen;
    }
}

