namespace VerificaRA
{
    partial class Frm_VerificaRA
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
            btn_Verifica = new Button();
            lbl_Titulo = new Label();
            txb_RA = new TextBox();
            SuspendLayout();
            // 
            // btn_Verifica
            // 
            btn_Verifica.Location = new Point(109, 159);
            btn_Verifica.MaximumSize = new Size(152, 25);
            btn_Verifica.MinimumSize = new Size(152, 25);
            btn_Verifica.Name = "btn_Verifica";
            btn_Verifica.Size = new Size(152, 25);
            btn_Verifica.TabIndex = 1;
            btn_Verifica.Text = "Verificar";
            btn_Verifica.UseVisualStyleBackColor = true;
            btn_Verifica.Click += btn_Verifica_Click;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Titulo.Location = new Point(109, 51);
            lbl_Titulo.MaximumSize = new Size(152, 25);
            lbl_Titulo.MinimumSize = new Size(152, 25);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(152, 25);
            lbl_Titulo.TabIndex = 5;
            lbl_Titulo.Text = "Digite o seu RA:";
            // 
            // txb_RA
            // 
            txb_RA.Location = new Point(109, 106);
            txb_RA.MaximumSize = new Size(152, 23);
            txb_RA.MaxLength = 7;
            txb_RA.MinimumSize = new Size(152, 23);
            txb_RA.Name = "txb_RA";
            txb_RA.Size = new Size(152, 23);
            txb_RA.TabIndex = 0;
            // 
            // Frm_VerificaRA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(371, 258);
            Controls.Add(txb_RA);
            Controls.Add(lbl_Titulo);
            Controls.Add(btn_Verifica);
            MaximumSize = new Size(387, 297);
            MinimumSize = new Size(387, 297);
            Name = "Frm_VerificaRA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verifica RA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Verifica;
        private Label lbl_Titulo;
        private TextBox txb_RA;
    }
}
