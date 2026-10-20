namespace CrudExemplo
{
    partial class btsalvar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxNome = new TextBox();
            textBoxCurso = new TextBox();
            textBoxAno = new TextBox();
            textBoxSobre = new TextBox();
            textBoxIdade = new TextBox();
            textBoxRM = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 39);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 68);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 93);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Curso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 132);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 3;
            label4.Text = "Ano:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 167);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Idade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 202);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 5;
            label6.Text = "RM:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(104, 34);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(198, 23);
            textBoxNome.TabIndex = 6;
            // 
            // textBoxCurso
            // 
            textBoxCurso.Location = new Point(104, 93);
            textBoxCurso.Name = "textBoxCurso";
            textBoxCurso.Size = new Size(198, 23);
            textBoxCurso.TabIndex = 7;
            // 
            // textBoxAno
            // 
            textBoxAno.Location = new Point(104, 132);
            textBoxAno.Name = "textBoxAno";
            textBoxAno.Size = new Size(198, 23);
            textBoxAno.TabIndex = 8;
            // 
            // textBoxSobre
            // 
            textBoxSobre.Location = new Point(104, 63);
            textBoxSobre.Name = "textBoxSobre";
            textBoxSobre.Size = new Size(198, 23);
            textBoxSobre.TabIndex = 9;
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(104, 167);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(198, 23);
            textBoxIdade.TabIndex = 10;
            // 
            // textBoxRM
            // 
            textBoxRM.Location = new Point(104, 196);
            textBoxRM.Name = "textBoxRM";
            textBoxRM.Size = new Size(198, 23);
            textBoxRM.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(126, 243);
            button1.Name = "button1";
            button1.Size = new Size(142, 50);
            button1.TabIndex = 12;
            button1.Text = "Botão Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btsalvar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxRM);
            Controls.Add(textBoxIdade);
            Controls.Add(textBoxSobre);
            Controls.Add(textBoxAno);
            Controls.Add(textBoxCurso);
            Controls.Add(textBoxNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "btsalvar";
            Text = "Nome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxNome;
        private TextBox textBoxCurso;
        private TextBox textBoxAno;
        private TextBox textBoxSobre;
        private TextBox textBoxIdade;
        private TextBox textBoxRM;
        private Button button1;
    }
}
