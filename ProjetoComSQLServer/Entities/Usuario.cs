using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComSQLServer.Entities {
    public class Usuario {        
        public string Nome { get; set; }
        public string Apelido { get; set; }

        public Usuario(string nome, string apelido) {
            Nome = nome;
            Apelido = apelido;
        }
    }
}
