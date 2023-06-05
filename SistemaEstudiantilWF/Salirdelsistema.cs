using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaEstudiantilWF
{
    public partial class Salirdelsistema : Form
    {
        public Salirdelsistema()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        { 

            timer1.Stop();

            // Cerrar la aplicación
            Environment.Exit(0);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 5000; // 5000 milisegundos = 5 segundos
            timer1.Tick += timer1_Tick; // evento que se ejecutará cuando el Timer expire
            timer1.Start(); //iniciar el timer
        }
    }
}
