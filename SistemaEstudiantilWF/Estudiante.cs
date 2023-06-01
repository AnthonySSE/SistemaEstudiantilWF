using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstudiantilWF
{
    internal class Estudiante
    {
        public int Id { get; set;  }

        public char Matricula { get; set; }

        public char Nombre { get; set; }

        public char Apellidos { get; set; }

        public int Edad { get; set; }

        public char Sexo { get; set; }

        public  DateTime FechaNacimiento { get; set; }

        public char Curso { get; set; }

        public int CantidadMateria { get; set; }

        public char UsuarioId { get; set; }
    }
}
