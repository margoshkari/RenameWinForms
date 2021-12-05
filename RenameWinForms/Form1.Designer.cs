
namespace RenameWinForms
{
    partial class Form1
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
            this.oldNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newNameTB = new System.Windows.Forms.TextBox();
            this.renameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldNameTB
            // 
            this.oldNameTB.Location = new System.Drawing.Point(12, 35);
            this.oldNameTB.Name = "oldNameTB";
            this.oldNameTB.Size = new System.Drawing.Size(267, 20);
            this.oldNameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "New name:";
            // 
            // newNameTB
            // 
            this.newNameTB.Location = new System.Drawing.Point(12, 94);
            this.newNameTB.Name = "newNameTB";
            this.newNameTB.Size = new System.Drawing.Size(267, 20);
            this.newNameTB.TabIndex = 3;
            // 
            // renameBtn
            // 
            this.renameBtn.Location = new System.Drawing.Point(104, 135);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(75, 23);
            this.renameBtn.TabIndex = 4;
            this.renameBtn.Text = "Rename";
            this.renameBtn.UseVisualStyleBackColor = true;
            this.renameBtn.Click += new System.EventHandler(this.renameBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 177);
            this.Controls.Add(this.renameBtn);
            this.Controls.Add(this.newNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldNameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newNameTB;
        private System.Windows.Forms.Button renameBtn;
    }
}

