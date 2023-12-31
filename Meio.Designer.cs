namespace Estacionamento
{
    partial class Meio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxCadastrar = new System.Windows.Forms.TextBox();
            this.boxRemover = new System.Windows.Forms.TextBox();
            this.boxHoras = new System.Windows.Forms.TextBox();
            this.rtbListar = new System.Windows.Forms.RichTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "LISTAR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "REMOVER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "HORAS";
            // 
            // boxCadastrar
            // 
            this.boxCadastrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.boxCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCadastrar.Location = new System.Drawing.Point(12, 63);
            this.boxCadastrar.Name = "boxCadastrar";
            this.boxCadastrar.Size = new System.Drawing.Size(113, 26);
            this.boxCadastrar.TabIndex = 4;
            this.boxCadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxRemover
            // 
            this.boxRemover.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.boxRemover.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxRemover.Location = new System.Drawing.Point(282, 63);
            this.boxRemover.Name = "boxRemover";
            this.boxRemover.Size = new System.Drawing.Size(121, 26);
            this.boxRemover.TabIndex = 5;
            this.boxRemover.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxRemover.TextChanged += new System.EventHandler(this.boxRemover_TextChanged);
            // 
            // boxHoras
            // 
            this.boxHoras.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxHoras.Location = new System.Drawing.Point(282, 141);
            this.boxHoras.Name = "boxHoras";
            this.boxHoras.Size = new System.Drawing.Size(121, 26);
            this.boxHoras.TabIndex = 6;
            this.boxHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbListar
            // 
            this.rtbListar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbListar.Location = new System.Drawing.Point(140, 63);
            this.rtbListar.Name = "rtbListar";
            this.rtbListar.Size = new System.Drawing.Size(122, 104);
            this.rtbListar.TabIndex = 7;
            this.rtbListar.Text = "";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(11, 107);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 33);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(140, 173);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(122, 33);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(282, 173);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(121, 33);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(11, 192);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 33);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Meio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 237);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rtbListar);
            this.Controls.Add(this.boxHoras);
            this.Controls.Add(this.boxRemover);
            this.Controls.Add(this.boxCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Meio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meio";
            this.Load += new System.EventHandler(this.Meio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxCadastrar;
        private System.Windows.Forms.TextBox boxRemover;
        private System.Windows.Forms.TextBox boxHoras;
        private System.Windows.Forms.RichTextBox rtbListar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnSair;
    }
}