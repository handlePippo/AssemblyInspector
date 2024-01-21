namespace AssemblyInspector
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InspectAttributes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InspectMethods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // InspectAttributes
            // 
            this.InspectAttributes.Location = new System.Drawing.Point(148, 36);
            this.InspectAttributes.Name = "InspectAttributes";
            this.InspectAttributes.Size = new System.Drawing.Size(121, 49);
            this.InspectAttributes.TabIndex = 0;
            this.InspectAttributes.Tag = "Attributes";
            this.InspectAttributes.Text = "Inspect Assembly Attributes";
            this.InspectAttributes.UseVisualStyleBackColor = true;
            this.InspectAttributes.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 307);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // InspectMethods
            // 
            this.InspectMethods.Location = new System.Drawing.Point(40, 36);
            this.InspectMethods.Name = "InspectMethods";
            this.InspectMethods.Size = new System.Drawing.Size(102, 49);
            this.InspectMethods.TabIndex = 2;
            this.InspectMethods.Tag = "Methods";
            this.InspectMethods.Text = "Inspect Assembly Methods";
            this.InspectMethods.UseVisualStyleBackColor = true;
            this.InspectMethods.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 439);
            this.Controls.Add(this.InspectMethods);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InspectAttributes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button InspectAttributes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button InspectMethods;
    }
}

