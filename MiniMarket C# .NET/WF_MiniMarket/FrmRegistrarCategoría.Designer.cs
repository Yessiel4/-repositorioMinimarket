namespace WF_MiniMarket
{
    partial class FrmRegistrarCategoría
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardarRegistroCategoria = new System.Windows.Forms.Button();
            this.textRegistrarDescripcionCat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textregistrarNombreCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnGuardarRegistroCategoria);
            this.groupBox1.Controls.Add(this.textRegistrarDescripcionCat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textregistrarNombreCat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "registrarCategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "REGISTRAR CATEGORÍA";
            // 
            // BtnGuardarRegistroCategoria
            // 
            this.BtnGuardarRegistroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarRegistroCategoria.Location = new System.Drawing.Point(559, 121);
            this.BtnGuardarRegistroCategoria.Name = "BtnGuardarRegistroCategoria";
            this.BtnGuardarRegistroCategoria.Size = new System.Drawing.Size(150, 44);
            this.BtnGuardarRegistroCategoria.TabIndex = 13;
            this.BtnGuardarRegistroCategoria.Text = "Guardar";
            this.BtnGuardarRegistroCategoria.UseVisualStyleBackColor = true;
            // 
            // textRegistrarDescripcionCat
            // 
            this.textRegistrarDescripcionCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRegistrarDescripcionCat.Location = new System.Drawing.Point(131, 166);
            this.textRegistrarDescripcionCat.Name = "textRegistrarDescripcionCat";
            this.textRegistrarDescripcionCat.Size = new System.Drawing.Size(271, 26);
            this.textRegistrarDescripcionCat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descripción";
            // 
            // textregistrarNombreCat
            // 
            this.textregistrarNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textregistrarNombreCat.Location = new System.Drawing.Point(131, 90);
            this.textregistrarNombreCat.Name = "textregistrarNombreCat";
            this.textregistrarNombreCat.Size = new System.Drawing.Size(198, 26);
            this.textregistrarNombreCat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmRegistrarCategoría
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarCategoría";
            this.Text = "FrmRegistrarCategoría";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardarRegistroCategoria;
        private System.Windows.Forms.TextBox textRegistrarDescripcionCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textregistrarNombreCat;
        private System.Windows.Forms.Label label1;
    }
}