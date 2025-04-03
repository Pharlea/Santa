
package tpsemana11;

public class TPSemana11 {
    public static void main(String[] args) {
        Livro umlivro = new Livro();

        MyDAL.geraTabela(umlivro);

        umlivro.setTitulo("Um titulo qualquer");
        umlivro.setAutor("Qualquer um");
        umlivro.setEditora("Uma editora qualquer");
        umlivro.setAno("2017");
        umlivro.setLocalizacao("Santos/SP");
        MyDAL.set(umlivro);
        umlivro.setTitulo("Um titulo qualquer");
        umlivro.setAutor(null);
        umlivro.setEditora(null);
        umlivro.setAno("2017");
        umlivro.setLocalizacao(null);
        MyDAL.delete(umlivro);
    }

}
