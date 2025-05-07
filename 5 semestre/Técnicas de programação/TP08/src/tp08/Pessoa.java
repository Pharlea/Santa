/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tp08;

/**
 *
 * @author unisanta
 */
public class Pessoa {
    private  String nome;
    private  String email;
    private  String nomemae;

    public Pessoa() {}
    public  void setNome(String _nome) {nome=_nome;}
    public  void setEmail(String _email) {email=_email;}
    public  void setNomemae(String _nomemae) {nomemae=_nomemae;}

    public  String getNome() {return nome;}
    public  String getEmail() {return email;}
    public  String getNomemae() {return nomemae;}
}
