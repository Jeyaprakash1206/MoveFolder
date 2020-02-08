namespace MoveFolders
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
            this.headinglbl = new System.Windows.Forms.Label();
            this.pagenolbl = new System.Windows.Forms.Label();
            this.pagenotxt = new System.Windows.Forms.RichTextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.pathlbl = new System.Windows.Forms.Label();
            this.pathtext = new System.Windows.Forms.TextBox();
            this.targettext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noofpages = new System.Windows.Forms.Label();
            this.movedfiles = new System.Windows.Forms.Label();
            this.statuslbl = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.nooffiles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headinglbl
            // 
            this.headinglbl.AutoSize = true;
            this.headinglbl.Location = new System.Drawing.Point(262, 32);
            this.headinglbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headinglbl.Name = "headinglbl";
            this.headinglbl.Size = new System.Drawing.Size(90, 13);
            this.headinglbl.TabIndex = 0;
            this.headinglbl.Text = "Folder Relocation";
            // 
            // pagenolbl
            // 
            this.pagenolbl.AutoSize = true;
            this.pagenolbl.Location = new System.Drawing.Point(211, 119);
            this.pagenolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pagenolbl.Name = "pagenolbl";
            this.pagenolbl.Size = new System.Drawing.Size(46, 13);
            this.pagenolbl.TabIndex = 1;
            this.pagenolbl.Text = "PageNo";
            this.pagenolbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pagenotxt
            // 
            this.pagenotxt.Location = new System.Drawing.Point(298, 119);
            this.pagenotxt.Margin = new System.Windows.Forms.Padding(2);
            this.pagenotxt.Name = "pagenotxt";
            this.pagenotxt.Size = new System.Drawing.Size(276, 192);
            this.pagenotxt.TabIndex = 2;
            this.pagenotxt.Text = "";
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(140, 337);
            this.submitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(101, 19);
            this.submitbtn.TabIndex = 3;
            this.submitbtn.Text = "Move Folder";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // pathlbl
            // 
            this.pathlbl.AutoSize = true;
            this.pathlbl.Location = new System.Drawing.Point(226, 61);
            this.pathlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pathlbl.Name = "pathlbl";
            this.pathlbl.Size = new System.Drawing.Size(29, 13);
            this.pathlbl.TabIndex = 4;
            this.pathlbl.Text = "Path";
            // 
            // pathtext
            // 
            this.pathtext.Location = new System.Drawing.Point(298, 61);
            this.pathtext.Margin = new System.Windows.Forms.Padding(2);
            this.pathtext.Name = "pathtext";
            this.pathtext.Size = new System.Drawing.Size(276, 20);
            this.pathtext.TabIndex = 5;
            this.pathtext.Text = "C:/xampp/htdocs/SRONEW/SRO/doc";
            // 
            // targettext
            // 
            this.targettext.Location = new System.Drawing.Point(298, 97);
            this.targettext.Margin = new System.Windows.Forms.Padding(2);
            this.targettext.Name = "targettext";
            this.targettext.Size = new System.Drawing.Size(276, 20);
            this.targettext.TabIndex = 6;
            this.targettext.Text = "C:/xampp/htdocs/SRONEW/SRO/doc/MovedFiles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Target";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Move Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.movebtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 337);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 19);
            this.button2.TabIndex = 9;
            this.button2.Text = "Copy Files";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 337);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 19);
            this.button3.TabIndex = 10;
            this.button3.Text = "Copy Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total No of Pages:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "No of files Moved:";
            // 
            // noofpages
            // 
            this.noofpages.AutoSize = true;
            this.noofpages.Location = new System.Drawing.Point(114, 147);
            this.noofpages.Name = "noofpages";
            this.noofpages.Size = new System.Drawing.Size(0, 13);
            this.noofpages.TabIndex = 14;
            // 
            // movedfiles
            // 
            this.movedfiles.AutoSize = true;
            this.movedfiles.Location = new System.Drawing.Point(111, 208);
            this.movedfiles.Name = "movedfiles";
            this.movedfiles.Size = new System.Drawing.Size(0, 13);
            this.movedfiles.TabIndex = 16;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Location = new System.Drawing.Point(12, 240);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(43, 13);
            this.statuslbl.TabIndex = 17;
            this.statuslbl.Text = "Status :";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(61, 240);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 18;
            // 
            // nooffiles
            // 
            this.nooffiles.AutoSize = true;
            this.nooffiles.Location = new System.Drawing.Point(116, 175);
            this.nooffiles.Name = "nooffiles";
            this.nooffiles.Size = new System.Drawing.Size(0, 13);
            this.nooffiles.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "No of files processed :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.status);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.movedfiles);
            this.Controls.Add(this.nooffiles);
            this.Controls.Add(this.noofpages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targettext);
            this.Controls.Add(this.pathtext);
            this.Controls.Add(this.pathlbl);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.pagenotxt);
            this.Controls.Add(this.pagenolbl);
            this.Controls.Add(this.headinglbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headinglbl;
        private System.Windows.Forms.Label pagenolbl;
        private System.Windows.Forms.RichTextBox pagenotxt;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Label pathlbl;
        private System.Windows.Forms.TextBox pathtext;
        private System.Windows.Forms.TextBox targettext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label noofpages;
        private System.Windows.Forms.Label movedfiles;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label nooffiles;
        private System.Windows.Forms.Label label2;
    }
}

