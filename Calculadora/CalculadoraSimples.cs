﻿namespace Calculadora
{
    public class CalculadoraSimples
    {
        //metodo para calcular a soma de 2 numeros
        public int Adicionar(int n1, int n2)
        {
            return n1 + n2;
        }

        //metodo para calcular a multiplicacao de 2 numeros
        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2; // metodo tem erro.
        }
        //metodo para calcular a subtração de 2 numeros
        public int Subtrair(int n1, int n2)
        {
            return n1 - n2; // metodo tem erro.
        }
        //metodo para calcular a divisao de 2 numeros
        public int Dividir(int n1, int n2)
        {
           
            try
            {

                return n1 / n2; // metodo tem erro.

            }
            catch (DivideByZeroException)
            {
                throw new Exception("divisao por zero");

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);

            }
        }

      
    }
}