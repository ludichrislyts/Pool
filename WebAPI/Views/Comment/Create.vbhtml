@ModelType WebAPI.Comment

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)


    @*@Html.HiddenFor(Function(x) x.Place.Id)*@

    @<fieldset>
        <legend>Comment</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.text)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.text)
            @Html.ValidationMessageFor(Function(model) model.text)
        </div>

        @*<div class="editor-label">
            @Html.LabelFor(Function(model) model.Place, "Place")
        </div>
        <div class="editor-field">
            @Html.DropDownList("PlaceID", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.Place)
        </div>*@

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
