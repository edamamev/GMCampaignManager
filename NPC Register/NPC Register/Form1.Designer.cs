﻿namespace NPC_Register
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
            this.itemList = new System.Windows.Forms.ListBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlNPC = new System.Windows.Forms.Panel();
            this.btnNPCRemove = new System.Windows.Forms.Button();
            this.btnNPCCreate = new System.Windows.Forms.Button();
            this.pnlWorkTools = new System.Windows.Forms.Panel();
            this.pnlWorkSpace = new System.Windows.Forms.Panel();
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.tsOpenDB = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlNPC.SuspendLayout();
            this.pnlWorkTools.SuspendLayout();
            this.pnlWorkSpace.SuspendLayout();
            this.tsTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(12, 90);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(171, 355);
            this.itemList.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Tomato;
            this.pnlTop.Controls.Add(this.pnlNPC);
            this.pnlTop.Controls.Add(this.pnlWorkTools);
            this.pnlTop.Location = new System.Drawing.Point(12, 37);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(776, 46);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlNPC
            // 
            this.pnlNPC.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlNPC.Controls.Add(this.btnNPCRemove);
            this.pnlNPC.Controls.Add(this.btnNPCCreate);
            this.pnlNPC.Location = new System.Drawing.Point(0, 0);
            this.pnlNPC.Name = "pnlNPC";
            this.pnlNPC.Size = new System.Drawing.Size(171, 47);
            this.pnlNPC.TabIndex = 3;
            // 
            // btnNPCRemove
            // 
            this.btnNPCRemove.Location = new System.Drawing.Point(82, 3);
            this.btnNPCRemove.Name = "btnNPCRemove";
            this.btnNPCRemove.Size = new System.Drawing.Size(86, 39);
            this.btnNPCRemove.TabIndex = 1;
            this.btnNPCRemove.Text = "Remove NPC";
            this.btnNPCRemove.UseVisualStyleBackColor = true;
            // 
            // btnNPCCreate
            // 
            this.btnNPCCreate.Location = new System.Drawing.Point(3, 3);
            this.btnNPCCreate.Name = "btnNPCCreate";
            this.btnNPCCreate.Size = new System.Drawing.Size(73, 39);
            this.btnNPCCreate.TabIndex = 0;
            this.btnNPCCreate.Text = "Create NPC";
            this.btnNPCCreate.UseVisualStyleBackColor = true;
            // 
            // pnlWorkTools
            // 
            this.pnlWorkTools.BackColor = System.Drawing.Color.Maroon;
            this.pnlWorkTools.Controls.Add(this.btnAddNote);
            this.pnlWorkTools.Location = new System.Drawing.Point(177, 0);
            this.pnlWorkTools.Name = "pnlWorkTools";
            this.pnlWorkTools.Size = new System.Drawing.Size(599, 46);
            this.pnlWorkTools.TabIndex = 2;
            // 
            // pnlWorkSpace
            // 
            this.pnlWorkSpace.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlWorkSpace.Controls.Add(this.panel1);
            this.pnlWorkSpace.Location = new System.Drawing.Point(189, 89);
            this.pnlWorkSpace.Name = "pnlWorkSpace";
            this.pnlWorkSpace.Size = new System.Drawing.Size(599, 356);
            this.pnlWorkSpace.TabIndex = 2;
            this.pnlWorkSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWorkSpace_Paint);
            // 
            // tsTop
            // 
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpenDB});
            this.tsTop.Location = new System.Drawing.Point(0, 0);
            this.tsTop.Name = "tsTop";
            this.tsTop.Size = new System.Drawing.Size(800, 25);
            this.tsTop.TabIndex = 3;
            this.tsTop.Text = "toolStrip1";
            // 
            // tsOpenDB
            // 
            this.tsOpenDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsOpenDB.Image = ((System.Drawing.Image)(resources.GetObject("tsOpenDB.Image")));
            this.tsOpenDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenDB.Name = "tsOpenDB";
            this.tsOpenDB.Size = new System.Drawing.Size(58, 22);
            this.tsOpenDB.Text = "Open DB";
            this.tsOpenDB.Click += new System.EventHandler(this.tsOpenDB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orchid;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(69, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Magenta;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 40);
            this.panel2.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 151);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(3, 3);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(86, 39);
            this.btnAddNote.TabIndex = 2;
            this.btnAddNote.Text = "Create Note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsTop);
            this.Controls.Add(this.pnlWorkSpace);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.itemList);
            this.Name = "Form1";
            this.Text = "NPC Register";
            this.pnlTop.ResumeLayout(false);
            this.pnlNPC.ResumeLayout(false);
            this.pnlWorkTools.ResumeLayout(false);
            this.pnlWorkSpace.ResumeLayout(false);
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlWorkSpace;
        private System.Windows.Forms.Button btnNPCCreate;
        private System.Windows.Forms.Panel pnlNPC;
        private System.Windows.Forms.Button btnNPCRemove;
        private System.Windows.Forms.Panel pnlWorkTools;
        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripButton tsOpenDB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
