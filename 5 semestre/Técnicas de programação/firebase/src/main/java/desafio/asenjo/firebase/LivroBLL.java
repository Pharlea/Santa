package desafio.asenjo.firebase;

public class LivroBLL {
  public static void validaDados(Livro umlivro) {
    Erro.setErro(false);
    if (umlivro.getTitulo().equals("")) {
      Erro.setErro("O campo TITULO é de preenchimento obrigatório...");
      return;
    }
    if (umlivro.getAutor().equals("")) {
      Erro.setErro("O campo AUTOR é de preenchimento obrigatório...");
      return;
    }
    if (umlivro.getEditora().equals("")) {
      Erro.setErro("O campo EDITORA é de preenchimento obrigatório...");
      return;
    }
    if (umlivro.getAnoEdicao().equals("")) {
      Erro.setErro("O campo ANO EDICAO é de preenchimento obrigatório...");
      return;
    } else
      try {
        Integer.parseInt(umlivro.getAnoEdicao());
      } catch (Exception e) {
        Erro.setErro("O campo ANO EDICAO deve ser numerico!");
        return;
      }
    if (umlivro.getLocalizacao().equals("")) {
      Erro.setErro("O campo LOCALIZACAO é de preenchimento obrigatório...");
      return;
    }
    LivroDAL.conecta();
    if (Erro.getErro())
      return;
    LivroDAL.inseriLivro(umlivro);
  }

  public static void validaTitulo(Livro umlivro) {
    Erro.setErro(false);
    if (umlivro.getTitulo().equals("")) {
      Erro.setErro("O campo TITULO é de preenchimento obrigatório...");
      return;
    }
    LivroDAL.conecta();
    if (Erro.getErro())
      return;
    LivroDAL.consultaLivro(umlivro);
    if (Erro.getErro())
      return;
  }
}
