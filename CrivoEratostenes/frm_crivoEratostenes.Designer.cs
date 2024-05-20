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
            txt_resultado = new TextBox();
            SuspendLayout();
            // 
            // txt_num
            // 
            txt_num.Location = new Point(29, 153);
            txt_num.Name = "txt_num";
            txt_num.PlaceholderText = "Número";
            txt_num.Size = new Size(100, 23);
            txt_num.TabIndex = 0;
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(29, 182);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(100, 23);
            btn_calcular.TabIndex = 1;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txt_resultado
            // 
            txt_resultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_resultado.Location = new Point(189, 12);
            txt_resultado.Multiline = true;
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.Size = new Size(345, 334);
            txt_resultado.TabIndex = 2;
            // 
            // frm_crivoEratostenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 358);
            Controls.Add(txt_resultado);
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
        private TextBox txt_resultado;
    }
}
