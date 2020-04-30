namespace EfStarTests1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdDumpByQuadrant = new System.Windows.Forms.Button();
            this.cmdEmptyStars = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdDraw1 = new System.Windows.Forms.Button();
            this.cmdFindMinMax = new System.Windows.Forms.Button();
            this.txtDecMax = new System.Windows.Forms.TextBox();
            this.txtDecMin = new System.Windows.Forms.TextBox();
            this.txtRaMax = new System.Windows.Forms.TextBox();
            this.txtRaMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFindNear1 = new System.Windows.Forms.Button();
            this.cmdDump200 = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Size = new System.Drawing.Size(2105, 775);
            this.splitContainer1.SplitterDistance = 517;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cmdClear);
            this.splitContainer2.Panel1.Controls.Add(this.cmdDumpByQuadrant);
            this.splitContainer2.Panel1.Controls.Add(this.cmdEmptyStars);
            this.splitContainer2.Panel1.Controls.Add(this.Import);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.cmdFindNear1);
            this.splitContainer2.Panel1.Controls.Add(this.cmdDump200);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pbImage);
            this.splitContainer2.Size = new System.Drawing.Size(2105, 517);
            this.splitContainer2.SplitterDistance = 1229;
            this.splitContainer2.TabIndex = 7;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(59, 431);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(116, 62);
            this.cmdClear.TabIndex = 13;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdDumpByQuadrant
            // 
            this.cmdDumpByQuadrant.Location = new System.Drawing.Point(228, 196);
            this.cmdDumpByQuadrant.Name = "cmdDumpByQuadrant";
            this.cmdDumpByQuadrant.Size = new System.Drawing.Size(209, 117);
            this.cmdDumpByQuadrant.TabIndex = 12;
            this.cmdDumpByQuadrant.Text = "Dump By Quadrant";
            this.cmdDumpByQuadrant.UseVisualStyleBackColor = true;
            this.cmdDumpByQuadrant.Click += new System.EventHandler(this.cmdDumpByQuadrant_Click_1);
            // 
            // cmdEmptyStars
            // 
            this.cmdEmptyStars.Location = new System.Drawing.Point(25, 156);
            this.cmdEmptyStars.Name = "cmdEmptyStars";
            this.cmdEmptyStars.Size = new System.Drawing.Size(145, 122);
            this.cmdEmptyStars.TabIndex = 11;
            this.cmdEmptyStars.Text = "Empty Stars";
            this.cmdEmptyStars.UseVisualStyleBackColor = true;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(25, 24);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(145, 99);
            this.Import.TabIndex = 10;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdDraw1);
            this.groupBox1.Controls.Add(this.cmdFindMinMax);
            this.groupBox1.Controls.Add(this.txtDecMax);
            this.groupBox1.Controls.Add(this.txtDecMin);
            this.groupBox1.Controls.Add(this.txtRaMax);
            this.groupBox1.Controls.Add(this.txtRaMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(683, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 393);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmdDraw1
            // 
            this.cmdDraw1.Location = new System.Drawing.Point(376, 232);
            this.cmdDraw1.Name = "cmdDraw1";
            this.cmdDraw1.Size = new System.Drawing.Size(124, 121);
            this.cmdDraw1.TabIndex = 11;
            this.cmdDraw1.Text = "Draw1";
            this.cmdDraw1.UseVisualStyleBackColor = true;
            this.cmdDraw1.Click += new System.EventHandler(this.cmdDraw1_Click);
            // 
            // cmdFindMinMax
            // 
            this.cmdFindMinMax.Location = new System.Drawing.Point(336, 57);
            this.cmdFindMinMax.Name = "cmdFindMinMax";
            this.cmdFindMinMax.Size = new System.Drawing.Size(148, 64);
            this.cmdFindMinMax.TabIndex = 10;
            this.cmdFindMinMax.Text = "Find";
            this.cmdFindMinMax.UseVisualStyleBackColor = true;
            this.cmdFindMinMax.Click += new System.EventHandler(this.cmdFindMinMax_Click);
            // 
            // txtDecMax
            // 
            this.txtDecMax.Location = new System.Drawing.Point(187, 261);
            this.txtDecMax.Name = "txtDecMax";
            this.txtDecMax.Size = new System.Drawing.Size(100, 44);
            this.txtDecMax.TabIndex = 9;
            this.txtDecMax.Text = "40";
            // 
            // txtDecMin
            // 
            this.txtDecMin.Location = new System.Drawing.Point(187, 185);
            this.txtDecMin.Name = "txtDecMin";
            this.txtDecMin.Size = new System.Drawing.Size(100, 44);
            this.txtDecMin.TabIndex = 8;
            this.txtDecMin.Text = "20";
            // 
            // txtRaMax
            // 
            this.txtRaMax.Location = new System.Drawing.Point(187, 114);
            this.txtRaMax.Name = "txtRaMax";
            this.txtRaMax.Size = new System.Drawing.Size(100, 44);
            this.txtRaMax.TabIndex = 7;
            this.txtRaMax.Text = "120";
            // 
            // txtRaMin
            // 
            this.txtRaMin.Location = new System.Drawing.Point(187, 57);
            this.txtRaMin.Name = "txtRaMin";
            this.txtRaMin.Size = new System.Drawing.Size(100, 44);
            this.txtRaMin.TabIndex = 6;
            this.txtRaMin.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "DecMax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "DecMin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "RaMax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "RaMin";
            // 
            // cmdFindNear1
            // 
            this.cmdFindNear1.Location = new System.Drawing.Point(445, 24);
            this.cmdFindNear1.Name = "cmdFindNear1";
            this.cmdFindNear1.Size = new System.Drawing.Size(186, 128);
            this.cmdFindNear1.TabIndex = 8;
            this.cmdFindNear1.Text = "Find by Quadrant";
            this.cmdFindNear1.UseVisualStyleBackColor = true;
            this.cmdFindNear1.Click += new System.EventHandler(this.cmdFindNear1_Click);
            // 
            // cmdDump200
            // 
            this.cmdDump200.Location = new System.Drawing.Point(228, 24);
            this.cmdDump200.Name = "cmdDump200";
            this.cmdDump200.Size = new System.Drawing.Size(173, 107);
            this.cmdDump200.TabIndex = 7;
            this.cmdDump200.Text = "Dump 200";
            this.cmdDump200.UseVisualStyleBackColor = true;
            this.cmdDump200.Click += new System.EventHandler(this.cmdDump200_Click);
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(872, 517);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(2105, 254);
            this.txtOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2105, 775);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button cmdDumpByQuadrant;
        private System.Windows.Forms.Button cmdEmptyStars;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdFindMinMax;
        private System.Windows.Forms.TextBox txtDecMax;
        private System.Windows.Forms.TextBox txtDecMin;
        private System.Windows.Forms.TextBox txtRaMax;
        private System.Windows.Forms.TextBox txtRaMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFindNear1;
        private System.Windows.Forms.Button cmdDump200;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdDraw1;
    }
}

