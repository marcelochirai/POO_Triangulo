using System;

namespace Course	//Precisa ter o mesmo nome do programa principal
{
	class Triangulo
	{
		//Definição das variáveis, atributos 
		public double A;
		public double B;
		public double C;

		//Método de cálculo
		public double Area()
		{
			double p = (A + B + C) / 2;
			double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
			return raiz;
		}
	}
}


