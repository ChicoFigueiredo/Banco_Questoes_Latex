namespace Componentes_do_Chico
{
    partial class ScintillaLatex
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScintillaLatex));
            this.atualizaPictureBox = new System.Windows.Forms.Timer(this.components);
            this.imagemLatex = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripContainerPreview = new System.Windows.Forms.ToolStripContainer();
            this.toolStripPreview = new System.Windows.Forms.ToolStrip();
            this.mnuFormatador = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripScintilla = new System.Windows.Forms.ToolStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ScintillaEditor = new ScintillaNET.ScintilaEx();
            this.splitContainerPreview = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLatex)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStripContainerPreview.ContentPanel.SuspendLayout();
            this.toolStripContainerPreview.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerPreview.SuspendLayout();
            this.toolStripScintilla.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPreview)).BeginInit();
            this.splitContainerPreview.Panel1.SuspendLayout();
            this.splitContainerPreview.Panel2.SuspendLayout();
            this.splitContainerPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // atualizaPictureBox
            // 
            this.atualizaPictureBox.Interval = 300;
            // 
            // imagemLatex
            // 
            this.imagemLatex.BackColor = System.Drawing.Color.White;
            this.imagemLatex.Location = new System.Drawing.Point(3, 3);
            this.imagemLatex.Name = "imagemLatex";
            this.imagemLatex.Size = new System.Drawing.Size(497, 591);
            this.imagemLatex.TabIndex = 0;
            this.imagemLatex.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.imagemLatex);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 733);
            this.panel1.TabIndex = 1;
            // 
            // toolStripContainerPreview
            // 
            // 
            // toolStripContainerPreview.ContentPanel
            // 
            this.toolStripContainerPreview.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainerPreview.ContentPanel.Size = new System.Drawing.Size(521, 733);
            this.toolStripContainerPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerPreview.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerPreview.Name = "toolStripContainerPreview";
            this.toolStripContainerPreview.Size = new System.Drawing.Size(521, 758);
            this.toolStripContainerPreview.TabIndex = 1;
            this.toolStripContainerPreview.Text = "toolStripContainerPreview";
            // 
            // toolStripContainerPreview.TopToolStripPanel
            // 
            this.toolStripContainerPreview.TopToolStripPanel.Controls.Add(this.toolStripPreview);
            // 
            // toolStripPreview
            // 
            this.toolStripPreview.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPreview.Location = new System.Drawing.Point(3, 0);
            this.toolStripPreview.Name = "toolStripPreview";
            this.toolStripPreview.Size = new System.Drawing.Size(111, 25);
            this.toolStripPreview.TabIndex = 0;
            // 
            // mnuFormatador
            // 
            this.mnuFormatador.Image = ((System.Drawing.Image)(resources.GetObject("mnuFormatador.Image")));
            this.mnuFormatador.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFormatador.Name = "mnuFormatador";
            this.mnuFormatador.Size = new System.Drawing.Size(68, 22);
            this.mnuFormatador.Text = "&Inserir";
            // 
            // toolStripScintilla
            // 
            this.toolStripScintilla.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripScintilla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormatador});
            this.toolStripScintilla.Location = new System.Drawing.Point(3, 0);
            this.toolStripScintilla.Name = "toolStripScintilla";
            this.toolStripScintilla.Size = new System.Drawing.Size(111, 25);
            this.toolStripScintilla.TabIndex = 0;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ScintillaEditor);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(486, 733);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(486, 758);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripScintilla);
            // 
            // ScintillaEditor
            // 
            this.ScintillaEditor.DelayedTextChangedTimeout = 300;
            this.ScintillaEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScintillaEditor.Location = new System.Drawing.Point(0, 0);
            this.ScintillaEditor.Name = "ScintillaEditor";
            this.ScintillaEditor.Size = new System.Drawing.Size(486, 733);
            this.ScintillaEditor.TabIndex = 0;
            this.ScintillaEditor.DelayedTextChanged += new System.EventHandler(this.ScintillaEditor_DelayedTextChanged);
            this.ScintillaEditor.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.ScintillaEditor_CharAdded);
            this.ScintillaEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScintillaEditor_KeyDown);
            // 
            // splitContainerPreview
            // 
            this.splitContainerPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPreview.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPreview.Name = "splitContainerPreview";
            // 
            // splitContainerPreview.Panel1
            // 
            this.splitContainerPreview.Panel1.Controls.Add(this.toolStripContainer1);
            // 
            // splitContainerPreview.Panel2
            // 
            this.splitContainerPreview.Panel2.Controls.Add(this.toolStripContainerPreview);
            this.splitContainerPreview.Size = new System.Drawing.Size(1011, 758);
            this.splitContainerPreview.SplitterDistance = 486;
            this.splitContainerPreview.TabIndex = 1;
            // 
            // ScintillaLatex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerPreview);
            this.Name = "ScintillaLatex";
            this.Size = new System.Drawing.Size(1011, 758);
            ((System.ComponentModel.ISupportInitialize)(this.imagemLatex)).EndInit();
            this.panel1.ResumeLayout(false);
            this.toolStripContainerPreview.ContentPanel.ResumeLayout(false);
            this.toolStripContainerPreview.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerPreview.TopToolStripPanel.PerformLayout();
            this.toolStripContainerPreview.ResumeLayout(false);
            this.toolStripContainerPreview.PerformLayout();
            this.toolStripScintilla.ResumeLayout(false);
            this.toolStripScintilla.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainerPreview.Panel1.ResumeLayout(false);
            this.splitContainerPreview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPreview)).EndInit();
            this.splitContainerPreview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer atualizaPictureBox;
        public System.Windows.Forms.PictureBox imagemLatex;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ToolStripContainer toolStripContainerPreview;
        private System.Windows.Forms.ToolStrip toolStripPreview;
        private System.Windows.Forms.ToolStripDropDownButton mnuFormatador;
        private System.Windows.Forms.ToolStrip toolStripScintilla;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainerPreview;
        private ScintillaNET.ScintilaEx ScintillaEditor;
    }
}
