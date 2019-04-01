using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpixCompilerIDE.clases {
    class AnalizadorLexico {

        public static List<string> palabrasReservadas = null;
        public static List<string> operadoresAritmeticos = null;
        public static List<string> delimitadoresExpresiones = null;
        public static List<string> expresiones = null;
        private static bool expCorr = false;

        private static List<string> listaExpresiones = new List<string>(
            new string[] {
                "var",
                "const",
                "while",
                "for",
                "do",
                "if",
                "else",
                "elif",
                "printLn",
                "print",
                "void",
                "main"
            });

        private static List<string> listaPalabrasUsuario = new List<string>(
            new string[] {
                "espacio",
                "variable",
                "operador aritmetico",
                "operador asignacion",
                "numero",
                "delimitador/terminal"
            });
        //void main() { printf("Hola mundo"); }

        private static List<string> reservadoSistema() {
            List<string> e = new List<string>();
            try {
                e.AddRange(operadoresAritmeticos);
                e.AddRange(palabrasReservadas);
                e.AddRange(listaExpresiones);
            } catch {
            }
            return e;
        }

        public static string analizarTokens(string[] expresion) {
            try {
                //string[] partir = expresion.Split(' ');
                //string partir
                //partir = partir.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                Console.WriteLine(expresion[0]);
                foreach(string exp in listaExpresiones) {
                    if(expresion[0].Equals(exp)) {
                        return exp;
                    }
                    if(expresion[0].Equals("main()")) {
                        return listaExpresiones[listaExpresiones.Count - 1]; //imprime main
                    }
                }
                return "a";
            } catch {
                return "C";
            }
        }

    }
}
