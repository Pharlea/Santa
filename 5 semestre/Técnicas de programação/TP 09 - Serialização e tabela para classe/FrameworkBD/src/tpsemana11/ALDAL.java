/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tpsemana11;

import java.io.File;
import java.io.FileWriter;
import java.lang.reflect.*;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.Statement;
import static tpsemana11.AFDAL.conecta;
import static tpsemana11.AFDAL.desconecta;

/**
 *
 * @author MauricioAsenjo
 */
public class ALDAL {

public static void geraTabela(Object obj)
{
Field[] f  = obj.getClass().getDeclaredFields();
String sql = "Create Table Tab" + obj.getClass().getSimpleName() + " (";


for(int i=0; i<f.length; ++i)
{
    sql += f[i].getName() + " " + (f[i].getType().getSimpleName().equals("String")?"varchar(60)":f[i].getType());
    if (i!=(f.length-1)) sql = sql + ", ";
}
sql += ")";
//System.out.println(sql);
AFDAL.conecta("Livros.mdb");
AFDAL.executeSQL(sql);
AFDAL.desconecta();
}
public static void set(Object obj)
{
Field[] f  = obj.getClass().getDeclaredFields();
String sql = "Insert Into Tab" + obj.getClass().getSimpleName() + " (";
Method mtd;

for(int i=0; i<f.length; ++i)
{
    sql += f[i].getName();
    if (i!=(f.length-1)) sql = sql + ", ";
}
sql += ") values (";
for(int i=0; i<f.length; ++i)
{
    try
    {
    String aux = "get" + f[i].getName().substring(0,1).toUpperCase() + f[i].getName().substring(1);
    mtd = obj.getClass().getMethod(aux);
    
    if (f[i].getType().getSimpleName().equals("String"))  
        sql += "'" + mtd.invoke(obj) + "'";
    else
        sql += mtd.invoke(obj);
    }
    catch(Exception e) {}
    if (i!=(f.length-1)) sql = sql + ", ";
}
sql += ")";
//System.out.println(sql);
AFDAL.conecta("Livros.mdb");
AFDAL.executeSQL(sql);
AFDAL.desconecta();
}
public static void delete(Object obj)
{
    Field[] f  = obj.getClass().getDeclaredFields();
    String sql = "Delete from Tab" + obj.getClass().getSimpleName() + " where ";
    Method mtd;
    String aux1, aux2;
    boolean flag = false;
        
    for (int i =0; i < f.length; ++i)
    {
        try
        {
        aux1 = "get" + f[i].getName().substring(0,1).toUpperCase() + f[i].getName().substring(1);  
        mtd = obj.getClass().getMethod(aux1);
        aux2 = mtd.invoke(obj).toString();
        if (!aux2.equals(""))
        {
            if (flag) sql += " and "; else flag = true;
            sql += f[i].getName() + " = ";
            if (f[i].getType().getSimpleName().equals("String"))  
                sql += "'" + aux2 + "'";
            else
                sql += aux2;
        }
        }
        catch(Exception e) {}
    }
    
    //System.out.println(sql);
    AFDAL.conecta("Livros.mdb");
    AFDAL.executeSQL(sql);
    AFDAL.desconecta();
}
public static void get(Object obj)
{
    Field[] f  = obj.getClass().getDeclaredFields();
    String sql = "Select * from Tab" + obj.getClass().getSimpleName() + " where ";
    Method mtd;
    String aux1, aux2;
    boolean flag = false;
        
    for (int i =0; i < f.length; ++i)
    {
        try
        {
        aux1 = "get" + f[i].getName().substring(0,1).toUpperCase() + f[i].getName().substring(1);  
        mtd = obj.getClass().getMethod(aux1);
        aux2 = mtd.invoke(obj).toString();
        if (!aux2.equals(""))
        {
            if (flag) sql += " and "; else flag = true;
            sql += f[i].getName() + " = ";
            if (f[i].getType().getSimpleName().equals("String"))  
                sql += "'" + aux2 + "'";
            else
                sql += aux2;
        }
        }
        catch(Exception e) {}
    }
    
    System.out.println(sql);
    AFDAL.conecta("Livros.mdb");
    AFDAL.executeSelect(sql, obj);
    AFDAL.desconecta();
}
public static void update(Object dados, Object chaves)
{
    Field[] f  = dados.getClass().getDeclaredFields();
    String sql = "Update Tab" + dados.getClass().getSimpleName() + " set ";
    Method mtd;
    String aux1, aux2;
    boolean flag = false;

    for (int i =0; i < f.length; ++i)
    {
        try
        {
        aux1 = "get" + f[i].getName().substring(0,1).toUpperCase() + f[i].getName().substring(1);  
        mtd = dados.getClass().getMethod(aux1);
        aux2 = mtd.invoke(dados).toString();
        if (!aux2.equals(""))
        {
            if (flag) sql += ", "; else flag = true;
            sql += f[i].getName() + " = ";
            if (f[i].getType().getSimpleName().equals("String"))  
                sql += "'" + aux2 + "'";
            else
                sql += aux2;
        }
        }
        catch(Exception e) {}
    }

    sql += " where ";
    f  = chaves.getClass().getDeclaredFields();
    flag = false;
    
    for (int i =0; i < f.length; ++i)
    {
        try
        {
        aux1 = "get" + f[i].getName().substring(0,1).toUpperCase() + f[i].getName().substring(1);  
        mtd = chaves.getClass().getMethod(aux1);
        aux2 = mtd.invoke(chaves).toString();
        if (!aux2.equals(""))
        {
            if (flag) sql += " and "; else flag = true;
            sql += f[i].getName() + " = ";
            if (f[i].getType().getSimpleName().equals("String"))  
                sql += "'" + aux2 + "'";
            else
                sql += aux2;
        }
        }
        catch(Exception e) {}
    }
    
    AFDAL.conecta("Livros.mdb");
    AFDAL.executeSQL(sql);
    AFDAL.desconecta();
}
public static void geraClasse(String _tabela, String _package) {
    // Remove o prefixo "tab" se estiver presente
    String nomeClasse = _tabela.startsWith("Tab") ? _tabela.substring(3) : _tabela;

    File arquivo = new File(nomeClasse + ".java");
    ResultSet rs;
    ResultSetMetaData rsmd;

    Connection con = conecta("Livros.mdb");
    Erro.setErro(false);
    try {
        Statement st = con.createStatement();
        rs = st.executeQuery("Select * from " + _tabela);
        rsmd = rs.getMetaData();
        String aux;

        FileWriter fw = new FileWriter(arquivo);
        fw.write("package " + _package + ";\n\n");
        fw.write("public class " + nomeClasse + " {\n\n");

        fw.write("    public " + nomeClasse + "() {}\n\n");

        for (int i = 1; i <= rsmd.getColumnCount(); ++i) {
            aux = rsmd.getColumnName(i);
            fw.write("    private String " + aux + ";\n");
        }
        fw.write("\n");

        for (int i = 1; i <= rsmd.getColumnCount(); ++i) {
            aux = rsmd.getColumnName(i);
            String metodo = aux.substring(0, 1).toUpperCase() + aux.substring(1);

            fw.write("    public String get" + metodo + "() {\n");
            fw.write("        return " + aux + ";\n");
            fw.write("    }\n\n");

            fw.write("    public void set" + metodo + "(String " + aux + ") {\n");
            fw.write("        this." + aux + " = " + aux + ";\n");
            fw.write("    }\n\n");
        }

        fw.write("}\n");
        fw.flush();
        fw.close();
        st.close();
    } catch(Exception e) {
        Erro.setErro(e.getMessage());
    }
    desconecta();
}

public static void serializaJSON(Object obj) {
    Field[] f = obj.getClass().getDeclaredFields();
    Method mtd;
    File arquivo = new File(obj.getClass().getSimpleName() + ".json"); // melhor extensão
    String Json = "{";

    for (int i = 0; i < f.length; ++i) {
        try {
            String aux = "get" + f[i].getName().substring(0, 1).toUpperCase() + f[i].getName().substring(1);
            Json += "'" + f[i].getName() + "': ";
            mtd = obj.getClass().getMethod(aux);
            Json += "'" + mtd.invoke(obj) + "'";
        } catch (Exception e) {
            Erro.setErro(e.getMessage());
        }
        if (i != (f.length - 1)) Json = Json + ",";
    }

    Json += "}";

    try {
        FileWriter fw = new FileWriter(arquivo);
        fw.write(Json);
        fw.close();
    } catch (Exception e) {
        Erro.setErro(e.getMessage());
    }
}


}
