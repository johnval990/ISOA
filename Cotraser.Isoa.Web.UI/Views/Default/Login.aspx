<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Default.Master" Inherits="System.Web.Mvc.ViewPage<Cotraser.Isoa.Web.UI.Models.LoginModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Login
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<!--CONTENT-->
    <div class="container">
        <div class="strip">
            <div class="row">
                <div class="span12">
                    <span class="call-to-action">Bienvenido a ISOA (Sistema Integrado de Aplicaciones)</span>
                </div>
            </div>
        </div>


      <section id="contact">
      <div class="row">
        <div class="span12">
          <h2><em><i class="icon-bookmark"></i>Inicio</em> <a class="up anchorLink" href="#home"><i class="icon-chevron-up"></i></a></h2>
        </div>
      </div>
      <div class="row">

        <div class="span4">
          <h3>Recordar contraseña</h3>
          <br>
          <div class="well">
            <strong>Aviso:</strong>
            <hr>
            <p>Si no recuerda su contraseña<br/>
              haga clic en el siguiente enlace<br/>
              <a href="javascript:void(0);"><strong>Recordar contraseña</strong></a>
            </p>
            
            
            <p>Si continua sin ingreso envié un correo a soporte@cotraser.com</p>
          </div>
        </div>
        
        
        <div class="span4">
        <h3>Ingreso al sistema</h3>
        <br/>
            <% using (Html.BeginForm(new { ReturnUrl = ViewBag.ReturnUrl }))
            { %>
                <%: Html.AntiForgeryToken() %>
                <%: Html.ValidationSummary(true) %>

            <fieldset>
              <div class="control-group">
                <label class="control-label" for="username">Nombre de usuario:</label>
                <input id="UserName" name="UserName" class="input-xlarge" type="text" placeholder="Escribre tu nombre de usuario" CustomName="Nombre de usuario" autofocus required>
              </div>
              <div class="control-group">
                <label class="control-label" for="contrasenia">Contraseña:</label>
                <input id="Password" name="Password" class="input-xlarge" type="password" placeholder="Escribre tu contraseña" CustomName="Contraseña" required>
              </div>
              <button type="submit" class="btn btn-red">Ingresar!</button>
            </fieldset>

          <% } %>
        </div>
       
       
        <div class="span4">
          <h3>How about a map?</h3>
          <br/>
          <img class="framed" src="../App_Themes/Default/assets/map.png" alt=""/>
        </div>
      
      
      </div>
    </section>
    </div>
    <!--/CONTENT-->

</asp:Content>


