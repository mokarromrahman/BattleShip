﻿namespace BattleShip
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnSend = new System.Windows.Forms.Button();
            this._tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(808, 720);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 61);
            this.textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(807, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(193, 702);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(79, 754);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 757);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Friend:";
            // 
            // _btnSend
            // 
            this._btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSend.Location = new System.Drawing.Point(960, 757);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(40, 23);
            this._btnSend.TabIndex = 5;
            this._btnSend.Text = "Send";
            this._btnSend.UseVisualStyleBackColor = true;
            // 
            // _tblPanel
            // 
            this._tblPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tblPanel.AutoSize = true;
            this._tblPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._tblPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this._tblPanel.ColumnCount = 10;
            this._tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this._tblPanel.Location = new System.Drawing.Point(228, 152);
            this._tblPanel.Name = "_tblPanel";
            this._tblPanel.RowCount = 10;
            this._tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPanel.Size = new System.Drawing.Size(560, 578);
            this._tblPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1007, 792);
            this.Controls.Add(this._tblPanel);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(822, 624);
            this.Name = "Form1";
            this.Text = "Battle Ship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnSend;
        private System.Windows.Forms.TableLayoutPanel _tblPanel;
    }
}

