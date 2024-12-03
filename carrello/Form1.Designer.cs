namespace Carrello2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Svuota = new Button();
            elimina = new Button();
            aggiungi = new Button();
            SuspendLayout();
            // 
            // Svuota
            // 
            Svuota.BackColor = SystemColors.MenuHighlight;
            Svuota.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Svuota.Location = new Point(322, 499);
            Svuota.Name = "Svuota";
            Svuota.Size = new Size(159, 49);
            Svuota.TabIndex = 1;
            Svuota.Text = "Svuota carrello";
            Svuota.UseVisualStyleBackColor = false;
            Svuota.Click += Svuota_Click;
            // 
            // elimina
            // 
            elimina.BackColor = SystemColors.MenuHighlight;
            elimina.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            elimina.ForeColor = SystemColors.ControlText;
            elimina.Location = new Point(107, 134);
            elimina.Name = "elimina";
            elimina.Size = new Size(121, 66);
            elimina.TabIndex = 2;
            elimina.Text = "Elimina prodotto";
            elimina.UseVisualStyleBackColor = false;
            elimina.Click += elimina_Click;
            // 
            // aggiungi
            // 
            aggiungi.BackColor = SystemColors.MenuHighlight;
            aggiungi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aggiungi.Location = new Point(584, 134);
            aggiungi.Name = "aggiungi";
            aggiungi.Size = new Size(129, 66);
            aggiungi.TabIndex = 3;
            aggiungi.Text = "Aggiungi prodotto";
            aggiungi.UseVisualStyleBackColor = false;
            aggiungi.Click += aggiungi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 549);
            Controls.Add(aggiungi);
            Controls.Add(elimina);
            Controls.Add(Svuota);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button Svuota;
        private Button elimina;
        private Button aggiungi;
    }
}
