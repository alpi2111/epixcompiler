using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpixCompilerIDE {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
            archGuardar.Enabled = false;
            archCerrar.Enabled = false;
        }

        Procesos archivo = new Procesos();

        private void archNuevo_Click(object sender, EventArgs e) {
            //TODO: generar el archivo nuevo sin guardar
        }

        private void archAbrir_Click(object sender, EventArgs e) {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Epix source file|*.txt";
            openFile.ShowDialog();
            //string ruta = openFile.FileName;
            archivo.Ruta = openFile.FileName;
            Console.WriteLine(archivo.Ruta);
        }

        private void archGuardar_Click(object sender, EventArgs e) {
            //TODO: generar el codigo para guardar un archivo, debe llevar las validaciones
            //para cuando es la primera vez o cuando se actualiza
            if (archivo.IsSave == false) {
                //debe guardar el archivo
            } else {
                //no debe hacer nada
            }
        }

        private void archCerrar_Click(object sender, EventArgs e) {
            //TODO: generar el cerrado del archivo actual, si no hay no debe estar activo
            if (archivo.Ruta.Length > 0 && archivo.IsSave == false) { //verifica si existe un archivo y no esta guardado
                //TODO: decir si guardar el archivo o no guardar el archivo y dependiendo de, cerrarlo
            } else {
                //TODO: simplemente cerrar el archivo
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            if (archivo.IsSave == true || archivo.Ruta.Equals("")) {
                Application.Exit();
            } else if (archivo.IsSave == false) {
                DialogResult salir = MessageBox.Show("Existe un documento sin guardar, ¿Desea guardar los cambios y salir?", "¿Salir?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (salir == DialogResult.Yes) {
                    //TODO: guardar cambios y luego cerrar
                } else if (salir == DialogResult.Cancel) {

                } else {
                    Application.Exit();
                }
            }
        }
    }
}
