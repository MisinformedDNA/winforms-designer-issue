namespace NBi_CommonScreens.UserControls
{
    partial class XtraGridSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.phoenixApplicationSearchFieldTableAdapter = new NBi_DataModule.NBi_DataSetTableAdapters.PhoenixApplicationSearchFieldTableAdapter();
            this.nBi_DataSet = new NBi_DataModule.NBi_DataSet();
            this.phoenixApplicationSearchFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBi_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoenixApplicationSearchFieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(125, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // phoenixApplicationSearchFieldTableAdapter
            // 
            this.phoenixApplicationSearchFieldTableAdapter.ClearBeforeFill = true;
            // 
            // nBi_DataSet
            // 
            this.nBi_DataSet.DataSetName = "NBi_DataSet";
            this.nBi_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoenixApplicationSearchFieldBindingSource
            // 
            this.phoenixApplicationSearchFieldBindingSource.DataMember = "PhoenixApplicationSearchField";
            this.phoenixApplicationSearchFieldBindingSource.DataSource = this.nBi_DataSet;
            // 
            // XtraGridSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Name = "XtraGridSearch";
            this.Size = new System.Drawing.Size(305, 20);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBi_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoenixApplicationSearchFieldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private NBi_DataModule.NBi_DataSetTableAdapters.PhoenixApplicationSearchFieldTableAdapter phoenixApplicationSearchFieldTableAdapter;
        private NBi_DataModule.NBi_DataSet nBi_DataSet;
        private System.Windows.Forms.BindingSource phoenixApplicationSearchFieldBindingSource;
    }
}
