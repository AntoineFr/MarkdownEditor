namespace MarkdownEditor
{
    partial class MainView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.editor = new System.Windows.Forms.RichTextBox();
            this.renderer = new System.Windows.Forms.WebBrowser();
            this.menubar = new System.Windows.Forms.ToolStrip();
            this.newFileButton = new System.Windows.Forms.ToolStripButton();
            this.openFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldButton = new System.Windows.Forms.ToolStripButton();
            this.italicButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.unorderedListButton = new System.Windows.Forms.ToolStripButton();
            this.orderedListButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.heading1Button = new System.Windows.Forms.ToolStripButton();
            this.heading2Button = new System.Windows.Forms.ToolStripButton();
            this.heading3Button = new System.Windows.Forms.ToolStripButton();
            this.heading4Button = new System.Windows.Forms.ToolStripButton();
            this.heading5Button = new System.Windows.Forms.ToolStripButton();
            this.heading6Button = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.editor);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.renderer);
            this.splitContainer1.Size = new System.Drawing.Size(982, 444);
            this.splitContainer1.SplitterDistance = 486;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // editor
            // 
            this.editor.AcceptsTab = true;
            this.editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editor.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.Location = new System.Drawing.Point(5, 5);
            this.editor.Margin = new System.Windows.Forms.Padding(5);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(476, 434);
            this.editor.TabIndex = 0;
            this.editor.Text = "";
            this.editor.TextChanged += new System.EventHandler(this.editor_TextChanged);
            // 
            // renderer
            // 
            this.renderer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderer.Location = new System.Drawing.Point(5, 5);
            this.renderer.Margin = new System.Windows.Forms.Padding(5);
            this.renderer.MinimumSize = new System.Drawing.Size(20, 20);
            this.renderer.Name = "renderer";
            this.renderer.Size = new System.Drawing.Size(476, 434);
            this.renderer.TabIndex = 0;
            // 
            // menubar
            // 
            this.menubar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileButton,
            this.openFileButton,
            this.saveFileButton,
            this.toolStripSeparator,
            this.helpButton,
            this.toolStripSeparator1,
            this.boldButton,
            this.italicButton,
            this.toolStripSeparator2,
            this.unorderedListButton,
            this.orderedListButton,
            this.toolStripSeparator3,
            this.heading1Button,
            this.heading2Button,
            this.heading3Button,
            this.heading4Button,
            this.heading5Button,
            this.heading6Button});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(982, 27);
            this.menubar.TabIndex = 1;
            this.menubar.Text = "toolStrip1";
            // 
            // newFileButton
            // 
            this.newFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFileButton.Image = ((System.Drawing.Image)(resources.GetObject("newFileButton.Image")));
            this.newFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(24, 24);
            this.newFileButton.Text = "&Nouveau";
            // 
            // openFileButton
            // 
            this.openFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(24, 24);
            this.openFileButton.Text = "&Ouvrir";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(24, 24);
            this.saveFileButton.Text = "&Enregistrer";
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // helpButton
            // 
            this.helpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(24, 24);
            this.helpButton.Text = "Aide";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // boldButton
            // 
            this.boldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.boldButton.Image = ((System.Drawing.Image)(resources.GetObject("boldButton.Image")));
            this.boldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(24, 24);
            this.boldButton.Text = "G";
            this.boldButton.ToolTipText = "Gras";
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.italicButton.Image = ((System.Drawing.Image)(resources.GetObject("italicButton.Image")));
            this.italicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(24, 24);
            this.italicButton.Text = "I";
            this.italicButton.ToolTipText = "Italique";
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // unorderedListButton
            // 
            this.unorderedListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.unorderedListButton.Image = ((System.Drawing.Image)(resources.GetObject("unorderedListButton.Image")));
            this.unorderedListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.unorderedListButton.Name = "unorderedListButton";
            this.unorderedListButton.Size = new System.Drawing.Size(24, 24);
            this.unorderedListButton.Text = "Liste non ordonnée";
            this.unorderedListButton.Click += new System.EventHandler(this.unorderedListButton_Click);
            // 
            // orderedListButton
            // 
            this.orderedListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderedListButton.Image = ((System.Drawing.Image)(resources.GetObject("orderedListButton.Image")));
            this.orderedListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.orderedListButton.Name = "orderedListButton";
            this.orderedListButton.Size = new System.Drawing.Size(24, 24);
            this.orderedListButton.Text = "Liste ordonnée";
            this.orderedListButton.Click += new System.EventHandler(this.orderedListButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // heading1Button
            // 
            this.heading1Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.heading1Button.Image = ((System.Drawing.Image)(resources.GetObject("heading1Button.Image")));
            this.heading1Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.heading1Button.Name = "heading1Button";
            this.heading1Button.Size = new System.Drawing.Size(24, 24);
            this.heading1Button.Text = "Titre 1";
            this.heading1Button.Click += new System.EventHandler(this.heading1Button_Click);
            // 
            // heading2Button
            // 
            this.heading2Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.heading2Button.Image = ((System.Drawing.Image)(resources.GetObject("heading2Button.Image")));
            this.heading2Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.heading2Button.Name = "heading2Button";
            this.heading2Button.Size = new System.Drawing.Size(24, 24);
            this.heading2Button.Text = "Titre 2";
            this.heading2Button.Click += new System.EventHandler(this.heading2Button_Click);
            // 
            // heading3Button
            // 
            this.heading3Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.heading3Button.Image = ((System.Drawing.Image)(resources.GetObject("heading3Button.Image")));
            this.heading3Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.heading3Button.Name = "heading3Button";
            this.heading3Button.Size = new System.Drawing.Size(24, 24);
            this.heading3Button.Text = "Titre 3";
            this.heading3Button.Click += new System.EventHandler(this.heading3Button_Click);
            // 
            // heading4Button
            // 
            this.heading4Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.heading4Button.Image = ((System.Drawing.Image)(resources.GetObject("heading4Button.Image")));
            this.heading4Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.heading4Button.Name = "heading4Button";
            this.heading4Button.Size = new System.Drawing.Size(24, 24);
            this.heading4Button.Text = "Titre 4";
            this.heading4Button.Click += new System.EventHandler(this.heading4Button_Click);
            // 
            // heading5Button
            // 
            this.heading5Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.heading5Button.Image = ((System.Drawing.Image)(resources.GetObject("heading5Button.Image")));
            this.heading5Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.heading5Button.Name = "heading5Button";
            this.heading5Button.Size = new System.Drawing.Size(24, 24);
            this.heading5Button.Text = "Titre 5";
            this.heading5Button.Click += new System.EventHandler(this.heading5Button_Click);
            // 
            // heading6Button
            // 
            this.heading6Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.heading6Button.Image = ((System.Drawing.Image)(resources.GetObject("heading6Button.Image")));
            this.heading6Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.heading6Button.Name = "heading6Button";
            this.heading6Button.Size = new System.Drawing.Size(24, 24);
            this.heading6Button.Text = "Titre 6";
            this.heading6Button.Click += new System.EventHandler(this.heading6Button_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 478);
            this.Controls.Add(this.menubar);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainView";
            this.Text = "Markdown Editor";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox editor;
        private System.Windows.Forms.WebBrowser renderer;
        private System.Windows.Forms.ToolStrip menubar;
        private System.Windows.Forms.ToolStripButton newFileButton;
        private System.Windows.Forms.ToolStripButton openFileButton;
        private System.Windows.Forms.ToolStripButton saveFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton boldButton;
        private System.Windows.Forms.ToolStripButton italicButton;
        private System.Windows.Forms.ToolStripButton unorderedListButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton orderedListButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton heading1Button;
        private System.Windows.Forms.ToolStripButton heading2Button;
        private System.Windows.Forms.ToolStripButton heading3Button;
        private System.Windows.Forms.ToolStripButton heading4Button;
        private System.Windows.Forms.ToolStripButton heading5Button;
        private System.Windows.Forms.ToolStripButton heading6Button;
    }
}

