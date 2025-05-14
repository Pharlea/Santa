import java.applet.Applet;
import java.awt.*;
import java.awt.event.*;
import javax.swing.JOptionPane;

public class applet extends Applet implements ActionListener
{
    private Label lb_peso;
    private Label lb_altura;
    private Label lb_imc;

    private TextField tf_altura;
    private TextField tf_peso;
    private TextField tf_imc;

    private Button bt;


    public void init() {
        lb_peso = new Label("Peso: ");
        tf_peso = new TextField(3);

        lb_altura = new Label("Altura: ");
        tf_altura = new TextField(3);

        lb_imc = new Label("imc: ");
        tf_imc = new TextField(4);

        bt = new Button("Calcular");

        add(lb_peso);
        add(tf_peso);
        add(lb_altura);
        add(tf_altura);
        add(lb_imc);
        add(tf_imc);
        add(bt);

        bt.addActionListener(this);
    }

    public void actionPerformed(ActionEvent e)
    {
        Pessoa p = new Pessoa();
        try
        {
            p.setPeso(tf_peso.getText());
            p.setAltura(tf_altura.getText());    
        }
        catch(Exception err)
        {
            Erro.setErro(err.getMessage());
        }        
        
        BLL.verificaDados(p);
        
        if(!Erro.getErro())
        {
            Float imc = Float.parseFloat(p.getPeso())/(Float.parseFloat(p.getAltura())*Float.parseFloat(p.getAltura()));
            tf_imc.setText(""+imc);
        }
        else
        {
            JOptionPane.showMessageDialog(null, Erro.getMens());
        }
    }
}
