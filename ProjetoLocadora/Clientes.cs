﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadora
{
    class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }    
        public DateTime cadastro { get; set; }
        public string telefone { get; set; }
    }
}