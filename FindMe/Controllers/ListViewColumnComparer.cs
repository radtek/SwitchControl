using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SwitchControl.Controllers
{
    class ListViewColumnComparer
    {
        public int ColumnIndex { get; set; }

        public ListViewColumnComparer(int columnIndex)
        {
            ColumnIndex = columnIndex;
        }

        public int Compare(object x, object y)
        {
            try
            {
                return String.Compare(
                ((ListViewItem)x).SubItems[ColumnIndex].Text,
                ((ListViewItem)y).SubItems[ColumnIndex].Text);
            }
            catch (Exception) // если вдруг столбец пустой (или что-то пошло не так)
            {
                return 0;
            }
        }
    }
}
