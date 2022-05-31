using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Controller
{
    class conexão
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kauan.mcardoso\source\repos\ProjetoAgenciaTI11T\ProjetoAgenciaTI11T\bdagencia.mdf;Integrated Security=True";
        }
    }
}
