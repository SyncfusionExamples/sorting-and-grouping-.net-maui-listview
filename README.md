# Sorting the list view items along with grouping in .NET MAUI ListView
This example describes how to sort the listview items along with grouping in .NET MAUI.

## Sample

```xaml
<syncfusion:SfListView x:Name="listView" ItemsSource="{Binding Items}" ItemSize="50">
    <syncfusion:SfListView.Behaviors>
        <local:Behavior/>
    </syncfusion:SfListView.Behaviors>
    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>

    <syncfusion:SfListView.GroupHeaderTemplate>
        <DataTemplate>
            <Label Text= "{Binding Key}" Padding="5,0,0,0" VerticalOptions="Center" BackgroundColor="Teal" FontSize="20" FontAttributes="Bold" TextColor="White"/>
        </DataTemplate>
    </syncfusion:SfListView.GroupHeaderTemplate>
</syncfusion:SfListView>

C#:

listView.DataSource!.GroupDescriptors.Add(new GroupDescriptor()
{
    PropertyName = "DateOfBirth",
    KeySelector = (object obj1) =>
    {
        var item = (obj1 as Contacts);
        return item!.DateOfBirth.Year;
    },
});

this.listView.DataSource.SortDescriptors.Add(new SortDescriptor()
{
    PropertyName = "DateOfBirth",
    Direction = ListSortDirection.Ascending
});


class CustomGroupComparer : IComparer<GroupResult>, ISortDirection
{
    public CustomGroupComparer()
    {
        this.SortDirection = ListSortDirection.Ascending;
    }

    public ListSortDirection SortDirection
    {
        get;
        set;
    }

    public int Compare(GroupResult? x, GroupResult? y)
    {
        DateTime xvalue = Convert.ToDateTime(x!.Key);
        DateTime yvalue = Convert.ToDateTime(y!.Key);

        if (xvalue.CompareTo(yvalue) > 0)
            return SortDirection == ListSortDirection.Ascending ? 1 : -1;
        else if (xvalue.CompareTo(yvalue) == -1)
            return SortDirection == ListSortDirection.Ascending ? -1 : 1;
        else
            return 0;
    }
}
```
