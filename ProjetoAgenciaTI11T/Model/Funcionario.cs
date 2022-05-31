using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Model
{
    class Funcionario
    {
        private static int codFun;
        private static string nomeFun;
        private static string emailFun;
        private static string senhaFun;

        public static int CodFun { get => codFun; set => codFun = value; }
        public static string NomeFun { get => nomeFun; set => nomeFun = value; }
        public static string EmailFun { get => emailFun; set => emailFun = value; }
        public static string SenhaFun { get => senhaFun; set => senhaFun = value; }
    }
}
