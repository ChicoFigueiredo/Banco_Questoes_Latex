namespace Banco_Questoes_Latex
{
    partial class Testes2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scintillaLatex1 = new Componentes_do_Chico.ScintillaLatex();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scintillaLatex1);
            this.splitContainer1.Size = new System.Drawing.Size(1043, 734);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // scintillaLatex1
            // 
            this.scintillaLatex1.Atualizaar_Picturebox = true;
            this.scintillaLatex1.Barra_Preview_Visivel = true;
            this.scintillaLatex1.Barra_Scintilla_Visivel = true;
            this.scintillaLatex1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintillaLatex1.Intervalo_Atualizacao_Picturebox = 300;
            this.scintillaLatex1.Location = new System.Drawing.Point(0, 0);
            this.scintillaLatex1.Name = "scintillaLatex1";
            this.scintillaLatex1.Orientacao = System.Windows.Forms.Orientation.Vertical;
            this.scintillaLatex1.Size = new System.Drawing.Size(1043, 630);
            this.scintillaLatex1.TabIndex = 0;
            // 
            // Testes2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 734);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Testes2";
            this.Text = "Testes2";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Componentes_do_Chico.ScintillaLatex scintillaLatex1;
    }
}