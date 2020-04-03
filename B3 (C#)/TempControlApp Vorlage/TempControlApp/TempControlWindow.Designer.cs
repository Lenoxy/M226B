namespace TempControlApp {
    partial class TempControlWindow {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSollTemp = new System.Windows.Forms.Label();
            this.txtSollTemp = new System.Windows.Forms.TextBox();
            this.txtIstTemp = new System.Windows.Forms.TextBox();
            this.lblIstTemp = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAktualisieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSollTemp
            // 
            this.lblSollTemp.AutoSize = true;
            this.lblSollTemp.Location = new System.Drawing.Point(21, 19);
            this.lblSollTemp.Name = "lblSollTemp";
            this.lblSollTemp.Size = new System.Drawing.Size(84, 13);
            this.lblSollTemp.TabIndex = 1;
            this.lblSollTemp.Text = "Soll-Temperatur:";
            // 
            // txtSollTemp
            // 
            this.txtSollTemp.Location = new System.Drawing.Point(111, 16);
            this.txtSollTemp.Name = "txtSollTemp";
            this.txtSollTemp.Size = new System.Drawing.Size(72, 20);
            this.txtSollTemp.TabIndex = 2;
            // 
            // txtIstTemp
            // 
            this.txtIstTemp.Location = new System.Drawing.Point(111, 47);
            this.txtIstTemp.Name = "txtIstTemp";
            this.txtIstTemp.ReadOnly = true;
            this.txtIstTemp.Size = new System.Drawing.Size(72, 20);
            this.txtIstTemp.TabIndex = 5;
            // 
            // lblIstTemp
            // 
            this.lblIstTemp.AutoSize = true;
            this.lblIstTemp.Location = new System.Drawing.Point(21, 50);
            this.lblIstTemp.Name = "lblIstTemp";
            this.lblIstTemp.Size = new System.Drawing.Size(78, 13);
            this.lblIstTemp.TabIndex = 4;
            this.lblIstTemp.Text = "Ist-Temperatur:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(91, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAktualisieren
            // 
            this.btnAktualisieren.Location = new System.Drawing.Point(189, 46);
            this.btnAktualisieren.Name = "btnAktualisieren";
            this.btnAktualisieren.Size = new System.Drawing.Size(84, 30);
            this.btnAktualisieren.TabIndex = 7;
            this.btnAktualisieren.Text = "Aktualisieren";
            this.btnAktualisieren.UseVisualStyleBackColor = true;
            this.btnAktualisieren.Click += new System.EventHandler(this.OnAktualisieren);
            // 
            // TempControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 134);
            this.Controls.Add(this.btnAktualisieren);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtIstTemp);
            this.Controls.Add(this.lblIstTemp);
            this.Controls.Add(this.txtSollTemp);
            this.Controls.Add(this.lblSollTemp);
            this.Controls.Add(this.btnSave);
            this.Name = "TempControlWindow";
            this.Text = "TempControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSollTemp;
        private System.Windows.Forms.TextBox txtSollTemp;
        private System.Windows.Forms.TextBox txtIstTemp;
        private System.Windows.Forms.Label lblIstTemp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAktualisieren;
    }
}

