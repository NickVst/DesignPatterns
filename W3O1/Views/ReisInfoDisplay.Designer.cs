namespace W3O1
{
    partial class ReisInfoDisplay
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
            this.lbl_huidigStation = new System.Windows.Forms.Label();
            this.lbl_spoor = new System.Windows.Forms.Label();
            this.lbl_toonHuidigStation = new System.Windows.Forms.Label();
            this.lbl_toonSpoor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_huidigStation
            // 
            this.lbl_huidigStation.AutoSize = true;
            this.lbl_huidigStation.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_huidigStation.Location = new System.Drawing.Point(13, 13);
            this.lbl_huidigStation.Name = "lbl_huidigStation";
            this.lbl_huidigStation.Size = new System.Drawing.Size(109, 20);
            this.lbl_huidigStation.TabIndex = 0;
            this.lbl_huidigStation.Text = "Huidig station:";
            // 
            // lbl_spoor
            // 
            this.lbl_spoor.AutoSize = true;
            this.lbl_spoor.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spoor.Location = new System.Drawing.Point(13, 41);
            this.lbl_spoor.Name = "lbl_spoor";
            this.lbl_spoor.Size = new System.Drawing.Size(54, 20);
            this.lbl_spoor.TabIndex = 1;
            this.lbl_spoor.Text = "Spoor:";
            // 
            // lbl_toonHuidigStation
            // 
            this.lbl_toonHuidigStation.AutoSize = true;
            this.lbl_toonHuidigStation.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toonHuidigStation.Location = new System.Drawing.Point(152, 13);
            this.lbl_toonHuidigStation.Name = "lbl_toonHuidigStation";
            this.lbl_toonHuidigStation.Size = new System.Drawing.Size(19, 20);
            this.lbl_toonHuidigStation.TabIndex = 2;
            this.lbl_toonHuidigStation.Text = "#";
            // 
            // lbl_toonSpoor
            // 
            this.lbl_toonSpoor.AutoSize = true;
            this.lbl_toonSpoor.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toonSpoor.Location = new System.Drawing.Point(152, 41);
            this.lbl_toonSpoor.Name = "lbl_toonSpoor";
            this.lbl_toonSpoor.Size = new System.Drawing.Size(19, 20);
            this.lbl_toonSpoor.TabIndex = 3;
            this.lbl_toonSpoor.Text = "#";
            // 
            // ReisInfoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 74);
            this.Controls.Add(this.lbl_toonSpoor);
            this.Controls.Add(this.lbl_toonHuidigStation);
            this.Controls.Add(this.lbl_spoor);
            this.Controls.Add(this.lbl_huidigStation);
            this.Name = "ReisInfoDisplay";
            this.Text = "ReisInfoDisplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_huidigStation;
        private System.Windows.Forms.Label lbl_spoor;
        private System.Windows.Forms.Label lbl_toonHuidigStation;
        private System.Windows.Forms.Label lbl_toonSpoor;
    }
}