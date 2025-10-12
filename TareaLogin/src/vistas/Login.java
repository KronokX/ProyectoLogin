package vistas;
import dao.UsuarioDAO;
import modelo.Usuario;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Login extends JFrame {
    JTextField txtUsuario;
    JPasswordField txtPassword;
    UsuarioDAO dao = new UsuarioDAO();

    public Login() {
        setTitle("Login");
        setSize(300, 200);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setLayout(new GridLayout(4,1));

        txtUsuario = new JTextField();
        txtPassword = new JPasswordField();
        JButton btnLogin = new JButton("Ingresar");
        JButton btnRegistrar = new JButton("Registrar");

        add(new JLabel("Usuario:"));
        add(txtUsuario);
        add(new JLabel("Contraseña:"));
        add(txtPassword);
        add(btnLogin);
        add(btnRegistrar);

        btnLogin.addActionListener(e -> {
            String user = txtUsuario.getText();
            String pass = new String(txtPassword.getPassword());
            if (dao.verificar(user, pass)) {
                JOptionPane.showMessageDialog(this, "Bienvenido " + user);
                new Usuarios().setVisible(true);
                dispose();
            } else {
                JOptionPane.showMessageDialog(this, "Credenciales incorrectas");
            }
        });

        btnRegistrar.addActionListener(e -> {
            new Registrar().setVisible(true);
        });
    }
}
