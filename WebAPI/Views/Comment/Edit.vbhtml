@ModelType WebAPI.Comment

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Comment</legend>

        @Html.HiddenFor(Function(model) model.Id)

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.text)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.text)
            @Html.ValidationMessageFor(Function(model) model.text)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.User.name)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.User.name)
            @Html.ValidationMessageFor(Function(model) model.User.name)
        </div>

        @*<div class="editor-label">
            @Html.LabelFor(Function(model) model.PlaceId, "Place")
        </div>
        <div class="editor-field">
            @Html.DropDownList("PlaceId", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.PlaceId)
        </div>*@

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
