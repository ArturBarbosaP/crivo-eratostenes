namespace CrivoEratostenes
{
    partial class frm_crivoEratostenes
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
            txt_num = new TextBox();
            btn_calcular = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // txt_num
            // 
            txt_num.Location = new Point(25, 34);
            txt_num.Name = "txt_num";
            txt_num.PlaceholderText = "Número";
            txt_num.Size = new Size(100, 23);
            txt_num.TabIndex = 0;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(25, 76);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(100, 23);
            btn_calcular.TabIndex = 1;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 34);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(345, 65);
            textBox2.TabIndex = 2;
            // 
            // frm_crivoEratostenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 133);
            Controls.Add(textBox2);
            Controls.Add(btn_calcular);
            Controls.Add(txt_num);
            Name = "frm_crivoEratostenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crivo de Eratóstones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_num;
        private Button btn_calcular;
        private TextBox textBox2;
    }
}
