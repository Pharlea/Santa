package gerarcomandosqlcombaseemclasse;

import java.lang.reflect.Field;
import java.util.ArrayList;
import java.util.List;

public class GerarComandoSQLComBaseEmClasse {

    public static void main(String[] args) 
    {
        Livro obj = new Livro();
        List<String> lista = new ArrayList<String>();
        List<String> listaTipos = new ArrayList<String>();
        String campos = "";

        String classe = obj.getClass().getSimpleName();
        for (Field f : obj.getClass().getDeclaredFields())
        {
            lista.add(f.getName());
            listaTipos.add(f.getType().getSimpleName());
        }

        for (int i = 0; i < listaTipos.size(); i++)
        {
            if (listaTipos.get(i).equals("String"))
            {
                listaTipos.set(i, "Varchar");
            }
        }

        for (int i = 0; i < lista.size(); i++)
        {
            campos += lista.get(i) + ":" + listaTipos.get(i) +", ";
        }

        campos = campos.substring(0, campos.lastIndexOf(","));

        System.out.println("CREATE TABLE TAB" + classe + " ("+ campos +")");
    }
    
}
