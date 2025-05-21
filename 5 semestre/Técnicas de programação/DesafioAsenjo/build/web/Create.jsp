<%-- 
    Document   : Create
    Created on : 20 de mai. de 2025, 04:09:32
    Author     : raraf
--%>

<%@page import="tpsemana11.*"%>
<%@page import="classes.Livro"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <link rel="stylesheet" href="Estilos.css" />
    </head>
    <body>
        <div class="MainMenu">
        <%
            Livro umLivro = new Livro();
            
            
            
            String metodo = request.getParameter("metodo");
            
            if (metodo.equals("create"))
            {
                String caminhoBD = application.getRealPath("/WEB-INF/db/Livros.db");
                umLivro.setTitulo(request.getParameter("titulo"));
                umLivro.setAutor(request.getParameter("autor"));
                umLivro.setEditora(request.getParameter("editora"));
                umLivro.setAno(request.getParameter("ano"));
                umLivro.setLocalizacao(request.getParameter("localizacao")); 
                ALDAL.set(umLivro, caminhoBD);
            }
            if (metodo.equals("read"))
            {   
                out.print(metodo);

                String caminhoBD = application.getRealPath("/WEB-INF/db/Livros.db");
                umLivro.setTitulo(request.getParameter("titulo"));
                umLivro.setAutor(null);
                umLivro.setEditora(null);
                umLivro.setAno(null);
                umLivro.setLocalizacao(null);
                ALDAL.get(umLivro, caminhoBD);

                out.print(""+umLivro.getTitulo()+"\n"+umLivro.getAutor()+"\n"+umLivro.getEditora()+"\n"+umLivro.getAno());
            }
            if (metodo.equals("delete")){
                String caminhoBD = application.getRealPath("/WEB-INF/db/Livros.db");
                umLivro.setTitulo(request.getParameter("titulo"));
                umLivro.setAutor(null);
                umLivro.setEditora(null);
                umLivro.setAno(null);
                umLivro.setLocalizacao(null);
                ALDAL.delete(umLivro, caminhoBD);
            }
            if (metodo.equals("update")){
                Livro livroDois = new Livro();
                String caminhoBD = application.getRealPath("/WEB-INF/db/Livros.db");
                umLivro.setTitulo(request.getParameter("titulo"));
                umLivro.setAutor(request.getParameter("autor"));
                umLivro.setEditora(request.getParameter("editora"));
                umLivro.setAno(request.getParameter("ano"));
                umLivro.setLocalizacao(request.getParameter("localizacao"));
                
                livroDois.setTitulo(umLivro.getTitulo());
                ALDAL.get(livroDois, caminhoBD);
                ALDAL.update(umLivro, livroDois, caminhoBD);
            }

         %>
         <a  href="index.html"><button>Voltar</button></a>
        </div>
    </body>
</html>
