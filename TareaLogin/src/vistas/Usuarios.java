package vistas;
import dao.UsuarioDAO;
import modelo.Usuario;
import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.util.List;

public class Usuarios extends JFrame {
    public Usuarios() {
        setTitle("Usuarios Registrados");
        setSize(400, 300);
        setLocationRelativeTo(null);

        UsuarioDAO dao = new UsuarioDAO();
        List<Usuario> lista = dao.listar();
        String[] columnas = {"ID", "Usuario", "Nombre"};
        DefaultTableModel modelo = new DefaultTableModel(columnas, 0);

        for (Usuario u : lista)
            modelo.addRow(new Object[]{u.getId(), u.getUsuario(), u.getNombre()});

        JTable tabla = new JTable(modelo);
        add(new JScrollPane(tabla), BorderLayout.CENTER);
    }
}
