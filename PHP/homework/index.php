<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
            <script type="text/javascript">
	function checkLogin(form1){
                    if(document.all("text").value==""){  
            alert("对不起，用户名不能为空值!");  
                    form1.id.focus();
                    retrn false;
           }else if(documen.all("pwd").value==""){  
            alert("对不起，密码不能为空值!");
                    form1.pwd.focus();
                    return false;  
           }  else{
                    return true;
	}
</script>
<link href="css.css" rel="stylesheet" type="text/css"/>
    </head>
    
    <body>
        <?php
            
        ?>
        <div class="index">
            <div class="box">
                <span class="title"><strong>登录页面</strong></span>
                <form action="flogin.php" method="post" style="border:1px solid #000">
                    <i class="top"><span>用户名:</span><input type="text" name="text"></i>
                   <i><span>密码:</span><input type="password" name="pwd"></i>
                   <i><input type="submit" value="登录" name="submit"><input type="reset" value="取消"></i>
                </form>
            </div>
        </div>
        
    </body>
    

</html>
