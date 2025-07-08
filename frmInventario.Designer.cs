namespace Clase7
{
    partial class frmInventario
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
            lblInvenatrio = new Label();
            lblTotalStock = new Label();
            lblFechaInventario = new Label();
            lblUbicacionStock = new Label();
            dtpFechaInventario = new DateTimePicker();
            txtTotalProductosStock = new TextBox();
            cboUbicacionStock = new ComboBox();
            lblIdArea = new Label();
            lblNombreAreas = new Label();
            lblNombreResponsable = new Label();
            txtNombreAreaI = new TextBox();
            txtNombreResponsableI = new TextBox();
            TotalProductosStock = new Label();
            cboIdAreaEmpresa = new ComboBox();
            SuspendLayout();
            // 
            // lblInvenatrio
            // 
            lblInvenatrio.AutoSize = true;
            lblInvenatrio.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInvenatrio.Location = new Point(52, 27);
            lblInvenatrio.Name = "lblInvenatrio";
            lblInvenatrio.Size = new Size(157, 14);
            lblInvenatrio.TabIndex = 0;
            lblInvenatrio.Text = "Formulario de Inventario";
            // 
            // lblTotalStock
            // 
            lblTotalStock.AutoSize = true;
            lblTotalStock.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStock.Location = new Point(64, 270);
            lblTotalStock.Name = "lblTotalStock";
            lblTotalStock.Size = new Size(236, 14);
            lblTotalStock.TabIndex = 1;
            lblTotalStock.Text = "Datos id Areas Empresas Seleccionado";
            // 
            // lblFechaInventario
            // 
            lblFechaInventario.AutoSize = true;
            lblFechaInventario.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaInventario.Location = new Point(57, 112);
            lblFechaInventario.Name = "lblFechaInventario";
            lblFechaInventario.Size = new Size(109, 14);
            lblFechaInventario.TabIndex = 2;
            lblFechaInventario.Text = "Fecha Inventario";
            // 
            // lblUbicacionStock
            // 
            lblUbicacionStock.AutoSize = true;
            lblUbicacionStock.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbicacionStock.Location = new Point(64, 167);
            lblUbicacionStock.Name = "lblUbicacionStock";
            lblUbicacionStock.Size = new Size(102, 14);
            lblUbicacionStock.TabIndex = 3;
            lblUbicacionStock.Text = "Ubicacion Stock";
            // 
            // dtpFechaInventario
            // 
            dtpFechaInventario.Format = DateTimePickerFormat.Short;
            dtpFechaInventario.Location = new Point(198, 104);
            dtpFechaInventario.Name = "dtpFechaInventario";
            dtpFechaInventario.Size = new Size(121, 22);
            dtpFechaInventario.TabIndex = 5;
            dtpFechaInventario.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtTotalProductosStock
            // 
            txtTotalProductosStock.BackColor = SystemColors.InactiveBorder;
            txtTotalProductosStock.Location = new Point(198, 61);
            txtTotalProductosStock.Name = "txtTotalProductosStock";
            txtTotalProductosStock.Size = new Size(199, 22);
            txtTotalProductosStock.TabIndex = 6;
            // 
            // cboUbicacionStock
            // 
            cboUbicacionStock.FormattingEnabled = true;
            cboUbicacionStock.Location = new Point(198, 159);
            cboUbicacionStock.Name = "cboUbicacionStock";
            cboUbicacionStock.Size = new Size(121, 22);
            cboUbicacionStock.TabIndex = 7;
            // 
            // lblIdArea
            // 
            lblIdArea.AutoSize = true;
            lblIdArea.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdArea.Location = new Point(64, 210);
            lblIdArea.Name = "lblIdArea";
            lblIdArea.Size = new Size(50, 14);
            lblIdArea.TabIndex = 8;
            lblIdArea.Text = "Id Area";
            // 
            // lblNombreAreas
            // 
            lblNombreAreas.AutoSize = true;
            lblNombreAreas.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreAreas.Location = new Point(73, 308);
            lblNombreAreas.Name = "lblNombreAreas";
            lblNombreAreas.Size = new Size(86, 14);
            lblNombreAreas.TabIndex = 10;
            lblNombreAreas.Text = "Nombre Area";
            // 
            // lblNombreResponsable
            // 
            lblNombreResponsable.AutoSize = true;
            lblNombreResponsable.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreResponsable.Location = new Point(397, 308);
            lblNombreResponsable.Name = "lblNombreResponsable";
            lblNombreResponsable.Size = new Size(158, 14);
            lblNombreResponsable.TabIndex = 11;
            lblNombreResponsable.Text = "Nombre del Responsable";
            // 
            // txtNombreAreaI
            // 
            txtNombreAreaI.Location = new Point(73, 354);
            txtNombreAreaI.Name = "txtNombreAreaI";
            txtNombreAreaI.Size = new Size(136, 22);
            txtNombreAreaI.TabIndex = 12;
            // 
            // txtNombreResponsableI
            // 
            txtNombreResponsableI.Location = new Point(397, 354);
            txtNombreResponsableI.Name = "txtNombreResponsableI";
            txtNombreResponsableI.Size = new Size(149, 22);
            txtNombreResponsableI.TabIndex = 13;
            // 
            // TotalProductosStock
            // 
            TotalProductosStock.AutoSize = true;
            TotalProductosStock.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalProductosStock.Location = new Point(57, 69);
            TotalProductosStock.Name = "TotalProductosStock";
            TotalProductosStock.Size = new Size(135, 14);
            TotalProductosStock.TabIndex = 14;
            TotalProductosStock.Text = "Total Productos Stock";
            // 
            // cboIdAreaEmpresa
            // 
            cboIdAreaEmpresa.FormattingEnabled = true;
            cboIdAreaEmpresa.Location = new Point(198, 210);
            cboIdAreaEmpresa.Name = "cboIdAreaEmpresa";
            cboIdAreaEmpresa.Size = new Size(121, 22);
            cboIdAreaEmpresa.TabIndex = 15;
            cboIdAreaEmpresa.SelectedIndexChanged += cboIdAreaEmpresa_SelectedIndexChanged;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 420);
            Controls.Add(cboIdAreaEmpresa);
            Controls.Add(TotalProductosStock);
            Controls.Add(txtNombreResponsableI);
            Controls.Add(txtNombreAreaI);
            Controls.Add(lblNombreResponsable);
            Controls.Add(lblNombreAreas);
            Controls.Add(lblIdArea);
            Controls.Add(cboUbicacionStock);
            Controls.Add(txtTotalProductosStock);
            Controls.Add(dtpFechaInventario);
            Controls.Add(lblUbicacionStock);
            Controls.Add(lblFechaInventario);
            Controls.Add(lblTotalStock);
            Controls.Add(lblInvenatrio);
            Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInventario";
            ShowIcon = false;
            Text = "formulario Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInvenatrio;
        private Label lblTotalStock;
        private Label lblFechaInventario;
        private Label lblUbicacionStock;
        private DateTimePicker dtpFechaInventario;
        private TextBox txtTotalProductosStock;
        private ComboBox cboUbicacionStock;
        private Label lblIdArea;
        private Label lblNombreAreas;
        private Label lblNombreResponsable;
        private TextBox txtNombreAreaI;
        private TextBox txtNombreResponsableI;
        private Label TotalProductosStock;
        private ComboBox cboIdAreaEmpresa;
    }
}