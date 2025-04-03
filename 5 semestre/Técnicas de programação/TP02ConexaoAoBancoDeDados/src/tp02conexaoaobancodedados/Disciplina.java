package tp02conexaoaobancodedados;

public class Disciplina 
{
    private String codigo;
    private String nome;
    private String cargaHoraria;


    public Disciplina() {}
    public void setCodigo(String _codigo) {codigo=_codigo;}
    public void setNome(String _nome) {nome=_nome;}
    public void setCargaHoraria(String _cargaHoraria) {cargaHoraria=_cargaHoraria;}

    public String getCodigo() {return codigo;}
    public String getNome() {return nome;}
    public String getCargaHoraria() {return cargaHoraria;}
}
