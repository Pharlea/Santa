package tp02conexaoaobancodedados;
import com.db4o.Db4o;
import com.db4o.ObjectContainer;
import com.db4o.ObjectSet;

public class PessoasDAL 
{
    private static ObjectContainer db;
    
    public static void conecta()
    {
        try
        {
            db = Db4o.openFile("umIncrivelBanco.dbo");
        }
        catch(Exception e)
        {
            Erro.setErro(e.getMessage());
        }
    }
    
    public static void desconecta()
    {
        try
        {
            db.close();
        }
        catch(Exception e)
        {
            Erro.setErro(e.getMessage());
        }
    }
    
    public static void inseriPessoa(Pessoa umaPessoa)
    {
        Erro.setErro(false);
        try 
        {
            db.set(umaPessoa);
        }
        catch(Exception e)
        {
            Erro.setErro(e.getMessage());
        }
    }

    public static void consultaPessoa(Pessoa _umaPessoa)
    {
        ObjectSet<Pessoa> lista;

        try
        {
            lista = db.get(_umaPessoa);
            
            if (lista.hasNext())
            {
                Pessoa aux = lista.next();
                
                _umaPessoa.setNome(aux.getNome());
                _umaPessoa.setSexo(aux.getSexo());
                _umaPessoa.setIdade(aux.getIdade());
                
               
            }
            else
            {
                Erro.setErro("Pessoa não encontrada!");                
            }
        }
        catch(Exception e)
        {
            Erro.setErro(e.getMessage());
        }
       
    }
    
    
    
    
    public static void deletaPessoa(Pessoa _umaPessoa)
    {
        Erro.setErro(false);
        ObjectSet<Pessoa> lista;
        
        try
        {
            lista = db.get(_umaPessoa);
            
            if (lista.hasNext())
            {
                _umaPessoa = lista.next();
                db.delete(_umaPessoa);
            }
                        else
            {
                Erro.setErro("Pessoa não encontrada!");
            }
        }
        catch(Exception e)
        {
            Erro.setErro(e.getMessage());
        }
    }
    
    
    
    
    public static void atualizaPessoa(Pessoa _umaPessoa) 
    {
        Erro.setErro(false);
        ObjectSet<Pessoa> lista;
        Pessoa consulta = new Pessoa();
        
        consulta.setCodigo(_umaPessoa.getCodigo());

        try 
        {
            lista = db.get(consulta);
            if (lista.hasNext())
            {
                consulta = lista.next();
                consulta.setNome(_umaPessoa.getNome());
                consulta.setSexo(_umaPessoa.getSexo());
                consulta.setIdade(_umaPessoa.getIdade());
                
                db.set(consulta);
            }            
            else
            {
                Erro.setErro("Pessoa não encontrada!");
            }
            
        } 
        catch (Exception e) 
        {
            Erro.setErro(e.getMessage());
        }
    }
}
