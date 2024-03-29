﻿
namespace MyApp
{
    partial class frmModifySQLConn
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDb = new System.Windows.Forms.Label();
            this.lblSsl = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtSslmode = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnModifyDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(447, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Connection ";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.ForeColor = System.Drawing.Color.Silver;
            this.lblServer.Location = new System.Drawing.Point(14, 67);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server:";
            // 
            // txtServerName
            // 
            this.txtServerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerName.ForeColor = System.Drawing.Color.Silver;
            this.txtServerName.Location = new System.Drawing.Point(77, 64);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(220, 13);
            this.txtServerName.TabIndex = 3;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.ForeColor = System.Drawing.Color.Silver;
            this.lblUserId.Location = new System.Drawing.Point(14, 93);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(44, 13);
            this.lblUserId.TabIndex = 4;
            this.lblUserId.Text = "user ID:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblPassword.Location = new System.Drawing.Point(14, 119);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.ForeColor = System.Drawing.Color.Silver;
            this.lblDb.Location = new System.Drawing.Point(14, 145);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(56, 13);
            this.lblDb.TabIndex = 6;
            this.lblDb.Text = "Database:";
            // 
            // lblSsl
            // 
            this.lblSsl.AutoSize = true;
            this.lblSsl.ForeColor = System.Drawing.Color.Silver;
            this.lblSsl.Location = new System.Drawing.Point(14, 171);
            this.lblSsl.Name = "lblSsl";
            this.lblSsl.Size = new System.Drawing.Size(54, 13);
            this.lblSsl.TabIndex = 7;
            this.lblSsl.Text = "Ssl Mode:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(77, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 13);
            this.txtPassword.TabIndex = 3;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatabaseName.ForeColor = System.Drawing.Color.Silver;
            this.txtDatabaseName.Location = new System.Drawing.Point(77, 142);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(220, 13);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // txtSslmode
            // 
            this.txtSslmode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtSslmode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSslmode.ForeColor = System.Drawing.Color.Silver;
            this.txtSslmode.Location = new System.Drawing.Point(77, 168);
            this.txtSslmode.Name = "txtSslmode";
            this.txtSslmode.Size = new System.Drawing.Size(220, 13);
            this.txtSslmode.TabIndex = 3;
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.ForeColor = System.Drawing.Color.Silver;
            this.txtUserId.Location = new System.Drawing.Point(77, 90);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(220, 13);
            this.txtUserId.TabIndex = 3;
            // 
            // btnModifyDb
            // 
            this.btnModifyDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.btnModifyDb.FlatAppearance.BorderSize = 0;
            this.btnModifyDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModifyDb.ForeColor = System.Drawing.Color.Silver;
            this.btnModifyDb.Location = new System.Drawing.Point(12, 319);
            this.btnModifyDb.Name = "btnModifyDb";
            this.btnModifyDb.Size = new System.Drawing.Size(140, 30);
            this.btnModifyDb.TabIndex = 8;
            this.btnModifyDb.Text = "Change Database";
            this.btnModifyDb.UseVisualStyleBackColor = false;
            this.btnModifyDb.Click += new System.EventHandler(this.btnModifyDb_Click);
            // 
            // frmModifySQLConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.btnModifyDb);
            this.Controls.Add(this.lblSsl);
            this.Controls.Add(this.lblDb);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtSslmode);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModifySQLConn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyApp Modify SQL database";
            this.Load += new System.EventHandler(this.frmModifySQLConn_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmModifySQLConn_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmModifySQLConn_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmModifySQLConn_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.Label lblSsl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtSslmode;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnModifyDb;
    }
}