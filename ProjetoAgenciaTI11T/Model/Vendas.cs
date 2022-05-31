using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Model
{
    class Vendas
    {
        private static int codVen;
        private static int codCliFK;
        private static int codPacFK;
        private static float pagoVen;

        public static int CodVen { get => codVen; set => codVen = value; }
        public static int CodCliFK { get => codCliFK; set => codCliFK = value; }
        public static int CodPacFK { get => codPacFK; set => codPacFK = value; }
        public static float PagoVen { get => pagoVen; set => pagoVen = value; }
    }
}
