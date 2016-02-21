@ModelType WebAPI.User

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
    <legend>User</legend>

    @Html.HiddenFor(Function(model) model.Id)

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
        <input type="submit" value="Save" />
    </p>
</fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
