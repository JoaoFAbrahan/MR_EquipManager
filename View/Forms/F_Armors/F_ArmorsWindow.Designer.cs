
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
            this.Lbl_TituloPagina = new System.Windows.Forms.Label();
            this.TabPanel_Search = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_InputSerchSection = new System.Windows.Forms.Panel();
            this.Lbl_InsertValue = new System.Windows.Forms.Label();
            this.tbx_Input = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.GroupBox_Filter = new System.Windows.Forms.GroupBox();
            this.Lbl_Type = new System.Windows.Forms.Label();
            this.Lbl_Element = new System.Windows.Forms.Label();
            this.cbx_FilterType = new System.Windows.Forms.ComboBox();
            this.cbx_FilterElement = new System.Windows.Forms.ComboBox();
            this.Panel_DataInformation = new System.Windows.Forms.Panel();
            this.lbl_NumFilter = new System.Windows.Forms.Label();
            this.lbl_NumTotal = new System.Windows.Forms.Label();
            this.Lbl_TotalByFilters = new System.Windows.Forms.Label();
            this.Lbl_TotalItens = new System.Windows.Forms.Label();
            this.TabPanel_DataBank = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridView_Armors = new System.Windows.Forms.DataGridView();
            this.Panel_Information = new System.Windows.Forms.Panel();
            this.Lbl_ItemInformation = new System.Windows.Forms.Label();
            this.tbx_ItemInfo = new System.Windows.Forms.TextBox();
            this.Col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Element = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Armor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabLayerPanel_MAIN.SuspendLayout();
            this.TabPanel_Search.SuspendLayout();
            this.Panel_InputSerchSection.SuspendLayout();
            this.GroupBox_Filter.SuspendLayout();
            this.Panel_DataInformation.SuspendLayout();
            this.TabPanel_DataBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Armors)).BeginInit();
            this.Panel_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabLayerPanel_MAIN
            // 
            this.TabLayerPanel_MAIN.ColumnCount = 1;
            this.TabLayerPanel_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabLayerPanel_MAIN.Controls.Add(this.Lbl_TituloPagina, 0, 0);
            this.TabLayerPanel_MAIN.Controls.Add(this.TabPanel_Search, 0, 1);
            this.TabLayerPanel_MAIN.Controls.Add(this.TabPanel_DataBank, 0, 2);
            this.TabLayerPanel_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLayerPanel_MAIN.Location = new System.Drawing.Point(0, 0);
            this.TabLayerPanel_MAIN.Margin = new System.Windows.Forms.Padding(0);
            this.TabLayerPanel_MAIN.Name = "TabLayerPanel_MAIN";
            this.TabLayerPanel_MAIN.RowCount = 3;
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.TabLayerPanel_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabLayerPanel_MAIN.Size = new System.Drawing.Size(1166, 743);
            this.TabLayerPanel_MAIN.TabIndex = 1;
            // 
            // Lbl_TituloPagina
            // 
            this.Lbl_TituloPagina.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TituloPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(20)))));
            this.Lbl_TituloPagina.Location = new System.Drawing.Point(30, 30);
            this.Lbl_TituloPagina.Margin = new System.Windows.Forms.Padding(30, 30, 0, 0);
            this.Lbl_TituloPagina.Name = "Lbl_TituloPagina";
            this.Lbl_TituloPagina.Size = new System.Drawing.Size(287, 54);
            this.Lbl_TituloPagina.TabIndex = 4;
            this.Lbl_TituloPagina.Text = "Armors";
            // 
            // TabPanel_Search
            // 
            this.TabPanel_Search.ColumnCount = 4;
            this.TabPanel_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabPanel_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.TabPanel_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 481F));
            this.TabPanel_Search.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TabPanel_Search.Controls.Add(this.Panel_InputSerchSection, 2, 0);
            this.TabPanel_Search.Controls.Add(this.GroupBox_Filter, 1, 0);
            this.TabPanel_Search.Controls.Add(this.Panel_DataInformation, 0, 0);
            this.TabPanel_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPanel_Search.Location = new System.Drawing.Point(0, 120);
            this.TabPanel_Search.Margin = new System.Windows.Forms.Padding(0);
            this.TabPanel_Search.Name = "TabPanel_Search";
            this.TabPanel_Search.RowCount = 1;
            this.TabPanel_Search.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabPanel_Search.Size = new System.Drawing.Size(1166, 130);
            this.TabPanel_Search.TabIndex = 5;
            // 
            // Panel_InputSerchSection
            // 
            this.Panel_InputSerchSection.Controls.Add(this.Lbl_InsertValue);
            this.Panel_InputSerchSection.Controls.Add(this.tbx_Input);
            this.Panel_InputSerchSection.Controls.Add(this.btn_Search);
            this.Panel_InputSerchSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_InputSerchSection.Location = new System.Drawing.Point(645, 0);
            this.Panel_InputSerchSection.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_InputSerchSection.Name = "Panel_InputSerchSection";
            this.Panel_InputSerchSection.Size = new System.Drawing.Size(481, 130);
            this.Panel_InputSerchSection.TabIndex = 1;
            // 
            // Lbl_InsertValue
            // 
            this.Lbl_InsertValue.AutoSize = true;
            this.Lbl_InsertValue.Location = new System.Drawing.Point(34, 41);
            this.Lbl_InsertValue.Name = "Lbl_InsertValue";
            this.Lbl_InsertValue.Size = new System.Drawing.Size(76, 15);
            this.Lbl_InsertValue.TabIndex = 3;
            this.Lbl_InsertValue.Text = "Search value:";
            // 
            // tbx_Input
            // 
            this.tbx_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_Input.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_Input.Location = new System.Drawing.Point(34, 58);
            this.tbx_Input.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tbx_Input.Name = "tbx_Input";
            this.tbx_Input.Size = new System.Drawing.Size(361, 25);
            this.tbx_Input.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(20)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(395, 58);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(85, 25);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // GroupBox_Filter
            // 
            this.GroupBox_Filter.Controls.Add(this.Lbl_Type);
            this.GroupBox_Filter.Controls.Add(this.Lbl_Element);
            this.GroupBox_Filter.Controls.Add(this.cbx_FilterType);
            this.GroupBox_Filter.Controls.Add(this.cbx_FilterElement);
            this.GroupBox_Filter.Location = new System.Drawing.Point(391, 10);
            this.GroupBox_Filter.Margin = new System.Windows.Forms.Padding(35, 10, 0, 0);
            this.GroupBox_Filter.Name = "GroupBox_Filter";
            this.GroupBox_Filter.Size = new System.Drawing.Size(237, 108);
            this.GroupBox_Filter.TabIndex = 0;
            this.GroupBox_Filter.TabStop = false;
            this.GroupBox_Filter.Text = "Filter by:";
            // 
            // Lbl_Type
            // 
            this.Lbl_Type.AutoSize = true;
            this.Lbl_Type.Location = new System.Drawing.Point(43, 67);
            this.Lbl_Type.Name = "Lbl_Type";
            this.Lbl_Type.Size = new System.Drawing.Size(34, 15);
            this.Lbl_Type.TabIndex = 3;
            this.Lbl_Type.Text = "Type:";
            // 
            // Lbl_Element
            // 
            this.Lbl_Element.AutoSize = true;
            this.Lbl_Element.Location = new System.Drawing.Point(24, 35);
            this.Lbl_Element.Name = "Lbl_Element";
            this.Lbl_Element.Size = new System.Drawing.Size(53, 15);
            this.Lbl_Element.TabIndex = 2;
            this.Lbl_Element.Text = "Element:";
            // 
            // cbx_FilterType
            // 
            this.cbx_FilterType.FormattingEnabled = true;
            this.cbx_FilterType.Items.AddRange(new object[] {
            "All Types",
            "Plate",
            "Leather",
            "Cloth"});
            this.cbx_FilterType.Location = new System.Drawing.Point(83, 63);
            this.cbx_FilterType.Name = "cbx_FilterType";
            this.cbx_FilterType.Size = new System.Drawing.Size(121, 23);
            this.cbx_FilterType.TabIndex = 1;
            this.cbx_FilterType.Text = "All Types";
            // 
            // cbx_FilterElement
            // 
            this.cbx_FilterElement.FormattingEnabled = true;
            this.cbx_FilterElement.Items.AddRange(new object[] {
            "All Elements",
            "Dark",
            "Light",
            "Air",
            "Water",
            "Earth",
            "Fire"});
            this.cbx_FilterElement.Location = new System.Drawing.Point(83, 31);
            this.cbx_FilterElement.Name = "cbx_FilterElement";
            this.cbx_FilterElement.Size = new System.Drawing.Size(121, 23);
            this.cbx_FilterElement.TabIndex = 0;
            this.cbx_FilterElement.Text = "All Elements";
            // 
            // Panel_DataInformation
            // 
            this.Panel_DataInformation.Controls.Add(this.lbl_NumFilter);
            this.Panel_DataInformation.Controls.Add(this.lbl_NumTotal);
            this.Panel_DataInformation.Controls.Add(this.Lbl_TotalByFilters);
            this.Panel_DataInformation.Controls.Add(this.Lbl_TotalItens);
            this.Panel_DataInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_DataInformation.Location = new System.Drawing.Point(40, 0);
            this.Panel_DataInformation.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.Panel_DataInformation.Name = "Panel_DataInformation";
            this.Panel_DataInformation.Size = new System.Drawing.Size(316, 130);
            this.Panel_DataInformation.TabIndex = 2;
            // 
            // lbl_NumFilter
            // 
            this.lbl_NumFilter.AutoSize = true;
            this.lbl_NumFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NumFilter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_NumFilter.Location = new System.Drawing.Point(105, 69);
            this.lbl_NumFilter.Name = "lbl_NumFilter";
            this.lbl_NumFilter.Size = new System.Drawing.Size(19, 21);
            this.lbl_NumFilter.TabIndex = 3;
            this.lbl_NumFilter.Text = "0";
            // 
            // lbl_NumTotal
            // 
            this.lbl_NumTotal.AutoSize = true;
            this.lbl_NumTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NumTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_NumTotal.Location = new System.Drawing.Point(105, 41);
            this.lbl_NumTotal.Name = "lbl_NumTotal";
            this.lbl_NumTotal.Size = new System.Drawing.Size(19, 21);
            this.lbl_NumTotal.TabIndex = 2;
            this.lbl_NumTotal.Text = "0";
            // 
            // Lbl_TotalByFilters
            // 
            this.Lbl_TotalByFilters.AutoSize = true;
            this.Lbl_TotalByFilters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TotalByFilters.Location = new System.Drawing.Point(0, 69);
            this.Lbl_TotalByFilters.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_TotalByFilters.Name = "Lbl_TotalByFilters";
            this.Lbl_TotalByFilters.Size = new System.Drawing.Size(105, 21);
            this.Lbl_TotalByFilters.TabIndex = 1;
            this.Lbl_TotalByFilters.Text = "Total by Filter:";
            // 
            // Lbl_TotalItens
            // 
            this.Lbl_TotalItens.AutoSize = true;
            this.Lbl_TotalItens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_TotalItens.Location = new System.Drawing.Point(0, 41);
            this.Lbl_TotalItens.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_TotalItens.Name = "Lbl_TotalItens";
            this.Lbl_TotalItens.Size = new System.Drawing.Size(87, 21);
            this.Lbl_TotalItens.TabIndex = 0;
            this.Lbl_TotalItens.Text = "Total Items:";
            // 
            // TabPanel_DataBank
            // 
            this.TabPanel_DataBank.ColumnCount = 2;
            this.TabPanel_DataBank.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabPanel_DataBank.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.TabPanel_DataBank.Controls.Add(this.DataGridView_Armors, 0, 0);
            this.TabPanel_DataBank.Controls.Add(this.Panel_Information, 1, 0);
            this.TabPanel_DataBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPanel_DataBank.Location = new System.Drawing.Point(0, 250);
            this.TabPanel_DataBank.Margin = new System.Windows.Forms.Padding(0);
            this.TabPanel_DataBank.Name = "TabPanel_DataBank";
            this.TabPanel_DataBank.RowCount = 1;
            this.TabPanel_DataBank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabPanel_DataBank.Size = new System.Drawing.Size(1166, 493);
            this.TabPanel_DataBank.TabIndex = 6;
            // 
            // DataGridView_Armors
            // 
            this.DataGridView_Armors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Armors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Name,
            this.Col_Element,
            this.Col_Type,
            this.Col_Armor});
            this.DataGridView_Armors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Armors.Location = new System.Drawing.Point(40, 0);
            this.DataGridView_Armors.Margin = new System.Windows.Forms.Padding(40, 0, 20, 40);
            this.DataGridView_Armors.Name = "DataGridView_Armors";
            this.DataGridView_Armors.RowTemplate.Height = 25;
            this.DataGridView_Armors.Size = new System.Drawing.Size(831, 453);
            this.DataGridView_Armors.TabIndex = 0;
            // 
            // Panel_Information
            // 
            this.Panel_Information.Controls.Add(this.Lbl_ItemInformation);
            this.Panel_Information.Controls.Add(this.tbx_ItemInfo);
            this.Panel_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Information.Location = new System.Drawing.Point(891, 0);
            this.Panel_Information.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Information.Name = "Panel_Information";
            this.Panel_Information.Size = new System.Drawing.Size(275, 493);
            this.Panel_Information.TabIndex = 1;
            // 
            // Lbl_ItemInformation
            // 
            this.Lbl_ItemInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ItemInformation.AutoSize = true;
            this.Lbl_ItemInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ItemInformation.Location = new System.Drawing.Point(8, -3);
            this.Lbl_ItemInformation.Name = "Lbl_ItemInformation";
            this.Lbl_ItemInformation.Size = new System.Drawing.Size(130, 21);
            this.Lbl_ItemInformation.TabIndex = 1;
            this.Lbl_ItemInformation.Text = "Item Information:";
            // 
            // tbx_ItemInfo
            // 
            this.tbx_ItemInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_ItemInfo.Location = new System.Drawing.Point(9, 22);
            this.tbx_ItemInfo.Margin = new System.Windows.Forms.Padding(10, 0, 40, 0);
            this.tbx_ItemInfo.Multiline = true;
            this.tbx_ItemInfo.Name = "tbx_ItemInfo";
            this.tbx_ItemInfo.ReadOnly = true;
            this.tbx_ItemInfo.Size = new System.Drawing.Size(226, 431);
            this.tbx_ItemInfo.TabIndex = 0;
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
            this.Col_Armor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col_Armor.HeaderText = "Armor";
            this.Col_Armor.Name = "Col_Armor";
            this.Col_Armor.ReadOnly = true;
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
            this.TabPanel_Search.ResumeLayout(false);
            this.Panel_InputSerchSection.ResumeLayout(false);
            this.Panel_InputSerchSection.PerformLayout();
            this.GroupBox_Filter.ResumeLayout(false);
            this.GroupBox_Filter.PerformLayout();
            this.Panel_DataInformation.ResumeLayout(false);
            this.Panel_DataInformation.PerformLayout();
            this.TabPanel_DataBank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Armors)).EndInit();
            this.Panel_Information.ResumeLayout(false);
            this.Panel_Information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabLayerPanel_MAIN;
        private System.Windows.Forms.Label Lbl_TituloPagina;
        private System.Windows.Forms.TableLayoutPanel TabPanel_Search;
        private System.Windows.Forms.GroupBox GroupBox_Filter;
        private System.Windows.Forms.TableLayoutPanel TabPanel_DataBank;
        private System.Windows.Forms.DataGridView DataGridView_Armors;
        private System.Windows.Forms.Panel Panel_Information;
        private System.Windows.Forms.Label Lbl_ItemInformation;
        private System.Windows.Forms.TextBox tbx_ItemInfo;
        private System.Windows.Forms.ComboBox cbx_FilterType;
        private System.Windows.Forms.ComboBox cbx_FilterElement;
        private System.Windows.Forms.Label Lbl_Type;
        private System.Windows.Forms.Label Lbl_Element;
        private System.Windows.Forms.Panel Panel_InputSerchSection;
        private System.Windows.Forms.TextBox tbx_Input;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label Lbl_InsertValue;
        private System.Windows.Forms.Panel Panel_DataInformation;
        private System.Windows.Forms.Label lbl_NumFilter;
        private System.Windows.Forms.Label lbl_NumTotal;
        private System.Windows.Forms.Label Lbl_TotalByFilters;
        private System.Windows.Forms.Label Lbl_TotalItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Element;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Armor;
    }
}