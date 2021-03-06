
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
            this.TabLayerPanel_MAIN = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_TituloPagina = new System.Windows.Forms.Label();
            this.GroupBox_Import = new System.Windows.Forms.GroupBox();
            this.btn_Import = new System.Windows.Forms.Button();
            this.Btn_BrowseImport = new System.Windows.Forms.Button();
            this.lbl_SelectArchive = new System.Windows.Forms.Label();
            this.Tbx_FilePatchImport = new System.Windows.Forms.TextBox();
            this.TabLayerPanel_MAIN.SuspendLayout();
            this.GroupBox_Import.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabLayerPanel_MAIN
            // 
            this.TabLayerPanel_MAIN.ColumnCount = 1;
            this.TabLayerPanel_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabLayerPanel_MAIN.Controls.Add(this.lbl_TituloPagina, 0, 0);
            this.TabLayerPanel_MAIN.Controls.Add(this.GroupBox_Import, 0, 1);
            this.TabLayerPanel_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLayerPanel_MAIN.Location = new System.Drawing.Point(0, 0);
            this.TabLayerPanel_MAIN.Margin = new System.Windows.Forms.Padding(0);
            this.TabLayerPanel_MAIN.Name = "TabLayerPanel_MAIN";
            this.TabLayerPanel_MAIN.RowCount = 2;
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TabLayerPanel_MAIN.Size = new System.Drawing.Size(1166, 743);
            this.TabLayerPanel_MAIN.TabIndex = 0;
            // 
            // lbl_TituloPagina
            // 
            this.lbl_TituloPagina.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(20)))));
            this.lbl_TituloPagina.Location = new System.Drawing.Point(30, 30);
            this.lbl_TituloPagina.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.lbl_TituloPagina.Name = "lbl_TituloPagina";
            this.lbl_TituloPagina.Size = new System.Drawing.Size(287, 54);
            this.lbl_TituloPagina.TabIndex = 4;
            this.lbl_TituloPagina.Text = "JSON Manager";
            // 
            // GroupBox_Import
            // 
            this.GroupBox_Import.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_Import.Controls.Add(this.btn_Import);
            this.GroupBox_Import.Controls.Add(this.Btn_BrowseImport);
            this.GroupBox_Import.Controls.Add(this.lbl_SelectArchive);
            this.GroupBox_Import.Controls.Add(this.Tbx_FilePatchImport);
            this.GroupBox_Import.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupBox_Import.Location = new System.Drawing.Point(100, 320);
            this.GroupBox_Import.Margin = new System.Windows.Forms.Padding(100, 200, 100, 0);
            this.GroupBox_Import.Name = "GroupBox_Import";
            this.GroupBox_Import.Padding = new System.Windows.Forms.Padding(0);
            this.GroupBox_Import.Size = new System.Drawing.Size(966, 171);
            this.GroupBox_Import.TabIndex = 5;
            this.GroupBox_Import.TabStop = false;
            this.GroupBox_Import.Text = "Import JSON";
            // 
            // btn_Import
            // 
            this.btn_Import.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Import.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Import.Location = new System.Drawing.Point(433, 114);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(96, 37);
            this.btn_Import.TabIndex = 10;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // Btn_BrowseImport
            // 
            this.Btn_BrowseImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_BrowseImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(20)))));
            this.Btn_BrowseImport.FlatAppearance.BorderSize = 0;
            this.Btn_BrowseImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BrowseImport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_BrowseImport.ForeColor = System.Drawing.Color.White;
            this.Btn_BrowseImport.Location = new System.Drawing.Point(773, 68);
            this.Btn_BrowseImport.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.Btn_BrowseImport.Name = "Btn_BrowseImport";
            this.Btn_BrowseImport.Size = new System.Drawing.Size(119, 32);
            this.Btn_BrowseImport.TabIndex = 8;
            this.Btn_BrowseImport.Text = "Browse";
            this.Btn_BrowseImport.UseVisualStyleBackColor = false;
            this.Btn_BrowseImport.Click += new System.EventHandler(this.Btn_BrowseImport_Click);
            // 
            // lbl_SelectArchive
            // 
            this.lbl_SelectArchive.AutoSize = true;
            this.lbl_SelectArchive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_SelectArchive.Location = new System.Drawing.Point(50, 42);
            this.lbl_SelectArchive.Margin = new System.Windows.Forms.Padding(50, 0, 0, 1);
            this.lbl_SelectArchive.Name = "lbl_SelectArchive";
            this.lbl_SelectArchive.Size = new System.Drawing.Size(108, 21);
            this.lbl_SelectArchive.TabIndex = 9;
            this.lbl_SelectArchive.Text = "Select archive:";
            // 
            // Tbx_FilePatchImport
            // 
            this.Tbx_FilePatchImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_FilePatchImport.BackColor = System.Drawing.Color.White;
            this.Tbx_FilePatchImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbx_FilePatchImport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tbx_FilePatchImport.Location = new System.Drawing.Point(50, 68);
            this.Tbx_FilePatchImport.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Tbx_FilePatchImport.Name = "Tbx_FilePatchImport";
            this.Tbx_FilePatchImport.Size = new System.Drawing.Size(723, 32);
            this.Tbx_FilePatchImport.TabIndex = 7;
            // 
            // F_HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1166, 743);
            this.ControlBox = false;
            this.Controls.Add(this.TabLayerPanel_MAIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_HomeWindow";
            this.TabLayerPanel_MAIN.ResumeLayout(false);
            this.GroupBox_Import.ResumeLayout(false);
            this.GroupBox_Import.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabLayerPanel_MAIN;
        private System.Windows.Forms.Label lbl_TituloPagina;
        private System.Windows.Forms.GroupBox GroupBox_Import;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button Btn_BrowseImport;
        private System.Windows.Forms.Label lbl_SelectArchive;
        private System.Windows.Forms.TextBox Tbx_FilePatchImport;
    }
}