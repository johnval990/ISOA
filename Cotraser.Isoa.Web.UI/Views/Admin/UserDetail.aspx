<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Default.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    UserDetail
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

 <!--CONTENT-->
    <div class="container">
        <div class="strip">
            <div class="row">
                <div class="span12">
                    <span class="call-to-action">Administración de Usuarios</span>
                </div>
            </div>
        </div>


      <section id="contact">
      <div class="row">
        <div class="span12">
          <h2><em><i class="icon-bookmark"></i>Ingreso</em> <a class="up anchorLink" href="#home"><i class="icon-chevron-up"></i></a></h2>
        </div>
      </div>

       
      <div class="row">

        <% using (Html.BeginForm(new { ReturnUrl = ViewBag.ReturnUrl }))
            { %>
                <%: Html.AntiForgeryToken() %>
                <%: Html.ValidationSummary(true) %>

            <div class="span4">

                <div class="control-group">
                    <label class="control-label" for="Name">Nombre:</label>
                    <input id="Name" name="Name" class="input-xlarge" type="text" tabindex="1" placeholder="Escribre un nombre" CustomName="Nombre" autofocus required />
                </div>
                <div class="control-group">
                    <label class="control-label" for="Identification">Identificación:</label>
                    <input id="Identification" name="Identification" class="input-xlarge" type="text" tabindex="2" placeholder="Escribre una identificación" CustomName="Identificación" required />
                </div>
                <div class="control-group">
                    <label class="control-label" for="usermail">Email:</label>
                    <input id="userMail" name="userMail" class="input-xlarge" type="email" tabindex="3" placeholder="Escribre un email" CustomName="Email" required />
                </div>
                
            </div>
        
              <div class="span4">

                  <div class="control-group">
                    <label class="control-label" for="UserName">Nombre de usuario:</label>
                    <input id="UserName" name="UserName" class="input-xlarge" type="text" tabindex="4" placeholder="Escribre un nombre de usuario" CustomName="Nombre de usuario" required />
                  </div>
                  <div class="control-group">
                    <label class="control-label" for="Password">Contraseña:</label>
                    <input id="Password" name="Password" class="input-xlarge" type="password" tabindex="5" placeholder="Escribre una contraseña" CustomName="Contraseña" required />
                  </div>
                  <div class="control-group">
                    <label class="control-label" for="userState">Estado:</label>
                    <select id="userState" name="userState" class="input-xlarge" CustomName="Estado" tabindex="6" required>
                        <option value="">Seleccione un estado</option>
                        <option value="1">Activo</option>
                        <option value="0">Inactivo</option>
                    </select>

                  </div>
                
            </div>
      
       
            <div class="span4">

                <div class="control-group">
                    <label class="control-label" for="userProfiles">Perfiles:</label>
                    <select id="userProfiles" name="userProfiles" class="input-xlarge" CustomName="Perfiles" tabindex="7" required>
                        <option value="">Seleccione un perfil</option>

                        <% List<Cotraser.Isoa.Domain.AplicationRole> aplicationRole = Cotraser.Isoa.Domain.AplicationRole.GetAllRoles();

                           foreach (Cotraser.Isoa.Domain.AplicationRole item in aplicationRole)
	                        {
                                Response.Write("<option value='" + item.IdAplicationRole + "'>" + item.Description + "</option>");
	                        }
                        %>

                    </select>
                  </div>
                  <div class="control-group">
                    <label class="control-label" for="userAreas">Areas:</label>
                    <select id="userAreas" name="userAreas" class="input-xlarge" CustomName="Areas" tabindex="8" required>
                        <option value="">Seleccione una area</option>
                        
                        <% List<Cotraser.Isoa.Domain.Area> areas = Cotraser.Isoa.Domain.Area.GetAllAreas();

                           foreach (Cotraser.Isoa.Domain.Area item in areas)
	                        {
                                Response.Write("<option value='" + item.IdArea + "'>" + item.Description + "</option>");
	                        }
                        %>

                    </select>
                  </div>
                  <button type="submit" tabindex="9" class="btn btn-red">Ingresar!</button>
              
            </div>
          
      
         <% } %>
      </div>


    </section>
    </div>
    <!--/CONTENT-->

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">

</asp:Content>
