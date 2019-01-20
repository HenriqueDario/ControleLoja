using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Controller
{
    public class ValidarCPF
    {
        public bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            int resto;
            string auxCPF;
            string digito;

            //checar o tamanho do cpf
            if (cpf.Length != 11)       //tirar a mascara
                cpf = cpf.Trim(); // tirar espaços
            cpf = cpf.Replace(",", "").Replace("-", ""); // trocar/tirar pontuação do cpf



            // Caso coloque todos os numeros iguais
            switch (cpf)
            {
                case "00000000000":
                    return false;
                case "11111111111":
                    return false;
                case "22222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
            }


            //pegar os 9 primeiros digitos
            auxCPF = cpf.Substring(0, 9);

            for (int i = 0; i < 9; i++)
            {
                //soma o resultado do digito * a posição do multiplicador1
                soma += (int.Parse(auxCPF[i].ToString())) * multiplicador1[i];
            }

            resto = soma % 11; // pega o resto da divisão


            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            //vai guardar o 1 digito
            digito = resto.ToString();

            //vai juntar o digito com o resto do CPF para fazer a validação da proxima casa
            auxCPF = auxCPF + digito;


            //zerar a soma
            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                //soma o resultado do digito * a posição do multiplicador2
                soma += int.Parse(auxCPF[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11; // pega o resto da divisão

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            //guardar o digito
            digito = resto.ToString();

            auxCPF = auxCPF + digito; // coloca o ultimo digito no cpf auxiliar

            //checar se o CPF auxiliar é igual o CPF passado
            if (auxCPF == cpf)
                return true;
            else
                return false;


        }
    }
}
