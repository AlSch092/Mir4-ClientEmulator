//By AlSch092 @ Github
﻿namespace Mir4ClientEmulator
{
    partial class EntityMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityMap));
            this.pictureBox_EntityMap = new System.Windows.Forms.PictureBox();
            this.pictureBox_Hero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EntityMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hero)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_EntityMap
            // 
            this.pictureBox_EntityMap.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_EntityMap.InitialImage")));
            this.pictureBox_EntityMap.Location = new System.Drawing.Point(12, 30);
            this.pictureBox_EntityMap.Name = "pictureBox_EntityMap";
            this.pictureBox_EntityMap.Size = new System.Drawing.Size(699, 507);
            this.pictureBox_EntityMap.TabIndex = 0;
            this.pictureBox_EntityMap.TabStop = false;
            // 
            // pictureBox_Hero
            // 
            this.pictureBox_Hero.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hero.InitialImage")));
            this.pictureBox_Hero.Location = new System.Drawing.Point(12, 30);
            this.pictureBox_Hero.Name = "pictureBox_Hero";
            this.pictureBox_Hero.Size = new System.Drawing.Size(31, 26);
            this.pictureBox_Hero.TabIndex = 1;
            this.pictureBox_Hero.TabStop = false;
            // 
            // EntityMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 547);
            this.Controls.Add(this.pictureBox_Hero);
            this.Controls.Add(this.pictureBox_EntityMap);
            this.Name = "EntityMap";
            this.ShowIcon = false;
            this.Text = "Entity Map";
            this.Load += new System.EventHandler(this.EntityMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EntityMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_EntityMap;
        private System.Windows.Forms.PictureBox pictureBox_Hero;
    }
}