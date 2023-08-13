namespace GuiTest
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
            btn_Escuro = new Button();
            btn_Claro = new Button();
            lbl_Escolha_um_tema = new Label();
            SuspendLayout();
            // 
            // btn_Escuro
            // 
            btn_Escuro.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Escuro.Location = new Point(171, 221);
            btn_Escuro.Name = "btn_Escuro";
            btn_Escuro.Size = new Size(107, 42);
            btn_Escuro.TabIndex = 0;
            btn_Escuro.Text = "Escuro";
            btn_Escuro.UseVisualStyleBackColor = true;
            btn_Escuro.Click += button1_Click;
            // 
            // btn_Claro
            // 
            btn_Claro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Claro.Location = new Point(415, 221);
            btn_Claro.Name = "btn_Claro";
            btn_Claro.Size = new Size(107, 42);
            btn_Claro.TabIndex = 1;
            btn_Claro.Text = "Claro";
            btn_Claro.UseVisualStyleBackColor = true;
            btn_Claro.Click += btn_Claro_Click;
            // 
            // lbl_Escolha_um_tema
            // 
            lbl_Escolha_um_tema.AutoSize = true;
            lbl_Escolha_um_tema.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Escolha_um_tema.Location = new Point(242, 105);
            lbl_Escolha_um_tema.Name = "lbl_Escolha_um_tema";
            lbl_Escolha_um_tema.Size = new Size(208, 35);
            lbl_Escolha_um_tema.TabIndex = 2;
            lbl_Escolha_um_tema.Text = "Escolha um tema";
            lbl_Escolha_um_tema.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 454);
            Controls.Add(lbl_Escolha_um_tema);
            Controls.Add(btn_Claro);
            Controls.Add(btn_Escuro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Escuro;
        private Button btn_Claro;
        private Label lbl_Escolha_um_tema;
    }
}