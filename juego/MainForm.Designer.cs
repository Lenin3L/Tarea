namespace PiedraPapelTijera
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Button btnPiedra;
        private Button btnPapel;
        private Button btnTijera;
        private Label lblUsuario;
        private Label lblMaquina;
        private Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnPiedra = new Button();
            btnPapel = new Button();
            btnTijera = new Button();
            lblUsuario = new Label();
            lblMaquina = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(93, 23);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Piedra, Papel o Tijera";
            // 
            // btnPiedra
            // 
            btnPiedra.Location = new Point(35, 81);
            btnPiedra.Margin = new Padding(4, 3, 4, 3);
            btnPiedra.Name = "btnPiedra";
            btnPiedra.Size = new Size(117, 58);
            btnPiedra.TabIndex = 1;
            btnPiedra.Text = "Piedra";
            btnPiedra.UseVisualStyleBackColor = true;
            btnPiedra.Click += btnPiedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.Location = new Point(175, 81);
            btnPapel.Margin = new Padding(4, 3, 4, 3);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(117, 58);
            btnPapel.TabIndex = 2;
            btnPapel.Text = "Papel";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTijera
            // 
            btnTijera.Location = new Point(315, 81);
            btnTijera.Margin = new Padding(4, 3, 4, 3);
            btnTijera.Name = "btnTijera";
            btnTijera.Size = new Size(117, 58);
            btnTijera.TabIndex = 3;
            btnTijera.Text = "Tijera";
            btnTijera.UseVisualStyleBackColor = true;
            btnTijera.Click += btnTijera_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(35, 162);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(53, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario: ";
            // 
            // lblMaquina
            // 
            lblMaquina.AutoSize = true;
            lblMaquina.Location = new Point(35, 196);
            lblMaquina.Margin = new Padding(4, 0, 4, 0);
            lblMaquina.Name = "lblMaquina";
            lblMaquina.Size = new Size(60, 15);
            lblMaquina.TabIndex = 5;
            lblMaquina.Text = "Máquina: ";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblResultado.Location = new Point(35, 242);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 6;
            lblResultado.DoubleClick += lblResultado_DoubleClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 330);
            Controls.Add(lblResultado);
            Controls.Add(lblMaquina);
            Controls.Add(lblUsuario);
            Controls.Add(btnTijera);
            Controls.Add(btnPapel);
            Controls.Add(btnPiedra);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Piedra, Papel o Tijera";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}