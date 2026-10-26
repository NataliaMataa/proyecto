namespace proyecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.baceptar = new System.Windows.Forms.Button();
            this.tresultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lnum2 = new System.Windows.Forms.Label();
            this.lop = new System.Windows.Forms.Label();
            this.lnum1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnivel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.laciertos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lfallos = new System.Windows.Forms.Label();
            this.btabla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bunjugador = new System.Windows.Forms.Button();
            this.bdosjugadores = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(55, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juego de Numeros";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.baceptar);
            this.panel1.Controls.Add(this.tresultado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lnum2);
            this.panel1.Controls.Add(this.lop);
            this.panel1.Controls.Add(this.lnum1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 355);
            this.panel1.TabIndex = 1;
            // 
            // baceptar
            // 
            this.baceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baceptar.ForeColor = System.Drawing.Color.Purple;
            this.baceptar.Location = new System.Drawing.Point(171, 240);
            this.baceptar.Name = "baceptar";
            this.baceptar.Size = new System.Drawing.Size(134, 56);
            this.baceptar.TabIndex = 8;
            this.baceptar.Text = "ACEPTAR";
            this.baceptar.UseVisualStyleBackColor = true;
            this.baceptar.Click += new System.EventHandler(this.baceptar_Click_1);
            // 
            // tresultado
            // 
            this.tresultado.Location = new System.Drawing.Point(383, 179);
            this.tresultado.Name = "tresultado";
            this.tresultado.Size = new System.Drawing.Size(100, 22);
            this.tresultado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(3, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite el resultado de la operación:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(440, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(415, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "=";
            // 
            // lnum2
            // 
            this.lnum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnum2.ForeColor = System.Drawing.Color.Purple;
            this.lnum2.Location = new System.Drawing.Point(258, 83);
            this.lnum2.Name = "lnum2";
            this.lnum2.Size = new System.Drawing.Size(75, 23);
            this.lnum2.TabIndex = 3;
            this.lnum2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lop
            // 
            this.lop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lop.ForeColor = System.Drawing.Color.Purple;
            this.lop.Location = new System.Drawing.Point(143, 83);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(75, 23);
            this.lop.TabIndex = 2;
            this.lop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnum1
            // 
            this.lnum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnum1.ForeColor = System.Drawing.Color.Purple;
            this.lnum1.Location = new System.Drawing.Point(11, 83);
            this.lnum1.Name = "lnum1";
            this.lnum1.Size = new System.Drawing.Size(75, 23);
            this.lnum1.TabIndex = 1;
            this.lnum1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "OPERACIÓN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(537, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nivel:";
            // 
            // lnivel
            // 
            this.lnivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnivel.ForeColor = System.Drawing.Color.Purple;
            this.lnivel.Location = new System.Drawing.Point(669, 156);
            this.lnivel.Name = "lnivel";
            this.lnivel.Size = new System.Drawing.Size(100, 23);
            this.lnivel.TabIndex = 3;
            this.lnivel.Text = "1";
            this.lnivel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(537, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Aciertos:";
            // 
            // laciertos
            // 
            this.laciertos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.laciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laciertos.ForeColor = System.Drawing.Color.Purple;
            this.laciertos.Location = new System.Drawing.Point(669, 203);
            this.laciertos.Name = "laciertos";
            this.laciertos.Size = new System.Drawing.Size(100, 23);
            this.laciertos.TabIndex = 5;
            this.laciertos.Text = "0";
            this.laciertos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(537, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "Fallos:";
            // 
            // lfallos
            // 
            this.lfallos.BackColor = System.Drawing.Color.White;
            this.lfallos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lfallos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lfallos.ForeColor = System.Drawing.Color.Purple;
            this.lfallos.Location = new System.Drawing.Point(669, 256);
            this.lfallos.Name = "lfallos";
            this.lfallos.Size = new System.Drawing.Size(100, 23);
            this.lfallos.TabIndex = 7;
            this.lfallos.Text = "0";
            this.lfallos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btabla
            // 
            this.btabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btabla.ForeColor = System.Drawing.Color.Purple;
            this.btabla.Location = new System.Drawing.Point(537, 320);
            this.btabla.Name = "btabla";
            this.btabla.Size = new System.Drawing.Size(221, 59);
            this.btabla.TabIndex = 8;
            this.btabla.Text = "Ver tabla de puntuaciones";
            this.btabla.UseVisualStyleBackColor = false;
            this.btabla.Click += new System.EventHandler(this.btabla_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(532, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(520, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "ELIJA EL MODO DE JUEGO:";
            // 
            // bunjugador
            // 
            this.bunjugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunjugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunjugador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunjugador.Location = new System.Drawing.Point(514, 77);
            this.bunjugador.Name = "bunjugador";
            this.bunjugador.Size = new System.Drawing.Size(104, 35);
            this.bunjugador.TabIndex = 10;
            this.bunjugador.Text = "Un jugador";
            this.bunjugador.UseVisualStyleBackColor = false;
            this.bunjugador.Click += new System.EventHandler(this.bunjugador_Click);
            // 
            // bdosjugadores
            // 
            this.bdosjugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bdosjugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdosjugadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bdosjugadores.Location = new System.Drawing.Point(638, 77);
            this.bdosjugadores.Name = "bdosjugadores";
            this.bdosjugadores.Size = new System.Drawing.Size(150, 35);
            this.bdosjugadores.TabIndex = 11;
            this.bdosjugadores.Text = "Dos jugadores";
            this.bdosjugadores.UseVisualStyleBackColor = false;
            this.bdosjugadores.Click += new System.EventHandler(this.bdosjugadores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bdosjugadores);
            this.Controls.Add(this.bunjugador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btabla);
            this.Controls.Add(this.lfallos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.laciertos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lnivel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lnum2;
        private System.Windows.Forms.Label lop;
        private System.Windows.Forms.Label lnum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button baceptar;
        private System.Windows.Forms.TextBox tresultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lnivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label laciertos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lfallos;
        private System.Windows.Forms.Button btabla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bunjugador;
        private System.Windows.Forms.Button bdosjugadores;
    }
}

