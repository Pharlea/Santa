/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package reflection01;

//import java.lang.reflect.Field;
import java.lang.reflect.Method;

/**
 *
 * @author MauricioAsenjo
 */
public class Reflection01 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Ex01 obj = new Ex01();
        Method mtd;
        
        obj.setA(5);
        obj.setB(7);
        System.out.println("Soma = " + obj.getSoma());
        
        try{
        mtd = obj.getClass().getMethod("setA", new Class[] {int.class});
        mtd.invoke(obj, new Object[] {5});
        
        mtd = obj.getClass().getMethod("setB", new Class[] {int.class});
        mtd.invoke(obj, new Object[] {7});

        mtd = obj.getClass().getMethod("getSoma");
        System.out.println("Soma = " + mtd.invoke(obj));
        }
        catch(Exception e){System.out.println(e.getMessage());}
        
        try{
        mtd = obj.getClass().getMethod("setAB", new Class[] {int.class, int.class});
        mtd.invoke(obj, new Object[] {1,2});

        mtd = obj.getClass().getMethod("getSoma");
        System.out.println("Soma = " + mtd.invoke(obj));
        }
        catch(Exception e){System.out.println(e.getMessage());}
        
      
    }
}
