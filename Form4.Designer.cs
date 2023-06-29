
namespace StarLanchesC
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btn_voltar = new Guna.UI.WinForms.GunaControlBox();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_voltar.AnimationHoverSpeed = 0.07F;
            this.btn_voltar.AnimationSpeed = 0.03F;
            this.btn_voltar.BackColor = System.Drawing.Color.White;
            this.btn_voltar.IconColor = System.Drawing.Color.Black;
            this.btn_voltar.IconSize = 15F;
            this.btn_voltar.Location = new System.Drawing.Point(741, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.OnHoverBackColor = System.Drawing.Color.Black;
            this.btn_voltar.OnHoverIconColor = System.Drawing.Color.Black;
            this.btn_voltar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_voltar.Size = new System.Drawing.Size(31, 27);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btn_voltar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre Nós";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaControlBox btn_voltar;
    }
}