@ModelType MvcApplication1.place

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>place</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Name)
    </div>
</fieldset>
<p>
    @Html.ActionLink("Add Comment", "Create", "Comment", New With {.PlaceId = Model.Id}, Nothing) |
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}) 

    <br /><br />
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
