<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    RealFake Estates | About
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <p><h1>About.</h1></p>
        <h2><%: ViewBag.Message %></h2>
    </hgroup>

    <article>
        <p>
           <h3> Designed and developed by Madison Liddell as a side project.</h3>
        </p>

        <p>
            The database is a relational database created in MySQL. It is populated with dummy agents and property listings.
        </p>

        <p>
            The website is an Asp.Net MVC4 application.
        </p>
    </article>

   <%-- <aside>
        <h3>Aside Title</h3>
        <p>
            Use this area to provide additional information.
        </p>
        <ul>
            <li><%: Html.ActionLink("Home", "Index", "Home") %></li>
            <li><%: Html.ActionLink("About", "About", "Home") %></li>
            <li><%: Html.ActionLink("Contact", "Contact", "Home") %></li>
        </ul>
    </aside>--%>
</asp:Content>