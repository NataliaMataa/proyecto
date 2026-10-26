using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form1 : Form
    {
      private static readonly Random rng = new Random();

            float n1 = 0, n2 = 0, op = 0, resultado = 0;
            char operador = ' ';
            int N = 11;
            int contfallosP1 = 0, contaciertosP1 = 0;
            int contfallosP2 = 0, contaciertosP2 = 0;

            private bool modoDosJugadores = false;
            private bool turnoJugador1 = true;

            private string[] nombresJugadores = new string[10];
            private int[] puntajesJugadores = new int[10];
            private int totalRegistros = 0;

            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
            MessageBox.Show("Bienvenido");
            MessageBox.Show("ELIJA EL MODO DE JUEGO ANTES DE EMPEZAR");
            }

            private void btabla_Click(object sender, EventArgs e)
            {
                MostrarTabla();
            }

            private void bunjugador_Click(object sender, EventArgs e)
            {
                modoDosJugadores = false;
                turnoJugador1 = true;
                contaciertosP1 = 0;
                contfallosP1 = 0;
                laciertos.Text = "0";
                lfallos.Text = "0";

                MessageBox.Show("Modo Un Jugador activado", "¡A jugar!");
                nuevaOperacion();
            }

            private void bdosjugadores_Click(object sender, EventArgs e)
            {
                modoDosJugadores = true;
                turnoJugador1 = true;
                contaciertosP1 = 0; contfallosP1 = 0;
                contaciertosP2 = 0; contfallosP2 = 0;
                laciertos.Text = "0";
                lfallos.Text = "0";

                MessageBox.Show("Modo Dos Jugadores activado. Comienza el Jugador 1.", "Modo Acompañado");
                nuevaOperacion();
            }

            private void baceptar_Click_1(object sender, EventArgs e)
            {
                if (float.TryParse(tresultado.Text, out float respuestaUsuario))
                {
                    // Validamos si la respuesta del usuario coincide con el resultado exacto
                    if (resultado == respuestaUsuario)
                    {
                        MessageBox.Show("¡Respuesta correcta!");

                        if (modoDosJugadores && !turnoJugador1)
                        {
                            contaciertosP2 += 1;
                        }
                        else
                        {
                            contaciertosP1 += 1;
                            if (contaciertosP1 % 3 == 0)
                            {
                                N += 50;
                                MessageBox.Show("¡Subiste de nivel! Rango numérico ampliado.");
                            }
                        }

                        GestionarTurnoYEvaluarFin();
                    }
                    else
                    {
                        MessageBox.Show($"Respuesta incorrecta. El resultado era: {resultado}");

                        if (modoDosJugadores && !turnoJugador1)
                        {
                            contfallosP2 += 1;
                        }
                        else
                        {
                            contfallosP1 += 1;
                        }

                        GestionarTurnoYEvaluarFin();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número válido.");
                }
            }

            private void GestionarTurnoYEvaluarFin()
            {
                tresultado.Clear();

                if (modoDosJugadores)
                {
                    // Cambiamos de turno
                    turnoJugador1 = !turnoJugador1;
                    string proximoJugador = turnoJugador1 ? "Jugador 1" : "Jugador 2";

                    // Actualizamos los contadores visuales según a quién le toque jugar
                    laciertos.Text = turnoJugador1 ? contaciertosP1.ToString() : contaciertosP2.ToString();
                    lfallos.Text = turnoJugador1 ? contfallosP1.ToString() : contfallosP2.ToString();

                    MessageBox.Show($"Turno de: {proximoJugador}", "Cambio de Turno");
                }
                else
                {
                    laciertos.Text = contaciertosP1.ToString();
                    lfallos.Text = contfallosP1.ToString();
                }

                nuevaOperacion();
            }

            private void nuevaOperacion()
            {
                n1 = rng.Next(1, N);
                n2 = rng.Next(1, N);
                op = rng.Next(1, 5);

                switch (op)
                {
                    case 1: // Suma
                        operador = '+';
                        resultado = n1 + n2;
                        break;
                    case 2: // Resta (Aseguramos que n1 sea mayor o igual a n2 para evitar negativos confusos)
                        operador = '-';
                        if (n1 < n2)
                        {
                            float temp = n1;
                            n1 = n2;
                            n2 = temp;
                        }
                        resultado = n1 - n2;
                        break;
                    case 3: // Multiplicación
                        operador = '*';
                        resultado = n1 * n2;
                        break;
                    case 4: // División (Aseguramos división exacta)
                        operador = '/';
                        n2 = rng.Next(1, Math.Max(2, N / 3)); // Evitar ceros y números muy grandes
                        int cociente = rng.Next(1, 10);
                        n1 = n2 * cociente; // Así n1 siempre es divisible exactamente entre n2
                        resultado = n1 / n2;
                        break;
                }

                lnum1.Text = n1.ToString();
                lnum2.Text = n2.ToString();
                lop.Text = operador.ToString();
            }

            private void GuardarPuntaje(string nombre, int puntaje)
            {
                if (totalRegistros < 10)
                {
                    nombresJugadores[totalRegistros] = nombre;
                    puntajesJugadores[totalRegistros] = puntaje;
                    totalRegistros++;
                }
                else
                {
                    puntajesJugadores[9] = puntaje;
                }
            }

            private void MostrarTabla()
            {
                totalRegistros = 0; // Reiniciamos el conteo temporal para la vista limpia de la tabla
                if (!modoDosJugadores)
                {
                    GuardarPuntaje("Jugador 1 (Individual)", contaciertosP1);
                }
                else
                {
                    GuardarPuntaje("Jugador 1", contaciertosP1);
                    GuardarPuntaje("Jugador 2", contaciertosP2);
                }

                string tabla = "=== TABLA DE POSICIONES ===\n\n";

                for (int i = 0; i < totalRegistros; i++)
                {
                    tabla += $"{i + 1}. {nombresJugadores[i]} - {puntajesJugadores[i]} aciertos\n";
                }

                MessageBox.Show(tabla, "Historial de Puntajes");
            }
        }
    }