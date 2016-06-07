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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjustarPesos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCaracter = new System.Windows.Forms.TextBox();
            this.btnRedNeuronal = new System.Windows.Forms.Button();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(360, 414);
            this.imageBox.TabIndex = 3;
            this.imageBox.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(77, 433);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(100, 23);
            this.btnCargarImagen.TabIndex = 4;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 462);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Iteraciones";
            // 
            // btnAjustarPesos
            // 
            this.btnAjustarPesos.Location = new System.Drawing.Point(183, 460);
            this.btnAjustarPesos.Name = "btnAjustarPesos";
            this.btnAjustarPesos.Size = new System.Drawing.Size(100, 23);
            this.btnAjustarPesos.TabIndex = 7;
            this.btnAjustarPesos.Text = "Ajustar Pesos";
            this.btnAjustarPesos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Caracter";
            // 
            // tbCaracter
            // 
            this.tbCaracter.Location = new System.Drawing.Point(77, 488);
            this.tbCaracter.Name = "tbCaracter";
            this.tbCaracter.Size = new System.Drawing.Size(100, 20);
            this.tbCaracter.TabIndex = 9;
            // 
            // btnRedNeuronal
            // 
            this.btnRedNeuronal.Location = new System.Drawing.Point(183, 486);
            this.btnRedNeuronal.Name = "btnRedNeuronal";
            this.btnRedNeuronal.Size = new System.Drawing.Size(100, 23);
            this.btnRedNeuronal.TabIndex = 10;
            this.btnRedNeuronal.Text = "Red Neuronal";
            this.btnRedNeuronal.UseVisualStyleBackColor = true;
            this.btnRedNeuronal.Click += new System.EventHandler(this.btnRedNeuronal_Click);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(290, 491);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(0, 13);
            this.lblPorcentaje.TabIndex = 11;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(183, 433);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(100, 23);
            this.btnFiltro.TabIndex = 12;
            this.btnFiltro.Text = "Filtro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 597);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.btnRedNeuronal);
            this.Controls.Add(this.tbCaracter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjustarPesos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjustarPesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCaracter;
        private System.Windows.Forms.Button btnRedNeuronal;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Button btnFiltro;
    }
}

