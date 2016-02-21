@ModelType WebAPI.Review

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Review</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.review)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.review)
    </div>
</fieldset>
@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
