/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package reflection01;

/**
 *
 * @author MauricioAsenjo
 */
public class Ex01 {
    private static int a;
    private static int b;

    public static void setA(int _a) {a=_a; System.out.println("Recebi o valor " + _a);}
    public static void setB(int _b) {b=_b; System.out.println("Recebi o valor " + _b);}
    public static void setAB(int _a, int _b)
    {
        a=_a; System.out.println("Recebi o valor " + _a);
        b=_b; System.out.println("Recebi o valor " + _b);
    }
    public static int getA() {return a;}
    public static int getB() {return b;}
    public static int getSoma() {return a+b;}
}
