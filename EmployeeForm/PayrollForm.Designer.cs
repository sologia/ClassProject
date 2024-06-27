namespace Payroll
{
    partial class PayrollForm
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
            dgvPayroll = new DataGridView();
            btnEmployee = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            dtpNomina = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvPayroll).BeginInit();
            SuspendLayout();
            // 
            // dgvPayroll
            // 
            dgvPayroll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayroll.Location = new Point(72, 215);
            dgvPayroll.Name = "dgvPayroll";
            dgvPayroll.ReadOnly = true;
            dgvPayroll.RowHeadersWidth = 51;
            dgvPayroll.Size = new Size(754, 233);
            dgvPayroll.TabIndex = 0;
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(709, 144);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(117, 50);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Empleados";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 30);
            label1.TabIndex = 2;
            label1.Text = "Creador De Nominas";
            // 
            // button1
            // 
            button1.Location = new Point(364, 165);
            button1.Name = "button1";
            button1.Size = new Size(97, 29);
            button1.TabIndex = 3;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(250, 165);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(484, 165);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(116, 56);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 6;
            label2.Text = "Periodo : ";
            // 
            // dtpNomina
            // 
            dtpNomina.Format = DateTimePickerFormat.Short;
            dtpNomina.Location = new Point(193, 55);
            dtpNomina.MaxDate = new DateTime(2999, 6, 26, 0, 0, 0, 0);
            dtpNomina.MinDate = new DateTime(2024, 6, 26, 0, 0, 0, 0);
            dtpNomina.Name = "dtpNomina";
            dtpNomina.Size = new Size(122, 27);
            dtpNomina.TabIndex = 7;
            dtpNomina.Value = new DateTime(2024, 6, 26, 0, 0, 0, 0);
            // 
            // PayrollForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 481);
            Controls.Add(dtpNomina);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnEmployee);
            Controls.Add(dgvPayroll);
            Name = "PayrollForm";
            Text = "PayrollForm";
            Load += PayrollForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayroll).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPayroll;
        private Button btnEmployee;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private DateTimePicker dtpNomina;
    }
}