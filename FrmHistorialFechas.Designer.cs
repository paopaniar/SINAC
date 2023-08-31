
namespace SINAC
{
    partial class FrmHistorialFechas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SP_HistorialReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSHistorialFechas = new SINAC.DSHistorialFechas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SP_HistorialReporteTableAdapter = new SINAC.DSHistorialFechasTableAdapters.SP_HistorialReporteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_HistorialReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSHistorialFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_HistorialReporteBindingSource
            // 
            this.SP_HistorialReporteBindingSource.DataMember = "SP_HistorialReporte";
            this.SP_HistorialReporteBindingSource.DataSource = this.DSHistorialFechas;
            // 
            // DSHistorialFechas
            // 
            this.DSHistorialFechas.DataSetName = "DSHistorialFechas";
            this.DSHistorialFechas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DSHistorialFechas";
            reportDataSource2.Value = this.SP_HistorialReporteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SINAC.HistorialFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(85, 104);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(643, 334);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SP_HistorialReporteTableAdapter
            // 
            this.SP_HistorialReporteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmHistorialFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmHistorialFechas";
            this.Text = "FrmHistorialFechas";
            this.Load += new System.EventHandler(this.FrmHistorialFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_HistorialReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSHistorialFechas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource SP_HistorialReporteBindingSource;
        private DSHistorialFechas DSHistorialFechas;
        private DSHistorialFechasTableAdapters.SP_HistorialReporteTableAdapter SP_HistorialReporteTableAdapter;
    }
}