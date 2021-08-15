
namespace View.F_Main
{
    partial class F_MainWindow
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
            this.TabPanel_MAIN = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_ControlBar = new System.Windows.Forms.Panel();
            this.Btn_Normalize = new System.Windows.Forms.Button();
            this.Btn_Minimize = new System.Windows.Forms.Button();
            this.Btn_Maximize = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Panel_MenuBar = new System.Windows.Forms.Panel();
            this.btn_MenuStatistics = new System.Windows.Forms.RadioButton();
            this.btn_MenuWeapons = new System.Windows.Forms.RadioButton();
            this.btn_MenuAcessories = new System.Windows.Forms.RadioButton();
            this.btn_MenuArmors = new System.Windows.Forms.RadioButton();
            this.btn_MenuHome = new System.Windows.Forms.RadioButton();
            this.PicBox_ImageLogo = new System.Windows.Forms.PictureBox();
            this.Panel_SelectedWindow = new System.Windows.Forms.Panel();
            this.TabPanel_MAIN.SuspendLayout();
            this.Panel_ControlBar.SuspendLayout();
            this.Panel_MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ImageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPanel_MAIN
            // 
            this.TabPanel_MAIN.ColumnCount = 2;
            this.TabPanel_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.TabPanel_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabPanel_MAIN.Controls.Add(this.Panel_ControlBar, 0, 0);
            this.TabPanel_MAIN.Controls.Add(this.Panel_MenuBar, 0, 1);
            this.TabPanel_MAIN.Controls.Add(this.Panel_SelectedWindow, 1, 1);
            this.TabPanel_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPanel_MAIN.Location = new System.Drawing.Point(1, 1);
            this.TabPanel_MAIN.Margin = new System.Windows.Forms.Padding(0);
            this.TabPanel_MAIN.Name = "TabPanel_MAIN";
            this.TabPanel_MAIN.RowCount = 2;
            this.TabPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TabPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabPanel_MAIN.Size = new System.Drawing.Size(1482, 832);
            this.TabPanel_MAIN.TabIndex = 0;
            // 
            // Panel_ControlBar
            // 
            this.Panel_ControlBar.BackColor = System.Drawing.Color.White;
            this.TabPanel_MAIN.SetColumnSpan(this.Panel_ControlBar, 2);
            this.Panel_ControlBar.Controls.Add(this.Btn_Normalize);
            this.Panel_ControlBar.Controls.Add(this.Btn_Minimize);
            this.Panel_ControlBar.Controls.Add(this.Btn_Maximize);
            this.Panel_ControlBar.Controls.Add(this.Btn_Close);
            this.Panel_ControlBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_ControlBar.Location = new System.Drawing.Point(0, 0);
            this.Panel_ControlBar.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_ControlBar.Name = "Panel_ControlBar";
            this.Panel_ControlBar.Size = new System.Drawing.Size(1482, 50);
            this.Panel_ControlBar.TabIndex = 0;
            this.Panel_ControlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_ControlBar_MouseDown);
            // 
            // Btn_Normalize
            // 
            this.Btn_Normalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Normalize.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Normalize.FlatAppearance.BorderSize = 0;
            this.Btn_Normalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Normalize.Image = global::View.Properties.Resources.icon_Normalize;
            this.Btn_Normalize.Location = new System.Drawing.Point(1391, 0);
            this.Btn_Normalize.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Btn_Normalize.Name = "Btn_Normalize";
            this.Btn_Normalize.Size = new System.Drawing.Size(45, 32);
            this.Btn_Normalize.TabIndex = 3;
            this.Btn_Normalize.TabStop = false;
            this.Btn_Normalize.UseVisualStyleBackColor = false;
            this.Btn_Normalize.Visible = false;
            this.Btn_Normalize.Click += new System.EventHandler(this.Btn_Normalize_Click);
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Minimize.FlatAppearance.BorderSize = 0;
            this.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimize.Image = global::View.Properties.Resources.icon_Minimize;
            this.Btn_Minimize.Location = new System.Drawing.Point(1345, 0);
            this.Btn_Minimize.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(45, 32);
            this.Btn_Minimize.TabIndex = 2;
            this.Btn_Minimize.TabStop = false;
            this.Btn_Minimize.UseVisualStyleBackColor = false;
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Btn_Maximize
            // 
            this.Btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Maximize.FlatAppearance.BorderSize = 0;
            this.Btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Maximize.Image = global::View.Properties.Resources.icon_Maximize;
            this.Btn_Maximize.Location = new System.Drawing.Point(1391, 0);
            this.Btn_Maximize.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Btn_Maximize.Name = "Btn_Maximize";
            this.Btn_Maximize.Size = new System.Drawing.Size(45, 32);
            this.Btn_Maximize.TabIndex = 1;
            this.Btn_Maximize.TabStop = false;
            this.Btn_Maximize.UseVisualStyleBackColor = false;
            this.Btn_Maximize.Click += new System.EventHandler(this.Btn_Maximize_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Image = global::View.Properties.Resources.icon_Close;
            this.Btn_Close.Location = new System.Drawing.Point(1437, 0);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(45, 32);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Panel_MenuBar
            // 
            this.Panel_MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.Panel_MenuBar.Controls.Add(this.btn_MenuStatistics);
            this.Panel_MenuBar.Controls.Add(this.btn_MenuWeapons);
            this.Panel_MenuBar.Controls.Add(this.btn_MenuAcessories);
            this.Panel_MenuBar.Controls.Add(this.btn_MenuArmors);
            this.Panel_MenuBar.Controls.Add(this.btn_MenuHome);
            this.Panel_MenuBar.Controls.Add(this.PicBox_ImageLogo);
            this.Panel_MenuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_MenuBar.Location = new System.Drawing.Point(0, 50);
            this.Panel_MenuBar.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_MenuBar.Name = "Panel_MenuBar";
            this.Panel_MenuBar.Size = new System.Drawing.Size(300, 782);
            this.Panel_MenuBar.TabIndex = 1;
            // 
            // btn_MenuStatistics
            // 
            this.btn_MenuStatistics.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_MenuStatistics.FlatAppearance.BorderSize = 0;
            this.btn_MenuStatistics.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.btn_MenuStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.btn_MenuStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btn_MenuStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuStatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_MenuStatistics.Image = global::View.Properties.Resources.icon_MenuStatistics;
            this.btn_MenuStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuStatistics.Location = new System.Drawing.Point(0, 350);
            this.btn_MenuStatistics.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MenuStatistics.Name = "btn_MenuStatistics";
            this.btn_MenuStatistics.Size = new System.Drawing.Size(300, 55);
            this.btn_MenuStatistics.TabIndex = 5;
            this.btn_MenuStatistics.TabStop = true;
            this.btn_MenuStatistics.Text = "              Statistics";
            this.btn_MenuStatistics.UseVisualStyleBackColor = true;
            // 
            // btn_MenuWeapons
            // 
            this.btn_MenuWeapons.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_MenuWeapons.FlatAppearance.BorderSize = 0;
            this.btn_MenuWeapons.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.btn_MenuWeapons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.btn_MenuWeapons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btn_MenuWeapons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuWeapons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuWeapons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_MenuWeapons.Image = global::View.Properties.Resources.icon_MenuWeapons;
            this.btn_MenuWeapons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuWeapons.Location = new System.Drawing.Point(0, 295);
            this.btn_MenuWeapons.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MenuWeapons.Name = "btn_MenuWeapons";
            this.btn_MenuWeapons.Size = new System.Drawing.Size(300, 55);
            this.btn_MenuWeapons.TabIndex = 4;
            this.btn_MenuWeapons.TabStop = true;
            this.btn_MenuWeapons.Text = "              Weapons";
            this.btn_MenuWeapons.UseVisualStyleBackColor = true;
            // 
            // btn_MenuAcessories
            // 
            this.btn_MenuAcessories.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_MenuAcessories.FlatAppearance.BorderSize = 0;
            this.btn_MenuAcessories.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.btn_MenuAcessories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.btn_MenuAcessories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btn_MenuAcessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuAcessories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuAcessories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_MenuAcessories.Image = global::View.Properties.Resources.icon_MenuAcessories;
            this.btn_MenuAcessories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuAcessories.Location = new System.Drawing.Point(0, 240);
            this.btn_MenuAcessories.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MenuAcessories.Name = "btn_MenuAcessories";
            this.btn_MenuAcessories.Size = new System.Drawing.Size(300, 55);
            this.btn_MenuAcessories.TabIndex = 3;
            this.btn_MenuAcessories.TabStop = true;
            this.btn_MenuAcessories.Text = "              Acessories";
            this.btn_MenuAcessories.UseVisualStyleBackColor = true;
            // 
            // btn_MenuArmors
            // 
            this.btn_MenuArmors.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_MenuArmors.FlatAppearance.BorderSize = 0;
            this.btn_MenuArmors.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.btn_MenuArmors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.btn_MenuArmors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btn_MenuArmors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuArmors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuArmors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_MenuArmors.Image = global::View.Properties.Resources.icon_MenuArmors;
            this.btn_MenuArmors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuArmors.Location = new System.Drawing.Point(0, 185);
            this.btn_MenuArmors.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MenuArmors.Name = "btn_MenuArmors";
            this.btn_MenuArmors.Size = new System.Drawing.Size(300, 55);
            this.btn_MenuArmors.TabIndex = 2;
            this.btn_MenuArmors.TabStop = true;
            this.btn_MenuArmors.Text = "              Armors";
            this.btn_MenuArmors.UseVisualStyleBackColor = true;
            // 
            // btn_MenuHome
            // 
            this.btn_MenuHome.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_MenuHome.FlatAppearance.BorderSize = 0;
            this.btn_MenuHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.btn_MenuHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.btn_MenuHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.btn_MenuHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_MenuHome.Image = global::View.Properties.Resources.icon_MenuImport;
            this.btn_MenuHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuHome.Location = new System.Drawing.Point(0, 130);
            this.btn_MenuHome.Margin = new System.Windows.Forms.Padding(0);
            this.btn_MenuHome.Name = "btn_MenuHome";
            this.btn_MenuHome.Size = new System.Drawing.Size(300, 55);
            this.btn_MenuHome.TabIndex = 1;
            this.btn_MenuHome.TabStop = true;
            this.btn_MenuHome.Text = "              JSON Manager";
            this.btn_MenuHome.UseVisualStyleBackColor = true;
            // 
            // PicBox_ImageLogo
            // 
            this.PicBox_ImageLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicBox_ImageLogo.Image = global::View.Properties.Resources.Logo_steam;
            this.PicBox_ImageLogo.Location = new System.Drawing.Point(1, 1);
            this.PicBox_ImageLogo.Margin = new System.Windows.Forms.Padding(1);
            this.PicBox_ImageLogo.Name = "PicBox_ImageLogo";
            this.PicBox_ImageLogo.Size = new System.Drawing.Size(299, 128);
            this.PicBox_ImageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBox_ImageLogo.TabIndex = 0;
            this.PicBox_ImageLogo.TabStop = false;
            // 
            // Panel_SelectedWindow
            // 
            this.Panel_SelectedWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(244)))), ((int)(((byte)(242)))));
            this.Panel_SelectedWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_SelectedWindow.Location = new System.Drawing.Point(300, 50);
            this.Panel_SelectedWindow.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_SelectedWindow.Name = "Panel_SelectedWindow";
            this.Panel_SelectedWindow.Size = new System.Drawing.Size(1182, 782);
            this.Panel_SelectedWindow.TabIndex = 2;
            // 
            // F_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1484, 834);
            this.ControlBox = false;
            this.Controls.Add(this.TabPanel_MAIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 460);
            this.Name = "F_MainWindow";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.F_MainWindow_Load);
            this.TabPanel_MAIN.ResumeLayout(false);
            this.Panel_ControlBar.ResumeLayout(false);
            this.Panel_MenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ImageLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabPanel_MAIN;
        private System.Windows.Forms.Panel Panel_ControlBar;
        private System.Windows.Forms.Panel Panel_MenuBar;
        private System.Windows.Forms.Panel Panel_SelectedWindow;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Minimize;
        private System.Windows.Forms.Button Btn_Maximize;
        private System.Windows.Forms.Button Btn_Normalize;
        private System.Windows.Forms.PictureBox PicBox_ImageLogo;
        private System.Windows.Forms.RadioButton btn_MenuAcessories;
        private System.Windows.Forms.RadioButton btn_MenuArmors;
        private System.Windows.Forms.RadioButton btn_MenuHome;
        private System.Windows.Forms.RadioButton btn_MenuStatistics;
        private System.Windows.Forms.RadioButton btn_MenuWeapons;
    }
}