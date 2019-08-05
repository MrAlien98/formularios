namespace formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grid = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumb = new System.Windows.Forms.TextBox();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.butLoad = new System.Windows.Forms.Button();
            this.butAddField = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.BackgroundImage")));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.grid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.butLoad);
            this.splitContainer1.Panel2.Controls.Add(this.butAddField);
            this.splitContainer1.Panel2.Controls.Add(this.butSave);
            this.splitContainer1.Size = new System.Drawing.Size(313, 462);
            this.splitContainer1.SplitterDistance = 405;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainer1_SplitterMoved);
            // 
            // grid
            // 
            this.grid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grid.BackgroundImage")));
            this.grid.Controls.Add(this.label1);
            this.grid.Controls.Add(this.label2);
            this.grid.Controls.Add(this.txtNumb);
            this.grid.Controls.Add(this.txtBuildingName);
            this.grid.Location = new System.Drawing.Point(4, 4);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(306, 398);
            this.grid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edificio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(144, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de grifos";
            // 
            // txtNumb
            // 
            this.txtNumb.Location = new System.Drawing.Point(55, 22);
            this.txtNumb.Name = "txtNumb";
            this.txtNumb.Size = new System.Drawing.Size(83, 20);
            this.txtNumb.TabIndex = 3;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(237, 22);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(60, 20);
            this.txtBuildingName.TabIndex = 2;
            // 
            // butLoad
            // 
            this.butLoad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butLoad.Location = new System.Drawing.Point(221, 21);
            this.butLoad.Name = "butLoad";
            this.butLoad.Size = new System.Drawing.Size(75, 23);
            this.butLoad.TabIndex = 2;
            this.butLoad.Text = "Cargar";
            this.butLoad.UseVisualStyleBackColor = false;
            this.butLoad.Click += new System.EventHandler(this.ButLoad_Click);
            // 
            // butAddField
            // 
            this.butAddField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butAddField.Location = new System.Drawing.Point(113, 21);
            this.butAddField.Name = "butAddField";
            this.butAddField.Size = new System.Drawing.Size(92, 23);
            this.butAddField.TabIndex = 1;
            this.butAddField.Text = "Agregar Campo";
            this.butAddField.UseVisualStyleBackColor = false;
            this.butAddField.Click += new System.EventHandler(this.ButAddField_Click);
            // 
            // butSave
            // 
            this.butSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butSave.Location = new System.Drawing.Point(12, 21);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Guardar";
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(313, 462);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FORMULARIO GRIFOS ICESI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grid.ResumeLayout(false);
            this.grid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button butLoad;
        private System.Windows.Forms.Button butAddField;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Panel grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumb;
        private System.Windows.Forms.TextBox txtBuildingName;
    }
}

