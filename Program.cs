using dio_curso_introducao_ao_c_sharp.Exemplos;

namespace dio_curso_introducao_ao_c_sharp
{
    class Program
    {
        static void Main()
        {
            Calcular();
        }

        static void Calcular()
        {
            Console.WriteLine("Entre com dois numeros: ");

            if (!float.TryParse(Console.ReadLine(), out float num1) ||
                (!float.TryParse(Console.ReadLine(), out float num2)))
            {
                Console.WriteLine("Entrada Invalida");
            }
            else
            {
                Calculadora calculadora = new();
                Console.WriteLine("A Soma é: " + calculadora.Soma(num1, num2));
                Console.WriteLine("A Subtracao é: " + calculadora.Subtracao(num1, num2));
                Console.WriteLine("A Multiplicacao é: " + calculadora.Multiplicacao(num1, num2));
                Console.WriteLine("A Divisao é: " + calculadora.Divisao(num1, num2));
            }
        }
    }
}
