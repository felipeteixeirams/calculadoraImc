using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraIMC
{
    class CalcularIMC
    {
        public string Calcular(int peso, double altura)
        {
            string classificacao;
            double imc = peso / (altura * altura);
            if (imc < 18.5) {
                classificacao = "Abaixo do peso";
            } else if (18.4 < imc && imc < 24.9)
            {
                classificacao = "Peso normal";
            }else if (24.9 < imc && imc < 30)
            {
                classificacao = "Sobrepeso";
            }else if (29.9 < imc && imc < 35)
            {
                classificacao = "Obesidade Grau I";
            }else if (34.9 < imc && imc < 40)
            {
                classificacao = "Obesidade Grau II";
            }else
            {
                classificacao = "Obesidade Mórbida";
            }
            return classificacao;
        }
    }
}
