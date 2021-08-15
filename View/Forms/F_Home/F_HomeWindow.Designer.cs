
namespace View
{
    partial class F_HomeWindow
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
            this.Panel_MAIN = new System.Windows.Forms.Panel();
            this.lbl_TituloPagina = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_MAIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_MAIN
            // 
            this.Panel_MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.Panel_MAIN.Controls.Add(this.button1);
            this.Panel_MAIN.Controls.Add(this.lbl_TituloPagina);
            this.Panel_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_MAIN.Location = new System.Drawing.Point(0, 0);
            this.Panel_MAIN.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_MAIN.Name = "Panel_MAIN";
            this.Panel_MAIN.Size = new System.Drawing.Size(1166, 743);
            this.Panel_MAIN.TabIndex = 0;
            // 
            // lbl_TituloPagina
            // 
            this.lbl_TituloPagina.AutoSize = true;
            this.lbl_TituloPagina.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(20)))));
            this.lbl_TituloPagina.Location = new System.Drawing.Point(19, 9);
            this.lbl_TituloPagina.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbl_TituloPagina.Name = "lbl_TituloPagina";
            this.lbl_TituloPagina.Size = new System.Drawing.Size(129, 54);
            this.lbl_TituloPagina.TabIndex = 0;
            this.lbl_TituloPagina.Text = "Home";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1166, 743);
            this.ControlBox = false;
            this.Controls.Add(this.Panel_MAIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_HomeWindow";
            this.Panel_MAIN.ResumeLayout(false);
            this.Panel_MAIN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_MAIN;
        private System.Windows.Forms.Label lbl_TituloPagina;
        private System.Windows.Forms.Button button1;
    }
}