<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage_kargah.aspx.cs" Inherits="Conf.Web.manage_kargah" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body, div, dl, dt, dd, ul, ol, li, h1, h2, h3, h4, h5, h6, 
pre, form, fieldset, input, textarea, p, blockquote, th, td { 
  padding:0;
  margin:0;}

fieldset, img {border:0}

ol, ul, li {list-style:none}

:focus {outline:none}

body,
input,
textarea,
select {
  font-family: 'Open Sans', sans-serif;
  font-size: 16px;
  color: #4c4c4c;
            margin-left: 15px;
        }

p {
  font-size: 12px;
  width: 150px;
  display: inline-block;
  margin-left: 18px;
}
h1 {
  font-size: 32px;
  font-weight: 300;
  color: #4c4c4c;
  text-align: center;
  padding-top: 10px;
  margin-bottom: 10px;
}

html{
  background-color: #ffffff;
}

.testbox {
  margin: 20px 16px 20px 15px;
  width: 354px; 
  height: 464px; 
  -webkit-border-radius: 8px/7px; 
  -moz-border-radius: 8px/7px; 
  border-radius: 8px/7px; 
  background-color: #ebebeb; 
  -webkit-box-shadow: 1px 2px 5px rgba(0,0,0,.31); 
  -moz-box-shadow: 1px 2px 5px rgba(0,0,0,.31); 
  box-shadow: 1px 2px 5px rgba(0,0,0,.31); 
  border: solid 1px #cbc9c9;
}

input[type=radio] {
  visibility: hidden;
}

form{
  margin: 0 30px;
}

label.radio {
	cursor: pointer;
  text-indent: 35px;
  overflow: visible;
  display: inline-block;
  position: relative;
  margin-bottom: 15px;
}

label.radio:before {
  background: #3a57af;
  content:'';
  position: absolute;
  top:2px;
  left: 0;
  width: 20px;
  height: 20px;
  border-radius: 100%;
}

label.radio:after {
	opacity: 0;
	content: '';
	position: absolute;
	width: 0.5em;
	height: 0.25em;
	background: transparent;
	top: 7.5px;
	left: 4.5px;
	border: 3px solid #ffffff;
	border-top: none;
	border-right: none;

	-webkit-transform: rotate(-45deg);
	-moz-transform: rotate(-45deg);
	-o-transform: rotate(-45deg);
	-ms-transform: rotate(-45deg);
	transform: rotate(-45deg);
}

input[type=radio]:checked + label:after {
	opacity: 1;
}

hr{
  color: #a9a9a9;
  opacity: 0.3;
}

input[type=text],input[type=password]{
  width: 200px; 
  height: 39px; 
  -webkit-border-radius: 0px 4px 4px 0px/5px 5px 4px 4px; 
  -moz-border-radius: 0px 4px 4px 0px/0px 0px 4px 4px; 
  border-radius: 0px 4px 4px 0px/5px 5px 4px 4px; 
  background-color: #fff; 
  -webkit-box-shadow: 1px 2px 5px rgba(0,0,0,.09); 
  -moz-box-shadow: 1px 2px 5px rgba(0,0,0,.09); 
  box-shadow: 1px 2px 5px rgba(0,0,0,.09); 
  border: solid 1px #cbc9c9;
  margin-left: 11px;
  margin-top: 13px; 
  padding-left: 10px;
}

input[type=password]{
  margin-bottom: 25px;
}

#icon {
  display: inline-block;
  width: 30px;
  background-color: #3a57af;
  padding: 8px 0px 8px 15px;
  margin-left: 15px;
  -webkit-border-radius: 4px 0px 0px 4px; 
  -moz-border-radius: 4px 0px 0px 4px; 
  border-radius: 4px 0px 0px 4px;
  color: white;
  -webkit-box-shadow: 1px 2px 5px rgba(0,0,0,.09);
  -moz-box-shadow: 1px 2px 5px rgba(0,0,0,.09); 
  box-shadow: 1px 2px 5px rgba(0,0,0,.09); 
  border: solid 0px #cbc9c9;
}

.gender {
  margin-left: 30px;
  margin-bottom: 30px;
}

.accounttype{
  margin-left: 8px;
  margin-top: 20px;
}

a.button {
  font-size: 14px;
  font-weight: 600;
  color: white;
  padding: 6px 25px 0px 20px;
  margin: 10px 8px 20px 0px;
  display: inline-block;
  float: right;
  text-decoration: none;
  width: 50px; height: 27px; 
  -webkit-border-radius: 5px; 
  -moz-border-radius: 5px; 
  border-radius: 5px; 
  background-color: #3a57af; 
  -webkit-box-shadow: 0 3px rgba(58,87,175,.75); 
  -moz-box-shadow: 0 3px rgba(58,87,175,.75); 
  box-shadow: 0 3px rgba(58,87,175,.75);
  transition: all 0.1s linear 0s; 
  top: 0px;
  position: relative;
}

a.button:hover {
  top: 3px;
  background-color:#2e458b;
  -webkit-box-shadow: none; 
  -moz-box-shadow: none; 
  box-shadow: none;
  
}


    </style>
</head>
<body>
    
    <form id="form1" runat="server">
            <div class="testbox" style="float: left;">
                <h1>Submit Karghah</h1>

                <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
                </asp:ScriptManager>
                <hr>
                <div class="accounttype">
                    <input type="radio" value="None" id="radioOne" name="account" checked />
                    <label for="radioOne" class="radio" chec>Personal</label>
                    <input type="radio" value="None" id="radioTwo" name="account" />
                    <label for="radioTwo" class="radio">Company</label>
                </div>
                <hr>
                <input type="text" name="name" id="name" placeholder="name of kargah" required />
                <label id="Label1" for="name"><i class="icon-user"></i></label>
                <input type="text" name="name" id="writer" placeholder="writer" required />
                <label id="Label2" for="name"><i class="icon-shield"></i></label>
                <input type="password" name="name" id="topic" placeholder="topic" required />
                <div class="gender">

                    <input type="radio" value="None" id="male" name="gender" checked />
                    <label for="male" class="radio" chec>Male</label>
                    <input type="radio" value="None" id="female" name="gender" />
                    <label for="female" class="radio">Female</label>
                </div>
                <p>By clicking Register, you agree on our <a href="#">terms and condition</a>.</p>
                <a href="#" class="button" onclick="return submit();">Register</a>

            </div>
            <div class="testbox" style="float: left;">
                <h1>Submit Session</h1>

                    
                    <hr>
                    <div class="accounttype">
                        <input type="radio" value="None" id="radio5" name="account" checked />
                        <label for="radioOne" class="radio" chec>Personal</label>
                        <input type="radio" value="None" id="radio6" name="account" />
                        <label for="radioTwo" class="radio">Company</label>
                    </div>
                    <hr>
                    &nbsp;<label id="Label5" for="name"><i class="icon-user"></i></label>
                    <label id="Label6" for="name"><i class="icon-shield"></i></label>
                    <input type="password" name="name" id="data" placeholder="data_id" required />
                    <div class="gender">

                        <input type="radio" value="None" id="Radio7" name="gender" checked />
                        <label for="male" class="radio" chec>Male</label>
                        <input type="radio" value="None" id="Radio8" name="gender" />
                        <label for="female" class="radio">Female</label>
                    </div>
                    <p>By clicking Register, you agree on our <a href="#">terms and condition</a>.</p>
                    <a href="#" class="button" onclick="return submit3();">Register</a>
            </div>
            <div class="testbox" style="float: right">
                <h1>Submit Place</h1>
                <hr>
                <div class="accounttype">
                    <input type="radio" value="None" id="radio1" name="account" checked />
                    <label for="radioOne" class="radio" chec>Personal</label>
                    <input type="radio" value="None" id="radio2" name="account" />
                    <label for="radioTwo" class="radio">Company</label>
                </div>
                <hr>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="session_id" DataValueField="session_id" Height="33px" Width="206px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnectionString %>" SelectCommand="SELECT [session_id] FROM [session]"></asp:SqlDataSource>
                <br />
                &nbsp;<label id="Label3" for="name"><i class="icon-user"></i></label>&nbsp;<label id="Label4" for="name"><i class="icon-shield"></i></label><input type="password" name="name" id="adres" placeholder="address" required />
                <div class="gender">

                    <input type="radio" value="None" id="Radio3" name="gender" checked />
                    <label for="male" class="radio" chec>Male</label>
                    <input type="radio" value="None" id="Radio4" name="gender" />
                    <label for="female" class="radio">Female</label>
                </div>
                <p>By clicking Register, you agree on our <a href="#">terms and condition</a>.</p>
                <br />
                <a href="#" class="button" onclick="return submit2();">Register</a>
            </div>
    </form>

    <script >
        function submit()
        {
            var name = document.getElementById('name').value;
            var writer = document.getElementById('writer').value;
            var topic = document.getElementById('topic').value;
            PageMethods.submit_kargah(name, writer, topic, onSucess, onError);
            function onSucess(result) {
                alert('success.');
            }

            function onError(result) {
                alert('Cannot process your request at the moment, please try later.');
            }
        }

        function submit2() {
            var name = document.getElementById('DropDownList1').value;
            var writer = document.getElementById('adres').value;
            PageMethods.submit_sesion(name, writer, onSucess, onError);
            function onSucess(result) {
                alert('success.');
            }

            function onError(result) {
                alert('Cannot process your request at the moment, please try later.');
            }
        }
            function submit3() {
                var name = document.getElementById('data').value;
                PageMethods.submit_place(name, onSucess, onError);
                function onSucess(result) {
                    alert('success.');
                }

                function onError(result) {
                    alert('Cannot process your request at the moment, please try later.');
                }
            }
    </script>
</body>
</html>
