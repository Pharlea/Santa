/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tpsemana11;

/**
 *
 * @author MauricioAsenjo
 */
public class TPSemana11 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Livro umlivro = new Livro();
        Livro umachave = new Livro();

        umlivro.setTitulo("1");
        umlivro.setAutor("1");
        umlivro.setEditora("1");
        umlivro.setAno("1");
        umlivro.setLocalizacao("1");
        MyDAL.set(umlivro);
        
        umlivro.setTitulo("1");
        umlivro.setAutor(null);
        umlivro.setEditora(null);
        umlivro.setAno("1");
        umlivro.setLocalizacao(null);
        MyDAL.select(umlivro);
        
        umlivro.setTitulo("1");
        umlivro.setAutor("1");
        umlivro.setEditora(null);
        umlivro.setAno(null);
        umlivro.setLocalizacao(null);
        
        umachave.setTitulo("1");
        MyDAL.update(umlivro, umachave);
        
        umlivro.setTitulo("1");
        umlivro.setAutor(null);
        umlivro.setEditora(null);
        umlivro.setAno(null);
        umlivro.setLocalizacao(null);
        MyDAL.delete(umlivro);
    }
    
}
