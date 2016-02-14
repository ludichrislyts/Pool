@ModelType MvcApplication1.User

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>User</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.email)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.email)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.password)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.password)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Place.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Place.name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Avatar.image)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Avatar.image)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Badge.image)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Badge.image)
    </div>
</fieldset>
@Using Html.BeginForm()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
