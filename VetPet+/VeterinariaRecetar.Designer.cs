﻿namespace VetPet_
{
    partial class VeterinariaRecetar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtMedicamentos = new System.Windows.Forms.DataGridView();
            this.columm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAgregarMedicamentos = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtIndicaciones = new System.Windows.Forms.RichTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMedicamentos = new System.Windows.Forms.ComboBox();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtMascota = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMedicamentos
            // 
            this.dtMedicamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columm1,
            this.Column2,
            this.Column3});
            this.dtMedicamentos.EnableHeadersVisualStyles = false;
            this.dtMedicamentos.Location = new System.Drawing.Point(25, 332);
            this.dtMedicamentos.Name = "dtMedicamentos";
            this.dtMedicamentos.RowHeadersVisible = false;
            this.dtMedicamentos.Size = new System.Drawing.Size(576, 218);
            this.dtMedicamentos.TabIndex = 329;
            this.dtMedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMedicamentos_CellClick);
            // 
            // columm1
            // 
            this.columm1.HeaderText = "id";
            this.columm1.Name = "columm1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // rtDiagnostico
            // 
            this.rtDiagnostico.BackColor = System.Drawing.Color.Silver;
            this.rtDiagnostico.Location = new System.Drawing.Point(637, 99);
            this.rtDiagnostico.Name = "rtDiagnostico";
            this.rtDiagnostico.ReadOnly = true;
            this.rtDiagnostico.Size = new System.Drawing.Size(424, 46);
            this.rtDiagnostico.TabIndex = 328;
            this.rtDiagnostico.Text = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.pictureBox3.BackgroundImage = global::VetPet_.Properties.Resources.VeterinariaRecetar;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(543, 280);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 29);
            this.pictureBox3.TabIndex = 326;
            this.pictureBox3.TabStop = false;
            // 
            // btnAgregarMedicamentos
            // 
            this.btnAgregarMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.btnAgregarMedicamentos.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMedicamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnAgregarMedicamentos.Location = new System.Drawing.Point(449, 265);
            this.btnAgregarMedicamentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarMedicamentos.Name = "btnAgregarMedicamentos";
            this.btnAgregarMedicamentos.Size = new System.Drawing.Size(152, 59);
            this.btnAgregarMedicamentos.TabIndex = 325;
            this.btnAgregarMedicamentos.Text = "Agregar";
            this.btnAgregarMedicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMedicamentos.UseVisualStyleBackColor = false;
            this.btnAgregarMedicamentos.Click += new System.EventHandler(this.btnAgregarMedicamentos_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.pictureBox2.BackgroundImage = global::VetPet_.Properties.Resources.VeterinariaAtras;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(984, 507);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 43);
            this.pictureBox2.TabIndex = 324;
            this.pictureBox2.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnRegresar.Location = new System.Drawing.Point(847, 496);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(205, 63);
            this.btnRegresar.TabIndex = 323;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.pictureBox1.BackgroundImage = global::VetPet_.Properties.Resources.VeterinariaGuardar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(772, 503);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 51);
            this.pictureBox1.TabIndex = 322;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(216)))), ((int)(((byte)(177)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.btnGuardar.Location = new System.Drawing.Point(634, 496);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(205, 63);
            this.btnGuardar.TabIndex = 321;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(305, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 319;
            this.label1.Text = "Raza";
            // 
            // rtIndicaciones
            // 
            this.rtIndicaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.rtIndicaciones.Location = new System.Drawing.Point(637, 194);
            this.rtIndicaciones.Name = "rtIndicaciones";
            this.rtIndicaciones.Size = new System.Drawing.Size(423, 282);
            this.rtIndicaciones.TabIndex = 318;
            this.rtIndicaciones.Text = "";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label24.Location = new System.Drawing.Point(639, 166);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(133, 25);
            this.label24.TabIndex = 317;
            this.label24.Text = "Indicaciones ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label14.Location = new System.Drawing.Point(639, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 25);
            this.label14.TabIndex = 310;
            this.label14.Text = "Diagnostico";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label11.Location = new System.Drawing.Point(245, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 25);
            this.label11.TabIndex = 307;
            this.label11.Text = "Temperatura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label9.Location = new System.Drawing.Point(52, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 306;
            this.label9.Text = "Peso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label8.Location = new System.Drawing.Point(24, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 305;
            this.label8.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label6.Location = new System.Drawing.Point(28, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 304;
            this.label6.Text = "Especie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label5.Location = new System.Drawing.Point(306, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 303;
            this.label5.Text = "Dueño";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label16.Location = new System.Drawing.Point(485, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 37);
            this.label16.TabIndex = 302;
            this.label16.Text = "Recetar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 301;
            this.label2.Text = "Mascota";
            // 
            // cbMedicamentos
            // 
            this.cbMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.cbMedicamentos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicamentos.FormattingEnabled = true;
            this.cbMedicamentos.Location = new System.Drawing.Point(33, 287);
            this.cbMedicamentos.Name = "cbMedicamentos";
            this.cbMedicamentos.Size = new System.Drawing.Size(179, 29);
            this.cbMedicamentos.TabIndex = 331;
            // 
            // nupCantidad
            // 
            this.nupCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(234)))), ((int)(((byte)(216)))));
            this.nupCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantidad.Location = new System.Drawing.Point(268, 287);
            this.nupCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(120, 29);
            this.nupCantidad.TabIndex = 333;
            this.nupCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label3.Location = new System.Drawing.Point(42, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 334;
            this.label3.Text = "Medicamentos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label4.Location = new System.Drawing.Point(276, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 335;
            this.label4.Text = "Cantidad";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Silver;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(386, 72);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(171, 29);
            this.txtNombre.TabIndex = 380;
            // 
            // txtRaza
            // 
            this.txtRaza.BackColor = System.Drawing.Color.Silver;
            this.txtRaza.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaza.Location = new System.Drawing.Point(369, 118);
            this.txtRaza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.ReadOnly = true;
            this.txtRaza.Size = new System.Drawing.Size(171, 29);
            this.txtRaza.TabIndex = 385;
            // 
            // txtMascota
            // 
            this.txtMascota.BackColor = System.Drawing.Color.Silver;
            this.txtMascota.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMascota.Location = new System.Drawing.Point(118, 72);
            this.txtMascota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.ReadOnly = true;
            this.txtMascota.Size = new System.Drawing.Size(171, 29);
            this.txtMascota.TabIndex = 386;
            // 
            // txtEspecie
            // 
            this.txtEspecie.BackColor = System.Drawing.Color.Silver;
            this.txtEspecie.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecie.Location = new System.Drawing.Point(115, 120);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.ReadOnly = true;
            this.txtEspecie.Size = new System.Drawing.Size(171, 29);
            this.txtEspecie.TabIndex = 387;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.BackColor = System.Drawing.Color.Silver;
            this.txtTemperatura.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatura.Location = new System.Drawing.Point(377, 162);
            this.txtTemperatura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.ReadOnly = true;
            this.txtTemperatura.Size = new System.Drawing.Size(99, 29);
            this.txtTemperatura.TabIndex = 389;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.Silver;
            this.txtPeso.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(115, 162);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(86, 29);
            this.txtPeso.TabIndex = 388;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.Silver;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(96, 210);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(128, 29);
            this.txtFecha.TabIndex = 390;
            // 
            // VeterinariaRecetar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(219)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1082, 577);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtMascota);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.cbMedicamentos);
            this.Controls.Add(this.dtMedicamentos);
            this.Controls.Add(this.rtDiagnostico);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnAgregarMedicamentos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtIndicaciones);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Name = "VeterinariaRecetar";
            this.Text = "VeterinariaRecetar";
            this.Load += new System.EventHandler(this.VeterinariaRecetar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMedicamentos;
        private System.Windows.Forms.RichTextBox rtDiagnostico;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAgregarMedicamentos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtIndicaciones;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMedicamentos;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtMascota;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn columm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtFecha;
    }
}