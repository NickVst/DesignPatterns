namespace W3O1.Views
{
    partial class ControlPanel
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
            this.btn_NieuwDisplay = new System.Windows.Forms.Button();
            this.btn_VolgendStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NieuwDisplay
            // 
            this.btn_NieuwDisplay.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NieuwDisplay.Location = new System.Drawing.Point(8, 96);
            this.btn_NieuwDisplay.Name = "btn_NieuwDisplay";
            this.btn_NieuwDisplay.Size = new System.Drawing.Size(256, 32);
            this.btn_NieuwDisplay.TabIndex = 3;
            this.btn_NieuwDisplay.Text = "Nieuw display";
            this.btn_NieuwDisplay.UseVisualStyleBackColor = true;
            // 
            // btn_VolgendStation
            // 
            this.btn_VolgendStation.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VolgendStation.Location = new System.Drawing.Point(8, 8);
            this.btn_VolgendStation.Name = "btn_VolgendStation";
            this.btn_VolgendStation.Size = new System.Drawing.Size(256, 64);
            this.btn_VolgendStation.TabIndex = 2;
            this.btn_VolgendStation.Text = "Volgend Station";
            this.btn_VolgendStation.UseVisualStyleBackColor = true;
            this.btn_VolgendStation.Click += new System.EventHandler(this.btn_VolgendStation_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 137);
            this.Controls.Add(this.btn_NieuwDisplay);
            this.Controls.Add(this.btn_VolgendStation);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NieuwDisplay;
        private System.Windows.Forms.Button btn_VolgendStation;
    }
}