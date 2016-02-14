@ModelType MvcApplication1.place

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>place</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Name)
    </div>
</fieldset>
@Using Html.BeginForm()
    @<p>
        <input type="submit" class="btn-primary" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
