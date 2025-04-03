package tpsemana11;

import java.lang.reflect.*;

public class MyDAL {

    public static void geraTabela(Object obj) {
        Field[] f = obj.getClass().getDeclaredFields();
        String sql = "Create Table Tab" + obj.getClass().getSimpleName() + " (";

        for (int i = 0; i < f.length; ++i) {
            sql += f[i].getName() + " "
                    + (f[i].getType().getSimpleName().equals("String") ? "varchar(60)" : f[i].getType());
            if (i != (f.length - 1))
                sql = sql + ", ";
        }
        sql += ")";
        System.out.println(sql);
    }

    public static void set(Object obj) {
        Field[] f = obj.getClass().getDeclaredFields();
        String sql = "Insert Into Tab" + obj.getClass().getSimpleName() + " (";

        for (int i = 0; i < f.length; i++) {
            sql += f[i].getName();

            if (i != (f.length - 1))
                sql = sql + ", ";
        }

        sql += ") values (";

        for (int i = 0; i < f.length; i++) {
            String fieldName = f[i].getName();
            String value = "";
            String methodName = "get" + (fieldName.substring(0, 1).toUpperCase() + fieldName.substring(1));
            Method mtd;

            try {
                mtd = obj.getClass().getMethod("" + methodName);
                value = "" + mtd.invoke(obj);
            } catch (Exception e) {
                System.out.println(e.getMessage());
            }

            sql += "'" + value + "'";

            if (i != (f.length - 1))
                sql = sql + ", ";
        }

        sql += ")";

        System.out.println(sql);
    }

    public static void delete(Object obj) {
        Field[] f = obj.getClass().getDeclaredFields();
        String sql = "DELETE FROM Tab" + obj.getClass().getSimpleName() + " WHERE ";

        for (int i = 0; i < f.length; i++) {
            String fieldName = f[i].getName();
            String value = "";
            String methodName = "get" + (fieldName.substring(0, 1).toUpperCase() + fieldName.substring(1));
            Method mtd;

            try {
                mtd = obj.getClass().getMethod("" + methodName);
                value = "" + mtd.invoke(obj);

                if (!mtd.invoke(obj).equals(null)) {
                    if (i != (f.length - 1) && i != 0)
                        sql = sql + " AND ";
                    sql += fieldName + "=" + "'" + value + "'";

                }
            } catch (Exception e) {
            }

        }
        sql += ";";
        System.out.println(sql);
    }

}
