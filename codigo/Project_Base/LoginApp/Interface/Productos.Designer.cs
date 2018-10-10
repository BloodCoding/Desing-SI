namespace LoginApp.Interface
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardarproductos = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            // 
            // btnguardarproductos
            // 
            this.btnguardarproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnguardarproductos.FlatAppearance.BorderSize = 0;
            this.btnguardarproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnguardarproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarproductos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarproductos.ForeColor = System.Drawing.Color.White;
            this.btnguardarproductos.Image = ((System.Drawing.Image)(resources.GetObject("btnguardarproductos.Image")));
            this.btnguardarproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardarproductos.Location = new System.Drawing.Point(362, 480);
            this.btnguardarproductos.Name = "btnguardarproductos";
            this.btnguardarproductos.Size = new System.Drawing.Size(247, 40);
            this.btnguardarproductos.TabIndex = 2;
            this.btnguardarproductos.Text = "Guardar";
            this.btnguardarproductos.UseVisualStyleBackColor = false;
            this.btnguardarproductos.Click += new System.EventHandler(this.btnguardarproductos_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.AutoSize = true;
            this.btncerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncerrar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btncerrar.Location = new System.Drawing.Point(948, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(24, 24);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Text = "X";
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 339);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(12, 85);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(337, 22);
            this.txtfiltro.TabIndex = 5;
            this.txtfiltro.Text = "FILTRO";
            this.txtfiltro.Enter += new System.EventHandler(this.txtfiltro_Enter);
            this.txtfiltro.Leave += new System.EventHandler(this.txtfiltro_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(81, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar Nuevo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnguardarproductos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardarproductos;
        private System.Windows.Forms.Label btncerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button button1;
    }
}