namespace VistaForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNIJefe = new System.Windows.Forms.TextBox();
            this.textApellidoJefe = new System.Windows.Forms.TextBox();
            this.txtNombreJefe = new System.Windows.Forms.TextBox();
            this.cmbDepartamentoOficina = new System.Windows.Forms.ComboBox();
            this.nudPisoOficina = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtLegajoEmpleado = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.nudPiso = new System.Windows.Forms.NumericUpDown();
            this.btnCrearOficina = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPisoOficina)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpIngreso);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDNIJefe);
            this.groupBox1.Controls.Add(this.textApellidoJefe);
            this.groupBox1.Controls.Add(this.txtNombreJefe);
            this.groupBox1.Controls.Add(this.cmbDepartamentoOficina);
            this.groupBox1.Controls.Add(this.nudPisoOficina);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DatosOficina";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Piso";
            // 
            // txtDNIJefe
            // 
            this.txtDNIJefe.Location = new System.Drawing.Point(87, 136);
            this.txtDNIJefe.Name = "txtDNIJefe";
            this.txtDNIJefe.Size = new System.Drawing.Size(190, 20);
            this.txtDNIJefe.TabIndex = 5;
            // 
            // textApellidoJefe
            // 
            this.textApellidoJefe.Location = new System.Drawing.Point(87, 110);
            this.textApellidoJefe.Name = "textApellidoJefe";
            this.textApellidoJefe.Size = new System.Drawing.Size(190, 20);
            this.textApellidoJefe.TabIndex = 4;
            // 
            // txtNombreJefe
            // 
            this.txtNombreJefe.Location = new System.Drawing.Point(87, 84);
            this.txtNombreJefe.Name = "txtNombreJefe";
            this.txtNombreJefe.Size = new System.Drawing.Size(190, 20);
            this.txtNombreJefe.TabIndex = 3;
            // 
            // cmbDepartamentoOficina
            // 
            this.cmbDepartamentoOficina.FormattingEnabled = true;
            this.cmbDepartamentoOficina.Location = new System.Drawing.Point(87, 56);
            this.cmbDepartamentoOficina.Name = "cmbDepartamentoOficina";
            this.cmbDepartamentoOficina.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartamentoOficina.TabIndex = 1;
            this.cmbDepartamentoOficina.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nudPisoOficina
            // 
            this.nudPisoOficina.Location = new System.Drawing.Point(87, 29);
            this.nudPisoOficina.Name = "nudPisoOficina";
            this.nudPisoOficina.Size = new System.Drawing.Size(120, 20);
            this.nudPisoOficina.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtNombreEmpleado);
            this.groupBox2.Controls.Add(this.txtApellidoEmpleado);
            this.groupBox2.Controls.Add(this.txtLegajoEmpleado);
            this.groupBox2.Controls.Add(this.cmbDepartamento);
            this.groupBox2.Controls.Add(this.nudPiso);
            this.groupBox2.Location = new System.Drawing.Point(379, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DatosEmpleado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Apellido";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Legajo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Piso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Departamento";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(81, 29);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(166, 20);
            this.txtNombreEmpleado.TabIndex = 6;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(80, 57);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(167, 20);
            this.txtApellidoEmpleado.TabIndex = 7;
            // 
            // txtLegajoEmpleado
            // 
            this.txtLegajoEmpleado.Location = new System.Drawing.Point(81, 84);
            this.txtLegajoEmpleado.Name = "txtLegajoEmpleado";
            this.txtLegajoEmpleado.Size = new System.Drawing.Size(166, 20);
            this.txtLegajoEmpleado.TabIndex = 8;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(82, 137);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartamento.TabIndex = 3;
            // 
            // nudPiso
            // 
            this.nudPiso.Location = new System.Drawing.Point(82, 111);
            this.nudPiso.Name = "nudPiso";
            this.nudPiso.Size = new System.Drawing.Size(120, 20);
            this.nudPiso.TabIndex = 1;
            // 
            // btnCrearOficina
            // 
            this.btnCrearOficina.Location = new System.Drawing.Point(12, 225);
            this.btnCrearOficina.Name = "btnCrearOficina";
            this.btnCrearOficina.Size = new System.Drawing.Size(109, 44);
            this.btnCrearOficina.TabIndex = 2;
            this.btnCrearOficina.Text = "Crear Oficina";
            this.btnCrearOficina.UseVisualStyleBackColor = true;
            this.btnCrearOficina.Click += new System.EventHandler(this.btnCrearOficina_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(242, 225);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(109, 44);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(624, 225);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 44);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 276);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(745, 153);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(87, 165);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpIngreso.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 441);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCrearOficina);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPisoOficina)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNIJefe;
        private System.Windows.Forms.TextBox textApellidoJefe;
        private System.Windows.Forms.TextBox txtNombreJefe;
        private System.Windows.Forms.ComboBox cmbDepartamentoOficina;
        private System.Windows.Forms.NumericUpDown nudPisoOficina;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtLegajoEmpleado;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.NumericUpDown nudPiso;
        private System.Windows.Forms.Button btnCrearOficina;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
    }
}

