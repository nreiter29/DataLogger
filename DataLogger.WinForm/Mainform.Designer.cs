namespace DataLogger.WinForm {
    partial class Datenlogger {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn.Location = new System.Drawing.Point(12, 536);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(159, 49);
            this.btn.TabIndex = 0;
            this.btn.Text = "Lade CSV-File";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Daten:";
            // 
            // ltbData
            // 
            this.ltbData.FormattingEnabled = true;
            this.ltbData.ItemHeight = 25;
            this.ltbData.Location = new System.Drawing.Point(21, 87);
            this.ltbData.Name = "ltbData";
            this.ltbData.Size = new System.Drawing.Size(604, 404);
            this.ltbData.TabIndex = 2;
            // 
            // Datenlogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 597);
            this.Controls.Add(this.ltbData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Name = "Datenlogger";
            this.Text = "Datenlogger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn;
        private Label label1;
        private ListBox ltbData;
    }
}