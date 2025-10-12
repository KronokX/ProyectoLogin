package vistas;
import dao.UsuarioDAO;
import modelo.Usuario;
import javax.swing.*;
import java.awt.*;

public class Registrar extends JFrame {
    JTextField txtUsuario, txtNombre;
    JPasswordField txtPassword;
    UsuarioDAO dao = new UsuarioDAO();

    public Registrar() {
        setTitle("Registrar Usuario");
        setSize(300, 200);
        setLocationRelativeTo(null);
        setLayout(new GridLayout(4,2));

        txtUsuario = new JTextField();
        txtPassword = new JPasswordField();
        txtNombre = new JTextField();
        JButton btnGuardar = new JButton("Guardar");

        add(new JLabel("Usuario:"));
        add(txtUsuario);
        add(new JLabel("Contraseña:"));
        add(txtPassword);
        add(new JLabel("Nombre:"));
        add(txtNombre);
        add(btnGuardar);

        btnGuardar.addActionListener(e -> {
            String user = txtUsuario.getText();
            String pass = new String(txtPassword.getPassword());
            String nom = txtNombre.getText();
            if (!user.isEmpty() && !pass.isEmpty()) {
                Usuario u = new Usuario(user, pass, nom);
                if (dao.registrar(u))
                    JOptionPane.showMessageDialog(this, "Usuario registrado");
                else
                    JOptionPane.showMessageDialog(this, "Error al registrar");
            }
        });
    }
}
