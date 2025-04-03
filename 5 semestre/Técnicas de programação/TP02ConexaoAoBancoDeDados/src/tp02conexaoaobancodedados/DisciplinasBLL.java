package tp02conexaoaobancodedados;

public class DisciplinasBLL {
public static void validaDados(Disciplina umaDisciplina)
{
 Erro.setErro(false);
 if (umaDisciplina.getNome().equals(""))
   {Erro.setErro("O campo AUTOR é de preenchimento obrigatório..."); return;}
 
 if (umaDisciplina.getCargaHoraria().equals(""))
   {Erro.setErro("O campo Carga Horária é de preenchimento obrigatório..."); return;}
 else
   try
     {
     Integer.parseInt(umaDisciplina.getCargaHoraria());
     }
   catch (Exception e)
     {
     Erro.setErro("O campo Carga Horária deve ser numerico!"); return;
     }
 
 if (umaDisciplina.getCodigo().equals(""))
   {Erro.setErro("O campo Código é de preenchimento obrigatório..."); return;}
 else
   try
     {
     Integer.parseInt(umaDisciplina.getCodigo());
     }
   catch (Exception e)
     {
     Erro.setErro("O campo ANO EDICAO deve ser numerico!"); return;
     }
 
   DisciplinasDAL.conecta("Livros.mdb");
   if (Erro.getErro()) return;

   DisciplinasDAL.inseriDisciplina(umaDisciplina);
   if (Erro.getErro()) return;

   DisciplinasDAL.desconecta();
}    

public static void validaDadosParaUpdate(Disciplina umaDisciplina)
{
 Erro.setErro(false);
 if (umaDisciplina.getNome().equals(""))
   {Erro.setErro("O campo AUTOR é de preenchimento obrigatório..."); return;}
 
 if (umaDisciplina.getCargaHoraria().equals(""))
   {Erro.setErro("O campo Carga Horária é de preenchimento obrigatório..."); return;}
 else
   try
     {
     Integer.parseInt(umaDisciplina.getCargaHoraria());
     }
   catch (Exception e)
     {
     Erro.setErro("O campo Carga Horária deve ser numerico!"); return;
     }
 
 if (umaDisciplina.getCodigo().equals(""))
   {Erro.setErro("O campo Código é de preenchimento obrigatório..."); return;}
 else
   try
     {
     Integer.parseInt(umaDisciplina.getCodigo());
     }
   catch (Exception e)
     {
     Erro.setErro("O campo ANO EDICAO deve ser numerico!"); return;
     }
 
   DisciplinasDAL.conecta("Livros.mdb");
   if (Erro.getErro()) return;

   DisciplinasDAL.desconecta();
}
public static void validaCodigo(Disciplina umaDisciplina)
{
 Erro.setErro(false);
 if (umaDisciplina.getCodigo().equals(""))
   {Erro.setErro("O campo Código é de preenchimento obrigatório..."); return;}
 else
   try
     {
     Integer.parseInt(umaDisciplina.getCodigo());
     }
   catch (Exception e)
     {
     Erro.setErro("O campo ANO EDICAO deve ser numerico!"); return;
     }
 
 DisciplinasDAL.conecta("Livros.mdb");
 if (Erro.getErro()) return;
 
 DisciplinasDAL.consultaDisciplina(umaDisciplina);
 if (Erro.getErro()) return;
 
 DisciplinasDAL.desconecta();
}
public static void deletaDisciplina(Disciplina umaDisciplina){
     DisciplinasDAL.conecta("Livros.mdb");
 if (Erro.getErro()) return;
    DisciplinasDAL.deletaDisciplina(umaDisciplina);
    DisciplinasDAL.desconecta();
}

public static void atualizaDisciplina(Disciplina umaDisciplina){
     DisciplinasDAL.conecta("Livros.mdb");
 if (Erro.getErro()) return;
    DisciplinasDAL.atualizaDisciplina(umaDisciplina);
    DisciplinasDAL.desconecta();
}
}
