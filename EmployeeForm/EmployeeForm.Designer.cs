namespace Payroll
{
    partial class EmployeeForm
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
            label1 = new Label();
            txtINSS = new TextBox();
            txtRUC = new TextBox();
            label3 = new Label();
            txtPrimerNombre = new TextBox();
            label4 = new Label();
            txtSecondNombre = new TextBox();
            label5 = new Label();
            txtSecondApellido = new TextBox();
            label6 = new Label();
            txtPrimerApellido = new TextBox();
            label7 = new Label();
            dtpNacimiento = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            mskCelular = new MaskedTextBox();
            mskTelefono = new MaskedTextBox();
            label10 = new Label();
            cmbSexo = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            cmbEstado = new ComboBox();
            label13 = new Label();
            dtpContrato = new DateTimePicker();
            label14 = new Label();
            dtpFinContrato = new DateTimePicker();
            chkActivo = new CheckBox();
            txtDireccion = new TextBox();
            label15 = new Label();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnActualizar = new Button();
            dgvEmpleados = new DataGridView();
            btnDeducciones = new Button();
            btnIngresos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(339, 9);
            label2.Name = "label2";
            label2.Size = new Size(305, 33);
            label2.TabIndex = 7;
            label2.Text = "Datos De Empleados";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 8;
            label1.Text = "INSS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtINSS
            // 
            txtINSS.Location = new Point(65, 62);
            txtINSS.Multiline = true;
            txtINSS.Name = "txtINSS";
            txtINSS.Size = new Size(125, 34);
            txtINSS.TabIndex = 9;
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(254, 62);
            txtRUC.Multiline = true;
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(108, 34);
            txtRUC.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(205, 70);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 10;
            label3.Text = "RUC";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(130, 107);
            txtPrimerNombre.Multiline = true;
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(145, 34);
            txtPrimerNombre.TabIndex = 13;
            txtPrimerNombre.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 115);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 12;
            label4.Text = "First Name";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // txtSecondNombre
            // 
            txtSecondNombre.Location = new Point(412, 107);
            txtSecondNombre.Multiline = true;
            txtSecondNombre.Name = "txtSecondNombre";
            txtSecondNombre.Size = new Size(145, 34);
            txtSecondNombre.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(285, 115);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 14;
            label5.Text = "Second Name";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSecondApellido
            // 
            txtSecondApellido.Location = new Point(963, 104);
            txtSecondApellido.Multiline = true;
            txtSecondApellido.Name = "txtSecondApellido";
            txtSecondApellido.Size = new Size(145, 34);
            txtSecondApellido.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(801, 111);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 16;
            label6.Text = "Second Surname";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(651, 107);
            txtPrimerApellido.Multiline = true;
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(145, 34);
            txtPrimerApellido.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(562, 112);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 18;
            label7.Text = "Surname";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(131, 162);
            dtpNacimiento.MaxDate = new DateTime(2999, 6, 26, 0, 0, 0, 0);
            dtpNacimiento.MinDate = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(122, 27);
            dtpNacimiento.TabIndex = 20;
            dtpNacimiento.Value = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 165);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 21;
            label8.Text = "Nacimiento";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(377, 70);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 22;
            label9.Text = "Celular";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // mskCelular
            // 
            mskCelular.Location = new Point(465, 66);
            mskCelular.Mask = "0000-0000";
            mskCelular.Name = "mskCelular";
            mskCelular.Size = new Size(62, 27);
            mskCelular.TabIndex = 23;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(629, 63);
            mskTelefono.Mask = "0000-0000";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(62, 27);
            mskTelefono.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(533, 67);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 24;
            label10.Text = "Telefono";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Femenino", "No identificado" });
            cmbSexo.Location = new Point(749, 62);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(98, 28);
            cmbSexo.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(697, 66);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 28;
            label11.Text = "Sexo";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(860, 65);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 30;
            label12.Text = "Estado Civil";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Casado/a", "Soltero/a", "Viudo/a", "Divorciado/a" });
            cmbEstado.Location = new Point(985, 61);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(98, 28);
            cmbEstado.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(259, 165);
            label13.Name = "label13";
            label13.Size = new Size(134, 20);
            label13.TabIndex = 32;
            label13.Text = "Contratacion";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtpContrato
            // 
            dtpContrato.Format = DateTimePickerFormat.Short;
            dtpContrato.Location = new Point(399, 162);
            dtpContrato.MaxDate = new DateTime(2999, 6, 26, 0, 0, 0, 0);
            dtpContrato.MinDate = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            dtpContrato.Name = "dtpContrato";
            dtpContrato.Size = new Size(122, 27);
            dtpContrato.TabIndex = 31;
            dtpContrato.Value = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(533, 165);
            label14.Name = "label14";
            label14.Size = new Size(166, 20);
            label14.TabIndex = 34;
            label14.Text = "Fin Contratacion";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtpFinContrato
            // 
            dtpFinContrato.Format = DateTimePickerFormat.Short;
            dtpFinContrato.Location = new Point(702, 162);
            dtpFinContrato.MaxDate = new DateTime(2999, 6, 26, 0, 0, 0, 0);
            dtpFinContrato.MinDate = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            dtpFinContrato.Name = "dtpFinContrato";
            dtpFinContrato.Size = new Size(122, 27);
            dtpFinContrato.TabIndex = 33;
            dtpFinContrato.Value = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(855, 163);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(73, 24);
            chkActivo.TabIndex = 36;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(130, 207);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(329, 34);
            txtDireccion.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(16, 215);
            label15.Name = "label15";
            label15.Size = new Size(98, 20);
            label15.TabIndex = 37;
            label15.Text = "Direccion";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(716, 210);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 41;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(482, 210);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 40;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(596, 210);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 29);
            btnActualizar.TabIndex = 39;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(12, 285);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(1096, 245);
            dgvEmpleados.TabIndex = 42;
            // 
            // btnDeducciones
            // 
            btnDeducciones.Location = new Point(940, 210);
            btnDeducciones.Name = "btnDeducciones";
            btnDeducciones.Size = new Size(109, 29);
            btnDeducciones.TabIndex = 44;
            btnDeducciones.Text = "Deducciones";
            btnDeducciones.UseVisualStyleBackColor = true;
            btnDeducciones.Click += btnDeducciones_Click;
            // 
            // btnIngresos
            // 
            btnIngresos.Location = new Point(823, 210);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(97, 29);
            btnIngresos.TabIndex = 43;
            btnIngresos.Text = "Ingresos";
            btnIngresos.UseVisualStyleBackColor = true;
            btnIngresos.Click += button5_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 542);
            Controls.Add(btnDeducciones);
            Controls.Add(btnIngresos);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(btnActualizar);
            Controls.Add(txtDireccion);
            Controls.Add(label15);
            Controls.Add(chkActivo);
            Controls.Add(label14);
            Controls.Add(dtpFinContrato);
            Controls.Add(label13);
            Controls.Add(dtpContrato);
            Controls.Add(label12);
            Controls.Add(cmbEstado);
            Controls.Add(label11);
            Controls.Add(cmbSexo);
            Controls.Add(mskTelefono);
            Controls.Add(label10);
            Controls.Add(mskCelular);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtpNacimiento);
            Controls.Add(txtPrimerApellido);
            Controls.Add(label7);
            Controls.Add(txtSecondApellido);
            Controls.Add(label6);
            Controls.Add(txtSecondNombre);
            Controls.Add(label5);
            Controls.Add(txtPrimerNombre);
            Controls.Add(label4);
            Controls.Add(txtRUC);
            Controls.Add(label3);
            Controls.Add(txtINSS);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtINSS;
        private TextBox txtRUC;
        private Label label3;
        private TextBox txtPrimerNombre;
        private Label label4;
        private TextBox txtSecondNombre;
        private Label label5;
        private TextBox txtSecondApellido;
        private Label label6;
        private TextBox txtPrimerApellido;
        private Label label7;
        private DateTimePicker dtpNacimiento;
        private Label label8;
        private Label label9;
        private MaskedTextBox mskCelular;
        private MaskedTextBox mskTelefono;
        private Label label10;
        private ComboBox cmbSexo;
        private Label label11;
        private Label label12;
        private ComboBox cmbEstado;
        private Label label13;
        private DateTimePicker dtpContrato;
        private Label label14;
        private DateTimePicker dtpFinContrato;
        private CheckBox chkActivo;
        private TextBox txtDireccion;
        private Label label15;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnActualizar;
        private DataGridView dgvEmpleados;
        private Button btnDeducciones;
        private Button btnIngresos;
    }
}