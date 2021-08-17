
namespace View
{
    partial class F_ArmorsWindow
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Armor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TituloPagina = new System.Windows.Forms.Label();
            this.Panel_Search = new System.Windows.Forms.Panel();
            this.Tbx_SearchItem = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.lbl_InsertText = new System.Windows.Forms.Label();
            this.Tbx_ItemDescrition = new System.Windows.Forms.TextBox();
            this.TabLayerPanel_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.Panel_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabLayerPanel_MAIN
            // 
            this.TabLayerPanel_MAIN.ColumnCount = 2;
            this.TabLayerPanel_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabLayerPanel_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 459F));
            this.TabLayerPanel_MAIN.Controls.Add(this.DataGridView, 0, 1);
            this.TabLayerPanel_MAIN.Controls.Add(this.lbl_TituloPagina, 0, 0);
            this.TabLayerPanel_MAIN.Controls.Add(this.Panel_Search, 1, 1);
            this.TabLayerPanel_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLayerPanel_MAIN.Location = new System.Drawing.Point(0, 0);
            this.TabLayerPanel_MAIN.Margin = new System.Windows.Forms.Padding(0);
            this.TabLayerPanel_MAIN.Name = "TabLayerPanel_MAIN";
            this.TabLayerPanel_MAIN.RowCount = 2;
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TabLayerPanel_MAIN.Size = new System.Drawing.Size(1166, 743);
            this.TabLayerPanel_MAIN.TabIndex = 1;
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Name,
            this.Col_Element,
            this.Col_Type,
            this.Col_Armor});
            this.DataGridView.Location = new System.Drawing.Point(40, 120);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(40, 0, 0, 40);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.Size = new System.Drawing.Size(667, 583);
            this.DataGridView.TabIndex = 9;
            // 
            // Col_Name
            // 
            this.Col_Name.HeaderText = "Name";
            this.Col_Name.Name = "Col_Name";
            this.Col_Name.ReadOnly = true;
            this.Col_Name.Width = 300;
            // 
            // Col_Element
            // 
            this.Col_Element.HeaderText = "Element";
            this.Col_Element.Name = "Col_Element";
            this.Col_Element.ReadOnly = true;
            // 
            // Col_Type
            // 
            this.Col_Type.HeaderText = "Type";
            this.Col_Type.Name = "Col_Type";
            this.Col_Type.ReadOnly = true;
            // 
            // Col_Armor
            // 
            this.Col_Armor.HeaderText = "Armor";
            this.Col_Armor.Name = "Col_Armor";
            this.Col_Armor.ReadOnly = true;
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
            this.lbl_TituloPagina.Text = "Armors";
            // 
            // Panel_Search
            // 
            this.Panel_Search.Controls.Add(this.Tbx_SearchItem);
            this.Panel_Search.Controls.Add(this.Btn_Search);
            this.Panel_Search.Controls.Add(this.lbl_InsertText);
            this.Panel_Search.Controls.Add(this.Tbx_ItemDescrition);
            this.Panel_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Search.Location = new System.Drawing.Point(707, 120);
            this.Panel_Search.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Search.Name = "Panel_Search";
            this.Panel_Search.Size = new System.Drawing.Size(459, 623);
            this.Panel_Search.TabIndex = 10;
            // 
            // Tbx_SearchItem
            // 
            this.Tbx_SearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_SearchItem.BackColor = System.Drawing.Color.White;
            this.Tbx_SearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbx_SearchItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tbx_SearchItem.Location = new System.Drawing.Point(10, 29);
            this.Tbx_SearchItem.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Tbx_SearchItem.Name = "Tbx_SearchItem";
            this.Tbx_SearchItem.Size = new System.Drawing.Size(312, 29);
            this.Tbx_SearchItem.TabIndex = 5;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(20)))));
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(322, 29);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(97, 29);
            this.Btn_Search.TabIndex = 6;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = false;
            // 
            // lbl_InsertText
            // 
            this.lbl_InsertText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_InsertText.AutoSize = true;
            this.lbl_InsertText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_InsertText.Location = new System.Drawing.Point(10, 6);
            this.lbl_InsertText.Margin = new System.Windows.Forms.Padding(50, 0, 0, 1);
            this.lbl_InsertText.Name = "lbl_InsertText";
            this.lbl_InsertText.Size = new System.Drawing.Size(100, 21);
            this.lbl_InsertText.TabIndex = 7;
            this.lbl_InsertText.Text = "Insert to Text:";
            // 
            // Tbx_ItemDescrition
            // 
            this.Tbx_ItemDescrition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_ItemDescrition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tbx_ItemDescrition.Location = new System.Drawing.Point(10, 73);
            this.Tbx_ItemDescrition.Margin = new System.Windows.Forms.Padding(0, 0, 40, 40);
            this.Tbx_ItemDescrition.Multiline = true;
            this.Tbx_ItemDescrition.Name = "Tbx_ItemDescrition";
            this.Tbx_ItemDescrition.ReadOnly = true;
            this.Tbx_ItemDescrition.Size = new System.Drawing.Size(409, 510);
            this.Tbx_ItemDescrition.TabIndex = 8;
            // 
            // F_ArmorsWindow
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
            this.Name = "F_ArmorsWindow";
            this.TabLayerPanel_MAIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.Panel_Search.ResumeLayout(false);
            this.Panel_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabLayerPanel_MAIN;
        private System.Windows.Forms.Label lbl_TituloPagina;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel Panel_Search;
        private System.Windows.Forms.TextBox Tbx_SearchItem;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Label lbl_InsertText;
        private System.Windows.Forms.TextBox Tbx_ItemDescrition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Element;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Armor;
    }
}