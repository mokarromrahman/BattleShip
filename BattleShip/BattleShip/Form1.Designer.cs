namespace BattleShip
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
            this._tbMessage = new System.Windows.Forms.TextBox();
            this._rtbMessages = new System.Windows.Forms.RichTextBox();
            this._tbIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnSend = new System.Windows.Forms.Button();
            this._tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this._lbFriends = new System.Windows.Forms.ListBox();
            this._btnHost = new System.Windows.Forms.Button();
            this._btnAddFriend = new System.Windows.Forms.Button();
            this._btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _tbMessage
            // 
            this._tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._tbMessage.Location = new System.Drawing.Point(607, 649);
            this._tbMessage.Multiline = true;
            this._tbMessage.Name = "_tbMessage";
            this._tbMessage.Size = new System.Drawing.Size(193, 61);
            this._tbMessage.TabIndex = 1;
            // 
            // _rtbMessages
            // 
            this._rtbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbMessages.Location = new System.Drawing.Point(606, 12);
            this._rtbMessages.Name = "_rtbMessages";
            this._rtbMessages.ReadOnly = true;
            this._rtbMessages.Size = new System.Drawing.Size(193, 631);
            this._rtbMessages.TabIndex = 2;
            this._rtbMessages.Text = "";
            // 
            // _tbIPAddress
            // 
            this._tbIPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._tbIPAddress.Location = new System.Drawing.Point(83, 616);
            this._tbIPAddress.Name = "_tbIPAddress";
            this._tbIPAddress.Size = new System.Drawing.Size(100, 20);
            this._tbIPAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Friend:";
            // 
            // _btnSend
            // 
            this._btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSend.Location = new System.Drawing.Point(759, 686);
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
            this._tblPanel.Location = new System.Drawing.Point(15, 12);
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
            this._tblPanel.Size = new System.Drawing.Size(550, 550);
            this._tblPanel.TabIndex = 6;
            // 
            // _lbFriends
            // 
            this._lbFriends.FormattingEnabled = true;
            this._lbFriends.Location = new System.Drawing.Point(336, 611);
            this._lbFriends.Name = "_lbFriends";
            this._lbFriends.Size = new System.Drawing.Size(120, 56);
            this._lbFriends.TabIndex = 7;
            // 
            // _btnHost
            // 
            this._btnHost.Location = new System.Drawing.Point(317, 673);
            this._btnHost.Name = "_btnHost";
            this._btnHost.Size = new System.Drawing.Size(75, 23);
            this._btnHost.TabIndex = 8;
            this._btnHost.Text = "Host";
            this._btnHost.UseVisualStyleBackColor = true;
            // 
            // _btnAddFriend
            // 
            this._btnAddFriend.Location = new System.Drawing.Point(189, 614);
            this._btnAddFriend.Name = "_btnAddFriend";
            this._btnAddFriend.Size = new System.Drawing.Size(75, 23);
            this._btnAddFriend.TabIndex = 9;
            this._btnAddFriend.Text = "Add Friend";
            this._btnAddFriend.UseVisualStyleBackColor = true;
            // 
            // _btnConnect
            // 
            this._btnConnect.Location = new System.Drawing.Point(398, 673);
            this._btnConnect.Name = "_btnConnect";
            this._btnConnect.Size = new System.Drawing.Size(75, 23);
            this._btnConnect.TabIndex = 10;
            this._btnConnect.Text = "Connect";
            this._btnConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(806, 721);
            this.Controls.Add(this._btnConnect);
            this.Controls.Add(this._btnAddFriend);
            this.Controls.Add(this._btnHost);
            this.Controls.Add(this._lbFriends);
            this.Controls.Add(this._tblPanel);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._tbIPAddress);
            this.Controls.Add(this._rtbMessages);
            this.Controls.Add(this._tbMessage);
            this.MinimumSize = new System.Drawing.Size(822, 624);
            this.Name = "Form1";
            this.Text = "Battle Ship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _tbMessage;
        private System.Windows.Forms.RichTextBox _rtbMessages;
        private System.Windows.Forms.TextBox _tbIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnSend;
        private System.Windows.Forms.TableLayoutPanel _tblPanel;
        private System.Windows.Forms.ListBox _lbFriends;
        private System.Windows.Forms.Button _btnHost;
        private System.Windows.Forms.Button _btnAddFriend;
        private System.Windows.Forms.Button _btnConnect;
    }
}

