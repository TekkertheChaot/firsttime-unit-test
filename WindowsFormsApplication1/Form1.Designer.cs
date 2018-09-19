namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.box_zaehler = new System.Windows.Forms.TextBox();
            this.box_nenner = new System.Windows.Forms.TextBox();
            this.box_ergebnis = new System.Windows.Forms.TextBox();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box_zaehler
            // 
            this.box_zaehler.Location = new System.Drawing.Point(13, 13);
            this.box_zaehler.Name = "box_zaehler";
            this.box_zaehler.Size = new System.Drawing.Size(92, 20);
            this.box_zaehler.TabIndex = 0;
            // 
            // box_nenner
            // 
            this.box_nenner.Location = new System.Drawing.Point(126, 13);
            this.box_nenner.Name = "box_nenner";
            this.box_nenner.Size = new System.Drawing.Size(92, 20);
            this.box_nenner.TabIndex = 1;
            // 
            // box_ergebnis
            // 
            this.box_ergebnis.Location = new System.Drawing.Point(305, 13);
            this.box_ergebnis.Name = "box_ergebnis";
            this.box_ergebnis.Size = new System.Drawing.Size(92, 20);
            this.box_ergebnis.TabIndex = 2;
            // 
            // btn_proceed
            // 
            this.btn_proceed.Location = new System.Drawing.Point(224, 13);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 3;
            this.btn_proceed.Text = "Ergebnis";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // div
            // 
            this.div.AutoSize = true;
            this.div.Location = new System.Drawing.Point(108, 16);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(12, 13);
            this.div.TabIndex = 4;
            this.div.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 50);
            this.Controls.Add(this.div);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.box_ergebnis);
            this.Controls.Add(this.box_nenner);
            this.Controls.Add(this.box_zaehler);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_zaehler;
        private System.Windows.Forms.TextBox box_nenner;
        private System.Windows.Forms.TextBox box_ergebnis;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label div;
    }
}

