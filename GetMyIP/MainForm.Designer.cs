namespace GetMyIP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBoxLanInternet = new System.Windows.Forms.ComboBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxLanInternet
            // 
            this.comboBoxLanInternet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxLanInternet, "comboBoxLanInternet");
            this.comboBoxLanInternet.FormattingEnabled = true;
            this.comboBoxLanInternet.Name = "comboBoxLanInternet";
            this.comboBoxLanInternet.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanInternet_SelectedIndexChanged);
            // 
            // textBoxIP
            // 
            this.textBoxIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxIP, "textBoxIP");
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.ReadOnly = true;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.CopyrightLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.CopyrightLabel, "CopyrightLabel");
            this.CopyrightLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Click += new System.EventHandler(this.CopyrightLabel_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.comboBoxLanInternet);
            this.Controls.Add(this.CopyrightLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLanInternet;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label CopyrightLabel;
    }
}

