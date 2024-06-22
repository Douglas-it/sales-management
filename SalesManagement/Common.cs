using System;
namespace SalesManagement
{
    public class OperacoesGerais
    {
        /*
         * Função para ler uma string não vazia
         * @param valor: string a ser verificada
         * @return bool: true se a string não for vazia, false caso contrário
         */
        public static bool LerStringValida(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return false;

            return true;
        }

        /*
         * Função para ler um inteiro válido dentro do intervalo especificado
         * @param entrada: string a ser verificada
         * @param valorMinimo: valor mínimo do intervalo
         * @param valorMaximo: valor máximo do intervalo
         * @return bool: true se a string for um inteiro válido dentro do intervalo especificado, false caso contrário
         */
        public static bool LerInteiroValido(string entrada, int valorMinimo = int.MinValue, int valorMaximo = int.MaxValue)
        {
            int saida;
            bool valido = int.TryParse(entrada, out saida) && saida >= valorMinimo && saida <= valorMaximo;
            return valido;
        }

        /*
         * Função para ler um número decimal válido dentro do intervalo especificado
         * @param entrada: string a ser verificada
         * @param valorMinimo: valor mínimo do intervalo
         * @param valorMaximo: valor máximo do intervalo
         * @return bool: true se a string for um número decimal válido dentro do intervalo especificado, false caso contrário
         */
        public static bool LerDecimalValido(string entrada, float valorMinimo = float.MinValue, float valorMaximo = float.MaxValue)
        {
            float saida;
            bool valido = float.TryParse(entrada, out saida) && saida >= valorMinimo && saida <= valorMaximo;
            return valido;
        }
    }
}