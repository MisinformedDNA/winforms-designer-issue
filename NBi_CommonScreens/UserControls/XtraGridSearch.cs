using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace NBi_CommonScreens.UserControls
{
    public partial class XtraGridSearch : DevExpress.XtraEditors.XtraUserControl
    {
        // note: see about making a design time property that defines the grid/gridview that this object is connected to
        GridView _gvLinked;
        string _ParentFormName;

        public XtraGridSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called from the Parent form and used to assign the which external grid will be searched.
        /// </summary>
        /// <param name="FormName"></param>
        /// <param name="aGridView"></param>
        public void LinkGridView(string FormName, GridView aGridView)
        {
            _ParentFormName = FormName;

            _gvLinked = aGridView;
            _gvLinked.DragObjectDrop += new DevExpress.XtraGrid.Views.Base.DragObjectDropEventHandler(SearchGridView_DragObjectDrop);
        }

        // Focus() method for the UserControl
        // sets focus to the search text
        public void Focus()
        {
            txtSearch.Focus();
        }

        /// <summary>
        /// Builds the list of search fields available for selection.
        /// </summary>
        public void LoadSearchFields()
        {
            string CurrentSearchField = "";
            bool foundField = false;

            if (cboSearch.Properties.Items.Count > 0)
            {
                CurrentSearchField = cboSearch.Text.Trim();
            }

            // clear any previously loaded search fields
            cboSearch.Properties.Items.Clear();

            // grab list of 'searchable' fields from the database
            phoenixApplicationSearchFieldTableAdapter.FillActiveByForm(nBi_DataSet.PhoenixApplicationSearchField, _ParentFormName);
            
            if (nBi_DataSet.PhoenixApplicationSearchField != null && nBi_DataSet.PhoenixApplicationSearchField.Rows.Count > 0)
            {
                // loop through all 'searchable' fields
                for (int i = 0; i < nBi_DataSet.PhoenixApplicationSearchField.Rows.Count; i++)
                {
                    // column = attempt to find grid column that matches the field name we have in the database
                    DevExpress.XtraGrid.Columns.GridColumn column = _gvLinked.Columns.ColumnByFieldName(nBi_DataSet.PhoenixApplicationSearchField[i].ActualFieldName);

                    if (column != null)
                    {
                        // is column currently visible?
                        if (column.Visible)
                        {
                            // add FriendlyFieldName to Items collection on the dropdown
                            cboSearch.Properties.Items.Add(nBi_DataSet.PhoenixApplicationSearchField[i].FriendlyFieldName.Trim());
                        }
                    }
                }
            }

            if (CurrentSearchField.Trim() != "")
            {
                // scanning collection of items for our previously selected search field
                for (int i = 0; i < cboSearch.Properties.Items.Count; i++)
                {
                    string fieldName = ((string)cboSearch.Properties.Items[i]);

                    if (fieldName.Trim().ToLower() == CurrentSearchField.Trim().ToLower())
                    {
                        cboSearch.SelectedIndex = i;
                        foundField = true;
                        break;
                    }
                }
            }

            if (!foundField)
            {
                cboSearch.SelectedIndex = 0;
                txtSearch.Text = "";
            }

        }

        // attempt to find matching grid row as they type
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {   
                string CurrentSearchText = txtSearch.Text.Trim().ToLower();
                string actualFieldName = "";
                
                // this sections attempts to determine what the ActualFieldName is that we are searching
                // based on selected field (from dropdown) and contents of SearchField table adapter
                if (nBi_DataSet.PhoenixApplicationSearchField != null && nBi_DataSet.PhoenixApplicationSearchField.Rows.Count > 0)
                {
                    for (int i = 0; i < nBi_DataSet.PhoenixApplicationSearchField.Rows.Count; i++)
                    {                        
                        if (nBi_DataSet.PhoenixApplicationSearchField[i].FriendlyFieldName.Trim().ToLower() == cboSearch.Text.Trim().ToLower())
                        {
                            actualFieldName = nBi_DataSet.PhoenixApplicationSearchField[i].ActualFieldName.Trim();
                            break;
                        }
                    }
                }

                // loop through GridView rows
                for (int i = 0; i < _gvLinked.RowCount; i++)
                {
                    // look to see if appropriate field (on this row) has a match to our search text
                    if (_gvLinked.GetRowCellDisplayText(i, actualFieldName).Trim().ToLower().IndexOf(CurrentSearchText) == 0)
                    {
                        // set currently focused row if match is found
                        _gvLinked.FocusedRowHandle = i;
                        
                        // v3.8.7.0
                        // if a grid is set to multi-select, we also need to force selection of the found row
                        // -also need to clear any previous selections
                        if (_gvLinked.OptionsSelection.MultiSelect)
                        {
                            _gvLinked.ClearSelection();
                            _gvLinked.SelectRow(i);
                        }

                        break;
                    }
                }

            }
            catch 
            { 
            }

        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            vSearchCodeScroll.Value = cboSearch.SelectedIndex;
        }

        // scroll control synched up with SelectedIndex of the dropdown
        private void vSearchCodeScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type != ScrollEventType.EndScroll)
            {
                if (e.Type == ScrollEventType.SmallDecrement && cboSearch.SelectedIndex > 0)
                {
                    cboSearch.SelectedIndex = cboSearch.SelectedIndex - 1;
                }
                else if (e.Type == ScrollEventType.SmallIncrement && cboSearch.SelectedIndex < cboSearch.Properties.Items.Count - 1)
                {
                    cboSearch.SelectedIndex = cboSearch.SelectedIndex + 1;
                    e.NewValue = cboSearch.SelectedIndex;
                }
                else if (e.Type == ScrollEventType.SmallIncrement)
                {
                    e.NewValue = cboSearch.Properties.Items.Count - 1;
                }
            }
        }


        private void SearchGridView_DragObjectDrop(object sender, DevExpress.XtraGrid.Views.Base.DragObjectDropEventArgs e)
        {
            try
            {
                LoadSearchFields();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error - Loading Search Fields", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
        }

    }



}
