namespace Conteggio_parole
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
            lbl_stringa = new Label();
            lbl_parole = new Label();
            btn_calcola = new Button();
            txt_stringa = new TextBox();
            SuspendLayout();
            // 
            // lbl_stringa
            // 
            lbl_stringa.AutoSize = true;
            lbl_stringa.Location = new Point(342, 74);
            lbl_stringa.Name = "lbl_stringa";
            lbl_stringa.Size = new Size(111, 15);
            lbl_stringa.TabIndex = 0;
            lbl_stringa.Text = "Inserisci una stringa";
            // 
            // lbl_parole
            // 
            lbl_parole.AutoSize = true;
            lbl_parole.Location = new Point(354, 256);
            lbl_parole.Name = "lbl_parole";
            lbl_parole.Size = new Size(87, 15);
            lbl_parole.TabIndex = 1;
            lbl_parole.Text = "Le parole sono:";
            // 
            // btn_calcola
            // 
            btn_calcola.Location = new Point(360, 210);
            btn_calcola.Name = "btn_calcola";
            btn_calcola.Size = new Size(75, 23);
            btn_calcola.TabIndex = 2;
            btn_calcola.Text = "Calcola";
            btn_calcola.UseVisualStyleBackColor = true;
            btn_calcola.Click += btn_calcola_Click;
            // 
            // txt_stringa
            // 
            txt_stringa.Location = new Point(347, 92);
            txt_stringa.Name = "txt_stringa";
            txt_stringa.Size = new Size(100, 23);
            txt_stringa.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_stringa);
            Controls.Add(btn_calcola);
            Controls.Add(lbl_parole);
            Controls.Add(lbl_stringa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_stringa;
        private Label lbl_parole;
        private Button btn_calcola;
        private TextBox txt_stringa;
    }
}
