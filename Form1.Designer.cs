using System;

namespace ConsultarDatos_6._2
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
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lstViewPuntuacion = new System.Windows.Forms.ListView();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.cmbRango = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIdActividad = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblPuntuación = new System.Windows.Forms.Label();
            this.txtIdActividad = new System.Windows.Forms.TextBox();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(14, 16);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(38, 13);
            this.lblTarea.TabIndex = 0;
            this.lblTarea.Text = "Tarea:";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Location = new System.Drawing.Point(195, 16);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(110, 13);
            this.lblRango.TabIndex = 1;
            this.lblRango.Text = "Rango Calificaciones:";
            this.lblRango.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(458, 10);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(387, 486);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lstViewPuntuacion
            // 
            this.lstViewPuntuacion.HideSelection = false;
            this.lstViewPuntuacion.Location = new System.Drawing.Point(17, 65);
            this.lstViewPuntuacion.Name = "lstViewPuntuacion";
            this.lstViewPuntuacion.Size = new System.Drawing.Size(516, 318);
            this.lstViewPuntuacion.TabIndex = 4;
            this.lstViewPuntuacion.UseCompatibleStateImageBehavior = false;
            // 
            // cmbTarea
            // 
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(56, 12);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(121, 21);
            this.cmbTarea.TabIndex = 5;
            this.cmbTarea.SelectedIndexChanged += new System.EventHandler(this.cmbTarea_SelectedIndexChanged);
            // 
            // cmbRango
            // 
            this.cmbRango.FormattingEnabled = true;
            this.cmbRango.Location = new System.Drawing.Point(311, 12);
            this.cmbRango.Name = "cmbRango";
            this.cmbRango.Size = new System.Drawing.Size(121, 21);
            this.cmbRango.TabIndex = 6;
      
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(306, 486);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(469, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblIdActividad
            // 
            this.lblIdActividad.AutoSize = true;
            this.lblIdActividad.Location = new System.Drawing.Point(14, 396);
            this.lblIdActividad.Name = "lblIdActividad";
            this.lblIdActividad.Size = new System.Drawing.Size(68, 13);
            this.lblIdActividad.TabIndex = 9;
            this.lblIdActividad.Text = "ID Actividad:";
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(14, 425);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(60, 13);
            this.lblEstudiante.TabIndex = 10;
            this.lblEstudiante.Text = "Estudiante:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(14, 456);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(54, 13);
            this.lblActividad.TabIndex = 11;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblPuntuación
            // 
            this.lblPuntuación.AutoSize = true;
            this.lblPuntuación.Location = new System.Drawing.Point(14, 486);
            this.lblPuntuación.Name = "lblPuntuación";
            this.lblPuntuación.Size = new System.Drawing.Size(64, 13);
            this.lblPuntuación.TabIndex = 12;
            this.lblPuntuación.Text = "Puntuación:";
            // 
            // txtIdActividad
            // 
            this.txtIdActividad.Location = new System.Drawing.Point(84, 396);
            this.txtIdActividad.Name = "txtIdActividad";
            this.txtIdActividad.Size = new System.Drawing.Size(35, 20);
            this.txtIdActividad.TabIndex = 13;
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(74, 425);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(100, 20);
            this.txtEstudiante.TabIndex = 14;
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(74, 451);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(100, 20);
            this.txtActividad.TabIndex = 15;
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(84, 483);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(40, 20);
            this.txtPuntuacion.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.txtIdActividad);
            this.Controls.Add(this.lblPuntuación);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.lblIdActividad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmbRango);
            this.Controls.Add(this.cmbTarea);
            this.Controls.Add(this.lstViewPuntuacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.lblTarea);
            this.Name = "Form1";
            this.Text = "Puntuaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        private void label2_Click(object sender, EventArgs e)
            {
            throw new NotImplementedException();
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            
            }

        private void cmbTarea_SelectedIndexChanged(object sender, EventArgs e)
            {
            
            Console.WriteLine("cmbTarea_SelectedIndexChanged method was called.");
            }
    


        #endregion
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListView lstViewPuntuacion;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.ComboBox cmbRango;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblIdActividad;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblPuntuación;
        private System.Windows.Forms.TextBox txtIdActividad;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtPuntuacion;
        }
    }

