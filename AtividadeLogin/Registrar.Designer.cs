
namespace AtividadeLogin
{
    partial class Registrar
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
            this.registrarSin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeRe = new System.Windows.Forms.TextBox();
            this.txtEmailRe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaRe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registrarAssin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrarSin
            // 
            this.registrarSin.Location = new System.Drawing.Point(63, 114);
            this.registrarSin.Name = "registrarSin";
            this.registrarSin.Size = new System.Drawing.Size(75, 23);
            this.registrarSin.TabIndex = 0;
            this.registrarSin.Text = "Registrar";
            this.registrarSin.UseVisualStyleBackColor = true;
            this.registrarSin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNomeRe
            // 
            this.txtNomeRe.Location = new System.Drawing.Point(63, 12);
            this.txtNomeRe.Name = "txtNomeRe";
            this.txtNomeRe.Size = new System.Drawing.Size(157, 23);
            this.txtNomeRe.TabIndex = 2;
            // 
            // txtEmailRe
            // 
            this.txtEmailRe.Location = new System.Drawing.Point(63, 41);
            this.txtEmailRe.Name = "txtEmailRe";
            this.txtEmailRe.Size = new System.Drawing.Size(157, 23);
            this.txtEmailRe.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // txtSenhaRe
            // 
            this.txtSenhaRe.Location = new System.Drawing.Point(63, 70);
            this.txtSenhaRe.Name = "txtSenhaRe";
            this.txtSenhaRe.Size = new System.Drawing.Size(157, 23);
            this.txtSenhaRe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // registrarAssin
            // 
            this.registrarAssin.Location = new System.Drawing.Point(144, 114);
            this.registrarAssin.Name = "registrarAssin";
            this.registrarAssin.Size = new System.Drawing.Size(75, 23);
            this.registrarAssin.TabIndex = 7;
            this.registrarAssin.Text = "Registrar";
            this.registrarAssin.UseVisualStyleBackColor = true;
            this.registrarAssin.Click += new System.EventHandler(this.registrarAssin_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(68, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Criptografia Sincrona";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(149, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Criptografia Assincrona";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 182);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.registrarAssin);
            this.Controls.Add(this.txtSenhaRe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailRe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeRe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrarSin);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrarSin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeRe;
        private System.Windows.Forms.TextBox txtEmailRe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenhaRe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registrarAssin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}