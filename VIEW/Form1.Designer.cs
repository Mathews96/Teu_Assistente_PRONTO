﻿namespace Teu_Assistente_HABITACAO
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
            this.pctBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbLinksUteis = new System.Windows.Forms.Label();
            this.pnlLinksUteis = new System.Windows.Forms.Panel();
            this.btnNissLinkUteis = new System.Windows.Forms.Button();
            this.btnCadmutLinkUteis = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnConfUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).BeginInit();
            this.pnlLinksUteis.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctBoxLogo
            // 
            this.pctBoxLogo.BackColor = System.Drawing.SystemColors.MenuText;
            this.pctBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxLogo.Image")));
            this.pctBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pctBoxLogo.Name = "pctBoxLogo";
            this.pctBoxLogo.Size = new System.Drawing.Size(285, 96);
            this.pctBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxLogo.TabIndex = 0;
            this.pctBoxLogo.TabStop = false;
            // 
            // lbLinksUteis
            // 
            this.lbLinksUteis.AutoSize = true;
            this.lbLinksUteis.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinksUteis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbLinksUteis.Location = new System.Drawing.Point(111, 133);
            this.lbLinksUteis.Name = "lbLinksUteis";
            this.lbLinksUteis.Size = new System.Drawing.Size(77, 13);
            this.lbLinksUteis.TabIndex = 1;
            this.lbLinksUteis.Text = "LINK\'s ÚTEIS";
            // 
            // pnlLinksUteis
            // 
            this.pnlLinksUteis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLinksUteis.Controls.Add(this.btnNissLinkUteis);
            this.pnlLinksUteis.Controls.Add(this.btnCadmutLinkUteis);
            this.pnlLinksUteis.Location = new System.Drawing.Point(12, 149);
            this.pnlLinksUteis.Name = "pnlLinksUteis";
            this.pnlLinksUteis.Size = new System.Drawing.Size(285, 53);
            this.pnlLinksUteis.TabIndex = 2;
            // 
            // btnNissLinkUteis
            // 
            this.btnNissLinkUteis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNissLinkUteis.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNissLinkUteis.Location = new System.Drawing.Point(185, 8);
            this.btnNissLinkUteis.Name = "btnNissLinkUteis";
            this.btnNissLinkUteis.Size = new System.Drawing.Size(84, 33);
            this.btnNissLinkUteis.TabIndex = 4;
            this.btnNissLinkUteis.Text = "NISS";
            this.btnNissLinkUteis.UseVisualStyleBackColor = true;
            this.btnNissLinkUteis.Click += new System.EventHandler(this.btnNissLinkUteis_Click);
            // 
            // btnCadmutLinkUteis
            // 
            this.btnCadmutLinkUteis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadmutLinkUteis.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadmutLinkUteis.Location = new System.Drawing.Point(15, 8);
            this.btnCadmutLinkUteis.Name = "btnCadmutLinkUteis";
            this.btnCadmutLinkUteis.Size = new System.Drawing.Size(84, 33);
            this.btnCadmutLinkUteis.TabIndex = 3;
            this.btnCadmutLinkUteis.Text = "CADMUT";
            this.btnCadmutLinkUteis.UseVisualStyleBackColor = true;
            this.btnCadmutLinkUteis.Click += new System.EventHandler(this.btnCadmutLinkUteis_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgendar.Location = new System.Drawing.Point(12, 228);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(285, 62);
            this.btnAgendar.TabIndex = 3;
            this.btnAgendar.Text = "AGENDA";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 296);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(285, 62);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "CADASTRO";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(12, 364);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(285, 62);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "CONSULTA";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnConfUsuario
            // 
            this.btnConfUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfUsuario.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfUsuario.Location = new System.Drawing.Point(266, 113);
            this.btnConfUsuario.Name = "btnConfUsuario";
            this.btnConfUsuario.Size = new System.Drawing.Size(31, 30);
            this.btnConfUsuario.TabIndex = 7;
            this.btnConfUsuario.Text = "?";
            this.btnConfUsuario.UseVisualStyleBackColor = true;
            this.btnConfUsuario.Click += new System.EventHandler(this.btnConfUsuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.btnConfUsuario);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.pnlLinksUteis);
            this.Controls.Add(this.lbLinksUteis);
            this.Controls.Add(this.pctBoxLogo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxLogo)).EndInit();
            this.pnlLinksUteis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctBoxLogo;
        private System.Windows.Forms.Label lbLinksUteis;
        private System.Windows.Forms.Panel pnlLinksUteis;
        private System.Windows.Forms.Button btnNissLinkUteis;
        private System.Windows.Forms.Button btnCadmutLinkUteis;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConfUsuario;
    }
}

