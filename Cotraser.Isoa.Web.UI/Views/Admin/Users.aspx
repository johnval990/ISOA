<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Default.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Users
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">

        <div class="strip">
            <div class="row">
                <div class="span12">
                    <span class="call-to-action">Administración de Usuarios</span>
                </div>
            </div>
        </div>



        <section id="features">
            <div class="row">
                <div class="span12">
                    <h2><em><i class="icon-bookmark"></i>Listado</em> <a class="up anchorLink" href="#home"><i class="icon-chevron-up"></i></a></h2>
                </div>
            </div>
           
	        


            <div id="dynamic">
                <table cellpadding="0" cellspacing="0" border="0" class="display" id="tdDynamic">
	                <thead>
		                <tr>
			                <th width="20%">Nombre</th>
                            <th width="20%">Nombre de usuario</th>
			                <th width="20%">Identificación</th>
			                <th width="20%">Email</th>
			                <th width="15%">Estado</th>
                            <th width="5%"></th>
		                </tr>
                        <tr>
			                <td id="Nombre"></td>
                            <td id="NombreUsr"></td>
			                <td id="Ident"></td>
			                <td id="Email"></td>
			                <td id="Estado"></td>
                            <td></td>
		                </tr>
	                </thead>
	                <tbody>
		                <%--CONTENIDO--%>
	                </tbody>
                    
                    <tfoot>
		                <tr>
			                <th>Nombre</th>
			                <th>Nombre de usuario</th>
			                <th>Identificación</th>
			                <th>Email</th>
			                <th>Estado</th>
			                <th></th>
		                </tr>
	                </tfoot>

                </table>
            </div>




        </section>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="HeaderContent" runat="server">

    <script type="text/javascript" language="javascript" src="<%: Url.Content("~/App_Themes/Default/js/DataTables/js/jquery.dataTables.js") %>"></script>
    <script type="text/javascript" language="javascript" src="<%: Url.Content("~/App_Themes/Default/js/DataTables/js/jquery.dataTables.columnFilter.js") %>"></script>

    <link rel="stylesheet" href="<%: Url.Content("~/App_Themes/Default/js/DataTables/css/demo_table.css") %>">

    <script type="text/javascript" charset="utf-8">

        $(document).ready(function () {
            var oTable = $('#tdDynamic').dataTable({
                "aaSorting": [],
                "sPaginationType": "full_numbers",
                "bSortCellsTop": true,
                "bStateSave": false,
                "bProcessing": true,
                "sAjaxSource": '<%: Url.Content("~/Services/Api/GetListUser") %>',
                "sServerMethod": "POST",
                "oLanguage": { "sUrl": '<%: Url.Content("~/App_Themes/Default/js/DataTables/lang.es.txt") %>' },
                "aoColumns": [
			                { "bSortable": true, "bSearchable": true, "sType": "string" },
			                { "bSortable": true, "bSearchable": true, "sType": "string" },
			                { "bSortable": true, "bSearchable": true, "sType": "string" },
			                { "bSortable": true, "bSearchable": true, "sType": "string" },
                            { "bSortable": true, "bSearchable": false },
                            {
                                "sClass": "centerBotontable",
                                "bSortable": false,
                                "bSearchable": false,
                                "sType": "html",
                                "fnRender": function (obj) {
                                    var sReturn = "<a href='/admin/period/edit/id/" + obj.aData[obj.iDataColumn] + "'>" + "  <i class='icon-pencil'></i>" + "</a>";
                                    return sReturn;
                                }
                            }
                            /*,{
                                "sClass": "centerBotontable",
                                "bSortable": false,
                                "bSearchable": false,
                                "sType": "html",
                                "fnRender": function (obj) {
                                    var sReturn = "<a href='#'>" + "    <i class='icon-trash'></i>" + "</a>";
                                    return sReturn;
                                    return '';
                                }
                            }*/
			            ]
            }).columnFilter({
                aoColumns: [
                    { type: "text", sSelector: "#Nombre" },
                    { type: "text", sSelector: "#NombreUsr" },
                    { type: "text", sSelector: "#Ident" },
                    { type: "text", sSelector: "#Email" },
                    { type: "select", sSelector: "#Estado", values: ['Activo', 'Inactivo'] }
                ]
            });
        });

		</script>
</asp:Content>
