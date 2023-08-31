
namespace SINAC.Layeres.UI
{
    partial class FrmComprasReporte
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dSHistorialComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSHistorialCompras = new SINAC.DSHistorialCompras();
            this.tableHistorialComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableHistorialCompras = new SINAC.DSHistorialComprasTableAdapters.TableHistorialCompras();
            ((System.ComponentModel.ISupportInitialize)(this.dSHistorialComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSHistorialCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHistorialComprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DSHistorialCompras";
            reportDataSource1.Value = this.tableHistorialComprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SINAC.HistorialCompras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(42, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(718, 346);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dSHistorialComprasBindingSource
            // 
            this.dSHistorialComprasBindingSource.DataSource = this.dSHistorialCompras;
            this.dSHistorialComprasBindingSource.Position = 0;
            // 
            // dSHistorialCompras
            // 
            this.dSHistorialCompras.DataSetName = "DSHistorialCompras";
            this.dSHistorialCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableHistorialComprasBindingSource
            // 
            this.tableHistorialComprasBindingSource.DataMember = "TableHistorialCompras";
            this.tableHistorialComprasBindingSource.DataSource = this.dSHistorialComprasBindingSource;
            // 
            // tableHistorialCompras
            // 
            this.tableHistorialCompras.ClearBeforeFill = true;
            // 
            // FrmComprasReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmComprasReporte";
            this.Text = "Historial de Compras";
            this.Load += new System.EventHandler(this.FrmComprasReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSHistorialComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSHistorialCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableHistorialComprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSHistorialComprasBindingSource;
        private DSHistorialCompras dSHistorialCompras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource tableHistorialComprasBindingSource;
        private DSHistorialComprasTableAdapters.TableHistorialCompras tableHistorialCompras;
    }
}