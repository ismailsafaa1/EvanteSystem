namespace EvanteSystem
{
    partial class AddInvitationsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbEvents = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtGuestName = new Guna.UI2.WinForms.Guna2TextBox();
            this.numPeopleCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGenerateCode = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddInvitation = new Guna.UI2.WinForms.Guna2Button();
            this.dgvInvitations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitations)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEvents
            // 
            this.cmbEvents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEvents.BackColor = System.Drawing.Color.Transparent;
            this.cmbEvents.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvents.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEvents.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEvents.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEvents.ItemHeight = 30;
            this.cmbEvents.Location = new System.Drawing.Point(358, 46);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(298, 36);
            this.cmbEvents.TabIndex = 0;
            this.cmbEvents.SelectedIndexChanged += new System.EventHandler(this.cmbEvents_SelectedIndexChanged);
            // 
            // txtGuestName
            // 
            this.txtGuestName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGuestName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuestName.DefaultText = "";
            this.txtGuestName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGuestName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGuestName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuestName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuestName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuestName.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuestName.Location = new System.Drawing.Point(340, 150);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.PasswordChar = '\0';
            this.txtGuestName.PlaceholderText = "";
            this.txtGuestName.SelectedText = "";
            this.txtGuestName.Size = new System.Drawing.Size(302, 59);
            this.txtGuestName.TabIndex = 1;
            // 
            // numPeopleCount
            // 
            this.numPeopleCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numPeopleCount.BackColor = System.Drawing.Color.Transparent;
            this.numPeopleCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numPeopleCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numPeopleCount.Location = new System.Drawing.Point(693, 149);
            this.numPeopleCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numPeopleCount.Name = "numPeopleCount";
            this.numPeopleCount.Size = new System.Drawing.Size(239, 60);
            this.numPeopleCount.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultText = "";
            this.txtCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCode.Location = new System.Drawing.Point(12, 150);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderText = "";
            this.txtCode.SelectedText = "";
            this.txtCode.Size = new System.Drawing.Size(275, 59);
            this.txtCode.TabIndex = 3;
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerateCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateCode.FillColor = System.Drawing.Color.Blue;
            this.btnGenerateCode.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCode.ForeColor = System.Drawing.Color.White;
            this.btnGenerateCode.Location = new System.Drawing.Point(544, 609);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(180, 45);
            this.btnGenerateCode.TabIndex = 4;
            this.btnGenerateCode.Text = "انشأ الكود";
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // btnAddInvitation
            // 
            this.btnAddInvitation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddInvitation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddInvitation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddInvitation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddInvitation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddInvitation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddInvitation.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvitation.ForeColor = System.Drawing.Color.White;
            this.btnAddInvitation.Location = new System.Drawing.Point(323, 609);
            this.btnAddInvitation.Name = "btnAddInvitation";
            this.btnAddInvitation.Size = new System.Drawing.Size(180, 45);
            this.btnAddInvitation.TabIndex = 5;
            this.btnAddInvitation.Text = "إضافة دعوة";
            this.btnAddInvitation.Click += new System.EventHandler(this.btnAddInvitation_Click);
            // 
            // dgvInvitations
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvInvitations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInvitations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvitations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInvitations.ColumnHeadersHeight = 4;
            this.dgvInvitations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvitations.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInvitations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInvitations.Location = new System.Drawing.Point(12, 258);
            this.dgvInvitations.Name = "dgvInvitations";
            this.dgvInvitations.RowHeadersVisible = false;
            this.dgvInvitations.RowHeadersWidth = 62;
            this.dgvInvitations.RowTemplate.Height = 29;
            this.dgvInvitations.Size = new System.Drawing.Size(965, 328);
            this.dgvInvitations.TabIndex = 6;
            this.dgvInvitations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInvitations.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvInvitations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvInvitations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvInvitations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvInvitations.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvInvitations.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInvitations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvInvitations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInvitations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvInvitations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInvitations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvInvitations.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvInvitations.ThemeStyle.ReadOnly = false;
            this.dgvInvitations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInvitations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInvitations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvInvitations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvInvitations.ThemeStyle.RowsStyle.Height = 29;
            this.dgvInvitations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInvitations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم الحدث";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(745, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "عدد الحظور";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "اسم الضيف";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "اكتب كود";
            // 
            // AddInvitationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 678);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInvitations);
            this.Controls.Add(this.btnAddInvitation);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.numPeopleCount);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.cmbEvents);
            this.Name = "AddInvitationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نموذج إضافة الدعوات";
            this.Load += new System.EventHandler(this.AddInvitationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPeopleCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvitations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbEvents;
        private Guna.UI2.WinForms.Guna2TextBox txtGuestName;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPeopleCount;
        private Guna.UI2.WinForms.Guna2TextBox txtCode;
        private Guna.UI2.WinForms.Guna2Button btnGenerateCode;
        private Guna.UI2.WinForms.Guna2Button btnAddInvitation;
        private Guna.UI2.WinForms.Guna2DataGridView dgvInvitations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}