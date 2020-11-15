namespace ExampleSQLApp
{
    partial class MainForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MainPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MainPanel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 35);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(906, 460);
            this.MainPanel.TabIndex = 4;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.main_panel.Controls.Add(this.buttonBack);
            this.main_panel.Controls.Add(this.closeButton);
            this.main_panel.Controls.Add(this.TopPanel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(905, 35);
            this.main_panel.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.Image = global::ExampleSQLApp.Properties.Resources.icons8_back_96px_3;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(35, 35);
            this.buttonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonBack.TabIndex = 3;
            this.buttonBack.TabStop = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::ExampleSQLApp.Properties.Resources.icons8_delete_96px_1;
            this.closeButton.Location = new System.Drawing.Point(871, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 35);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopPanel.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopPanel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(905, 35);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 493);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox buttonBack;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label TopPanel;
    }
}