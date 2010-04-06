<%@ Page Language="C#" Inherits="OpenRasta.Codecs.WebForms.ResourceView<ArtistListResource>" MasterPageFile="~/Views/HomeView.Master" %>

<asp:Content ContentPlaceHolderID="body" ID="content" runat="server">
    <div>
        Welcome to the list
    </div>

    <ul>
        <% foreach(Britannic.Web.Models.Artist a in Resource.Artists) { %>
            <li><%= a.Name %></li>
        <%} %>
    </ul>
</asp:Content>
