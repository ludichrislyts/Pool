@ModelType MvcApplication1.User

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
    <legend>User</legend>

    <div class="editor-label">
        @Html.LabelFor(Function(model) model.name)
    </div>
    <div class="editor-field">
        @Html.EditorFor(Function(model) model.name)
        @Html.ValidationMessageFor(Function(model) model.name)
    </div>

    <div class="editor-label">
        @Html.LabelFor(Function(model) model.email)
    </div>
    <div class="editor-field">
        @Html.EditorFor(Function(model) model.email)
        @Html.ValidationMessageFor(Function(model) model.email)
    </div>

    <div class="editor-label">
        @Html.LabelFor(Function(model) model.password)
    </div>
    <div class="editor-field">
        @Html.EditorFor(Function(model) model.password)
        @Html.ValidationMessageFor(Function(model) model.password)
    </div>

    <div class="editor-label">
        @Html.LabelFor(Function(model) model.Avatar, "Avatar")
    </div>
    <div class="editor-field">
        @Html.DropDownList("AvatarId", String.Empty)
        @Html.ValidationMessageFor(Function(model) model.Avatar)
    </div>

    <p>
        <input type="submit" value="Create" />
    </p>
</fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section