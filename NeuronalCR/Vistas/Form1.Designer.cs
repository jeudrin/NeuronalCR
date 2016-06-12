namespace NeuronalCR
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageBox = new Emgu.CV.UI.ImageBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbIteraciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjustarPesos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCaracter = new System.Windows.Forms.TextBox();
            this.btnRedNeuronal = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnAnalisisCaracteres = new System.Windows.Forms.Button();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(600, 600);
            this.imageBox.TabIndex = 3;
            this.imageBox.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(683, 12);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(119, 23);
            this.btnCargarImagen.TabIndex = 4;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tbIteraciones
            // 
            this.tbIteraciones.Location = new System.Drawing.Point(683, 72);
            this.tbIteraciones.Name = "tbIteraciones";
            this.tbIteraciones.Size = new System.Drawing.Size(119, 20);
            this.tbIteraciones.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Iteraciones";
            // 
            // btnAjustarPesos
            // 
            this.btnAjustarPesos.Location = new System.Drawing.Point(808, 70);
            this.btnAjustarPesos.Name = "btnAjustarPesos";
            this.btnAjustarPesos.Size = new System.Drawing.Size(119, 23);
            this.btnAjustarPesos.TabIndex = 7;
            this.btnAjustarPesos.Text = "Ajustar Pesos";
            this.btnAjustarPesos.UseVisualStyleBackColor = true;
            this.btnAjustarPesos.Click += new System.EventHandler(this.btnAjustarPesos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Caracter";
            // 
            // tbCaracter
            // 
            this.tbCaracter.Location = new System.Drawing.Point(683, 101);
            this.tbCaracter.Name = "tbCaracter";
            this.tbCaracter.Size = new System.Drawing.Size(119, 20);
            this.tbCaracter.TabIndex = 9;
            // 
            // btnRedNeuronal
            // 
            this.btnRedNeuronal.Location = new System.Drawing.Point(808, 99);
            this.btnRedNeuronal.Name = "btnRedNeuronal";
            this.btnRedNeuronal.Size = new System.Drawing.Size(119, 23);
            this.btnRedNeuronal.TabIndex = 10;
            this.btnRedNeuronal.Text = "Red Neuronal";
            this.btnRedNeuronal.UseVisualStyleBackColor = true;
            this.btnRedNeuronal.Click += new System.EventHandler(this.btnRedNeuronal_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(618, 154);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 11;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(808, 12);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(119, 23);
            this.btnFiltro.TabIndex = 12;
            this.btnFiltro.Text = "Filtro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnAnalisisCaracteres
            // 
            this.btnAnalisisCaracteres.Location = new System.Drawing.Point(808, 128);
            this.btnAnalisisCaracteres.Name = "btnAnalisisCaracteres";
            this.btnAnalisisCaracteres.Size = new System.Drawing.Size(119, 23);
            this.btnAnalisisCaracteres.TabIndex = 13;
            this.btnAnalisisCaracteres.Text = "Análisis de Caracteres";
            this.btnAnalisisCaracteres.UseVisualStyleBackColor = true;
            this.btnAnalisisCaracteres.Click += new System.EventHandler(this.btnAnalisisCaracteres_Click);
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(808, 41);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(119, 23);
            this.btnInicializar.TabIndex = 14;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(621, 170);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(306, 442);
            this.tbResultado.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 624);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.btnAnalisisCaracteres);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnRedNeuronal);
            this.Controls.Add(this.tbCaracter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjustarPesos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIteraciones);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.imageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NeuronalCR";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbIteraciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjustarPesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCaracter;
        private System.Windows.Forms.Button btnRedNeuronal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnAnalisisCaracteres;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.TextBox tbResultado;
    }
}

