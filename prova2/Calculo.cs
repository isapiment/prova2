using System;

public static class Calculo
{
    public static double CalculoValor(double valor, double pis, double icms, double confins, double lucro, string unidade)
    {
        if (unidade == "UN")
        {
            double n1 = Convert.ToDouble(valor);
            double n2 = Convert.ToDouble(pis);
            double n3 = Convert.ToDouble(icms);
            double n4 = Convert.ToDouble(confins);
            double n5 = Convert.ToDouble(lucro);

            double soma = n2 + n3 + n4;

            double resultado = soma + valor;
            double resul = soma / lucro;
            double result = valor + resul;


        }
        else if (unidade == "LT")
        {
            double n1 = Convert.ToDouble(valor);
            double n2 = Convert.ToDouble(pis);
            double n3 = Convert.ToDouble(icms);
            double n4 = Convert.ToDouble(confins);
            double n5 = Convert.ToDouble(lucro);

            double soma = n2 + n3 + n4;

            double resultado = soma + valor;
            double resul = soma / lucro;
            double result = (valor + resul) * 0.5;

        }
        else if (unidade == "KL")
        {
            double n1 = Convert.ToDouble(valor);
            double n2 = Convert.ToDouble(pis);
            double n3 = Convert.ToDouble(icms);
            double n4 = Convert.ToDouble(confins);
            double n5 = Convert.ToDouble(lucro);

            double soma = n2 + n3 + n4;

            double resultado = soma + valor;
            double resul = soma / lucro;
            double result = (valor + resul) * 0.5;
            return result;

        }

    }

}
