
namespace View
{
    partial class F_ArtifactWindow
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
            this.lbl_InsertText = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Tbx_SearchItem = new System.Windows.Forms.TextBox();
            this.Tbx_ItemDescrition = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_InsertText
            // 
            this.lbl_InsertText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_InsertText.AutoSize = true;
            this.lbl_InsertText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_InsertText.Location = new System.Drawing.Point(643, 106);
            this.lbl_InsertText.Margin = new System.Windows.Forms.Padding(50, 0, 0, 1);
            this.lbl_InsertText.Name = "lbl_InsertText";
            this.lbl_InsertText.Size = new System.Drawing.Size(100, 21);
            this.lbl_InsertText.TabIndex = 2;
            this.lbl_InsertText.Text = "Insert to Text:";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(20)))));
            this.Btn_Search.FlatAppearance.BorderSize = 0;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Location = new System.Drawing.Point(1010, 130);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(97, 29);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = false;
            // 
            // Tbx_SearchItem
            // 
            this.Tbx_SearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_SearchItem.BackColor = System.Drawing.Color.White;
            this.Tbx_SearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbx_SearchItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tbx_SearchItem.Location = new System.Drawing.Point(643, 130);
            this.Tbx_SearchItem.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Tbx_SearchItem.Name = "Tbx_SearchItem";
            this.Tbx_SearchItem.Size = new System.Drawing.Size(367, 29);
            this.Tbx_SearchItem.TabIndex = 0;
            // 
            // Tbx_ItemDescrition
            // 
            this.Tbx_ItemDescrition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_ItemDescrition.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tbx_ItemDescrition.Location = new System.Drawing.Point(643, 186);
            this.Tbx_ItemDescrition.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.Tbx_ItemDescrition.Multiline = true;
            this.Tbx_ItemDescrition.Name = "Tbx_ItemDescrition";
            this.Tbx_ItemDescrition.ReadOnly = true;
            this.Tbx_ItemDescrition.Size = new System.Drawing.Size(464, 410);
            this.Tbx_ItemDescrition.TabIndex = 3;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(59, 106);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.Size = new System.Drawing.Size(567, 490);
            this.DataGridView.TabIndex = 4;
            // 
            // F_ArtifactWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1166, 743);
            this.ControlBox = false;
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.Tbx_ItemDescrition);
            this.Controls.Add(this.lbl_InsertText);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Tbx_SearchItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ArtifactWindow";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_InsertText;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Tbx_SearchItem;
        private System.Windows.Forms.TextBox Tbx_ItemDescrition;
        private System.Windows.Forms.DataGridView DataGridView;
    }
}