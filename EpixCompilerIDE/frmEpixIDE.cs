using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpixCompilerIDE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            archGuardar.Enabled = false;
            archCerrar.Enabled = false;
        }

        private void archNuevo_Click(object sender, EventArgs e)
        {
            //TODO: generar el archivo nuevo sin guardar
        }

        private void archAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Epix source file|*.epix";
            openFile.ShowDialog();
            string ruta = openFile.FileName;
            Console.WriteLine(ruta);
        }

        private void archGuardar_Click(object sender, EventArgs e)
        {
            //TODO: generar el codigo para guardar un archivo, debe llevar las validaciones
            //para cuando es la primera vez o cuando se actualiza
        }

        private void archCerrar_Click(object sender, EventArgs e)
        {
            //TODO: generar el cerrado del archivo actual, si no hay no debe estar activo
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: falta generar el modo de cerrar si hay un archivo sin guardar y
            //permitir guardar o no.
            Application.Exit();
        }
    }
}
