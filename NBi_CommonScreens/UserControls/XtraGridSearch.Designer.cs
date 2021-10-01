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
            this.vSearchCodeScroll = new DevExpress.XtraEditors.VScrollBar();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.cboSearch = new DevExpress.XtraEditors.ComboBoxEdit();
            this.phoenixApplicationSearchFieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoenixApplicationSearchFieldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vSearchCodeScroll
            // 
            this.vSearchCodeScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vSearchCodeScroll.Location = new System.Drawing.Point(99, 0);
            this.vSearchCodeScroll.Name = "vSearchCodeScroll";
            this.vSearchCodeScroll.Size = new System.Drawing.Size(20, 20);
            this.vSearchCodeScroll.TabIndex = 148;
            this.vSearchCodeScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vSearchCodeScroll_Scroll);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.EditValue = "f";
            this.txtSearch.Location = new System.Drawing.Point(125, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // cboSearch
            // 
            this.cboSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearch.EditValue = "";
            this.cboSearch.Location = new System.Drawing.Point(0, 0);
            this.cboSearch.Name = "cboSearch";
            // 
            // 
            // 
            this.cboSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSearch.Size = new System.Drawing.Size(119, 20);
            this.cboSearch.TabIndex = 1;
            this.cboSearch.Tag = "";
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // phoenixApplicationSearchFieldBindingSource
            // 
            this.phoenixApplicationSearchFieldBindingSource.DataMember = "PhoenixApplicationSearchField";
            // 
            // XtraGridSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vSearchCodeScroll);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "XtraGridSearch";
            this.Size = new System.Drawing.Size(305, 20);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoenixApplicationSearchFieldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.VScrollBar vSearchCodeScroll;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.ComboBoxEdit cboSearch;
        private NBi_DataModule.NBi_DataSetTableAdapters.PhoenixApplicationSearchFieldTableAdapter phoenixApplicationSearchFieldTableAdapter;
        private NBi_DataModule.NBi_DataSet nBi_DataSet;
        private System.Windows.Forms.BindingSource phoenixApplicationSearchFieldBindingSource;
    }
}
