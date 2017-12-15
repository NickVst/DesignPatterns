namespace W3O1
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
            this.btn_volgendStation = new System.Windows.Forms.Button();
            this.btn_nieuwDisplay = new System.Windows.Forms.Button();
            this.btn_lijstDisplay = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_volgendStation
            // 
            this.btn_volgendStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_volgendStation.Location = new System.Drawing.Point(12, 12);
            this.btn_volgendStation.Name = "btn_volgendStation";
            this.btn_volgendStation.Size = new System.Drawing.Size(260, 56);
            this.btn_volgendStation.TabIndex = 0;
            this.btn_volgendStation.Text = "Volgend Station";
            this.btn_volgendStation.UseVisualStyleBackColor = true;
            this.btn_volgendStation.Click += new System.EventHandler(this.btn_volgendStation_Click);
            // 
            // btn_nieuwDisplay
            // 
            this.btn_nieuwDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nieuwDisplay.Location = new System.Drawing.Point(12, 83);
            this.btn_nieuwDisplay.Name = "btn_nieuwDisplay";
            this.btn_nieuwDisplay.Size = new System.Drawing.Size(99, 49);
            this.btn_nieuwDisplay.TabIndex = 1;
            this.btn_nieuwDisplay.Text = "Maak een nieuw display aan";
            this.btn_nieuwDisplay.UseVisualStyleBackColor = true;
            this.btn_nieuwDisplay.Click += new System.EventHandler(this.btn_nieuwDisplay_Click);
            // 
            // btn_lijstDisplay
            // 
            this.btn_lijstDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lijstDisplay.Location = new System.Drawing.Point(173, 83);
            this.btn_lijstDisplay.Name = "btn_lijstDisplay";
            this.btn_lijstDisplay.Size = new System.Drawing.Size(99, 49);
            this.btn_lijstDisplay.TabIndex = 2;
            this.btn_lijstDisplay.Text = "Maak een lijst display aan";
            this.btn_lijstDisplay.UseVisualStyleBackColor = true;
            this.btn_lijstDisplay.Click += new System.EventHandler(this.btn_lijstDisplay_Click);
            // 
            // btn_return
            // 
            this.btn_return.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_return.Location = new System.Drawing.Point(12, 150);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(260, 56);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "Keer om";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 254);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_lijstDisplay);
            this.Controls.Add(this.btn_nieuwDisplay);
            this.Controls.Add(this.btn_volgendStation);
            this.Name = "ControlPanel";
            this.Text = "ControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volgendStation;
        private System.Windows.Forms.Button btn_nieuwDisplay;
        private System.Windows.Forms.Button btn_lijstDisplay;
        private System.Windows.Forms.Button btn_return;
    }
}