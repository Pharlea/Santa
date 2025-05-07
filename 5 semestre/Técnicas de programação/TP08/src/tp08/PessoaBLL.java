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
public class PessoaBLL {
    public static void verificaDados(Pessoa _umaPessoa){
        Erro.setErro(false);
        
        if(_umaPessoa.getNome().equals("")){
            Erro.setErro("O campo nome é obrigatório");
        }
        else if(_umaPessoa.getEmail().equals("")){
            Erro.setErro("O campo email é obrigatório");
        }
        else if(_umaPessoa.getNomemae().equals("")){
            Erro.setErro("O campo nome da mae é obrigatório");
        }
    }
    public static void verificaTitulo(Pessoa _umaPessoa){
        Erro.setErro(false);
        
        if(_umaPessoa.getNome().equals("")){
            Erro.setErro("O campo nome é obrigatório");
        }
    }
}
