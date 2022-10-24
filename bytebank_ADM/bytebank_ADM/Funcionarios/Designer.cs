﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public Designer(string cpf, double salario) : base(cpf, 3000)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }