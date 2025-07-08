namespace Clase7
{
    partial class frmPrincipal
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
            lblGestionAreadelaEmpresa = new Label();
            lblIdArea = new Label();
            lblNombredelArea = new Label();
            lblResponsabledelArea = new Label();
            txtIdArea = new TextBox();
            txtResponsabledelArea = new TextBox();
            btnCreateAreasEmpresas = new Button();
            btnUpdateAreadeempresas = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            btnGestionarPersonas = new Button();
            tabControl = new TabControl();
            tabPageAreasEmpresas = new TabPage();
            grdAreasEmpresas = new DataGridView();
            lblInventarioEmpresa = new TabPage();
            lblInventarioEmpresaa = new Label();
            btnGestionarInventario = new Button();
            tabPageProduccion = new TabPage();
            tabPageMercadeo = new TabPage();
            tabPageFinanzas = new TabPage();
            cboNombreArea = new ComboBox();
            tabControl.SuspendLayout();
            tabPageAreasEmpresas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdAreasEmpresas).BeginInit();
            lblInventarioEmpresa.SuspendLayout();
            SuspendLayout();
            // 
            // lblGestionAreadelaEmpresa
            // 
            lblGestionAreadelaEmpresa.AutoSize = true;
            lblGestionAreadelaEmpresa.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionAreadelaEmpresa.Location = new Point(32, 17);
            lblGestionAreadelaEmpresa.Name = "lblGestionAreadelaEmpresa";
            lblGestionAreadelaEmpresa.Size = new Size(174, 14);
            lblGestionAreadelaEmpresa.TabIndex = 0;
            lblGestionAreadelaEmpresa.Text = " Gestion Area de la Empresa";
            // 
            // lblIdArea
            // 
            lblIdArea.AutoSize = true;
            lblIdArea.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdArea.Location = new Point(64, 65);
            lblIdArea.Name = "lblIdArea";
            lblIdArea.Size = new Size(50, 14);
            lblIdArea.TabIndex = 1;
            lblIdArea.Text = "Id Area";
            // 
            // lblNombredelArea
            // 
            lblNombredelArea.AutoSize = true;
            lblNombredelArea.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombredelArea.Location = new Point(64, 103);
            lblNombredelArea.Name = "lblNombredelArea";
            lblNombredelArea.Size = new Size(108, 14);
            lblNombredelArea.TabIndex = 2;
            lblNombredelArea.Text = "Nombre del Area";
            // 
            // lblResponsabledelArea
            // 
            lblResponsabledelArea.AutoSize = true;
            lblResponsabledelArea.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponsabledelArea.Location = new Point(64, 147);
            lblResponsabledelArea.Name = "lblResponsabledelArea";
            lblResponsabledelArea.Size = new Size(136, 14);
            lblResponsabledelArea.TabIndex = 3;
            lblResponsabledelArea.Text = "Responsable del Area";
            // 
            // txtIdArea
            // 
            txtIdArea.Enabled = false;
            txtIdArea.Location = new Point(189, 56);
            txtIdArea.Name = "txtIdArea";
            txtIdArea.Size = new Size(100, 23);
            txtIdArea.TabIndex = 4;
            // 
            // txtResponsabledelArea
            // 
            txtResponsabledelArea.Location = new Point(206, 143);
            txtResponsabledelArea.Name = "txtResponsabledelArea";
            txtResponsabledelArea.Size = new Size(140, 23);
            txtResponsabledelArea.TabIndex = 6;
            // 
            // btnCreateAreasEmpresas
            // 
            btnCreateAreasEmpresas.BackColor = Color.FromArgb(128, 255, 128);
            btnCreateAreasEmpresas.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAreasEmpresas.ForeColor = SystemColors.ActiveCaptionText;
            btnCreateAreasEmpresas.Image = Properties.Resources.imgBotonGuardar;
            btnCreateAreasEmpresas.ImageAlign = ContentAlignment.TopCenter;
            btnCreateAreasEmpresas.Location = new Point(64, 172);
            btnCreateAreasEmpresas.Name = "btnCreateAreasEmpresas";
            btnCreateAreasEmpresas.Size = new Size(65, 59);
            btnCreateAreasEmpresas.TabIndex = 7;
            btnCreateAreasEmpresas.Text = "Create";
            btnCreateAreasEmpresas.TextAlign = ContentAlignment.BottomCenter;
            btnCreateAreasEmpresas.UseVisualStyleBackColor = false;
            btnCreateAreasEmpresas.Click += btnCreateAreasEmpresas_Click;
            // 
            // btnUpdateAreadeempresas
            // 
            btnUpdateAreadeempresas.BackColor = Color.FromArgb(255, 255, 128);
            btnUpdateAreadeempresas.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAreadeempresas.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdateAreadeempresas.Image = Properties.Resources.imgBotonActualizar;
            btnUpdateAreadeempresas.ImageAlign = ContentAlignment.TopCenter;
            btnUpdateAreadeempresas.Location = new Point(234, 172);
            btnUpdateAreadeempresas.Name = "btnUpdateAreadeempresas";
            btnUpdateAreadeempresas.Size = new Size(66, 59);
            btnUpdateAreadeempresas.TabIndex = 8;
            btnUpdateAreadeempresas.Text = "Update";
            btnUpdateAreadeempresas.TextAlign = ContentAlignment.BottomCenter;
            btnUpdateAreadeempresas.UseVisualStyleBackColor = false;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.MediumTurquoise;
            btnRead.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.ForeColor = SystemColors.ActiveCaptionText;
            btnRead.Image = Properties.Resources.imgBotonLeer;
            btnRead.ImageAlign = ContentAlignment.TopCenter;
            btnRead.Location = new Point(147, 172);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(62, 59);
            btnRead.TabIndex = 9;
            btnRead.Text = "Read";
            btnRead.TextAlign = ContentAlignment.BottomCenter;
            btnRead.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Image = Properties.Resources.imgBotonEliminar;
            btnDelete.ImageAlign = ContentAlignment.TopCenter;
            btnDelete.Location = new Point(319, 172);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(58, 59);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnGestionarPersonas
            // 
            btnGestionarPersonas.BackColor = Color.FromArgb(255, 192, 255);
            btnGestionarPersonas.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionarPersonas.ForeColor = Color.Black;
            btnGestionarPersonas.Image = Properties.Resources.imgBotonPersonas;
            btnGestionarPersonas.ImageAlign = ContentAlignment.TopCenter;
            btnGestionarPersonas.Location = new Point(553, 65);
            btnGestionarPersonas.Name = "btnGestionarPersonas";
            btnGestionarPersonas.Size = new Size(101, 88);
            btnGestionarPersonas.TabIndex = 11;
            btnGestionarPersonas.Text = "Gestionar personas";
            btnGestionarPersonas.UseVisualStyleBackColor = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageAreasEmpresas);
            tabControl.Controls.Add(lblInventarioEmpresa);
            tabControl.Controls.Add(tabPageProduccion);
            tabControl.Controls.Add(tabPageMercadeo);
            tabControl.Controls.Add(tabPageFinanzas);
            tabControl.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(43, 237);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(712, 247);
            tabControl.TabIndex = 12;
            // 
            // tabPageAreasEmpresas
            // 
            tabPageAreasEmpresas.Controls.Add(grdAreasEmpresas);
            tabPageAreasEmpresas.Location = new Point(4, 23);
            tabPageAreasEmpresas.Name = "tabPageAreasEmpresas";
            tabPageAreasEmpresas.Padding = new Padding(3);
            tabPageAreasEmpresas.Size = new Size(704, 220);
            tabPageAreasEmpresas.TabIndex = 0;
            tabPageAreasEmpresas.Text = "Areas Empresas";
            tabPageAreasEmpresas.UseVisualStyleBackColor = true;
            // 
            // grdAreasEmpresas
            // 
            grdAreasEmpresas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdAreasEmpresas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAreasEmpresas.Location = new Point(23, 24);
            grdAreasEmpresas.Name = "grdAreasEmpresas";
            grdAreasEmpresas.Size = new Size(645, 176);
            grdAreasEmpresas.TabIndex = 0;
            grdAreasEmpresas.SelectionChanged += grdAreasEmpresas_SelectionChanged;
            // 
            // lblInventarioEmpresa
            // 
            lblInventarioEmpresa.Controls.Add(lblInventarioEmpresaa);
            lblInventarioEmpresa.Controls.Add(btnGestionarInventario);
            lblInventarioEmpresa.Location = new Point(4, 23);
            lblInventarioEmpresa.Name = "lblInventarioEmpresa";
            lblInventarioEmpresa.Padding = new Padding(3);
            lblInventarioEmpresa.Size = new Size(704, 220);
            lblInventarioEmpresa.TabIndex = 1;
            lblInventarioEmpresa.Text = "Inventario";
            lblInventarioEmpresa.UseVisualStyleBackColor = true;
            // 
            // lblInventarioEmpresaa
            // 
            lblInventarioEmpresaa.AutoSize = true;
            lblInventarioEmpresaa.Font = new Font("Rockwell", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventarioEmpresaa.Location = new Point(28, 26);
            lblInventarioEmpresaa.Name = "lblInventarioEmpresaa";
            lblInventarioEmpresaa.Size = new Size(168, 15);
            lblInventarioEmpresaa.TabIndex = 1;
            lblInventarioEmpresaa.Text = "Inventario de la Empresa";
            // 
            // btnGestionarInventario
            // 
            btnGestionarInventario.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionarInventario.Location = new Point(68, 52);
            btnGestionarInventario.Name = "btnGestionarInventario";
            btnGestionarInventario.Size = new Size(146, 23);
            btnGestionarInventario.TabIndex = 0;
            btnGestionarInventario.Text = "Gestionar Inventario";
            btnGestionarInventario.UseVisualStyleBackColor = true;
            btnGestionarInventario.Click += btnGestionarInventario_Click;
            // 
            // tabPageProduccion
            // 
            tabPageProduccion.Location = new Point(4, 23);
            tabPageProduccion.Name = "tabPageProduccion";
            tabPageProduccion.Size = new Size(704, 220);
            tabPageProduccion.TabIndex = 2;
            tabPageProduccion.Text = "Produccion";
            tabPageProduccion.UseVisualStyleBackColor = true;
            // 
            // tabPageMercadeo
            // 
            tabPageMercadeo.Location = new Point(4, 23);
            tabPageMercadeo.Name = "tabPageMercadeo";
            tabPageMercadeo.Size = new Size(704, 220);
            tabPageMercadeo.TabIndex = 3;
            tabPageMercadeo.Text = "Mercadeo";
            tabPageMercadeo.UseVisualStyleBackColor = true;
            // 
            // tabPageFinanzas
            // 
            tabPageFinanzas.Location = new Point(4, 23);
            tabPageFinanzas.Name = "tabPageFinanzas";
            tabPageFinanzas.Size = new Size(704, 220);
            tabPageFinanzas.TabIndex = 4;
            tabPageFinanzas.Text = "Finanzas";
            tabPageFinanzas.UseVisualStyleBackColor = true;
            // 
            // cboNombreArea
            // 
            cboNombreArea.FormattingEnabled = true;
            cboNombreArea.Location = new Point(206, 99);
            cboNombreArea.Name = "cboNombreArea";
            cboNombreArea.Size = new Size(121, 23);
            cboNombreArea.TabIndex = 13;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(cboNombreArea);
            Controls.Add(tabControl);
            Controls.Add(btnGestionarPersonas);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnUpdateAreadeempresas);
            Controls.Add(btnCreateAreasEmpresas);
            Controls.Add(txtResponsabledelArea);
            Controls.Add(txtIdArea);
            Controls.Add(lblResponsabledelArea);
            Controls.Add(lblNombredelArea);
            Controls.Add(lblIdArea);
            Controls.Add(lblGestionAreadelaEmpresa);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proyecto aula ";
            Load += frmPrincipal_Load;
            tabControl.ResumeLayout(false);
            tabPageAreasEmpresas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdAreasEmpresas).EndInit();
            lblInventarioEmpresa.ResumeLayout(false);
            lblInventarioEmpresa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGestionAreadelaEmpresa;
        private Label lblIdArea;
        private Label lblNombredelArea;
        private Label lblResponsabledelArea;
        private TextBox txtIdArea;
        private TextBox txtResponsabledelArea;
        private Button btnCreateAreasEmpresas;
        private Button btnUpdateAreadeempresas;
        private Button btnRead;
        private Button btnDelete;
        private Button btnGestionarPersonas;
        private TabControl tabControl;
        private TabPage tabPageAreasEmpresas;
        private TabPage lblInventarioEmpresa;
        private TabPage tabPageProduccion;
        private TabPage tabPageMercadeo;
        private TabPage tabPageFinanzas;
        private DataGridView grdAreasEmpresas;
        private Label lblInventarioEmpresaa;
        private Button btnGestionarInventario;
        private ComboBox cboNombreArea;
    }
}
