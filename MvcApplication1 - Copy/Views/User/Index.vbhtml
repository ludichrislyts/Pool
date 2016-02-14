@ModelType IEnumerable(Of MvcApplication1.User)

@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.password)
        </th>       
        <th>
            @Html.DisplayNameFor(Function(model) model.Avatar.image)
        </th>     
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.email)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.password)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Avatar.image)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.Id}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.Id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.Id})
        </td>
    </tr>
Next

</table>
