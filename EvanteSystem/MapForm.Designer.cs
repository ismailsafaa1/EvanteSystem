namespace EvanteSystem
{
    partial class MapForm
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSavelLocation = new System.Windows.Forms.Button();
            this.txtMapUrl = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(75, 584);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(279, 39);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSavelLocation
            // 
            this.btnSavelLocation.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavelLocation.Location = new System.Drawing.Point(867, 583);
            this.btnSavelLocation.Name = "btnSavelLocation";
            this.btnSavelLocation.Size = new System.Drawing.Size(256, 40);
            this.btnSavelLocation.TabIndex = 2;
            this.btnSavelLocation.Text = "حفظ";
            this.btnSavelLocation.UseVisualStyleBackColor = true;
            this.btnSavelLocation.Click += new System.EventHandler(this.btnSavelLocation_Click);
            // 
            // txtMapUrl
            // 
            this.txtMapUrl.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMapUrl.Location = new System.Drawing.Point(409, 583);
            this.txtMapUrl.Name = "txtMapUrl";
            this.txtMapUrl.Size = new System.Drawing.Size(279, 39);
            this.txtMapUrl.TabIndex = 3;
            this.txtMapUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(75, 629);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(279, 39);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 674);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtMapUrl);
            this.Controls.Add(this.btnSavelLocation);
            this.Controls.Add(this.txtLocation);
            this.Name = "MapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حدد موقع الحدث";
            this.Load += new System.EventHandler(this.MapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSavelLocation;
        private System.Windows.Forms.TextBox txtMapUrl;
        private System.Windows.Forms.TextBox txtDescription;
    }
}