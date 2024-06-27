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
            txtIdEmpleado = new MaskedTextBox();
            label9 = new Label();
            label4 = new Label();
            txtSalario = new MaskedTextBox();
            label1 = new Label();
            txtHorasExtras = new MaskedTextBox();
            label3 = new Label();
            label5 = new Label();
            txtAñosDeAntiguedad = new MaskedTextBox();
            label6 = new Label();
            dgvIncomes = new DataGridView();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnActualizar = new Button();
            cmbNocturnidad = new ComboBox();
            cmbRiesgoLaboral = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvIncomes).BeginInit();
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
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(135, 59);
            txtIdEmpleado.Mask = "000";
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(26, 27);
            txtIdEmpleado.TabIndex = 25;
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
            // txtSalario
            // 
            txtSalario.Location = new Point(364, 56);
            txtSalario.Mask = "00000000000";
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(75, 27);
            txtSalario.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(491, 60);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 28;
            label1.Text = "Nocturnidad";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(236, 100);
            txtHorasExtras.Mask = "000";
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(26, 27);
            txtHorasExtras.TabIndex = 31;
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
            // txtAñosDeAntiguedad
            // 
            txtAñosDeAntiguedad.Location = new Point(752, 97);
            txtAñosDeAntiguedad.Mask = "000";
            txtAñosDeAntiguedad.Name = "txtAñosDeAntiguedad";
            txtAñosDeAntiguedad.Size = new Size(26, 27);
            txtAñosDeAntiguedad.TabIndex = 35;
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
            // dgvIncomes
            // 
            dgvIncomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncomes.Location = new Point(12, 237);
            dgvIncomes.Name = "dgvIncomes";
            dgvIncomes.RowHeadersWidth = 51;
            dgvIncomes.Size = new Size(766, 233);
            dgvIncomes.TabIndex = 36;
            dgvIncomes.CellClick += dgvIncomes_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(679, 179);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 44;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(445, 179);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 43;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(559, 179);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 29);
            btnActualizar.TabIndex = 42;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // cmbNocturnidad
            // 
            cmbNocturnidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNocturnidad.FormattingEnabled = true;
            cmbNocturnidad.Items.AddRange(new object[] { "Si", "No" });
            cmbNocturnidad.Location = new Point(638, 52);
            cmbNocturnidad.Name = "cmbNocturnidad";
            cmbNocturnidad.Size = new Size(98, 28);
            cmbNocturnidad.TabIndex = 45;
            // 
            // cmbRiesgoLaboral
            // 
            cmbRiesgoLaboral.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRiesgoLaboral.FormattingEnabled = true;
            cmbRiesgoLaboral.Items.AddRange(new object[] { "Si", "No" });
            cmbRiesgoLaboral.Location = new Point(434, 100);
            cmbRiesgoLaboral.Name = "cmbRiesgoLaboral";
            cmbRiesgoLaboral.Size = new Size(98, 28);
            cmbRiesgoLaboral.TabIndex = 46;
            // 
            // IncomesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 513);
            Controls.Add(cmbRiesgoLaboral);
            Controls.Add(cmbNocturnidad);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(btnActualizar);
            Controls.Add(dgvIncomes);
            Controls.Add(txtAñosDeAntiguedad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtHorasExtras);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtSalario);
            Controls.Add(label4);
            Controls.Add(txtIdEmpleado);
            Controls.Add(label9);
            Controls.Add(label2);
            Name = "IncomesForm";
            Text = "IncomesForm";
            Load += IncomesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIncomes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private MaskedTextBox txtIdEmpleado;
        private Label label9;
        private Label label4;
        private MaskedTextBox txtSalario;
        private Label label1;
        private MaskedTextBox txtHorasExtras;
        private Label label3;
        private Label label5;
        private MaskedTextBox txtAñosDeAntiguedad;
        private Label label6;
        private DataGridView dgvIncomes;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnActualizar;
        private ComboBox cmbNocturnidad;
        private ComboBox cmbRiesgoLaboral;
    }
}