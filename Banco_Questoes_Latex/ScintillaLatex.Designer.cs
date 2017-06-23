namespace Banco_Questoes_Latex
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
            this.splitContainerPreview = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ScintillaEditor = new ScintillaNET.Scintilla();
            this.toolStripScintilla = new System.Windows.Forms.ToolStrip();
            this.toolStripContainerPreview = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagemLatex = new System.Windows.Forms.PictureBox();
            this.toolStripPreview = new System.Windows.Forms.ToolStrip();
            this.atualizaPictureBox = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPreview)).BeginInit();
            this.splitContainerPreview.Panel1.SuspendLayout();
            this.splitContainerPreview.Panel2.SuspendLayout();
            this.splitContainerPreview.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainerPreview.ContentPanel.SuspendLayout();
            this.toolStripContainerPreview.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerPreview.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLatex)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerPreview.Size = new System.Drawing.Size(996, 665);
            this.splitContainerPreview.SplitterDistance = 479;
            this.splitContainerPreview.TabIndex = 0;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ScintillaEditor);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(479, 640);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(479, 665);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripScintilla);
            // 
            // ScintillaEditor
            // 
            this.ScintillaEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScintillaEditor.Location = new System.Drawing.Point(0, 0);
            this.ScintillaEditor.Name = "ScintillaEditor";
            this.ScintillaEditor.Size = new System.Drawing.Size(479, 640);
            this.ScintillaEditor.TabIndex = 0;
            this.ScintillaEditor.BeforeInsert += new System.EventHandler<ScintillaNET.BeforeModificationEventArgs>(this.ScintillaEditor_BeforeInsert);
            this.ScintillaEditor.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.ScintillaEditor_CharAdded);
            // 
            // toolStripScintilla
            // 
            this.toolStripScintilla.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripScintilla.Location = new System.Drawing.Point(3, 0);
            this.toolStripScintilla.Name = "toolStripScintilla";
            this.toolStripScintilla.Size = new System.Drawing.Size(111, 25);
            this.toolStripScintilla.TabIndex = 0;
            // 
            // toolStripContainerPreview
            // 
            // 
            // toolStripContainerPreview.ContentPanel
            // 
            this.toolStripContainerPreview.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainerPreview.ContentPanel.Size = new System.Drawing.Size(513, 640);
            this.toolStripContainerPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerPreview.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerPreview.Name = "toolStripContainerPreview";
            this.toolStripContainerPreview.Size = new System.Drawing.Size(513, 665);
            this.toolStripContainerPreview.TabIndex = 1;
            this.toolStripContainerPreview.Text = "toolStripContainerPreview";
            // 
            // toolStripContainerPreview.TopToolStripPanel
            // 
            this.toolStripContainerPreview.TopToolStripPanel.Controls.Add(this.toolStripPreview);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.imagemLatex);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 640);
            this.panel1.TabIndex = 1;
            // 
            // imagemLatex
            // 
            this.imagemLatex.Location = new System.Drawing.Point(3, 3);
            this.imagemLatex.Name = "imagemLatex";
            this.imagemLatex.Size = new System.Drawing.Size(431, 539);
            this.imagemLatex.TabIndex = 0;
            this.imagemLatex.TabStop = false;
            // 
            // toolStripPreview
            // 
            this.toolStripPreview.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripPreview.Location = new System.Drawing.Point(3, 0);
            this.toolStripPreview.Name = "toolStripPreview";
            this.toolStripPreview.Size = new System.Drawing.Size(111, 25);
            this.toolStripPreview.TabIndex = 0;
            // 
            // atualizaPictureBox
            // 
            this.atualizaPictureBox.Interval = 300;
            this.atualizaPictureBox.Tick += new System.EventHandler(this.atualizaPictureBox_Tick);
            // 
            // ScintillaLatex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerPreview);
            this.Name = "ScintillaLatex";
            this.Size = new System.Drawing.Size(996, 665);
            this.splitContainerPreview.Panel1.ResumeLayout(false);
            this.splitContainerPreview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPreview)).EndInit();
            this.splitContainerPreview.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainerPreview.ContentPanel.ResumeLayout(false);
            this.toolStripContainerPreview.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerPreview.TopToolStripPanel.PerformLayout();
            this.toolStripContainerPreview.ResumeLayout(false);
            this.toolStripContainerPreview.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagemLatex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerPreview;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        public ScintillaNET.Scintilla ScintillaEditor;
        private System.Windows.Forms.ToolStrip toolStripScintilla;
        public System.Windows.Forms.ToolStripContainer toolStripContainerPreview;
        public System.Windows.Forms.PictureBox imagemLatex;
        private System.Windows.Forms.ToolStrip toolStripPreview;
        private System.Windows.Forms.Timer atualizaPictureBox;
        private System.Windows.Forms.Panel panel1;
    }
}
