namespace CursoWindowsForms
{
    partial class Frm_MouseCursor
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
            this.Btn_Cursor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Cursor
            // 
            this.Btn_Cursor.Location = new System.Drawing.Point(108, 78);
            this.Btn_Cursor.Name = "Btn_Cursor";
            this.Btn_Cursor.Size = new System.Drawing.Size(256, 115);
            this.Btn_Cursor.TabIndex = 0;
            this.Btn_Cursor.UseVisualStyleBackColor = true;
            this.Btn_Cursor.Click += new System.EventHandler(this.Btn_Cursor_Click);
            // 
            // Frm_MouseCursor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 274);
            this.Controls.Add(this.Btn_Cursor);
            this.Name = "Frm_MouseCursor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MouseCursor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cursor;
    }
}