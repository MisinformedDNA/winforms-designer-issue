using System;
using System.Collections;
using System.Collections.Generic;

namespace NBi_DataModule
{
    public partial class NBi_DataSet : global::System.Data.DataSet
    {
        public PhoenixApplicationSearchFieldDataTable PhoenixApplicationSearchField { get; set; }

        public class PhoenixApplicationSearchFieldDataTable : IList<PhoenixApplicationSearchFieldRow>
        {
            public PhoenixApplicationSearchFieldRow this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public List<PhoenixApplicationSearchFieldRow> Rows { get; set; }

            public int Count => throw new NotImplementedException();

            public bool IsReadOnly => throw new NotImplementedException();

            public void Add(PhoenixApplicationSearchFieldRow item)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(PhoenixApplicationSearchFieldRow item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(PhoenixApplicationSearchFieldRow[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<PhoenixApplicationSearchFieldRow> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public int IndexOf(PhoenixApplicationSearchFieldRow item)
            {
                throw new NotImplementedException();
            }

            public void Insert(int index, PhoenixApplicationSearchFieldRow item)
            {
                throw new NotImplementedException();
            }

            public bool Remove(PhoenixApplicationSearchFieldRow item)
            {
                throw new NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }

        public class PhoenixApplicationSearchFieldRow
        {
            public string FriendlyFieldName { get; internal set; }
            public string ActualFieldName { get; internal set; }
        }
    }
}
