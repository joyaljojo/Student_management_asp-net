<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="Lab_7.AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
<head runat="server">
    <title>Student management</title>
    
</head>
<body class="container-md">
    <h1>Students</h1>
    <form  runat="server">
        <div class="mb-3">
            <asp:Label class="form-label" runat="server" Text="Student Name: "></asp:Label>
            <asp:TextBox class="form-control" ID="studentname" runat="server"></asp:TextBox><br />
            </div>
            <asp:Label ID="Label2" runat="server" Text="Student Type: "></asp:Label>
            <div class="input-group mb-3">
            <asp:DropDownList ID="course" class="form-select" runat="server">
            <asp:ListItem Enabled="true" Text= "Select...." Value= "-1"></asp:ListItem>
            <asp:ListItem Text= "Full time" Value="1"></asp:ListItem>
            <asp:ListItem Text= "Part time" Value="2"></asp:ListItem>
            <asp:ListItem Text= "co-op" Value="3"></asp:ListItem>
            </asp:DropDownList>
            </div>
            <div class ="submit" runat="server">
            <asp:Button   class="btn btn-primary" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
        </div>
    </form>
   <asp:Label runat="server" ID="lblErrorMsg" CssClass="alert-danger"  ForeColor="Red"></asp:Label>
    <div runat="server" id="tabl">
    <asp:table  class="table table-bordered">
        <table>
          <tr>
            <th scope="col">Id</th>
            <th scope="col">Name</th>            
          </tr>
            <tr>
                <td><td scope="row">Nothng yet</td></td>
            </tr>
            </table>
            
        </asp:table>
        </div>
            <div class="table2">
        <asp:Label ID="lblConfirmation" runat="server" Text="" style="font-weight: bold;"></asp:Label>
</div>
    
</body>
</html>
