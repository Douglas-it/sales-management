using System;
namespace SalesManagement
{
    public class OperacoesGerais
    {
        // Função para ler uma string não vazia
        public static bool LerStringValida(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return false;

            return true;
        }

        // Função para ler um inteiro válido do console dentro do intervalo especificado
        public static bool LerInteiroValido(string entrada, int valorMinimo = int.MinValue, int valorMaximo = int.MaxValue)
        {
            int saida;
            bool valido = int.TryParse(entrada, out saida) && saida >= valorMinimo && saida <= valorMaximo;
            return valido;
        }

        // Lê um número decimal válido da consola dentro do intervalo especificado, com mensagem de prompt opcional
        public static bool LerDecimalValido(string entrada, float valorMinimo = float.MinValue, float valorMaximo = float.MaxValue)
        {
            float saida;
            bool valido = float.TryParse(entrada, out saida) && saida >= valorMinimo && saida <= valorMaximo;
            return valido;
        }
    }
}