<%-- 
    Document   : pagcadastrar
    Created on : 31/10/2017, 08:20:36
    Author     : asenj
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
        
        packLogar.LoginDAL.insereUsuario();

        if(packLogar.Erro.getErro())
            out.println(packLogar.Erro.getMens());
        else
            out.println("Usuario cadastrado com sucesso!");  
        %>
    </body>
</html>
