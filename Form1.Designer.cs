
namespace BlackMesaWorkshopManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.disableCustom = new System.Windows.Forms.Button();
            this.enableCustom = new System.Windows.Forms.Button();
            this.launchGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isWorkshopDisabled = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createCustom = new System.Windows.Forms.Button();
            this.workshopPage = new System.Windows.Forms.Button();
            this.resetCustom = new System.Windows.Forms.CheckBox();
            this.aboutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // disableCustom
            // 
            this.disableCustom.Enabled = false;
            this.disableCustom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableCustom.Location = new System.Drawing.Point(122, 243);
            this.disableCustom.Name = "disableCustom";
            this.disableCustom.Size = new System.Drawing.Size(134, 41);
            this.disableCustom.TabIndex = 0;
            this.disableCustom.Text = "Disable Custom Folder";
            this.disableCustom.UseVisualStyleBackColor = true;
            this.disableCustom.Click += new System.EventHandler(this.disableCustom_Click);
            // 
            // enableCustom
            // 
            this.enableCustom.Enabled = false;
            this.enableCustom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableCustom.Location = new System.Drawing.Point(122, 196);
            this.enableCustom.Name = "enableCustom";
            this.enableCustom.Size = new System.Drawing.Size(134, 41);
            this.enableCustom.TabIndex = 1;
            this.enableCustom.Text = "Enable Custom Folder";
            this.enableCustom.UseVisualStyleBackColor = true;
            this.enableCustom.Click += new System.EventHandler(this.enableCustom_Click);
            // 
            // launchGame
            // 
            this.launchGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchGame.Location = new System.Drawing.Point(12, 358);
            this.launchGame.Name = "launchGame";
            this.launchGame.Size = new System.Drawing.Size(360, 57);
            this.launchGame.TabIndex = 3;
            this.launchGame.Text = "Launch";
            this.launchGame.UseVisualStyleBackColor = true;
            this.launchGame.Click += new System.EventHandler(this.launchGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 35);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // isWorkshopDisabled
            // 
            this.isWorkshopDisabled.AutoSize = true;
            this.isWorkshopDisabled.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isWorkshopDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.isWorkshopDisabled.Location = new System.Drawing.Point(112, 333);
            this.isWorkshopDisabled.Name = "isWorkshopDisabled";
            this.isWorkshopDisabled.Size = new System.Drawing.Size(161, 19);
            this.isWorkshopDisabled.TabIndex = 5;
            this.isWorkshopDisabled.Text = "Disable workshop addons";
            this.isWorkshopDisabled.UseVisualStyleBackColor = true;
            this.isWorkshopDisabled.CheckedChanged += new System.EventHandler(this.isWorkshopDisabled_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 437);
            this.label2.MaximumSize = new System.Drawing.Size(500, 20);
            this.label2.MinimumSize = new System.Drawing.Size(480, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Make sure Steam is running before pressing Launch.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // createCustom
            // 
            this.createCustom.Enabled = false;
            this.createCustom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCustom.Location = new System.Drawing.Point(122, 149);
            this.createCustom.Name = "createCustom";
            this.createCustom.Size = new System.Drawing.Size(134, 41);
            this.createCustom.TabIndex = 9;
            this.createCustom.Text = "Create Custom Folder";
            this.createCustom.UseVisualStyleBackColor = true;
            this.createCustom.Click += new System.EventHandler(this.createCustom_Click);
            // 
            // workshopPage
            // 
            this.workshopPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.workshopPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopPage.ForeColor = System.Drawing.Color.White;
            this.workshopPage.Location = new System.Drawing.Point(122, 102);
            this.workshopPage.Name = "workshopPage";
            this.workshopPage.Size = new System.Drawing.Size(134, 41);
            this.workshopPage.TabIndex = 10;
            this.workshopPage.Text = "Go to Workshop Page";
            this.workshopPage.UseVisualStyleBackColor = false;
            // 
            // resetCustom
            // 
            this.resetCustom.AutoSize = true;
            this.resetCustom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetCustom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetCustom.Location = new System.Drawing.Point(112, 308);
            this.resetCustom.Name = "resetCustom";
            this.resetCustom.Size = new System.Drawing.Size(171, 19);
            this.resetCustom.TabIndex = 11;
            this.resetCustom.Text = "My custom folder is broken";
            this.resetCustom.UseVisualStyleBackColor = true;
            this.resetCustom.CheckedChanged += new System.EventHandler(this.resetCustom_CheckedChanged);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(297, 433);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 12;
            this.aboutButton.Text = "About...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.resetCustom);
            this.Controls.Add(this.workshopPage);
            this.Controls.Add(this.createCustom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isWorkshopDisabled);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.launchGame);
            this.Controls.Add(this.enableCustom);
            this.Controls.Add(this.disableCustom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.Text = "Black Mesa Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disableCustom;
        private System.Windows.Forms.Button enableCustom;
        private System.Windows.Forms.Button launchGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox isWorkshopDisabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createCustom;
        private System.Windows.Forms.Button workshopPage;
        private System.Windows.Forms.CheckBox resetCustom;
        private System.Windows.Forms.Button aboutButton;
    }
}

