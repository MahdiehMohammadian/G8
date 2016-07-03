<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manage.aspx.cs" Inherits="Conf.Web.manage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
         *{
	 font-family: Cambria, Palatino, "Palatino Linotype", "Palatino LT STD", Georgia, serif;
	 -webkit-font-smoothing: antialiased;
	 -moz-font-smoothing: antialiased;
	 font-smoothing: antialiased;
	 font-family: 'Quicksand', sans-serif;
	 font-weight:700;
	 font-size:12px;
	 color:#333;
	 padding:0px;
	 margin:0px;
	 border:0;
	 -moz-box-sizing: border-box;
	 -webkit-box-sizing: border-box; box-sizing: border-box;
 }
 
	 ::selection
	{
		color:inherit;
	}
	::-moz-selection
	{
		color:inherit;
	} 
 
  body{
	width:100%;
	margin:0 auto;
	background:#ccc;
	background: #fff url(http://www.olliehusbanddesign.co.uk/form/images/slice.jpg) repeat top left;
}
  
 h1{
	color:#ccc;
    margin-bottom: 0;
	text-align:center;
	 font: 70px Tahoma,Helvetica,Arial,Sans-Serif;
	position:relative;
	width:90%;
	margin:2% auto 0%;
 }
 
.contact{
	position:relative;
	width:60%;
	max-width:700px;
	margin:0 auto 0%;
	padding:10px;
	-webkit-border-radius: 5px;
	-moz-border-radius: 5px;
	-o-border-radius: 5px;
	-ms-border-radius: 5px;
	border-radius: 5px; 
	background:rgba(0,0,0,0.05);
}

.three_col , .one_col{
	float:left;
	width:100%;
	position:relative;
}
 
.three_col input, .one_col input, .three_col select, .one_col textarea, .one_col  #file {
	position:relative;
	padding:5px 5px;
	margin:1% 2%;
	float:left;
	z-index:10;
	border:1px solid #ccc;
	background:url(http://www.olliehusbanddesign.co.uk/form/images/tick.jpg) 120% 0 no-repeat #fff;	
}

.three_col span.error, .one_col span.error{
	background: none repeat scroll 0 0 rgba(0, 0, 0, 0.6);
    border-radius: 5px 5px 5px 5px;
    color: #FFFFFF;
    display: block;
    font-size: 10px;
    height: 35px;
    left: 0;
    padding: 10px 15px;
    position: absolute;
    top: -33px;
	left:25%;
    width: auto;
	z-index:999999999;
	display:none;
}

.three_col span.error:nth-child(5){
	left:65%;
}

.three_col span.error:after, .one_col span.error:after{
	background: url("http://www.olliehusbanddesign.co.uk/form/images/popup_arrow.png") repeat scroll 0 0 transparent;
    bottom: -7px;
    content: "";
    height: 7px;
    left: 47%;
    position: absolute;
    width: 17px;
}	
.three_col select{
	width:16%;
	background:#fff;
	padding:4px;
}
.three_col input{
	width:36%;
}	

.one_col input, .one_col textarea, .one_col  #file {
	width:96%;
}

.one_col  #file {
  background: url("http://www.olliehusbanddesign.co.uk/form/images/Camera_icon.png") no-repeat scroll center 35px transparent;
    border: 1px dotted #CCCCCC;
    cursor: pointer;
    display: none;
    float: right;
    position: relative;
    text-align: center;
    width: 96%;	
}

.one_col  #file p{
padding: 95px 0 0;
line-height: 40px;
}

.one_col #image-list li{
	list-style:none;	
	border:1px solid #ccc;	
	margin: 2%;
	background:#fff;
}

.one_col #image-list li img{
	width:98%;
	height:98%;
	margin: 1% !important;
}

.one_col #submit{
	border-top-color: #4d4d4d;
   background: #4d4d4d;
   color: #d6d6d6;
   cursor:pointer;
}

.one_col #submit:hover{
	background: #333;
   color: #d6d6d6;
}	

.clear{
	clear:both;
	content:"";
	line-height:0px;
	display: block;
}

/* old browser fixed */

.no-rgba .contact,  .no-rgba .three_col span.error,  .no-rgba .one_col span.error{
	background:url(http://www.olliehusbanddesign.co.uk/form/images/norgba_bg.png) !important;
}

.no-canvas .one_col, .no-canvas .three_col, .no-canvas .one_col input, .no-canvas .three_col input{
	float:right !important;	
	margin-right:0;
	margin-bottom:0;
}

.no-canvas .three_col input{
	width:34% !important;
	margin-right:0;
	margin-bottom:0;
	float:right;
}


.no-canvas .file-upload  div{
	display:block !important;
	height:auto !important;
	width: 45% !important;
	float:right;
}

.no-canvas .one_col  #file{
	display:none !important;
}

/* animations */


@-moz-keyframes default-to-error {
	0%{
        background-position:120% -28px;
    }
	50%{
        background-position:right -28px;
    }
}

@-moz-keyframes default-to-success {
   0%{
        background-position:120% 0px;
    }
	50%{
        background-position:right 0px;
    }
}

@-moz-keyframes error-to-success {
    0%{
        background-position:right -28px;
    } 
	50%{
        background-position:120% -28px;
    } 
	60%{
        background-position:120% 0px;
    }
	100%{
        background-position:right 0px;
    }
}

@-moz-keyframes success-to-error {
    0%{
        background-position:right 0px;
    } 
	50%{
        background-position:120% 0px;
    } 
	60%{
        background-position:120% -28px;
    }
	100%{
        background-position:right -28px;
    }
}
@-webkit-keyframes default-to-error {
	0%{
        background-position:120% -28px;
    }
	50%{
        background-position:right -28px;
    }
}

@-webkit-keyframes default-to-success {
   0%{
        background-position:120% 0px;
    }
	50%{
        background-position:right 0px;
    }
}

@-webkit-keyframes error-to-success {
    0%{
        background-position:right -28px;
    } 
	50%{
        background-position:120% -28px;
    } 
	60%{
        background-position:120% 0px;
    }
	100%{
        background-position:right 0px;
    }
}

@-webkit-keyframes success-to-error {
    0%{
        background-position:right 0px;
    } 
	50%{
        background-position:120% 0px;
    } 
	60%{
        background-position:120% -28px;
    }
	100%{
        background-position:right -28px;
    }
}


input.default-to-error{
	-webkit-animation: default-to-error 0.5s;
	-moz-animation: default-to-error 0.5s;
	-animation: default-to-error 0.5s;
	  background-position:right -28px;	  
	  -webkit-box-shadow:0 0 7px rgba(243,38,36, 0.6); 
	-moz-box-shadow: 0 0 7px rgba(243,38,36, 0.6); 
	box-shadow:0 0 7px rgba(243,38,36, 0.6); 
}

input.default-to-success{
	-webkit-animation: default-to-success 0.5s;
	-moz-animation: default-to-success 0.5s;
	-animation: default-to-success 0.5s;
	  background-position:right 0px;	  	
	-webkit-box-shadow:0 0 7px rgba(161,199,54, 0.6); 
	-moz-box-shadow: 0 0 7px rgba(161,199,54, 0.6); 
	box-shadow:0 0 7px rgba(161,199,54, 0.6); 
}


@media handheld, only screen and (max-width: 580px) {
	
	.contact{
		width:90%;
	}
	
	.one_col  #file{
		width:96%;
	}
	
	.three_col input, .one_col input, .three_col select, .one_col textarea{
		width:96%;
		margin:2% 2%;
	}
	
	.three_col input, .one_col input{
		padding-right: 21px;
	}	
	
	.three_col span.error, .one_col span.error{
		display:none !Important;
	}
}
#myProgress {
    margin-left:5%;
    position: relative;
    width: 90%;
    height: 30px;
    background-color: grey;
    border-radius:7px;
}
#myBar {
    position: absolute;
    width: 1%;
    height: 100%;
    background-color:rgb(220, 27, 198);
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
     <h1>Get in touch!</h1>
  <div class="contact">
  <form method="post" enctype="multipart/form-data"  action="#" id="image-form">
		<div class="three_col">
			<select id="mySelect" onchange="return chang();" >
                <option>Select from list</option>
			</select>
			<input id="a1" type="text" name="fname" placeholder="First Name" class="default" msg="Error for First name">
			<span class="error"></span>
			<input id="a2" type="text" name="lname" placeholder="Last Name" class="default" msg="Error for Last name">
			<span class="error"></span>
		</div>
		<div class="one_col email">
			<input id="a3" type="text" name="email" placeholder="Email Address" class="default" msg="Please enter a valid email">
			<span class="error"></span>
		</div>
		<div class="one_col">
			<input id="a4" type="text" name="website" placeholder="Tell" class="default" msg="Error for website">
			<span class="error"></span>
		</div>
		<div class="one_col">
          	<select id="Select1" onchange="return chang2();" style="margin-left:20px;border:1px solid silver;border-radius:3px;height:20px" >
                <option>Select from list</option>
			</select>
			<textarea rows="4" cols="20" id="t1" placeholder="Article Id"></textarea>
			<span class="error"></span>
		</div>
		<div class="one_col">
		<div id="myProgress">
  <div id="myBar"></div>
</div>
			<input id="submit" type="submit" value="Submit" onclick="return foo();" />
		</div>
		<span class="clear"></span>
	</form>
</div>
    </form>
    <script>

        function foo()
        {
            var txt = document.getElementById('mySelect').options[document.getElementById('mySelect').selectedIndex].text;
            var txt2 = document.getElementById('Select1').options[document.getElementById('Select1').selectedIndex].text;
            move();
            PageMethods.submit(txt, txt2, onSucess, onError);
            function onSucess(result) {
                alert('success.');
            }

            function onError(result) {
                alert('Cannot process your request at the moment, please try later.');
            }
            return true;
        }

        var flag = 0;
        function chang()
        {
            flag = 1;
            var txt = document.getElementById('mySelect').options[document.getElementById('mySelect').selectedIndex].text;
            PageMethods.parametr(txt, onSucess, onError);
            function onSucess(result) {

                var text = result.split("*");
                document.getElementById('a1').value = text[0];
                document.getElementById('a2').value = text[1];
                document.getElementById('a3').value = text[3];
                document.getElementById('a4').value = text[4];
            }
            function onError(result) {
                alert('Cannot process your request at the moment, please try later.');
            }
            move();
      
        }

        function chang2() {
            flag = 1;
            var txt = document.getElementById('Select1').options[document.getElementById('Select1').selectedIndex].text;
            PageMethods.parametr2(txt, onSucess, onError);
            function onSucess(result) {


                document.getElementById('t1').value = result;
            }
            function onError(result) {
                alert('Cannot process your request at the moment, please try later.');
            }
            move();

        }


        function move() {
            if (flag==1) {
                var elem = document.getElementById("myBar");
                var width = 1;
                var id = setInterval(frame, 5);
                function frame() {
                    if (width >= 100) {
                        clearInterval(id);
                    } else {
                        width++;
                        elem.style.width = width + '%';
                    }
                }
            }
            flag = 0;
        }

      onload=  function set()
        {
            PageMethods.fill(onSucess, onError);
            function onSucess(result) {
                var i=0;
                try {
                    var x = document.getElementById("mySelect");
                    while (result[i] != null) {
                        var option = document.createElement("option");
                        option.text = result[i];
                        x.add(option);
                        i++;
                    }
                }
                catch (e) { return; }
                set2();
            }

            function onError(result) {
                alert('Cannot process your request at the moment, please try later.');
            }
      }

      function set2() {
          PageMethods.fill2(onSucess, onError);
          function onSucess(result) {
              var i = 0;
              try {
                  var x = document.getElementById("Select1");
                  while (result[i] != null) {
                      var option = document.createElement("option");
                      option.text = result[i];
                      x.add(option);
                      i++;
                  }
              }
              catch (e) { return; }
          }

          function onError(result) {
              alert('Cannot process your request at the moment, please try later.');
          }
      }


    </script>
</body>
</html>
