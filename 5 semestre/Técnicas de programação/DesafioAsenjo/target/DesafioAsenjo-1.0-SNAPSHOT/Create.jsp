<%-- 
    Document   : Create
    Created on : 20 de mai. de 2025, 04:09:32
    Author     : raraf
--%>

<%@page import="main.java.utils.ALDAL"%>
<%@page import="desafioasenjo.*"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <link rel="stylesheet" href="Estilos.css" />
    </head>
    <body>
        <%
            Livro umLivro = new Livro();
            
            umLivro.setTitulo(request.getParameter("titulo"));
            umLivro.setAutor(request.getParameter("autor"));
            umLivro.setEditora(request.getParameter("editora"));
            umLivro.setAno(request.getParameter("ano"));
            umLivro.setLocalizacao(request.getParameter("localizacao"));
            

            ALDAL.set(umLivro, "C:Users:raraf:OneDrive:Área de Trabalho:DesafioAsenjo:Livros.db");
         %>
         <a  href="Index.html"><button>Voltar</button></a>
    </body>
</html>
