using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcularImc.Models
{
    public class Calculo
    {
        // Declarando as propriedades;
        private decimal seuPeso = 0;
        private decimal suaAltura = 0;

        public Calculo(decimal seuPeso, decimal suaAltura)
        {
            this.seuPeso = seuPeso;
            this.suaAltura = suaAltura;

        }

        // Declarando o método utilizado no programa
        public void Calcular()
        {
            decimal calculoImc = 0;
        
        // Calculo padrão para calcular o IMC;   
            calculoImc = seuPeso / (suaAltura * suaAltura);

        // Validando o calculo e as classificações;
            if (calculoImc < 18.5M)
            {
                Console.WriteLine($"O seu IMC é de: {calculoImc.ToString("N2")}! Cuidado a sua classificação é: MAGREZA!");
            }
            else if(calculoImc <= 18.5M || calculoImc <= 24.9M)
            {
                Console.WriteLine($"O seu IMC é de: {calculoImc.ToString("N2")}! Parabéns, sua classificação: ESTÁ NO PESO ADEQUADO PARA A SUA ALTURA!");
            }
            else if(calculoImc <= 25.0M  || calculoImc <= 29.9M)
            {
                Console.WriteLine($"O seu IMC é de: {calculoImc.ToString("N2")}! Cuidado, a sua classificação é: SOBREPRESO!");
            }
            else if(calculoImc <=  30.0M  || calculoImc <= 39.9M)
            {
                Console.WriteLine($"O seu IMC é de: {calculoImc.ToString("N2")}! Procure um médico o mais rápido possível, a sua classificação é: OBESIDADE!");
            }
            else if(calculoImc > 40)
            {
                Console.WriteLine($"O seu IMC é de: {calculoImc.ToString("N2")}! A sua classificação é: OBESIDADE GRAVE, procure um médico e comece já os exercícios!");
            }
            else 
            {
                Console.WriteLine("Opção desconhecida! Tente novamente!");
            }
        }
    }
}