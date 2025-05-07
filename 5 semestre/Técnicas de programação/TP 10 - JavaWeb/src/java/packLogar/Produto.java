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
public class Produto {
    private String codigo;
    private String quantidade;
    private String preco;
    
    public void setCodigo(String _codigo) {codigo=_codigo;}
    public void setQuantidade(String _quantidade) {quantidade=_quantidade;}
    public void setPreco(String _preco) {preco=_preco;}
    public String getCodigo() {return codigo;}
    public String getQuantidade() {return quantidade;}
    public String getPreco() {return preco;}

}
