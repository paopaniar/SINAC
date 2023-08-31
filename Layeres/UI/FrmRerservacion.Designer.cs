
namespace SINAC.Layeres.UI
{
    partial class FrmRerservacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRerservacion));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTipoParque = new System.Windows.Forms.ComboBox();
            this.dgvRerservaciones = new System.Windows.Forms.DataGridView();
            this.clmArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeb = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clmHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDisponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.TimeS = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centrosDeServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRerservaciones)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(75, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Area por Visitar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(604, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tiempo para reservar";
            // 
            // cboTipoParque
            // 
            this.cboTipoParque.FormattingEnabled = true;
            this.cboTipoParque.Location = new System.Drawing.Point(220, 123);
            this.cboTipoParque.Name = "cboTipoParque";
            this.cboTipoParque.Size = new System.Drawing.Size(121, 21);
            this.cboTipoParque.TabIndex = 16;
            this.cboTipoParque.SelectedIndexChanged += new System.EventHandler(this.cboTipoParque_SelectedIndexChanged);
            // 
            // dgvRerservaciones
            // 
            this.dgvRerservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRerservaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmArea,
            this.TipoArea,
            this.clmWeb,
            this.clmHorario,
            this.clmHoras,
            this.clmPrecio,
            this.clmDisponibilidad,
            this.clmFoto});
            this.dgvRerservaciones.Location = new System.Drawing.Point(16, 181);
            this.dgvRerservaciones.Name = "dgvRerservaciones";
            this.dgvRerservaciones.Size = new System.Drawing.Size(815, 150);
            this.dgvRerservaciones.TabIndex = 18;
            this.dgvRerservaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRerservaciones_CellContentClick);
            this.dgvRerservaciones.SelectionChanged += new System.EventHandler(this.dgvRerservaciones_SelectionChanged);
            // 
            // clmArea
            // 
            this.clmArea.DataPropertyName = "Nombre";
            this.clmArea.HeaderText = "Area";
            this.clmArea.Name = "clmArea";
            this.clmArea.ReadOnly = true;
            // 
            // TipoArea
            // 
            this.TipoArea.DataPropertyName = "Tipo";
            this.TipoArea.HeaderText = "Tipo";
            this.TipoArea.Name = "TipoArea";
            // 
            // clmWeb
            // 
            this.clmWeb.DataPropertyName = "SitioWeb";
            this.clmWeb.HeaderText = "Link";
            this.clmWeb.Name = "clmWeb";
            this.clmWeb.ReadOnly = true;
            this.clmWeb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmWeb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmHorario
            // 
            this.clmHorario.DataPropertyName = "Horario";
            this.clmHorario.HeaderText = "Fechas";
            this.clmHorario.Name = "clmHorario";
            this.clmHorario.ReadOnly = true;
            // 
            // clmHoras
            // 
            this.clmHoras.DataPropertyName = "Hora";
            this.clmHoras.HeaderText = "Horas";
            this.clmHoras.Name = "clmHoras";
            // 
            // clmPrecio
            // 
            this.clmPrecio.DataPropertyName = "Precio";
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            // 
            // clmDisponibilidad
            // 
            this.clmDisponibilidad.DataPropertyName = "Disponibilidad";
            this.clmDisponibilidad.HeaderText = "Disponibles";
            this.clmDisponibilidad.Name = "clmDisponibilidad";
            this.clmDisponibilidad.ReadOnly = true;
            // 
            // clmFoto
            // 
            this.clmFoto.DataPropertyName = "Foto";
            this.clmFoto.HeaderText = "Foto";
            this.clmFoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clmFoto.Name = "clmFoto";
            this.clmFoto.ReadOnly = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAceptar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAceptar.Location = new System.Drawing.Point(271, 337);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(319, 43);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Continuar y ver carrito de compras";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Número de Reserva";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(128, 57);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(40, 20);
            this.txtNumero.TabIndex = 22;
            // 
            // TimeS
            // 
            this.TimeS.AutoSize = true;
            this.TimeS.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimeS.Location = new System.Drawing.Point(655, 75);
            this.TimeS.Name = "TimeS";
            this.TimeS.Size = new System.Drawing.Size(48, 20);
            this.TimeS.TabIndex = 24;
            this.TimeS.Text = "00:00";
            this.TimeS.Click += new System.EventHandler(this.TimeS_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPerfilToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // miPerfilToolStripMenuItem
            // 
            this.miPerfilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("miPerfilToolStripMenuItem.Image")));
            this.miPerfilToolStripMenuItem.Name = "miPerfilToolStripMenuItem";
            this.miPerfilToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.miPerfilToolStripMenuItem.Text = "Mi Perfil";
            this.miPerfilToolStripMenuItem.Click += new System.EventHandler(this.miPerfilToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centrosDeServiciosToolStripMenuItem});
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // centrosDeServiciosToolStripMenuItem
            // 
            this.centrosDeServiciosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("centrosDeServiciosToolStripMenuItem.Image")));
            this.centrosDeServiciosToolStripMenuItem.Name = "centrosDeServiciosToolStripMenuItem";
            this.centrosDeServiciosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centrosDeServiciosToolStripMenuItem.Text = "Centros de Servicios";
            // 
            // FrmRerservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::SINAC.Properties.Resources.siSTEM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(843, 383);
            this.Controls.Add(this.TimeS);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvRerservaciones);
            this.Controls.Add(this.cboTipoParque);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmRerservacion";
            this.Text = "Reservar Cupos";
            this.Load += new System.EventHandler(this.FrmRerservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRerservaciones)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTipoParque;
        private System.Windows.Forms.DataGridView dgvRerservaciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label TimeS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoArea;
        private System.Windows.Forms.DataGridViewLinkColumn clmWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDisponibilidad;
        private System.Windows.Forms.DataGridViewImageColumn clmFoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centrosDeServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPerfilToolStripMenuItem;
    }
}