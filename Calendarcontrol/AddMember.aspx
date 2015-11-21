<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMember.aspx" Inherits="Calendarcontrol.AddMember" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">


<head>
<title>AddMemeber</title>
    <link href="StyleSheetE.css" rel="stylesheet" type="text/css" />
     <link href="http://code.jquery.com/ui/1.11.2/themes/smoothness/jquery-ui.css" rel="stylesheet" type="text/css" />
    <script src="http://code.jquery.com/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="http://code.jquery.com/ui/1.11.2/jquery-ui.js" type="text/javascript"></script>

    <style type="text/css">

html, body {
    height: 100%;
  }
  #tableContainer-1 {
    height: 100%;
    width: 100%;
    display: table;
  }
  #tableContainer-2 {
    vertical-align: middle;
    display: table-cell;
    height: 100%;
  }
  #myTable {
    margin: 0 auto;
     margin-left: auto; 
margin-right: auto; 
text-align: left; 
  }


       
      .style17
        {
            width: 140px;
            height: 58px;
        }
        
        #TextArea1
        {
            height: 101px;
            width: 206px;
        }
       
        
        .style18
        {
            width: 1025px;
        }
        .style19
        {
            width: 246px;
            height: 58px;
        }
        .style20
        {
            width: 246px;
        }
       
        
        .cpnlHeader
        {}
       
        
    </style>

    <script type="text/javascript" language="javascript">
        $(function () {
            $("#txteventdate").datepicker();

        });
       
    </script>



</head>
<body>
    <form id="form1" runat="server"  >
    <asp:ScriptManager ID="scmAddresses" runat="server"></asp:ScriptManager>
     <div id="tableContainer-1" >
                        <div id="tableContainer-2">
        <table  id="myTable" >
            <tr>
                <td >
                    <asp:UpdatePanel ID="updPanel" runat="server">
                        <ContentTemplate>
                         <table >
<tr>
  <td  valign='top' > 
  <a name="top"></a>
  <a href="http://www.communityfamilycenters.org">
      <img src="Scripts/Images/banner1.jpg" alt="Community Family Centers"  
          style="width: 993px; height: 110px"></a></td>
</tr>
</table>

                       
                            <table >
                                <tr>
                                    <td align="center" class="style18">
                                        <asp:Label ID="lblHead" runat="server" CssClass="lblHeader" Text="Add Member"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td class="style18">
                                     <asp:Panel ID="pnlSearchHeader" runat="server" CssClass="cpnlHeader" 
                                            BackColor="#FDBC2E" Height="16px" Width="1020px"   >
                                            
                                        </asp:Panel>
                                        <div style="width: 100%; height: 100%; background-image:url(Scripts/Images/home_image.jpg); background-repeat:no-repeat" >

                                        <asp:Panel ID="pnlSearchBody" runat="server" CssClass="cpnlBody"  
                                              style="width: 100%; height: 100%">
  
                                            <table class="center" >
                                            <tr>
                                            <td class="style17">
                                                <asp:Label ID="Position" runat="server" Text="Position"></asp:Label>
                                            </td>
                                            <td class="style17">
                                            <asp:TextBox ID="txtgeneral" runat="server" Width="186px"></asp:TextBox>
                                                <%--<asp:DropDownList ID="ddleventtype" runat="server" Width="186px">
                                                    <asp:ListItem Value="0">----Select-----</asp:ListItem>
                                                    <asp:ListItem Value="1">DIRECTORY MEETING</asp:ListItem>
                                                     <asp:ListItem Value="4">GENERAL MEETING</asp:ListItem>
                                                    <asp:ListItem Value="7">EVENT PLANNING MEETING</asp:ListItem>
                                                    <asp:ListItem Value="4">TOPIC PREPARATION MEETING</asp:ListItem>
                                                    <asp:ListItem Value="5">GROUP MEETING</asp:ListItem>
                                                    <asp:ListItem Value="6">QUARTER REVISION MEETING</asp:ListItem>
                                                    <asp:ListItem Value="7">SPECIAL EVENT</asp:ListItem>
                                                    <asp:ListItem Value="8">EVENT PLANNING</asp:ListItem>
                                                </asp:DropDownList>--%>
                                                
                                                                                            </td>
                                            <td class="style17">
                                            </td>
                                            <td class="style19">

                                           </td>
                                            </tr>


                                             <tr>
                                            <td class="style17">
                                                <asp:Label ID="Name1" runat="server" Text="First Name"></asp:Label>
                                            </td>
                                            <td class="style17">
                                                <asp:TextBox ID="txtname1" runat="server"  Width="186px"></asp:TextBox>
                                            </td>
                                            <td class="style17">
                                            </td>
                                            <td class="style19">

                                           </td>
                                            </tr>


                                             <tr>
                                            <td class="style17">
                                                <asp:Label ID="Name2" runat="server" Text="Second Name"></asp:Label>
                                            </td>
                                            <td class="style17">
                                                <asp:TextBox ID="Txtname2" runat="server"  Width="186px"></asp:TextBox>
                                                <%--<asp:TextBox ID="txteventminute" runat="server" Width="39px" placeholder="MM"></asp:TextBox>--%>&nbsp
                                                
                                                <%--<asp:DropDownList ID="ddltime" runat="server"  >
                                                <asp:ListItem Value="0">--Select---</asp:ListItem>
                                                    <asp:ListItem Value="1">AM</asp:ListItem>
                                                    <asp:ListItem Value="2">PM</asp:ListItem>
                                                </asp:DropDownList>--%>
                                                
                                            </td>
                                            <td class="style17">
                                            </td>
                                            <td class="style19">

                                           </td>
                                            </tr>


                                             <tr>
                                            <td class="style17">
                                                <asp:Label ID="lbllastname" runat="server" Text="Place"></asp:Label>
                                                 </td>
                                            <td class="style17">
                                            
                                            <asp:TextBox ID="TxtPlace" runat="server" Width="186px"></asp:TextBox>
                                                 <%--<asp:DropDownList ID="ddlplace" runat="server" Width="199px" Height="20px">
                                                    <asp:ListItem Value="0">----Select-----</asp:ListItem>
                                                    <asp:ListItem Value="1">FAMILY ROOM</asp:ListItem>
                                                      <asp:ListItem Value="7">COMMUNITY ROOM</asp:ListItem>
                                                     <asp:ListItem Value="4">ROOM 234</asp:ListItem>
                                                  
                                                    <asp:ListItem Value="4">ROOM 305</asp:ListItem>
                                                    <asp:ListItem Value="5">ROOM 310</asp:ListItem>
                                                 
                                                </asp:DropDownList>--%></td>
                                            <td class="style17">
                                            </td>
                                            <td class="style19">

                                           </td>
                                            </tr>


                                             <tr>
                                            <td class="style17">
                                                <asp:Label ID="lbladdress" runat="server" Text="Address"></asp:Label>
                                                 </td>
                                            <td class="style17">
                                                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Width="194px" 
                                                    Height="80px"></asp:TextBox>
                                                </td>
                                            <td class="style17">
                                            </td>
                                            <td>
                                            
                                            </td>
                                            <td class="style20">


                                           </td>
                                            </tr>
                                         
                             <tr>
                             
                             
                                 <td class="style17">
                                     <asp:Label ID="lblphone1" runat="server" Text="Phone1"></asp:Label>
                                 </td>
                                 <td class="style17">
                                     <asp:TextBox ID="Txtphone1" runat="server" Width="186px"></asp:TextBox>
                                 </td>
                                 <tr>
                                 
                                 <td class="style17">
                                 <asp:Label ID="Lblphone2" runat="server" Text="Phone2"></asp:Label>
                                 </td>
                                 <td class="style17">
                                 <asp:TextBox ID="Txtphone2" runat="server" Width="186px"></asp:TextBox>
                                 </td>
                                 </tr>
                                 <tr>
                                 <td class="style17">

                                 <asp:Label ID="Lblemail1" runat="server" Text=" First Email"></asp:Label>
                                 </td>

                                 <td class="style17">
                                 <asp:TextBox ID="Txtemail1" runat="server" Width="186px"></asp:TextBox>
                                 </td>
                                 <tr>
                                 <td class="style17">

                                  <asp:Label ID="lblemail2" runat="server" Text=" Second Email"></asp:Label>
                                  <td class="style17">
                                  <asp:TextBox ID="Txtemail2" runat="server" Width="186px"></asp:TextBox>

                                  </td>
                                 </td>
                                 <tr>
                                 <td class="style17">
                                  <asp:Label ID="lblmemberprof" runat="server" Text=" Member Profession"></asp:Label>
                                  </td>
                                  <td>
                                  
                                                                                                                                                                                                                          
                                  </td>
                                  <td>
                                  
                                  <asp:RadioButton ID="Levelcoridnator" runat="server" />
                                  </td>
                                 </tr>
                                 </tr>
                                 </tr>
                                 <tr>
                                     <td class="style17" colspan="1">
                                         <asp:Button ID="btnSave" runat="server" CssClass="btn" OnClick="btnSave_Click" Text="Save" Width="70px" />
                                     </td>
                                     <td class="style17">
                                         <asp:Button ID="btnCancel" runat="server" CssClass="btn"  OnClick="btnCancel_Click" Text="Cancel" Width="69px" />
                                     </td>
                                     <td class="style17">
                                     </td>
                                     <td class="style20">
                                     </td>
                                 </tr>
                             
                             
                             </tr>



                                            </table>
                                            
                                        </asp:Panel>

                                        </div>


                                    </td>
                                </tr>
                            </table>
                          
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    
                    </td>
            </tr>
        </table>
         
                         </div>
                          </div>
    </form>
</body>
</html>