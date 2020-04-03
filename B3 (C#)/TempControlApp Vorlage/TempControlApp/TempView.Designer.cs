namespace TempControlApp {
    partial class TempView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIstTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSollTemp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(59, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 33);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "aktuelle Temperatur:";
            // 
            // lblIstTemp
            // 
            this.lblIstTemp.AutoSize = true;
            this.lblIstTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIstTemp.Location = new System.Drawing.Point(122, 9);
            this.lblIstTemp.Name = "lblIstTemp";
            this.lblIstTemp.Size = new System.Drawing.Size(129, 18);
            this.lblIstTemp.TabIndex = 2;
            this.lblIstTemp.Text = "15 Grad Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Soll-Temperatur:";
            // 
            // lblSollTemp
            // 
            this.lblSollTemp.AutoSize = true;
            this.lblSollTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSollTemp.Location = new System.Drawing.Point(122, 39);
            this.lblSollTemp.Name = "lblSollTemp";
            this.lblSollTemp.Size = new System.Drawing.Size(129, 18);
            this.lblSollTemp.TabIndex = 4;
            this.lblSollTemp.Text = "20 Grad Celsius";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TempView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 125);
            this.Controls.Add(this.lblSollTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIstTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Name = "TempView";
            this.Text = "TempView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TempView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIstTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSollTemp;
        private System.Windows.Forms.Timer timer1;
    }
}