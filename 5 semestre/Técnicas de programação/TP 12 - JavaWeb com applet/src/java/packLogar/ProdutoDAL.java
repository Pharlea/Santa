/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package packLogar;

import java.sql.*;
/**
 *
 * @author MauricioAsenjo
 */
public class ProdutoDAL {
    private static Connection con;

    public static void conecta(String _alias, String _usuario, String _senha)
    {
    try {
      Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
      con = DriverManager.getConnection("jdbc:ucanaccess://"+_alias,_usuario,_senha);
    }
    catch (Exception e) { Erro.setErro(e.getMessage()); }
    }

    public static void desconecta()
    {
    try {
      con.close();
    }
    catch (Exception e) { Erro.setErro(e.getMessage()); }
    }

    public static void consultaUsuario()
    {
    ResultSet rs;
    String aux = "SELECT * FROM TabLogin where Login='" + Login.getUsuario() + "' and Senha=" + Login.getSenha();
    
    Erro.setErro(false);
    conecta("C:\\matar\\BD.mdb","","");
    if (Erro.getErro()) return;
    try {
        Statement st = con.createStatement();
        rs = st.executeQuery(aux);
        if (rs.next())
        {
          Erro.setErro(false);
        }
        else
        {
          Erro.setErro(true);
        }
        st.close();
    }
    catch(Exception e){ Erro.setErro(e.getMessage()); }
    desconecta();
    }    

    public static void insereUsuario()
    {
    String aux = "INSERT INTO TabLogin (Login,Senha) VALUES ('" + Login.getUsuario() + "'," + Login.getSenha() + ")";
    
    Erro.setErro(false);
    conecta("C:\\matar\\BD.mdb","","");
    if (Erro.getErro()) return;
    try {
        Statement st = con.createStatement();
        st.executeUpdate(aux);
        st.close();
    }
    catch(Exception e){ Erro.setErro("Usuario e/ou senha não cadastrado!"); }
    desconecta();
    }
}
