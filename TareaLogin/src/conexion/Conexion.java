package conexion;
import java.sql.Connection;
import java.sql.DriverManager;

public class Conexion {
    private static final String URL = "jdbc:mysql://127.0.0.1:3307/login_db";
    private static final String USER = "root";
    private static final String PASSWORD = "";

    public static Connection getConexion() {
        try {
            Class.forName("com.mysql.cj.jdbc.Driver");
            return DriverManager.getConnection(URL, USER, PASSWORD);
        } catch (Exception e) {
            System.out.println("Error en conexión: " + e.getMessage());
            return null;
        }
    }
}
