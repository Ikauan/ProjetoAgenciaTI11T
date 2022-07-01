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
        private static string retorno;
        private static string codFunFK;

        public static int CodVen { get => codVen; set => codVen = value; }
        public static int CodCliFK { get => codCliFK; set => codCliFK = value; }
        public static int CodPacFK { get => codPacFK; set => codPacFK = value; }
        public static float PagoVen { get => pagoVen; set => pagoVen = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
        public static string CodFunFK { get => codFunFK; set => codFunFK = value; }
    }
}
