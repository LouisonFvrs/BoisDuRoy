namespace BoisDuRoy_Margaux_Louison.Forms
{
    partial class ViewCreateFunction
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_nomFonction = new System.Windows.Forms.TextBox();
            this.err_nomFonction = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom fonction";
            // 
            // tbx_nomFonction
            // 
            this.tbx_nomFonction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_nomFonction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_nomFonction.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nomFonction.Location = new System.Drawing.Point(60, 128);
            this.tbx_nomFonction.Name = "tbx_nomFonction";
            this.tbx_nomFonction.Size = new System.Drawing.Size(353, 25);
            this.tbx_nomFonction.TabIndex = 8;
            // 
            // err_nomFonction
            // 
            this.err_nomFonction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.err_nomFonction.AutoSize = true;
            this.err_nomFonction.Font = new System.Drawing.Font("Montserrat Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_nomFonction.ForeColor = System.Drawing.Color.Red;
            this.err_nomFonction.Location = new System.Drawing.Point(56, 156);
            this.err_nomFonction.Name = "err_nomFonction";
            this.err_nomFonction.Size = new System.Drawing.Size(111, 24);
            this.err_nomFonction.TabIndex = 26;
            this.err_nomFonction.Text = "Champ vide";
            this.err_nomFonction.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(196)))), ((int)(((byte)(179)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(60, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 40);
            this.button2.TabIndex = 27;
            this.button2.Text = "CRÉER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewCreateFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1250, 640);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.err_nomFonction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_nomFonction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCreateFunction";
            this.Text = "ViewCreateFunction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_nomFonction;
        private System.Windows.Forms.Label err_nomFonction;
        private System.Windows.Forms.Button button2;
    }
}