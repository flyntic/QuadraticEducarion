using System;

public class QuadraticEducation
{
	double a, b, c;
    public QuadraticEducation() {
		Console.WriteLine("Уравнение вида ax*x + b*x + c = 0 ");

		Console.WriteLine("Введите коеффициент a");
		a=Double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коеффициент b");
        b = Double.Parse(Console.ReadLine());

        Console.WriteLine("Введите коеффициент c");
        c = Double.Parse(Console.ReadLine());

	}
    public QuadraticEducation(double _a, double _b, double _c) 
	{ a = _a;
	  b = _b;
	  c = _c; 
	}

	public String ToString()
	{
		return $"{a} * x*x + {b} * x + {c} = 0";
	}
	public string Solve()
	{
		double disq = (b * b - 4 * a * c);
		if (disq < 0) return "Действительных корней нет";

		if (disq == 0) return $"Один корень {- b / (2*a)}";

		return $"Первый корень ={ (- b + Math.Sqrt(disq))/ (2*a) } , Второй корень = {(- b - Math.Sqrt(disq))/ (2*a) }";

	}
}
