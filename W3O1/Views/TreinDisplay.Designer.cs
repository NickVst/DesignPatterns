namespace W3O1.Views
{
    partial class TreinDisplay
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
            this.lbl_ShowHuidigStation = new System.Windows.Forms.Label();
            this.lbl_ShowSpoor = new System.Windows.Forms.Label();
            this.lbl_HuidigStation = new System.Windows.Forms.Label();
            this.lbl_Spoor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ShowHuidigStation
            // 
            this.lbl_ShowHuidigStation.AutoSize = true;
            this.lbl_ShowHuidigStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowHuidigStation.Location = new System.Drawing.Point(16, 16);
            this.lbl_ShowHuidigStation.Name = "lbl_ShowHuidigStation";
            this.lbl_ShowHuidigStation.Size = new System.Drawing.Size(110, 20);
            this.lbl_ShowHuidigStation.TabIndex = 0;
            this.lbl_ShowHuidigStation.Text = "Huidig station:";
            // 
            // lbl_ShowSpoor
            // 
            this.lbl_ShowSpoor.AutoSize = true;
            this.lbl_ShowSpoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowSpoor.Location = new System.Drawing.Point(16, 48);
            this.lbl_ShowSpoor.Name = "lbl_ShowSpoor";
            this.lbl_ShowSpoor.Size = new System.Drawing.Size(56, 20);
            this.lbl_ShowSpoor.TabIndex = 1;
            this.lbl_ShowSpoor.Text = "Spoor:";
            // 
            // lbl_HuidigStation
            // 
            this.lbl_HuidigStation.AutoSize = true;
            this.lbl_HuidigStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HuidigStation.Location = new System.Drawing.Point(136, 16);
            this.lbl_HuidigStation.Name = "lbl_HuidigStation";
            this.lbl_HuidigStation.Size = new System.Drawing.Size(101, 20);
            this.lbl_HuidigStation.TabIndex = 2;
            this.lbl_HuidigStation.Text = "{placeholder}";
            // 
            // lbl_Spoor
            // 
            this.lbl_Spoor.AutoSize = true;
            this.lbl_Spoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Spoor.Location = new System.Drawing.Point(136, 48);
            this.lbl_Spoor.Name = "lbl_Spoor";
            this.lbl_Spoor.Size = new System.Drawing.Size(101, 20);
            this.lbl_Spoor.TabIndex = 3;
            this.lbl_Spoor.Text = "{placeholder}";
            // 
            // TreinDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.lbl_Spoor);
            this.Controls.Add(this.lbl_HuidigStation);
            this.Controls.Add(this.lbl_ShowSpoor);
            this.Controls.Add(this.lbl_ShowHuidigStation);
            this.Name = "TreinDisplay";
            this.Text = "TreinDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ShowHuidigStation;
        private System.Windows.Forms.Label lbl_ShowSpoor;
        private System.Windows.Forms.Label lbl_HuidigStation;
        private System.Windows.Forms.Label lbl_Spoor;
    }
}