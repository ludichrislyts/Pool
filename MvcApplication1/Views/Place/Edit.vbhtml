@ModelType MvcApplication1.place

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>place</legend>

        @Html.HiddenFor(Function(model) model.Id)

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Name)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Name)
            @Html.ValidationMessageFor(Function(model) model.Name)
        </div>
        <br />
        <div class="editor-label">
            @Html.LabelFor(Function(model) model.address)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.address)
            @Html.ValidationMessageFor(Function(model) model.address)
        </div>
        <br />
        <div class="editor-label">
            @Html.LabelFor(Function(model) model.city)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.city)
            @Html.ValidationMessageFor(Function(model) model.city)
        </div>
        <br />
        <div class="editor-label">
            @Html.LabelFor(Function(model) model.state)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.state)
            @Html.ValidationMessageFor(Function(model) model.state)
        </div>
        <br />
        <div class="editor-label">
            @Html.LabelFor(Function(model) model.zip)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.zip)
            @Html.ValidationMessageFor(Function(model) model.zip)
        </div>
        <br />
        <div class="editor-label">
            @Html.LabelFor(Function(model) model.phone)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.phone)
            @Html.ValidationMessageFor(Function(model) model.phone)
        </div>
        <br />


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
