namespace GenerateRepositoryServiceCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFolderEntity = new System.Windows.Forms.Button();
            this.txtFolderEntity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRepoInterface = new System.Windows.Forms.Button();
            this.txtRepoInterface = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRepoImplement = new System.Windows.Forms.Button();
            this.txtRepoImplement = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServiceImplement = new System.Windows.Forms.TextBox();
            this.btnServiceImplement = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServiceInterface = new System.Windows.Forms.TextBox();
            this.btnServiceInterface = new System.Windows.Forms.Button();
            this.btnFileServiceInterface = new System.Windows.Forms.Button();
            this.txtFileServiceInterface = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFileServiceImplement = new System.Windows.Forms.Button();
            this.txtFileServiceImplement = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFileRepoImplement = new System.Windows.Forms.TextBox();
            this.btnFileRepoImplement = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFileRepoInterface = new System.Windows.Forms.TextBox();
            this.btnFileRepoInterface = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtReplace1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReplaceTo1 = new System.Windows.Forms.TextBox();
            this.txtReplace2 = new System.Windows.Forms.TextBox();
            this.txtReplaceTo2 = new System.Windows.Forms.TextBox();
            this.txtReplace3 = new System.Windows.Forms.TextBox();
            this.txtReplaceTo3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnFolderEntity
            // 
            this.btnFolderEntity.Location = new System.Drawing.Point(501, 61);
            this.btnFolderEntity.Name = "btnFolderEntity";
            this.btnFolderEntity.Size = new System.Drawing.Size(123, 23);
            this.btnFolderEntity.TabIndex = 0;
            this.btnFolderEntity.Text = "Select folder entity";
            this.btnFolderEntity.UseVisualStyleBackColor = true;
            this.btnFolderEntity.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFolderEntity
            // 
            this.txtFolderEntity.Location = new System.Drawing.Point(198, 61);
            this.txtFolderEntity.Name = "txtFolderEntity";
            this.txtFolderEntity.ReadOnly = true;
            this.txtFolderEntity.Size = new System.Drawing.Size(273, 23);
            this.txtFolderEntity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder entity";
            // 
            // btnRepoInterface
            // 
            this.btnRepoInterface.Location = new System.Drawing.Point(501, 118);
            this.btnRepoInterface.Name = "btnRepoInterface";
            this.btnRepoInterface.Size = new System.Drawing.Size(216, 23);
            this.btnRepoInterface.TabIndex = 0;
            this.btnRepoInterface.Text = "Select folder repository Interface";
            this.btnRepoInterface.UseVisualStyleBackColor = true;
            this.btnRepoInterface.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRepoInterface
            // 
            this.txtRepoInterface.Location = new System.Drawing.Point(198, 118);
            this.txtRepoInterface.Name = "txtRepoInterface";
            this.txtRepoInterface.ReadOnly = true;
            this.txtRepoInterface.Size = new System.Drawing.Size(273, 23);
            this.txtRepoInterface.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Folder Repository Interface";
            // 
            // btnRepoImplement
            // 
            this.btnRepoImplement.Location = new System.Drawing.Point(501, 153);
            this.btnRepoImplement.Name = "btnRepoImplement";
            this.btnRepoImplement.Size = new System.Drawing.Size(216, 23);
            this.btnRepoImplement.TabIndex = 0;
            this.btnRepoImplement.Text = "Select folder repository Implement";
            this.btnRepoImplement.UseVisualStyleBackColor = true;
            this.btnRepoImplement.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRepoImplement
            // 
            this.txtRepoImplement.Location = new System.Drawing.Point(198, 153);
            this.txtRepoImplement.Name = "txtRepoImplement";
            this.txtRepoImplement.ReadOnly = true;
            this.txtRepoImplement.Size = new System.Drawing.Size(273, 23);
            this.txtRepoImplement.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Folder Repository Implement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Folder Service Implement";
            // 
            // txtServiceImplement
            // 
            this.txtServiceImplement.Location = new System.Drawing.Point(198, 236);
            this.txtServiceImplement.Name = "txtServiceImplement";
            this.txtServiceImplement.ReadOnly = true;
            this.txtServiceImplement.Size = new System.Drawing.Size(273, 23);
            this.txtServiceImplement.TabIndex = 1;
            // 
            // btnServiceImplement
            // 
            this.btnServiceImplement.Location = new System.Drawing.Point(501, 236);
            this.btnServiceImplement.Name = "btnServiceImplement";
            this.btnServiceImplement.Size = new System.Drawing.Size(216, 23);
            this.btnServiceImplement.TabIndex = 0;
            this.btnServiceImplement.Text = "Select folder Service Implement";
            this.btnServiceImplement.UseVisualStyleBackColor = true;
            this.btnServiceImplement.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Folder Service Interface";
            // 
            // txtServiceInterface
            // 
            this.txtServiceInterface.Location = new System.Drawing.Point(198, 201);
            this.txtServiceInterface.Name = "txtServiceInterface";
            this.txtServiceInterface.ReadOnly = true;
            this.txtServiceInterface.Size = new System.Drawing.Size(273, 23);
            this.txtServiceInterface.TabIndex = 1;
            // 
            // btnServiceInterface
            // 
            this.btnServiceInterface.Location = new System.Drawing.Point(501, 201);
            this.btnServiceInterface.Name = "btnServiceInterface";
            this.btnServiceInterface.Size = new System.Drawing.Size(216, 23);
            this.btnServiceInterface.TabIndex = 0;
            this.btnServiceInterface.Text = "Select folder Service Interface";
            this.btnServiceInterface.UseVisualStyleBackColor = true;
            this.btnServiceInterface.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFileServiceInterface
            // 
            this.btnFileServiceInterface.Location = new System.Drawing.Point(501, 390);
            this.btnFileServiceInterface.Name = "btnFileServiceInterface";
            this.btnFileServiceInterface.Size = new System.Drawing.Size(216, 23);
            this.btnFileServiceInterface.TabIndex = 0;
            this.btnFileServiceInterface.Text = "Select file Service Interface";
            this.btnFileServiceInterface.UseVisualStyleBackColor = true;
            this.btnFileServiceInterface.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileServiceInterface
            // 
            this.txtFileServiceInterface.Location = new System.Drawing.Point(198, 390);
            this.txtFileServiceInterface.Name = "txtFileServiceInterface";
            this.txtFileServiceInterface.ReadOnly = true;
            this.txtFileServiceInterface.Size = new System.Drawing.Size(273, 23);
            this.txtFileServiceInterface.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "File Service Interface";
            // 
            // btnFileServiceImplement
            // 
            this.btnFileServiceImplement.Location = new System.Drawing.Point(501, 425);
            this.btnFileServiceImplement.Name = "btnFileServiceImplement";
            this.btnFileServiceImplement.Size = new System.Drawing.Size(216, 23);
            this.btnFileServiceImplement.TabIndex = 0;
            this.btnFileServiceImplement.Text = "Select file  Service Implement";
            this.btnFileServiceImplement.UseVisualStyleBackColor = true;
            this.btnFileServiceImplement.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileServiceImplement
            // 
            this.txtFileServiceImplement.Location = new System.Drawing.Point(198, 425);
            this.txtFileServiceImplement.Name = "txtFileServiceImplement";
            this.txtFileServiceImplement.ReadOnly = true;
            this.txtFileServiceImplement.Size = new System.Drawing.Size(273, 23);
            this.txtFileServiceImplement.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "File Service Implement";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "File Repository Implement";
            // 
            // txtFileRepoImplement
            // 
            this.txtFileRepoImplement.Location = new System.Drawing.Point(198, 342);
            this.txtFileRepoImplement.Name = "txtFileRepoImplement";
            this.txtFileRepoImplement.ReadOnly = true;
            this.txtFileRepoImplement.Size = new System.Drawing.Size(273, 23);
            this.txtFileRepoImplement.TabIndex = 1;
            // 
            // btnFileRepoImplement
            // 
            this.btnFileRepoImplement.Location = new System.Drawing.Point(501, 342);
            this.btnFileRepoImplement.Name = "btnFileRepoImplement";
            this.btnFileRepoImplement.Size = new System.Drawing.Size(216, 23);
            this.btnFileRepoImplement.TabIndex = 0;
            this.btnFileRepoImplement.Text = "Select file repository Implement";
            this.btnFileRepoImplement.UseVisualStyleBackColor = true;
            this.btnFileRepoImplement.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "File Repository Interface";
            // 
            // txtFileRepoInterface
            // 
            this.txtFileRepoInterface.Location = new System.Drawing.Point(198, 307);
            this.txtFileRepoInterface.Name = "txtFileRepoInterface";
            this.txtFileRepoInterface.ReadOnly = true;
            this.txtFileRepoInterface.Size = new System.Drawing.Size(273, 23);
            this.txtFileRepoInterface.TabIndex = 1;
            // 
            // btnFileRepoInterface
            // 
            this.btnFileRepoInterface.Location = new System.Drawing.Point(501, 307);
            this.btnFileRepoInterface.Name = "btnFileRepoInterface";
            this.btnFileRepoInterface.Size = new System.Drawing.Size(216, 23);
            this.btnFileRepoInterface.TabIndex = 0;
            this.btnFileRepoInterface.Text = "Select file repository Interface";
            this.btnFileRepoInterface.UseVisualStyleBackColor = true;
            this.btnFileRepoInterface.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(41, 13);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtReplace1
            // 
            this.txtReplace1.Location = new System.Drawing.Point(832, 110);
            this.txtReplace1.Name = "txtReplace1";
            this.txtReplace1.Size = new System.Drawing.Size(209, 23);
            this.txtReplace1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(871, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Word want to replace";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1195, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Replace To";
            // 
            // txtReplaceTo1
            // 
            this.txtReplaceTo1.Location = new System.Drawing.Point(1122, 110);
            this.txtReplaceTo1.Name = "txtReplaceTo1";
            this.txtReplaceTo1.Size = new System.Drawing.Size(209, 23);
            this.txtReplaceTo1.TabIndex = 4;
            // 
            // txtReplace2
            // 
            this.txtReplace2.Location = new System.Drawing.Point(832, 139);
            this.txtReplace2.Name = "txtReplace2";
            this.txtReplace2.Size = new System.Drawing.Size(209, 23);
            this.txtReplace2.TabIndex = 4;
            // 
            // txtReplaceTo2
            // 
            this.txtReplaceTo2.Location = new System.Drawing.Point(1122, 139);
            this.txtReplaceTo2.Name = "txtReplaceTo2";
            this.txtReplaceTo2.Size = new System.Drawing.Size(209, 23);
            this.txtReplaceTo2.TabIndex = 4;
            // 
            // txtReplace3
            // 
            this.txtReplace3.Location = new System.Drawing.Point(832, 168);
            this.txtReplace3.Name = "txtReplace3";
            this.txtReplace3.Size = new System.Drawing.Size(209, 23);
            this.txtReplace3.TabIndex = 4;
            // 
            // txtReplaceTo3
            // 
            this.txtReplaceTo3.Location = new System.Drawing.Point(1122, 168);
            this.txtReplaceTo3.Name = "txtReplaceTo3";
            this.txtReplaceTo3.Size = new System.Drawing.Size(209, 23);
            this.txtReplaceTo3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 538);
            this.Controls.Add(this.txtReplaceTo3);
            this.Controls.Add(this.txtReplace3);
            this.Controls.Add(this.txtReplaceTo2);
            this.Controls.Add(this.txtReplace2);
            this.Controls.Add(this.txtReplaceTo1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtReplace1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnFileRepoInterface);
            this.Controls.Add(this.txtFileRepoInterface);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFileRepoImplement);
            this.Controls.Add(this.txtFileRepoImplement);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFileServiceImplement);
            this.Controls.Add(this.btnFileServiceImplement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFileServiceInterface);
            this.Controls.Add(this.btnFileServiceInterface);
            this.Controls.Add(this.btnServiceInterface);
            this.Controls.Add(this.txtServiceInterface);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnServiceImplement);
            this.Controls.Add(this.txtServiceImplement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRepoImplement);
            this.Controls.Add(this.btnRepoImplement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRepoInterface);
            this.Controls.Add(this.btnRepoInterface);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolderEntity);
            this.Controls.Add(this.btnFolderEntity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFolderEntity;
        private System.Windows.Forms.TextBox txtFolderEntity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRepoInterface;
        private System.Windows.Forms.TextBox txtRepoInterface;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRepoImplement;
        private System.Windows.Forms.TextBox txtRepoImplement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServiceImplement;
        private System.Windows.Forms.Button btnServiceImplement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServiceInterface;
        private System.Windows.Forms.Button btnServiceInterface;
        private System.Windows.Forms.Button btnFileServiceInterface;
        private System.Windows.Forms.TextBox txtFileServiceInterface;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFileServiceImplement;
        private System.Windows.Forms.TextBox txtFileServiceImplement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFileRepoImplement;
        private System.Windows.Forms.Button btnFileRepoImplement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFileRepoInterface;
        private System.Windows.Forms.Button btnFileRepoInterface;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtReplace1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReplaceTo1;
        private System.Windows.Forms.TextBox txtReplace2;
        private System.Windows.Forms.TextBox txtReplaceTo2;
        private System.Windows.Forms.TextBox txtReplace3;
        private System.Windows.Forms.TextBox txtReplaceTo3;
    }
}

