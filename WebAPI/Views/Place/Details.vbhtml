@ModelType WebAPI.Place

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>Place</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.name)
    </div>
</fieldset>


<h2>Reviews</h2>

<table>
    <caption>Reviews</caption>
    <tr>
        <th>Name</th>
        <th>Rating</th>
        <th>Review</th>
    </tr>
    @For Each Item In Model.Reviews
    @<tr>
        <td>@Item.User.name</td>
        <td>@Item.rating</td>
        <td>@Item.review</td>
    </tr>
    Next
</table>

<p>
    @Html.ActionLink("Add Comment", "Create", "Comment", New With {.PlaceId = Model.Id}, Nothing) |
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id})

    <br /><br />
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink("Back to List", "Index")
</p>