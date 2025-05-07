/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package packLogar;

/**
 *
 * @author MauricioAsenjo
 */
public class Login {
    private static String usuario;
    private static String senha;
    
    public static void setUsuario(String _usuario) {usuario=_usuario;}
    public static void setSenha(String _senha) {senha=_senha;}
    public static String getUsuario() {return usuario;}
    public static String getSenha() {return senha;}
}
