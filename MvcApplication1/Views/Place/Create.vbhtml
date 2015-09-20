@ModelType MvcApplication1.place

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>place</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Name)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Name)
            @Html.ValidationMessageFor(Function(model) model.Name)<br />
            <div class="editor-label">
                @Html.LabelFor(Function(model) model.address)
            </div>
            @Html.EditorFor(Function(model) model.address)
            @Html.ValidationMessageFor(Function(model) model.address)<br />
            <div class="editor-label">
                @Html.LabelFor(Function(model) model.city)
            </div>
            @Html.EditorFor(Function(model) model.city)
            @Html.ValidationMessageFor(Function(model) model.city)<br />
            <div class="editor-label">
                @Html.LabelFor(Function(model) model.state)
            </div>
            @Html.EditorFor(Function(model) model.state)
            @Html.ValidationMessageFor(Function(model) model.state)<br />
            <div class="editor-label">
                @Html.LabelFor(Function(model) model.zip)
            </div>
            @Html.EditorFor(Function(model) model.zip)
            @Html.ValidationMessageFor(Function(model) model.zip)<br />
            <div class="editor-label">
                @Html.LabelFor(Function(model) model.phone)
            </div>
            @Html.EditorFor(Function(model) model.phone)
            @Html.ValidationMessageFor(Function(model) model.phone)

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
