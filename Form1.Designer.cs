namespace SnowrunnerLauncher
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
            this.lblSnowrunnerPath = new System.Windows.Forms.Label();
            this.txtSnowrunnerPath = new System.Windows.Forms.TextBox();
            this.chkSRUIC = new System.Windows.Forms.CheckBox();
            this.btnBrowseSR = new System.Windows.Forms.Button();
            this.btnLaunchGame = new System.Windows.Forms.Button();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.lblDelay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSnowrunnerPath
            // 
            this.lblSnowrunnerPath.AutoSize = true;
            this.lblSnowrunnerPath.Location = new System.Drawing.Point(15, 27);
            this.lblSnowrunnerPath.Name = "lblSnowrunnerPath";
            this.lblSnowrunnerPath.Size = new System.Drawing.Size(132, 20);
            this.lblSnowrunnerPath.TabIndex = 0;
            this.lblSnowrunnerPath.Text = "Snowrunner Path";
            // 
            // txtSnowrunnerPath
            // 
            this.txtSnowrunnerPath.Location = new System.Drawing.Point(147, 24);
            this.txtSnowrunnerPath.Name = "txtSnowrunnerPath";
            this.txtSnowrunnerPath.Size = new System.Drawing.Size(571, 26);
            this.txtSnowrunnerPath.TabIndex = 1;
            this.txtSnowrunnerPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\SnowRunner\\Sources\\Bin";
            // 
            // chkSRUIC
            // 
            this.chkSRUIC.AutoSize = true;
            this.chkSRUIC.Checked = true;
            this.chkSRUIC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSRUIC.Location = new System.Drawing.Point(15, 62);
            this.chkSRUIC.Name = "chkSRUIC";
            this.chkSRUIC.Size = new System.Drawing.Size(267, 24);
            this.chkSRUIC.TabIndex = 2;
            this.chkSRUIC.Text = "Launch Snowrunner UI Changes";
            this.chkSRUIC.UseVisualStyleBackColor = true;
            // 
            // btnBrowseSR
            // 
            this.btnBrowseSR.Location = new System.Drawing.Point(724, 22);
            this.btnBrowseSR.Name = "btnBrowseSR";
            this.btnBrowseSR.Size = new System.Drawing.Size(75, 31);
            this.btnBrowseSR.TabIndex = 3;
            this.btnBrowseSR.Text = "Browse";
            this.btnBrowseSR.UseVisualStyleBackColor = true;
            this.btnBrowseSR.Click += new System.EventHandler(this.btnBrowseSR_Click);
            // 
            // btnLaunchGame
            // 
            this.btnLaunchGame.Location = new System.Drawing.Point(327, 119);
            this.btnLaunchGame.Name = "btnLaunchGame";
            this.btnLaunchGame.Size = new System.Drawing.Size(147, 33);
            this.btnLaunchGame.TabIndex = 4;
            this.btnLaunchGame.Text = "Launch Game";
            this.btnLaunchGame.UseVisualStyleBackColor = true;
            this.btnLaunchGame.Click += new System.EventHandler(this.btnLaunchGame_Click);
            // 
            // numDelay
            // 
            this.numDelay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDelay.Location = new System.Drawing.Point(295, 62);
            this.numDelay.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(58, 26);
            this.numDelay.TabIndex = 5;
            this.numDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(362, 62);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(106, 20);
            this.lblDelay.TabIndex = 6;
            this.lblDelay.Text = "Launch Delay";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 164);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.btnLaunchGame);
            this.Controls.Add(this.btnBrowseSR);
            this.Controls.Add(this.chkSRUIC);
            this.Controls.Add(this.txtSnowrunnerPath);
            this.Controls.Add(this.lblSnowrunnerPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Snowrunner Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSnowrunnerPath;
        private System.Windows.Forms.TextBox txtSnowrunnerPath;
        private System.Windows.Forms.CheckBox chkSRUIC;
        private System.Windows.Forms.Button btnBrowseSR;
        private System.Windows.Forms.Button btnLaunchGame;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label lblDelay;
    }
}

