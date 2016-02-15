@ModelType MvcApplication1.Review

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Review</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.review)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.review)
            @Html.ValidationMessageFor(Function(model) model.review)
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
