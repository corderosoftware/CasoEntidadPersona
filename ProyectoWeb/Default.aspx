<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ABML Personas</title>
    <script src="Scripts/jquery-1.11.1.min.js" type="text/javascript"></script>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Content/bootstrap.min.js" type="text/javascript"></script>
    <style type="text/css">
        #GridContainer
        {
            margin-top:5em;
            margin-left:auto;
            margin-right:auto;
            width:50%;            
        }

        #LabelContainer
        {
            text-align:center;
        }

        #lblHeading
        {
            margin-left:auto;
            margin-right:auto;
            font-weight:bold;
            font-size:1.5em;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Container">
        <div id="GridContainer">
            <div id="LabelContainer">
                <asp:Label ID="lblHeading" runat="server" Text="ABML Personas" ></asp:Label>
            </div>           
            <br />
               
               <asp:GridView ID="GridPersonas" runat="server" AutoGenerateColumns="False" DataKeyNames="id" 
                ShowFooter="True" OnRowCancelingEdit="GridPersonas_RowCancelingEdit"
                OnRowDeleting="GridPersonas_RowDeleting"
                OnRowEditing="GridPersonas_RowEditing" OnRowUpdating="GridPersonas_RowUpdating" OnRowCommand="GridPersonas_RowCommand" 
                CellPadding="0" ForeColor="#333333" CssClass="table table-striped table-bordered table-condensed" EnableModelValidation="True">
                    <Columns>
                        <asp:TemplateField HeaderText="Nombre Completo">
                            <EditItemTemplate>
                                <asp:TextBox id="txtNombre" runat="server" Text='<%# Eval("nombre_completo") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label id="Lblnombre" runat="server" Text='<%# Eval("nombre_completo") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtNewNombre" runat="server" ></asp:TextBox>
                            </FooterTemplate>
                            <ItemStyle Wrap="True" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Nacimiento">
                            <EditItemTemplate>
                                <asp:TextBox id="txtNacimiento" runat="server" Text='<%# Convert.ToDateTime(Eval("fecha_nacimiento")).ToString("dd/MM/yyyy") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label id="Lblfecha" runat="server" Text='<%# Convert.ToDateTime(Eval("fecha_nacimiento")).ToString("dd/MM/yyyy") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtNewNacimiento" runat="server" ></asp:TextBox>
                            </FooterTemplate>
                            <ItemStyle Wrap="True" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Edad">
                            <EditItemTemplate>
                                <asp:TextBox id="txtEdad" runat="server" Text='<%# Eval("edad") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label id="Label3" runat="server" Text='<%# Eval("edad") %>'></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:TextBox ID="txtNewEdad" runat="server" ></asp:TextBox>
                            </FooterTemplate>
                            <ItemStyle Wrap="True" />
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Sexo">
                            <EditItemTemplate>
                                &nbsp;           
                                <asp:DropDownList ID="cmbSexo" runat="server">
                                    <asp:ListItem>Femenino</asp:ListItem>
                                    <asp:ListItem>Masculino</asp:ListItem>
                                </asp:DropDownList>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%# IIf(Eval("sexo") = "F", "Femenino", "Masculino")%>' id="Lblsexo"></asp:Label>
                            </ItemTemplate>
                            <FooterTemplate>
                                <asp:DropDownList ID="cmbNewSexo" runat="server" >
                                    <asp:ListItem>Femenino</asp:ListItem>
                                    <asp:ListItem>Masculino</asp:ListItem>
                                </asp:DropDownList>
                            </FooterTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>                                    
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" CssClass="btn btn-primary" Text="Editar"></asp:LinkButton>  
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="True" CssClass="btn btn-info" CommandName="Update" Text="Actualizar"></asp:LinkButton>
                                    <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CssClass="btn btn-info"  CommandName="Cancel" Text="Cancelar"></asp:LinkButton> 
                                </EditItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton ID="lnkAddNew" CssClass="btn btn-primary" runat="server" CommandName="AddNew">Agregar</asp:LinkButton>
                                </FooterTemplate>
                            </asp:TemplateField>
    
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>        
                                <span onclick="return confirm('¿Desea Eliminar este Registro?')">
                                    
                                    <asp:LinkButton ID="lnkB" runat="Server" CssClass="btn btn-primary"  Text="Eliminar" CommandArgument='<%# Container.DataItemIndex %>' CommandName="Delete"></asp:LinkButton>
                                </span>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
            </asp:GridView>
            <div>
                <asp:Label ID="LblError" runat="server" Text="" ForeColor="#CC0000"></asp:Label>
            </div>
        </div>    
    </div>
    </form>
</body>
</html>
