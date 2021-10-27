﻿using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
        //diretor é também um funcionário (heranca)
    {
        public Diretor( string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public override double GetBonificacao()
        {

            return Salario  * 0.5;
        }
    }
}
