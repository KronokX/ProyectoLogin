package dao;
import conexion.Conexion;
import modelo.Usuario;
import java.sql.*;
import java.util.*;

public class UsuarioDAO {
    Connection con;
    PreparedStatement ps;
    ResultSet rs;

    public boolean registrar(Usuario u) {
        String sql = "INSERT INTO usuarios(usuario, password, nombre) VALUES (?,?,?)";
        try {
            con = Conexion.getConexion();
            ps = con.prepareStatement(sql);
            ps.setString(1, u.getUsuario());
            ps.setString(2, u.getPassword());
            ps.setString(3, u.getNombre());
            ps.executeUpdate();
            return true;
        } catch (Exception e) {
            System.out.println("Error al registrar: " + e.getMessage());
            return false;
        }
    }

    public boolean verificar(String usuario, String password) {
        String sql = "SELECT * FROM usuarios WHERE usuario=? AND password=?";
        try {
            con = Conexion.getConexion();
            ps = con.prepareStatement(sql);
            ps.setString(1, usuario);
            ps.setString(2, Usuario.encriptarSHA1(password));
            rs = ps.executeQuery();
            return rs.next();
        } catch (Exception e) {
            System.out.println("Error al verificar: " + e.getMessage());
            return false;
        }
    }

    public List<Usuario> listar() {
        List<Usuario> lista = new ArrayList<>();
        String sql = "SELECT * FROM usuarios";
        try {
            con = Conexion.getConexion();
            ps = con.prepareStatement(sql);
            rs = ps.executeQuery();
            while (rs.next()) {
                Usuario u = new Usuario();
                u.setId(rs.getInt("id"));
                u.setUsuario(rs.getString("usuario"));
                u.setNombre(rs.getString("nombre"));
                lista.add(u);
            }
        } catch (Exception e) {
            System.out.println("Error al listar: " + e.getMessage());
        }
        return lista;
    }
}
