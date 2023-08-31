
namespace SINAC
{
    partial class Facturación
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSFacturapdf = new SINAC.DSFacturapdf();
            this.PA_SeleccionarReservaPorUsuarioIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PA_SeleccionarReservaPorUsuarioIdTableAdapter = new SINAC.DSFacturapdfTableAdapters.PA_SeleccionarReservaPorUsuarioIdTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DSFacturapdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_SeleccionarReservaPorUsuarioIdBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSFactura";
            reportDataSource1.Value = this.PA_SeleccionarReservaPorUsuarioIdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SINAC.FacturaPDF.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSFacturapdf
            // 
            this.DSFacturapdf.DataSetName = "DSFacturapdf";
            this.DSFacturapdf.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_SeleccionarReservaPorUsuarioIdBindingSource
            // 
            this.PA_SeleccionarReservaPorUsuarioIdBindingSource.DataMember = "PA_SeleccionarReservaPorUsuarioId";
            this.PA_SeleccionarReservaPorUsuarioIdBindingSource.DataSource = this.DSFacturapdf;
            // 
            // PA_SeleccionarReservaPorUsuarioIdTableAdapter
            // 
            this.PA_SeleccionarReservaPorUsuarioIdTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generar PDF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Facturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Facturación";
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSFacturapdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_SeleccionarReservaPorUsuarioIdBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PA_SeleccionarReservaPorUsuarioIdBindingSource;
        private DSFacturapdf DSFacturapdf;
        private DSFacturapdfTableAdapters.PA_SeleccionarReservaPorUsuarioIdTableAdapter PA_SeleccionarReservaPorUsuarioIdTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}