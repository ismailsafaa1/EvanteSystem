namespace EvanteSystem
{
    partial class StatsForm
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
            this.cmbEvents = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTotalInvites = new System.Windows.Forms.Label();
            this.lblTotalGuests = new System.Windows.Forms.Label();
            this.lblTotalAttendance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.cmbEvents.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEvents.ItemHeight = 30;
            this.cmbEvents.Location = new System.Drawing.Point(130, 76);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(355, 36);
            this.cmbEvents.TabIndex = 0;
            this.cmbEvents.SelectedIndexChanged += new System.EventHandler(this.cmbEvents_SelectedIndexChanged);
            // 
            // lblTotalInvites
            // 
            this.lblTotalInvites.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalInvites.AutoSize = true;
            this.lblTotalInvites.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvites.Location = new System.Drawing.Point(134, 191);
            this.lblTotalInvites.Name = "lblTotalInvites";
            this.lblTotalInvites.Size = new System.Drawing.Size(76, 32);
            this.lblTotalInvites.TabIndex = 1;
            this.lblTotalInvites.Text = "label1";
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGuests.Location = new System.Drawing.Point(336, 191);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(79, 32);
            this.lblTotalGuests.TabIndex = 2;
            this.lblTotalGuests.Text = "label2";
            // 
            // lblTotalAttendance
            // 
            this.lblTotalAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalAttendance.AutoSize = true;
            this.lblTotalAttendance.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAttendance.Location = new System.Drawing.Point(560, 191);
            this.lblTotalAttendance.Name = "lblTotalAttendance";
            this.lblTotalAttendance.Size = new System.Drawing.Size(79, 32);
            this.lblTotalAttendance.TabIndex = 3;
            this.lblTotalAttendance.Text = "label3";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "الاحداث";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(510, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "تحديث";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalAttendance);
            this.Controls.Add(this.lblTotalGuests);
            this.Controls.Add(this.lblTotalInvites);
            this.Controls.Add(this.cmbEvents);
            this.Name = "StatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نموذج الإحصائيات";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbEvents;
        private System.Windows.Forms.Label lblTotalInvites;
        private System.Windows.Forms.Label lblTotalGuests;
        private System.Windows.Forms.Label lblTotalAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}