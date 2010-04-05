<%@ Page Language="C#" Inherits="OpenRasta.Codecs.WebForms.ResourceView<HomeResource>" MasterPageFile="~/Views/HomeView.Master" %>

<asp:Content ContentPlaceHolderID="body" ID="content" runat="server">
    <div>
        Welcome home <%= Resource.Name %>
    </div>
</asp:Content>
