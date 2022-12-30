using Microsoft.Maui.Controls;
using Syncfusion.Maui.DataSource;
using Syncfusion.Maui.GridCommon.ScrollAxis;
using Syncfusion.Maui.ListView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class Behavior : Behavior<SfListView>
    {
        SfListView listView;
        protected override void OnAttachedTo(SfListView bindable)
        {
            listView = bindable;

            listView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "DateOfBirth",
                KeySelector = (object obj1) =>
                {
                    var item = (obj1 as Contacts);
                    return item.DateOfBirth.Year;
                },
            });

            this.listView.DataSource.SortDescriptors.Add(new SortDescriptor()
            {
                PropertyName = "DateOfBirth",
                Direction = ListSortDirection.Ascending
            });

            base.OnAttachedTo(bindable);
        }
        protected override void OnDetachingFrom(SfListView bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}
