<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="contactTitle" ContentPlaceHolderID="TitleContent" runat="server">
    RealFake Esates | Contact Dev
</asp:Content>

<asp:Content ID="contactContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: ViewBag.Message %></h1>
    </hgroup>
    <section class="contact">
        <header>
            <h3>Phone:</h3>
        </header>
        <p>
            <span class="label">Cell:</span>
            <span>713-876-3130</span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Email:</h3>
        </header>
        <p>
            <span class="label">Business use only:</span>
            <span><a href="mailto:madison.liddell@yahoo.com">Madison.Liddell@yahoo.com</a></span>
        </p>
    </section>
</asp:Content>