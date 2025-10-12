package modelo;
import java.security.MessageDigest;

public class Usuario {
    private int id;
    private String usuario;
    private String password;
    private String nombre;

    public Usuario() {}

    public Usuario(String usuario, String password, String nombre) {
        this.usuario = usuario;
        this.password = encriptarSHA1(password);
        this.nombre = nombre;
    }

    public static String encriptarSHA1(String pass) {
    try {
        MessageDigest md = MessageDigest.getInstance("SHA-1");
        byte[] bytes = md.digest(pass.getBytes("UTF-8"));
        StringBuilder sb = new StringBuilder();
        for (byte b : bytes) sb.append(String.format("%02x", b));
        return sb.toString();
    } catch (Exception e) {
        return null;
    }
}


    // Getters y setters
    public int getId() { return id; }
    public void setId(int id) { this.id = id; }
    public String getUsuario() { return usuario; }
    public void setUsuario(String usuario) { this.usuario = usuario; }
    public String getPassword() { return password; }
    public void setPassword(String password) { this.password = password; }
    public String getNombre() { return nombre; }
    public void setNombre(String nombre) { this.nombre = nombre; }
}
