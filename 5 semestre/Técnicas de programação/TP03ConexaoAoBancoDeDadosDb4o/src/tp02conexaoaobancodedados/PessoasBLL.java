package tp02conexaoaobancodedados;

public class PessoasBLL 
{
    public static void validaDados (Pessoa _pessoa)
    {
        Erro.setErro(false);
        
        PessoasDAL.conecta();
        
        /*
        * Teste de nome
        */
        if (_pessoa.getNome().length() == 0) 
        {
            Erro.setErro("O campo de nome é obrigatório!");
            return;
        }
        /*
        * Teste de sexo
        */
        if (_pessoa.getSexo().length() == 0)
        {
            Erro.setErro("O campo de Sexo é obrigatório!");
            return;
        }
        if (!_pessoa.getSexo().equals("masculino") && !_pessoa.getSexo().equals("feminino") && !_pessoa.getSexo().equals("m") && !_pessoa.getSexo().equals("f"))
        {
            
            Erro.setErro("Para o campo sexo são aceitos apenas os valores 'masculino' ou 'feminino'!");
            return;
        }
        /*
        * Teste de código
        */
        if (_pessoa.getCodigo().length() == 0)
        {
            Erro.setErro("O campo de Código é obrigatório!");
            return;
        }
        else
        {
            try
            {
                Integer.parseInt(_pessoa.getCodigo());
            }
            catch(Exception e)
            {
                Erro.setErro("O campo de Código deve ser numérico!");
                return;
            }
        }
        /*
        * Teste de idade
        */
        if (_pessoa.getIdade().length() == 0)
        {
            Erro.setErro("O campo de Idade é obrigatório!");
            return;
        }
        else
        {
            try
            {
                Integer.parseInt(_pessoa.getCodigo());
            }
            catch(Exception e)
            {
                Erro.setErro("O campo de Idade deve ser numérico!");
                return;
            }
        }
        
        PessoasDAL.desconecta();
    }
    
    public static void validaCodigo(Pessoa _pessoa)
    {
        Erro.setErro(false);
        PessoasDAL.desconecta();
        
        if (_pessoa.getCodigo().length() == 0)
            Erro.setErro("O campo de Código é obrigatório!");
        else
            try
            {
                Integer.parseInt(_pessoa.getCodigo());
            }
            catch(Exception e)
            {
                Erro.setErro("O campo de Código deve ser numérico!");
                return;
            }
        
            PessoasDAL.desconecta();
    }
    
    public static void atualizaPessoa(Pessoa _pessoa)
    {
        PessoasDAL.conecta();
        PessoasDAL.atualizaPessoa(_pessoa);
        PessoasDAL.desconecta();
    }
    
    public static void deletaPessoa(Pessoa _pessoa)
    {
        PessoasDAL.conecta();
        PessoasDAL.deletaPessoa(_pessoa);
        PessoasDAL.desconecta();
    }
    
    public static void inserePessoa(Pessoa _pessoa)
    {
        PessoasDAL.conecta();
        PessoasDAL.inseriPessoa(_pessoa);
        PessoasDAL.desconecta();
    }
    
    public static void consultaPessoa(Pessoa _pessoa)
    {
        PessoasDAL.conecta();
        PessoasDAL.consultaPessoa(_pessoa);
        PessoasDAL.desconecta();
        
    }
}
