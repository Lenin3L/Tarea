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
        
            jugadores.Add(new Jugador("Usuario"));

         
            jugadores.Add(new Jugador("Máquina"));
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
          
            ((Jugador)jugadores[0]).HacerTiro(tiradaUsuario);

            string tiradaMaquina = (string)opciones[random.Next(opciones.Count)];
            ((Jugador)jugadores[1]).HacerTiro(tiradaMaquina);

            lblUsuario.Text = $"Usuario: {((Jugador)jugadores[0]).TiradaActual}";
            lblMaquina.Text = $"Máquina: {((Jugador)jugadores[1]).TiradaActual}";

      
            string resultado = DeterminarResultado(tiradaUsuario, tiradaMaquina);
            lblResultado.Text = resultado;
            lblResultado.ForeColor = Color.Black;

    
            if (resultado.Contains("Ganaste"))
                lblResultado.ForeColor = Color.Green;
            else if (resultado.Contains("máquina"))
                lblResultado.ForeColor = Color.Red;
        }

        private string DeterminarResultado(string usuario, string maquina)
        {
            if (usuario == maquina)
                return "¡Empate!";

            if ((usuario == "Piedra" && maquina == "Tijera") ||
                (usuario == "Papel" && maquina == "Piedra") ||
                (usuario == "Tijera" && maquina == "Papel"))
            {
                return "¡Ganaste!";
            }

            return "¡La máquina ganó!";
        }

        // Evento para reiniciar el juego al hacer doble clic en el resultado
        private void lblResultado_DoubleClick(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: ";
            lblMaquina.Text = "Máquina: ";
            lblResultado.Text = "";
        }
    }
}