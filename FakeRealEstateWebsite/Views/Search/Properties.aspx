<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<FakeRealEstateWebsite.Models.property>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Properties
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Properties</h2>

<fieldset>
    <legend>property</legend>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.prop_type) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.prop_type) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.prop_address) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.prop_address) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.prop_owner_fname) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.prop_owner_fname) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.prop_owner_lname) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.prop_owner_lname) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.prop_worth) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.prop_worth) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.prop_city) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.prop_city) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.prop_state) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.prop_state) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.prop_zipcode) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.prop_zipcode) %>
    </div>

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.fk_agent_id) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.fk_agent_id) %>
    </div>
</fieldset>
<p>

    <%: Html.ActionLink("Edit", "Edit", new { id=Model.prop_code }) %> |
    <%: Html.ActionLink("Back to List", "Index") %>
</p>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
