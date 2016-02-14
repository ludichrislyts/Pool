@ModelType IEnumerable(Of MvcApplication1.Comment)

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
            @Html.DisplayNameFor(Function(model) model.text)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UserId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Place.name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.text)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.UserId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Place.name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.Id}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.Id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.Id})
        </td>
    </tr>
Next

</table>
