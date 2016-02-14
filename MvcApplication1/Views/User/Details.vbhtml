@ModelType MvcApplication1.User

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
        @Html.DisplayNameFor(Function(model) model.Avatar)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Avatar)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
