@page
@model IEnumerable<ApplicationUser>

<h2>Users</h2>

<table class="table table-bordered table-sm">
    @foreach (var user in Model)
    {
        <tr class="">
            <td class="col-6">
                <a asp-controller="Admin" asp-action="UpdateUser" asp-route-Id="@user.Id">@user.FullName</a>
            </td>

            @if (Context.User.IsInRole("Admin"))
            {
                <td class="col-auto">
                    <a class="btn btn-sm btn-primary" asp-controller="Admin" asp-action="UpdateUser" asp-route-Id="@user.Id">Update</a>
                </td>
                <td class="col-auto">
                    <a class="btn btn-sm btn-danger" asp-controller="Admin" asp-action="DeleteUser" asp-route-Id="@user.Id">Delete</a>
                </td>
            }

        </tr>
    }
</table>