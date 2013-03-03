<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<% 
    if (Request.IsAuthenticated)
    {
        //VALIDAR ROLES DE USUARIOS
        
        SiteMapNodeCollection mapNodes = System.Web.SiteMap.RootNode.ChildNodes;
        
        
        foreach (SiteMapNode item in mapNodes)
        {
            if (Cotraser.Isoa.Systems.SecuritySystem.ValidateUserRoles(item))
            {
                Response.Write(string.Format("<li><a class='anchorLink' href='{0}'>{1}</a><ul>", item.Url, item.Title));

                foreach (SiteMapNode subItem in item.ChildNodes)
                {
                    if (Cotraser.Isoa.Systems.SecuritySystem.ValidateUserRoles(subItem))
                        Response.Write(string.Format("<li><a class='anchorLink' href='{0}'>{1}</a></li>", subItem.Url, subItem.Title));
                }

                Response.Write("</ul></li>");
            }
        }
    
    
    
        Cotraser.Isoa.Domain.User currentUser = Cotraser.Isoa.Systems.SecuritySystem.GetCurrentUser(); %>

        <li>Hello, <%: currentUser.Name%>!</li>

        <li>
            <% using (Html.BeginForm("LogOff", "Default", FormMethod.Post, new { id = "logoutForm" }))
               { %>
            <%: Html.AntiForgeryToken()%>
            <a href="javascript:document.getElementById('logoutForm').submit()">Log off</a>
            <% } %>
        </li>
<%  }%>