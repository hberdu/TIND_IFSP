﻿namespace TIND
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReservaSala = new System.Windows.Forms.Button();
            this.btnCadastroM = new System.Windows.Forms.Button();
            this.btnCadastroP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnReservaSala);
            this.panel1.Controls.Add(this.btnCadastroM);
            this.panel1.Controls.Add(this.btnCadastroP);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 511);
            this.panel1.TabIndex = 0;
            // 
            // btnReservaSala
            // 
            this.btnReservaSala.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnReservaSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservaSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaSala.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReservaSala.Location = new System.Drawing.Point(3, 313);
            this.btnReservaSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReservaSala.Name = "btnReservaSala";
            this.btnReservaSala.Size = new System.Drawing.Size(272, 71);
            this.btnReservaSala.TabIndex = 9;
            this.btnReservaSala.Text = "Reserva de Sala";
            this.btnReservaSala.UseVisualStyleBackColor = false;
            // 
            // btnCadastroM
            // 
            this.btnCadastroM.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastroM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroM.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastroM.Location = new System.Drawing.Point(3, 238);
            this.btnCadastroM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastroM.Name = "btnCadastroM";
            this.btnCadastroM.Size = new System.Drawing.Size(272, 71);
            this.btnCadastroM.TabIndex = 9;
            this.btnCadastroM.Text = "Cadastro de Materias";
            this.btnCadastroM.UseVisualStyleBackColor = false;
            this.btnCadastroM.Click += new System.EventHandler(this.btnCadastroM_Click);
            // 
            // btnCadastroP
            // 
            this.btnCadastroP.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastroP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroP.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastroP.Location = new System.Drawing.Point(3, 163);
            this.btnCadastroP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastroP.Name = "btnCadastroP";
            this.btnCadastroP.Size = new System.Drawing.Size(272, 71);
            this.btnCadastroP.TabIndex = 8;
            this.btnCadastroP.Text = "Cadastro de Professor";
            this.btnCadastroP.UseVisualStyleBackColor = false;
            this.btnCadastroP.Click += new System.EventHandler(this.btnCadastroP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1164, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 511);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReservaSala;
        private System.Windows.Forms.Button btnCadastroM;
        private System.Windows.Forms.Button btnCadastroP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

