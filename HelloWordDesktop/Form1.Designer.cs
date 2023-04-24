namespace HelloWordDesktop
{
    partial class Form1
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
            textNome = new TextBox();
            textEndereco = new TextBox();
            textComplemento = new TextBox();
            textNumero = new TextBox();
            label1 = new Label();
            pbxCorFundo = new PictureBox();
            btnGravar = new Button();
            lbxDados = new ListBox();
            btnLimpar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbxCorFundo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Location = new Point(12, 3);
            textNome.Name = "textNome";
            textNome.PlaceholderText = "Nome";
            textNome.Size = new Size(318, 23);
            textNome.TabIndex = 0;
            textNome.TextChanged += textNome_TextChanged;
            // 
            // textEndereco
            // 
            textEndereco.Location = new Point(12, 32);
            textEndereco.Name = "textEndereco";
            textEndereco.PlaceholderText = "Endereço";
            textEndereco.Size = new Size(318, 23);
            textEndereco.TabIndex = 1;
            textEndereco.TextChanged += textEndereco_TextChanged;
            // 
            // textComplemento
            // 
            textComplemento.Location = new Point(12, 61);
            textComplemento.Name = "textComplemento";
            textComplemento.PlaceholderText = "Complemento";
            textComplemento.Size = new Size(209, 23);
            textComplemento.TabIndex = 2;
            // 
            // textNumero
            // 
            textNumero.Location = new Point(230, 61);
            textNumero.Name = "textNumero";
            textNumero.PlaceholderText = "Número";
            textNumero.Size = new Size(100, 23);
            textNumero.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 101);
            label1.Name = "label1";
            label1.Size = new Size(80, 14);
            label1.TabIndex = 5;
            label1.Text = "Cor de fundo";
            label1.Click += label1_Click;
            // 
            // pbxCorFundo
            // 
            pbxCorFundo.BorderStyle = BorderStyle.Fixed3D;
            pbxCorFundo.Location = new Point(98, 98);
            pbxCorFundo.Name = "pbxCorFundo";
            pbxCorFundo.Size = new Size(123, 26);
            pbxCorFundo.TabIndex = 6;
            pbxCorFundo.TabStop = false;
            pbxCorFundo.Click += pictureBox1_Click;
            // 
            // btnGravar
            // 
            btnGravar.FlatStyle = FlatStyle.System;
            btnGravar.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGravar.Location = new Point(242, 98);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(70, 23);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // lbxDados
            // 
            lbxDados.FormattingEnabled = true;
            lbxDados.ItemHeight = 15;
            lbxDados.Location = new Point(12, 156);
            lbxDados.Name = "lbxDados";
            lbxDados.Size = new Size(318, 184);
            lbxDados.TabIndex = 8;
            lbxDados.SelectedIndexChanged += lbxDados_SelectedIndexChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatStyle = FlatStyle.System;
            btnLimpar.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.ImageAlign = ContentAlignment.MiddleRight;
            btnLimpar.Location = new Point(12, 346);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(316, 23);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbxDados);
            panel1.Controls.Add(pbxCorFundo);
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textNome);
            panel1.Controls.Add(textComplemento);
            panel1.Controls.Add(btnGravar);
            panel1.Controls.Add(textEndereco);
            panel1.Controls.Add(textNumero);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 372);
            panel1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 375);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "HelloWorld";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbxCorFundo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textNome;
        private TextBox textEndereco;
        private TextBox textComplemento;
        private TextBox textNumero;
        private Label label1;
        private PictureBox pbxCorFundo;
        private Button btnGravar;
        private ListBox lbxDados;
        private Button btnLimpar;
        private Panel panel1;
    }
}