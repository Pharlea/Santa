<%-- 
    Document   : paglogar
    Created on : 03/09/2014, 12:20:36
    Author     : MauricioAsenjo
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <% 
        packLogar.Login.setUsuario(request.getParameter("usuario"));
        packLogar.Login.setSenha(request.getParameter("senha"));
        
        packLogar.LoginDAL.consultaUsuario();
        
        if(packLogar.Erro.getErro())
            out.println("Usuario e/ou senha invalidos!");
        else
            out.println("Seja bem vindo " + packLogar.Login.getUsuario());  
        %>
    </body>
</html>
