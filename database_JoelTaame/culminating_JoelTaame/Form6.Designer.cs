namespace culminating_JoelTaame
{
    partial class formDeleteRecord
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
            this.btnReturnToMM = new System.Windows.Forms.Button();
            this.btnDeleteRec = new System.Windows.Forms.Button();
            this.txtbxDeleteRec = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDeletedRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnToMM
            // 
            this.btnReturnToMM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReturnToMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMM.Location = new System.Drawing.Point(520, 442);
            this.btnReturnToMM.Name = "btnReturnToMM";
            this.btnReturnToMM.Size = new System.Drawing.Size(202, 62);
            this.btnReturnToMM.TabIndex = 19;
            this.btnReturnToMM.Text = "Return To Main Menu";
            this.btnReturnToMM.UseVisualStyleBackColor = false;
            this.btnReturnToMM.Click += new System.EventHandler(this.btnReturnToMM_Click);
            // 
            // btnDeleteRec
            // 
            this.btnDeleteRec.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteRec.Location = new System.Drawing.Point(214, 222);
            this.btnDeleteRec.Name = "btnDeleteRec";
            this.btnDeleteRec.Size = new System.Drawing.Size(303, 84);
            this.btnDeleteRec.TabIndex = 126;
            this.btnDeleteRec.Text = "Delete Record";
            this.btnDeleteRec.UseVisualStyleBackColor = false;
            this.btnDeleteRec.Click += new System.EventHandler(this.btnDeleteRec_Click);
            // 
            // txtbxDeleteRec
            // 
            this.txtbxDeleteRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDeleteRec.Location = new System.Drawing.Point(197, 142);
            this.txtbxDeleteRec.Name = "txtbxDeleteRec";
            this.txtbxDeleteRec.Size = new System.Drawing.Size(339, 38);
            this.txtbxDeleteRec.TabIndex = 125;
            this.txtbxDeleteRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(157, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(419, 84);
            this.lblTitle.TabIndex = 124;
            this.lblTitle.Text = "Enter Building IRN Number\r\nfor Record you want to Delete";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeletedRecord
            // 
            this.btnDeletedRecord.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeletedRecord.Enabled = false;
            this.btnDeletedRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletedRecord.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeletedRecord.Location = new System.Drawing.Point(12, 342);
            this.btnDeletedRecord.Name = "btnDeletedRecord";
            this.btnDeletedRecord.Size = new System.Drawing.Size(709, 76);
            this.btnDeletedRecord.TabIndex = 128;
            this.btnDeletedRecord.UseVisualStyleBackColor = false;
            this.btnDeletedRecord.Visible = false;
            // 
            // formDeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::culminating_JoelTaame.pictures.databaseBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 516);
            this.ControlBox = false;
            this.Controls.Add(this.btnDeletedRecord);
            this.Controls.Add(this.btnDeleteRec);
            this.Controls.Add(this.txtbxDeleteRec);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturnToMM);
            this.Name = "formDeleteRecord";
            this.Text = "formDeleteRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMM;
        private System.Windows.Forms.Button btnDeleteRec;
        private System.Windows.Forms.TextBox txtbxDeleteRec;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDeletedRecord;
    }
}