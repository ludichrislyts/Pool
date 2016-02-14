@ModelType MvcApplication1.Comment

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>Comment</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.text)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.text)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.UserId)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.UserId)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Place.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Place.name)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
