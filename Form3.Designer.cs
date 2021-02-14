
namespace BlackMesaWorkshopManager
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.enterMod = new System.Windows.Forms.TextBox();
            this.sayOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterMod
            // 
            this.enterMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterMod.Location = new System.Drawing.Point(12, 45);
            this.enterMod.Name = "enterMod";
            this.enterMod.Size = new System.Drawing.Size(445, 23);
            this.enterMod.TabIndex = 0;
            // 
            // sayOK
            // 
            this.sayOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayOK.Location = new System.Drawing.Point(382, 74);
            this.sayOK.Name = "sayOK";
            this.sayOK.Size = new System.Drawing.Size(75, 23);
            this.sayOK.TabIndex = 1;
            this.sayOK.Text = "OK";
            this.sayOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert the Mod ID you want to modify, and press OK. (Leave blank for bms)";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 104);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sayOK);
            this.Controls.Add(this.enterMod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Black Mesa Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterMod;
        private System.Windows.Forms.Button sayOK;
        private System.Windows.Forms.Label label1;
    }
}