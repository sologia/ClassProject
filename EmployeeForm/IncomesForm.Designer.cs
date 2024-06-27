namespace Payroll
{
    partial class IncomesForm
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
            label2 = new Label();
            mskIDEmpleado = new MaskedTextBox();
            label9 = new Label();
            label4 = new Label();
            mskSalario = new MaskedTextBox();
            mskHorasNocturnas = new MaskedTextBox();
            label1 = new Label();
            mskHorasExtras = new MaskedTextBox();
            label3 = new Label();
            label5 = new Label();
            txtRiesgoLaboral = new TextBox();
            mskAñosAntiguedad = new MaskedTextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 9);
            label2.Name = "label2";
            label2.Size = new Size(148, 33);
            label2.TabIndex = 8;
            label2.Text = "INGRESOS";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // mskIDEmpleado
            // 
            mskIDEmpleado.Location = new Point(135, 59);
            mskIDEmpleado.Mask = "000";
            mskIDEmpleado.Name = "mskIDEmpleado";
            mskIDEmpleado.Size = new Size(26, 27);
            mskIDEmpleado.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 63);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 24;
            label9.Text = "ID Empleado";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(182, 63);
            label4.Name = "label4";
            label4.Size = new Size(176, 20);
            label4.TabIndex = 26;
            label4.Text = "Salario 0rdinario";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // mskSalario
            // 
            mskSalario.Location = new Point(364, 56);
            mskSalario.Mask = "00000000000";
            mskSalario.Name = "mskSalario";
            mskSalario.Size = new Size(75, 27);
            mskSalario.TabIndex = 27;
            // 
            // mskHorasNocturnas
            // 
            mskHorasNocturnas.Location = new Point(711, 56);
            mskHorasNocturnas.Mask = "000";
            mskHorasNocturnas.Name = "mskHorasNocturnas";
            mskHorasNocturnas.Size = new Size(26, 27);
            mskHorasNocturnas.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 60);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 28;
            label1.Text = "Cantidad Horas Nocturnas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // mskHorasExtras
            // 
            mskHorasExtras.Location = new Point(236, 100);
            mskHorasExtras.Mask = "000";
            mskHorasExtras.Name = "mskHorasExtras";
            mskHorasExtras.Size = new Size(26, 27);
            mskHorasExtras.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(219, 20);
            label3.TabIndex = 30;
            label3.Text = "Cantidad Horas Extras";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(280, 104);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 32;
            label5.Text = "Riesgo Laboral";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtRiesgoLaboral
            // 
            txtRiesgoLaboral.Location = new Point(434, 100);
            txtRiesgoLaboral.Multiline = true;
            txtRiesgoLaboral.Name = "txtRiesgoLaboral";
            txtRiesgoLaboral.Size = new Size(145, 27);
            txtRiesgoLaboral.TabIndex = 33;
            // 
            // mskAñosAntiguedad
            // 
            mskAñosAntiguedad.Location = new Point(752, 97);
            mskAñosAntiguedad.Mask = "000";
            mskAñosAntiguedad.Name = "mskAñosAntiguedad";
            mskAñosAntiguedad.Size = new Size(26, 27);
            mskAñosAntiguedad.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(585, 104);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 34;
            label6.Text = "Años Antiguedad";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(766, 233);
            dataGridView1.TabIndex = 36;
            // 
            // button3
            // 
            button3.Location = new Point(679, 179);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 44;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(445, 179);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 43;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(559, 179);
            button1.Name = "button1";
            button1.Size = new Size(97, 29);
            button1.TabIndex = 42;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // IncomesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 513);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(mskAñosAntiguedad);
            Controls.Add(label6);
            Controls.Add(txtRiesgoLaboral);
            Controls.Add(label5);
            Controls.Add(mskHorasExtras);
            Controls.Add(label3);
            Controls.Add(mskHorasNocturnas);
            Controls.Add(label1);
            Controls.Add(mskSalario);
            Controls.Add(label4);
            Controls.Add(mskIDEmpleado);
            Controls.Add(label9);
            Controls.Add(label2);
            Name = "IncomesForm";
            Text = "IncomesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private MaskedTextBox mskIDEmpleado;
        private Label label9;
        private Label label4;
        private MaskedTextBox mskSalario;
        private MaskedTextBox mskHorasNocturnas;
        private Label label1;
        private MaskedTextBox mskHorasExtras;
        private Label label3;
        private Label label5;
        private TextBox txtRiesgoLaboral;
        private MaskedTextBox mskAñosAntiguedad;
        private Label label6;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}