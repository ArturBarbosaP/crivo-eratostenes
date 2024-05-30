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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            btn_calcular = new Button();
            txt_num = new NumericUpDown();
            dtg_listaNum = new DataGridView();
            Coluna1 = new DataGridViewTextBoxColumn();
            Coluna2 = new DataGridViewTextBoxColumn();
            Coluna3 = new DataGridViewTextBoxColumn();
            Coluna4 = new DataGridViewTextBoxColumn();
            Coluna5 = new DataGridViewTextBoxColumn();
            Coluna6 = new DataGridViewTextBoxColumn();
            Coluna7 = new DataGridViewTextBoxColumn();
            Coluna8 = new DataGridViewTextBoxColumn();
            Coluna9 = new DataGridViewTextBoxColumn();
            Coluna10 = new DataGridViewTextBoxColumn();
            ltx_resultado = new ListBox();
            txt_resultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txt_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_listaNum).BeginInit();
            SuspendLayout();
            // 
            // btn_calcular
            // 
            btn_calcular.Location = new Point(15, 48);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(100, 23);
            btn_calcular.TabIndex = 1;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // txt_num
            // 
            txt_num.Location = new Point(15, 19);
            txt_num.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            txt_num.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(100, 23);
            txt_num.TabIndex = 3;
            txt_num.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtg_listaNum
            // 
            dtg_listaNum.AllowUserToAddRows = false;
            dtg_listaNum.AllowUserToDeleteRows = false;
            dtg_listaNum.AllowUserToResizeColumns = false;
            dtg_listaNum.AllowUserToResizeRows = false;
            dtg_listaNum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_listaNum.ColumnHeadersVisible = false;
            dtg_listaNum.Columns.AddRange(new DataGridViewColumn[] { Coluna1, Coluna2, Coluna3, Coluna4, Coluna5, Coluna6, Coluna7, Coluna8, Coluna9, Coluna10 });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new Padding(0, 5, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dtg_listaNum.DefaultCellStyle = dataGridViewCellStyle11;
            dtg_listaNum.Location = new Point(15, 143);
            dtg_listaNum.MultiSelect = false;
            dtg_listaNum.Name = "dtg_listaNum";
            dtg_listaNum.ReadOnly = true;
            dtg_listaNum.RowHeadersVisible = false;
            dtg_listaNum.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtg_listaNum.RowTemplate.Height = 50;
            dtg_listaNum.ShowEditingIcon = false;
            dtg_listaNum.Size = new Size(520, 289);
            dtg_listaNum.TabIndex = 4;
            dtg_listaNum.SelectionChanged += dtg_listaNum_SelectionChanged;
            // 
            // Coluna1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            Coluna1.DefaultCellStyle = dataGridViewCellStyle1;
            Coluna1.HeaderText = "Coluna1";
            Coluna1.Name = "Coluna1";
            Coluna1.ReadOnly = true;
            Coluna1.Resizable = DataGridViewTriState.False;
            Coluna1.Width = 50;
            // 
            // Coluna2
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            Coluna2.DefaultCellStyle = dataGridViewCellStyle2;
            Coluna2.HeaderText = "Coluna2";
            Coluna2.Name = "Coluna2";
            Coluna2.ReadOnly = true;
            Coluna2.Resizable = DataGridViewTriState.False;
            Coluna2.Width = 50;
            // 
            // Coluna3
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            Coluna3.DefaultCellStyle = dataGridViewCellStyle3;
            Coluna3.HeaderText = "Coluna3";
            Coluna3.Name = "Coluna3";
            Coluna3.ReadOnly = true;
            Coluna3.Resizable = DataGridViewTriState.False;
            Coluna3.Width = 50;
            // 
            // Coluna4
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            Coluna4.DefaultCellStyle = dataGridViewCellStyle4;
            Coluna4.HeaderText = "Coluna4";
            Coluna4.Name = "Coluna4";
            Coluna4.ReadOnly = true;
            Coluna4.Resizable = DataGridViewTriState.False;
            Coluna4.Width = 50;
            // 
            // Coluna5
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            Coluna5.DefaultCellStyle = dataGridViewCellStyle5;
            Coluna5.HeaderText = "Coluna5";
            Coluna5.Name = "Coluna5";
            Coluna5.ReadOnly = true;
            Coluna5.Resizable = DataGridViewTriState.False;
            Coluna5.Width = 50;
            // 
            // Coluna6
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter;
            Coluna6.DefaultCellStyle = dataGridViewCellStyle6;
            Coluna6.HeaderText = "Coluna6";
            Coluna6.Name = "Coluna6";
            Coluna6.ReadOnly = true;
            Coluna6.Resizable = DataGridViewTriState.False;
            Coluna6.Width = 50;
            // 
            // Coluna7
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            Coluna7.DefaultCellStyle = dataGridViewCellStyle7;
            Coluna7.HeaderText = "Coluna7";
            Coluna7.Name = "Coluna7";
            Coluna7.ReadOnly = true;
            Coluna7.Resizable = DataGridViewTriState.False;
            Coluna7.Width = 50;
            // 
            // Coluna8
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopCenter;
            Coluna8.DefaultCellStyle = dataGridViewCellStyle8;
            Coluna8.HeaderText = "Coluna8";
            Coluna8.Name = "Coluna8";
            Coluna8.ReadOnly = true;
            Coluna8.Resizable = DataGridViewTriState.False;
            Coluna8.Width = 50;
            // 
            // Coluna9
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.TopCenter;
            Coluna9.DefaultCellStyle = dataGridViewCellStyle9;
            Coluna9.HeaderText = "Coluna9";
            Coluna9.Name = "Coluna9";
            Coluna9.ReadOnly = true;
            Coluna9.Resizable = DataGridViewTriState.False;
            Coluna9.Width = 50;
            // 
            // Coluna10
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.TopCenter;
            Coluna10.DefaultCellStyle = dataGridViewCellStyle10;
            Coluna10.HeaderText = "Coluna10";
            Coluna10.Name = "Coluna10";
            Coluna10.ReadOnly = true;
            Coluna10.Resizable = DataGridViewTriState.False;
            Coluna10.Width = 50;
            // 
            // ltx_resultado
            // 
            ltx_resultado.Font = new Font("Segoe UI", 13F);
            ltx_resultado.FormattingEnabled = true;
            ltx_resultado.HorizontalScrollbar = true;
            ltx_resultado.ItemHeight = 23;
            ltx_resultado.Location = new Point(13, 438);
            ltx_resultado.Name = "ltx_resultado";
            ltx_resultado.SelectionMode = SelectionMode.None;
            ltx_resultado.Size = new Size(520, 142);
            ltx_resultado.TabIndex = 5;
            // 
            // txt_resultado
            // 
            txt_resultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_resultado.Location = new Point(15, 77);
            txt_resultado.Multiline = true;
            txt_resultado.Name = "txt_resultado";
            txt_resultado.ReadOnly = true;
            txt_resultado.ScrollBars = ScrollBars.Horizontal;
            txt_resultado.Size = new Size(520, 60);
            txt_resultado.TabIndex = 6;
            txt_resultado.WordWrap = false;
            // 
            // frm_crivoEratostenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 591);
            Controls.Add(txt_resultado);
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
            PerformLayout();
        }

        #endregion
        private Button btn_calcular;
        private NumericUpDown txt_num;
        private DataGridView dtg_listaNum;
        private ListBox ltx_resultado;
        private TextBox txt_resultado;
        private DataGridViewTextBoxColumn Coluna1;
        private DataGridViewTextBoxColumn Coluna2;
        private DataGridViewTextBoxColumn Coluna3;
        private DataGridViewTextBoxColumn Coluna4;
        private DataGridViewTextBoxColumn Coluna5;
        private DataGridViewTextBoxColumn Coluna6;
        private DataGridViewTextBoxColumn Coluna7;
        private DataGridViewTextBoxColumn Coluna8;
        private DataGridViewTextBoxColumn Coluna9;
        private DataGridViewTextBoxColumn Coluna10;
    }
}
