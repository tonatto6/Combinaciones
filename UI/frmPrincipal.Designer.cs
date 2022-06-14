
namespace UI
{
    partial class frmPrincipal
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidadVariables = new System.Windows.Forms.TextBox();
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.cboLetra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportarTXT = new System.Windows.Forms.Button();
            this.cbo5 = new System.Windows.Forms.ComboBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCombinacionPrincipal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbo4 = new System.Windows.Forms.ComboBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo3 = new System.Windows.Forms.ComboBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCantidadCombinaciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtCantidadVariables);
            this.groupBox1.Controls.Add(this.cboTipoCarga);
            this.groupBox1.Controls.Add(this.cboLetra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de datos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(280, 262);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 36);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidadVariables
            // 
            this.txtCantidadVariables.Location = new System.Drawing.Point(175, 119);
            this.txtCantidadVariables.Name = "txtCantidadVariables";
            this.txtCantidadVariables.Size = new System.Drawing.Size(212, 26);
            this.txtCantidadVariables.TabIndex = 4;
            this.txtCantidadVariables.Text = "1";
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.Items.AddRange(new object[] {
            "Variable",
            "No variable"});
            this.cboTipoCarga.Location = new System.Drawing.Point(175, 183);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(212, 28);
            this.cboTipoCarga.TabIndex = 3;
            this.cboTipoCarga.Text = "Seleccionar";
            // 
            // cboLetra
            // 
            this.cboLetra.FormattingEnabled = true;
            this.cboLetra.Items.AddRange(new object[] {
            "D",
            "W",
            "L",
            "LR",
            "T",
            "F",
            "H",
            "S",
            "R",
            "E"});
            this.cboLetra.Location = new System.Drawing.Point(175, 51);
            this.cboLetra.Name = "cboLetra";
            this.cboLetra.Size = new System.Drawing.Size(212, 28);
            this.cboLetra.TabIndex = 1;
            this.cboLetra.Text = "Seleccionar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de carga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sub estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCantidadCombinaciones);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnExportarTXT);
            this.groupBox2.Controls.Add(this.cbo5);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblCombinacionPrincipal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.cbo4);
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbo3);
            this.groupBox2.Controls.Add(this.txt3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbo2);
            this.groupBox2.Controls.Add(this.txt2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbo1);
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(455, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 683);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear combinaciones";
            // 
            // btnExportarTXT
            // 
            this.btnExportarTXT.BackColor = System.Drawing.Color.LightGray;
            this.btnExportarTXT.FlatAppearance.BorderSize = 0;
            this.btnExportarTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarTXT.Location = new System.Drawing.Point(16, 627);
            this.btnExportarTXT.Name = "btnExportarTXT";
            this.btnExportarTXT.Size = new System.Drawing.Size(227, 36);
            this.btnExportarTXT.TabIndex = 19;
            this.btnExportarTXT.Text = "Exportar resultados a .txt";
            this.btnExportarTXT.UseVisualStyleBackColor = false;
            this.btnExportarTXT.Click += new System.EventHandler(this.btnExportarTXT_Click);
            // 
            // cbo5
            // 
            this.cbo5.FormattingEnabled = true;
            this.cbo5.Location = new System.Drawing.Point(762, 72);
            this.cbo5.Name = "cbo5";
            this.cbo5.Size = new System.Drawing.Size(71, 28);
            this.cbo5.TabIndex = 18;
            this.cbo5.Text = "Elegir";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(696, 74);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(60, 26);
            this.txt5.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(672, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "+";
            // 
            // lblCombinacionPrincipal
            // 
            this.lblCombinacionPrincipal.AutoSize = true;
            this.lblCombinacionPrincipal.Location = new System.Drawing.Point(185, 186);
            this.lblCombinacionPrincipal.Name = "lblCombinacionPrincipal";
            this.lblCombinacionPrincipal.Size = new System.Drawing.Size(14, 20);
            this.lblCombinacionPrincipal.TabIndex = 15;
            this.lblCombinacionPrincipal.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Combinacion principal:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightGray;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(726, 627);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(107, 36);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightGray;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(726, 119);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 36);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(16, 219);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(817, 344);
            this.listBox1.TabIndex = 13;
            // 
            // cbo4
            // 
            this.cbo4.FormattingEnabled = true;
            this.cbo4.Location = new System.Drawing.Point(579, 73);
            this.cbo4.Name = "cbo4";
            this.cbo4.Size = new System.Drawing.Size(71, 28);
            this.cbo4.TabIndex = 12;
            this.cbo4.Text = "Elegir";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(513, 75);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(60, 26);
            this.txt4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "+";
            // 
            // cbo3
            // 
            this.cbo3.FormattingEnabled = true;
            this.cbo3.Location = new System.Drawing.Point(412, 72);
            this.cbo3.Name = "cbo3";
            this.cbo3.Size = new System.Drawing.Size(71, 28);
            this.cbo3.TabIndex = 9;
            this.cbo3.Text = "Elegir";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(346, 74);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(60, 26);
            this.txt3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "+";
            // 
            // cbo2
            // 
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Location = new System.Drawing.Point(249, 70);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(71, 28);
            this.cbo2.TabIndex = 6;
            this.cbo2.Text = "Elegir";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(183, 72);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(60, 26);
            this.txt2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "+";
            // 
            // cbo1
            // 
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Location = new System.Drawing.Point(82, 70);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(71, 28);
            this.cbo1.TabIndex = 3;
            this.cbo1.Text = "Elegir";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(16, 70);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(60, 26);
            this.txt1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 347);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos cargados";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(17, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(380, 284);
            this.listBox2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 590);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cantidad de combinaciones obtenidas:";
            // 
            // lblCantidadCombinaciones
            // 
            this.lblCantidadCombinaciones.AutoSize = true;
            this.lblCantidadCombinaciones.Location = new System.Drawing.Point(301, 590);
            this.lblCantidadCombinaciones.Name = "lblCantidadCombinaciones";
            this.lblCantidadCombinaciones.Size = new System.Drawing.Size(0, 20);
            this.lblCantidadCombinaciones.TabIndex = 21;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 725);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidadVariables;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.ComboBox cboLetra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo4;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo3;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCombinacionPrincipal;
        private System.Windows.Forms.ComboBox cbo5;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExportarTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCantidadCombinaciones;
    }
}