/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author unisanta
 */
public class Pessoa {
    private static String peso;
    private static String altura;
    
    public static void setPeso (String _peso)
    {
        peso = _peso;
    }
    public static void setAltura (String _altura)
    {
        altura = _altura;
    }
    
    public static String getPeso()
    {
        return peso;
    }
    public static String getAltura()
    {
        return altura;
    }
}
