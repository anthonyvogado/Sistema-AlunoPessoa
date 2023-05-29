namespace SistemaAlunoPessoa
{
    partial class form
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
            label_listaPessoa = new Label();
            textBox_listaPessoa = new TextBox();
            label_nomeArquivo = new Label();
            textBox_nomeArquivo = new TextBox();
            button_procurarArquivo = new Button();
            label_numeroPessoas = new Label();
            label_numeroAlunos = new Label();
            textBox_numeroPessoas = new TextBox();
            textBox_numeroAlunos = new TextBox();
            SuspendLayout();
            // 
            // label_listaPessoa
            // 
            label_listaPessoa.AutoSize = true;
            label_listaPessoa.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_listaPessoa.Location = new Point(181, 166);
            label_listaPessoa.Name = "label_listaPessoa";
            label_listaPessoa.Size = new Size(140, 23);
            label_listaPessoa.TabIndex = 2;
            label_listaPessoa.Text = "Lista de Pessoas";
            // 
            // textBox_listaPessoa
            // 
            textBox_listaPessoa.Location = new Point(12, 210);
            textBox_listaPessoa.Multiline = true;
            textBox_listaPessoa.Name = "textBox_listaPessoa";
            textBox_listaPessoa.ReadOnly = true;
            textBox_listaPessoa.ScrollBars = ScrollBars.Vertical;
            textBox_listaPessoa.Size = new Size(443, 344);
            textBox_listaPessoa.TabIndex = 3;
            // 
            // label_nomeArquivo
            // 
            label_nomeArquivo.AutoSize = true;
            label_nomeArquivo.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label_nomeArquivo.Location = new Point(12, 9);
            label_nomeArquivo.Name = "label_nomeArquivo";
            label_nomeArquivo.Size = new Size(309, 18);
            label_nomeArquivo.TabIndex = 4;
            label_nomeArquivo.Text = "Insira o nome do arquivo para a procura";
            // 
            // textBox_nomeArquivo
            // 
            textBox_nomeArquivo.Location = new Point(12, 30);
            textBox_nomeArquivo.Name = "textBox_nomeArquivo";
            textBox_nomeArquivo.Size = new Size(309, 23);
            textBox_nomeArquivo.TabIndex = 5;
            // 
            // button_procurarArquivo
            // 
            button_procurarArquivo.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_procurarArquivo.Location = new Point(12, 59);
            button_procurarArquivo.Name = "button_procurarArquivo";
            button_procurarArquivo.Size = new Size(87, 24);
            button_procurarArquivo.TabIndex = 6;
            button_procurarArquivo.Text = "Procurar";
            button_procurarArquivo.UseVisualStyleBackColor = true;
            button_procurarArquivo.Click += button_procurarArquivo_Click;
            // 
            // label_numeroPessoas
            // 
            label_numeroPessoas.AutoSize = true;
            label_numeroPessoas.Location = new Point(461, 210);
            label_numeroPessoas.Name = "label_numeroPessoas";
            label_numeroPessoas.Size = new Size(111, 15);
            label_numeroPessoas.TabIndex = 7;
            label_numeroPessoas.Text = "Numero de pessoas";
            // 
            // label_numeroAlunos
            // 
            label_numeroAlunos.AutoSize = true;
            label_numeroAlunos.Location = new Point(603, 210);
            label_numeroAlunos.Name = "label_numeroAlunos";
            label_numeroAlunos.Size = new Size(105, 15);
            label_numeroAlunos.TabIndex = 8;
            label_numeroAlunos.Text = "Numero de alunos";
            // 
            // textBox_numeroPessoas
            // 
            textBox_numeroPessoas.Location = new Point(461, 228);
            textBox_numeroPessoas.Name = "textBox_numeroPessoas";
            textBox_numeroPessoas.Size = new Size(111, 23);
            textBox_numeroPessoas.TabIndex = 9;
            // 
            // textBox_numeroAlunos
            // 
            textBox_numeroAlunos.Location = new Point(603, 228);
            textBox_numeroAlunos.Name = "textBox_numeroAlunos";
            textBox_numeroAlunos.Size = new Size(105, 23);
            textBox_numeroAlunos.TabIndex = 10;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(817, 566);
            Controls.Add(textBox_numeroAlunos);
            Controls.Add(textBox_numeroPessoas);
            Controls.Add(label_numeroAlunos);
            Controls.Add(label_numeroPessoas);
            Controls.Add(button_procurarArquivo);
            Controls.Add(textBox_nomeArquivo);
            Controls.Add(label_nomeArquivo);
            Controls.Add(textBox_listaPessoa);
            Controls.Add(label_listaPessoa);
            Name = "form";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_listaPessoa;
        private TextBox textBox_listaPessoa;
        private Label label_nomeArquivo;
        private TextBox textBox_nomeArquivo;
        private Button button_procurarArquivo;
        private Label label_numeroPessoas;
        private Label label_numeroAlunos;
        private TextBox textBox_numeroPessoas;
        private TextBox textBox_numeroAlunos;
    }
}