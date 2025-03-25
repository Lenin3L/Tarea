using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace PiedraPapelTijera
{
    public partial class MainForm : Form
    {
        private ArrayList jugadores = new ArrayList();
        private Random random = new Random();
        private ArrayList opciones = new ArrayList() { "Piedra", "Papel", "Tijera" };

        public MainForm()
        {
            InitializeComponent();
            InicializarJugadores();
        }

        private void InicializarJugadores()
        {
            // Crear jugador usuario
            jugadores.Add(new Jugador("Usuario"));

            // Crear jugador m�quina
            jugadores.Add(new Jugador("M�quina"));
        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            Jugar("Piedra");
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Jugar("Papel");
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            Jugar("Tijera");
        }

        private void Jugar(string tiradaUsuario)
        {
            // Usuario hace su tirada
            ((Jugador)jugadores[0]).HacerTiro(tiradaUsuario);

            // M�quina hace tirada aleatoria
            string tiradaMaquina = (string)opciones[random.Next(opciones.Count)];
            ((Jugador)jugadores[1]).HacerTiro(tiradaMaquina);

            // Mostrar tiradas
            lblUsuario.Text = $"Usuario: {((Jugador)jugadores[0]).TiradaActual}";
            lblMaquina.Text = $"M�quina: {((Jugador)jugadores[1]).TiradaActual}";

            // Determinar resultado
            string resultado = DeterminarResultado(tiradaUsuario, tiradaMaquina);
            lblResultado.Text = resultado;
            lblResultado.ForeColor = Color.Black;

            // Cambiar color seg�n resultado
            if (resultado.Contains("Ganaste"))
                lblResultado.ForeColor = Color.Green;
            else if (resultado.Contains("m�quina"))
                lblResultado.ForeColor = Color.Red;
        }

        private string DeterminarResultado(string usuario, string maquina)
        {
            if (usuario == maquina)
                return "�Empate!";

            if ((usuario == "Piedra" && maquina == "Tijera") ||
                (usuario == "Papel" && maquina == "Piedra") ||
                (usuario == "Tijera" && maquina == "Papel"))
            {
                return "�Ganaste!";
            }

            return "�La m�quina gan�!";
        }

        // Evento para reiniciar el juego al hacer doble clic en el resultado
        private void lblResultado_DoubleClick(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: ";
            lblMaquina.Text = "M�quina: ";
            lblResultado.Text = "";
        }
    }
}