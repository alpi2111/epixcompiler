﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpixCompilerIDE {
    public partial class frmMain : Form {

        private byte cont = 0;

        public frmMain() {
            InitializeComponent();
            archGuardar.Enabled = false;
            archCerrar.Enabled = false;
            splitCodigo.Visible = false;
            tabInfo.Enabled = false;
            tabCodigos.Visible = false;
        }

        Procesos archivo = new Procesos();

        //PARTE DEL MENU ARCHIVO
        private void archNuevo_Click(object sender, EventArgs e) {
            //TODO: generar el archivo nuevo sin guardar
            archivo.IsFirst = true;
            splitCodigo.Visible = true;
            TabPage nueva = new TabPage();
            nueva.Name = cont + "";
            nueva.Padding = new System.Windows.Forms.Padding(3);
            nueva.TabIndex = cont;
            nueva.Text = "Sin Titulo " + (++cont);
            nueva.UseVisualStyleBackColor = true;
            tabCodigos.Controls.Add(nueva);
            tabCodigos.TabIndex = cont - 1;
            tabCodigos.SelectTab(cont - 1);
            if (!tabCodigos.Visible) {
                tabCodigos.Visible = true;
                archCerrar.Enabled = true;
                archGuardar.Enabled = true;
            }
        }

        private void archAbrir_Click(object sender, EventArgs e) {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Epix source file|*.epix";
            openFile.ShowDialog();
            //string ruta = openFile.FileName;
            archivo.Ruta = openFile.FileName;
            //richTextBox1.LoadFile(archivo.Ruta);
            Console.WriteLine(archivo.Ruta);
        }

        private void archGuardar_Click(object sender, EventArgs e) {
            //TODO: generar el codigo para guardar un archivo, debe llevar las validaciones
            //para cuando es la primera vez o cuando se actualiza
            if (!archivo.IsSave && archivo.IsFirst) {
                //debe guardar el archivo en alguna ruta
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.AddExtension = true;
                saveFile.CheckPathExists = true;
                //saveFile.DefaultExt = ".epix";
                saveFile.FileName = "Sin Titulo "+ (tabCodigos.SelectedIndex + 1) + ".epix";
                saveFile.Filter = "Epix source file|.epix";
                saveFile.ShowDialog();
                //saveFile.
                archivo.Ruta = saveFile.FileName;
                //tabCodigos.SelectedIndex
                //tabCodigos.Name = 
                //richTextBox1.SaveFile(archivo.Ruta);
                Console.WriteLine(archivo.Ruta);
            } else if (!archivo.IsSave) {
                //solo debe guardar el archivo en la ruta que se abrio
            } else {
                //no debe hacer nada
            }
        }

        private void archCerrar_Click(object sender, EventArgs e) {
            //TODO: generar el cerrado del archivo actual, si no hay no debe estar activo
            /*if (!archivo.Ruta.Equals("") && archivo.IsSave == false) { //verifica si existe un archivo y no esta guardado
                //TODO: decir si guardar el archivo o no guardar el archivo y dependiendo de, cerrarlo
            } else {
                //TODO: simplemente cerrar el archivo
            }*/

            if (tabCodigos.SelectedIndex > 0) {
                tabCodigos.Controls.RemoveAt(tabCodigos.SelectedIndex);
            } else {
                archCerrar.Enabled = false;
                archGuardar.Enabled = false;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            if (archivo.IsSave == true || archivo.IsFirst) {
                Application.Exit();
            } else if (!archivo.IsSave || archivo.IsFirst) {
                DialogResult salir = MessageBox.Show("Existe un documento sin guardar, ¿Desea guardar los cambios y salir?", "¿Salir?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (salir == DialogResult.Yes) {
                    //TODO: guardar cambios y luego cerrar
                } else if (salir == DialogResult.Cancel) {

                } else {
                    Application.Exit();
                }
            }
        }
        //FINALIZA LA PARTE DEL MENU ARCHIVO
    }
}
