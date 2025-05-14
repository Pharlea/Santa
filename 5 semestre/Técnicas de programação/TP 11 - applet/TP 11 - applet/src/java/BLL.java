/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author unisanta
 */
public class BLL {
    public static void verificaDados(Pessoa _p)
    {
        Erro.setErro(false);
        try
        {
            if(_p.getPeso().isEmpty())
            {
               Erro.setErro("O peso não pode ser nulo");
               return;
            }
            
            if(_p.getAltura().isEmpty())
            {
               Erro.setErro("A altura não pode ser nula");
               return;
            }
            
            try
            {
                Float.parseFloat(_p.getPeso());
            }
            catch(Exception e)
            {
               Erro.setErro("O peso deve ser um número");
               return;
            }
            
            try
            {
                Float.parseFloat(_p.getAltura());
            }
            catch(Exception e)
            {
               Erro.setErro("A altura deve ser um número");
               return;
            }
            
            if (Float.parseFloat(_p.getPeso())<0)
            {
               Erro.setErro("O peso deve ser um número positivo");
               return;
            }
            if (Float.parseFloat(_p.getAltura())<0)
            {
               Erro.setErro("A altura deve ser um número positivo");
               return;
            }
        }
        catch(Exception e)
        {
           Erro.setErro(""+e.getMessage());
           return;
        }
    }
}
