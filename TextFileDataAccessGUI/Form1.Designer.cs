
namespace TextFileDataAccessGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SaveToFile = new System.Windows.Forms.Button();
            this.tb_FName = new System.Windows.Forms.TextBox();
            this.tb_LName = new System.Windows.Forms.TextBox();
            this.tb_URL = new System.Windows.Forms.TextBox();
            this.btn_LoadFromFile = new System.Windows.Forms.Button();
            this.btn_SaveToList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_PersonList = new System.Windows.Forms.ListBox();
            this.ofd_File = new System.Windows.Forms.OpenFileDialog();
            this.fbd_Browse = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(52, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // btn_SaveToFile
            // 
            this.btn_SaveToFile.BackColor = System.Drawing.Color.Yellow;
            this.btn_SaveToFile.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_SaveToFile.Location = new System.Drawing.Point(33, 338);
            this.btn_SaveToFile.Name = "btn_SaveToFile";
            this.btn_SaveToFile.Size = new System.Drawing.Size(137, 42);
            this.btn_SaveToFile.TabIndex = 2;
            this.btn_SaveToFile.Text = "Save To File:";
            this.btn_SaveToFile.UseVisualStyleBackColor = false;
            this.btn_SaveToFile.Click += new System.EventHandler(this.btn_SaveToFile_Click_1);
            // 
            // tb_FName
            // 
            this.tb_FName.BackColor = System.Drawing.Color.Aquamarine;
            this.tb_FName.ForeColor = System.Drawing.Color.Blue;
            this.tb_FName.Location = new System.Drawing.Point(198, 92);
            this.tb_FName.Name = "tb_FName";
            this.tb_FName.Size = new System.Drawing.Size(125, 27);
            this.tb_FName.TabIndex = 3;
            // 
            // tb_LName
            // 
            this.tb_LName.BackColor = System.Drawing.Color.Aquamarine;
            this.tb_LName.ForeColor = System.Drawing.Color.Blue;
            this.tb_LName.Location = new System.Drawing.Point(198, 144);
            this.tb_LName.Name = "tb_LName";
            this.tb_LName.Size = new System.Drawing.Size(125, 27);
            this.tb_LName.TabIndex = 6;
            // 
            // tb_URL
            // 
            this.tb_URL.BackColor = System.Drawing.Color.Aquamarine;
            this.tb_URL.ForeColor = System.Drawing.Color.Blue;
            this.tb_URL.Location = new System.Drawing.Point(198, 193);
            this.tb_URL.Name = "tb_URL";
            this.tb_URL.Size = new System.Drawing.Size(125, 27);
            this.tb_URL.TabIndex = 7;
            // 
            // btn_LoadFromFile
            // 
            this.btn_LoadFromFile.BackColor = System.Drawing.Color.Yellow;
            this.btn_LoadFromFile.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_LoadFromFile.Location = new System.Drawing.Point(33, 386);
            this.btn_LoadFromFile.Name = "btn_LoadFromFile";
            this.btn_LoadFromFile.Size = new System.Drawing.Size(137, 42);
            this.btn_LoadFromFile.TabIndex = 8;
            this.btn_LoadFromFile.Text = "Load From File";
            this.btn_LoadFromFile.UseVisualStyleBackColor = false;
            this.btn_LoadFromFile.Click += new System.EventHandler(this.btn_LoadFromFile_Click);
            // 
            // btn_SaveToList
            // 
            this.btn_SaveToList.BackColor = System.Drawing.Color.Yellow;
            this.btn_SaveToList.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_SaveToList.Location = new System.Drawing.Point(114, 261);
            this.btn_SaveToList.Name = "btn_SaveToList";
            this.btn_SaveToList.Size = new System.Drawing.Size(209, 29);
            this.btn_SaveToList.TabIndex = 9;
            this.btn_SaveToList.Text = "Save To List ->";
            this.btn_SaveToList.UseVisualStyleBackColor = false;
            this.btn_SaveToList.Click += new System.EventHandler(this.btn_SaveToList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(57, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(104, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "URL:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.BlueViolet;
            this.button1.Location = new System.Drawing.Point(198, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "Exit:";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_PersonList
            // 
            this.lb_PersonList.BackColor = System.Drawing.Color.Aquamarine;
            this.lb_PersonList.ForeColor = System.Drawing.Color.Blue;
            this.lb_PersonList.FormattingEnabled = true;
            this.lb_PersonList.ItemHeight = 20;
            this.lb_PersonList.Location = new System.Drawing.Point(375, 93);
            this.lb_PersonList.Name = "lb_PersonList";
            this.lb_PersonList.Size = new System.Drawing.Size(559, 464);
            this.lb_PersonList.TabIndex = 14;
            // 
            // ofd_File
            // 
            this.ofd_File.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(976, 591);
            this.Controls.Add(this.lb_PersonList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SaveToList);
            this.Controls.Add(this.btn_LoadFromFile);
            this.Controls.Add(this.tb_URL);
            this.Controls.Add(this.tb_LName);
            this.Controls.Add(this.tb_FName);
            this.Controls.Add(this.btn_SaveToFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "News FInder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SaveToFile;
        private System.Windows.Forms.TextBox tb_FName;
        private System.Windows.Forms.TextBox tb_LName;
        private System.Windows.Forms.TextBox tb_URL;
        private System.Windows.Forms.Button btn_LoadFromFile;
        private System.Windows.Forms.Button btn_SaveToList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lb_PersonList;
        private System.Windows.Forms.OpenFileDialog ofd_File;
        private System.Windows.Forms.FolderBrowserDialog fbd_Browse;
    }
}

