namespace Payroll
{
    partial class DeductionForm
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
            mskID = new MaskedTextBox();
            label9 = new Label();
            dgvEgresos = new DataGridView();
            btnEliminar = new Button();
            btnCrear = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEgresos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 9);
            label2.Name = "label2";
            label2.Size = new Size(134, 33);
            label2.TabIndex = 9;
            label2.Text = "EGRESOS";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // mskID
            // 
            mskID.Location = new Point(135, 53);
            mskID.Mask = "000";
            mskID.Name = "mskID";
            mskID.Size = new Size(26, 27);
            mskID.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 57);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 26;
            label9.Text = "ID Empleado";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dgvEgresos
            // 
            dgvEgresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEgresos.Location = new Point(10, 162);
            dgvEgresos.Name = "dgvEgresos";
            dgvEgresos.ReadOnly = true;
            dgvEgresos.RowHeadersWidth = 51;
            dgvEgresos.Size = new Size(332, 286);
            dgvEgresos.TabIndex = 28;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(248, 109);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 44;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(14, 109);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 43;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(128, 109);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 29);
            btnActualizar.TabIndex = 42;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // DeductionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 513);
            Controls.Add(btnEliminar);
            Controls.Add(btnCrear);
            Controls.Add(btnActualizar);
            Controls.Add(dgvEgresos);
            Controls.Add(mskID);
            Controls.Add(label9);
            Controls.Add(label2);
            Name = "DeductionForm";
            Text = "DeductionForm";
            Load += DeductionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEgresos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private MaskedTextBox mskID;
        private Label label9;
        private DataGridView dgvEgresos;
        private Button btnEliminar;
        private Button btnCrear;
        private Button btnActualizar;
    }
}