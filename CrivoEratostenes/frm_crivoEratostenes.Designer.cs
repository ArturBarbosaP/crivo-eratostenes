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
            btn_calcular = new Button();
            txt_num = new NumericUpDown();
            dtg_listaNum = new DataGridView();
            ltx_resultado = new ListBox();
            ((System.ComponentModel.ISupportInitialize)txt_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_listaNum).BeginInit();
            SuspendLayout();
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(24, 50);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(100, 23);
            btn_calcular.TabIndex = 1;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txt_num
            // 
            txt_num.Location = new Point(24, 21);
            txt_num.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            txt_num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(100, 23);
            txt_num.TabIndex = 3;
            txt_num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtg_listaNum
            // 
            dtg_listaNum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_listaNum.Location = new Point(24, 79);
            dtg_listaNum.Name = "dtg_listaNum";
            dtg_listaNum.Size = new Size(345, 334);
            dtg_listaNum.TabIndex = 4;
            // 
            // ltx_resultado
            // 
            ltx_resultado.Font = new Font("Segoe UI", 18F);
            ltx_resultado.FormattingEnabled = true;
            ltx_resultado.HorizontalScrollbar = true;
            ltx_resultado.ItemHeight = 32;
            ltx_resultado.Location = new Point(24, 419);
            ltx_resultado.Name = "ltx_resultado";
            ltx_resultado.Size = new Size(345, 132);
            ltx_resultado.TabIndex = 5;
            // 
            // frm_crivoEratostenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 570);
            Controls.Add(ltx_resultado);
            Controls.Add(dtg_listaNum);
            Controls.Add(txt_num);
            Controls.Add(btn_calcular);
            Name = "frm_crivoEratostenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crivo de Eratóstones";
            ((System.ComponentModel.ISupportInitialize)txt_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_listaNum).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_calcular;
        private NumericUpDown txt_num;
        private DataGridView dtg_listaNum;
        private ListBox ltx_resultado;
    }
}
