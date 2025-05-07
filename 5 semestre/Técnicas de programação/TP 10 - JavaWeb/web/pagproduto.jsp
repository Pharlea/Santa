<%-- 
    Document   : pagcadastrar
    Created on : 31/10/2017, 08:20:36
    Author     : asenj
--%>

<%@page import="packLogar.Produto"%>
<%@page import="packLogar.Erro"%>
<%@page import="packLogar.ALDAL"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <%
        Produto umProduto = new Produto();
            
        umProduto.setCodigo(request.getParameter("codigo"));
        umProduto.setQuantidade(request.getParameter("quantidade"));
        umProduto.setPreco(request.getParameter("preco"));
        
        ALDAL.set(umProduto, "C:\\Matar\\BD");

        if(Erro.getErro())
            out.println(Erro.getMens());
        else
            out.println("Produto cadastrado com sucesso!");  
        %>
    </body>
</html>
