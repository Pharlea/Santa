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
        
            <link rel="stylesheet" href="css.css" />
    </head>
    <body>
        <div class="main_div">
            <div>
        <%
        Produto umProduto = new Produto();
            
        umProduto.setCodigo(request.getParameter("codigo"));
        
        ALDAL.get(umProduto, "C:\\Matar\\BD");

        if(Erro.getErro())
            out.println(Erro.getMens());
        else
            out.println("Quantidade: "+umProduto.getQuantidade()+"<br> Preço: "+umProduto.getPreco()); 
        %>
        </div>
        <div>
        <a href="/LoginPeopleware03/pagprodutos.html"><button>Voltar</button></a>
        </div>
    </body>
</html>
