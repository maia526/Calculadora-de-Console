namespace Calculadora {
    class Program{
        const int Soma = 1;
        const int Subtracao = 2;
        const int Divisao = 3;
        const int Multiplicacao = 4;
        const int Potencia = 5;
        const int Sair = 0;
        
        static void Main(string[] args){
            double num1 = 0; 
            double num2 = 0;
            bool ativo = true;

            while (ativo){
                Console.WriteLine("---------- Calculadora ----------");
                Console.WriteLine("(1) Soma\n(2) Subtração\n(3) Divisão\n(4) Multiplicação\n(5) Potência\n(0) Sair");
                
                int operacao;
                while (!int.TryParse(Console.ReadLine(), out operacao) || operacao < 0 || operacao > 5){
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }

                if (operacao == Sair){
                    Console.WriteLine("Calculadora encerrada.");
                    ativo = false;
                }
                else{
                    num1 = leDouble("Numero 1: ");
                    num2 = leDouble("Numero 2: ");
                    
                    switch(operacao){
                        case Soma:
                            Console.WriteLine($"{num1} + {num2} = {soma(num1, num2)}");
                            break;
                        case Subtracao:
                            Console.WriteLine($"{num1} - {num2} = {subtracao(num1, num2)}");
                            break; 
                        case Divisao:
                            if (num2 == 0)
                                    Console.WriteLine("Não é possível divir por zero.");
                            else
                                Console.WriteLine($"{num1} / {num2} = {divisao(num1, num2)}");
                            break;
                        case Multiplicacao:
                            Console.WriteLine($"{num1} * {num2} = {multiplicacao(num1, num2)}");
                            break;
                        case Potencia:
                            Console.WriteLine($"{num1} ^ {num2} = {potenciacao(num1, num2)}");
                            break;
                        default:
                            Console.WriteLine("Operação inválida.");
                            break;
                    }
                }
            }
        }
        static double leDouble(string mensagem){
            double num = -1;
            while (true) {
                Console.Write(mensagem);
                string input = Console.ReadLine();

                if (double.TryParse(input, out num)) {
                    return num;
                } else {
                    Console.WriteLine("Entrada inválida. Tente novamente.\n");
                }
            }
        }
        static double soma(double a, double b){
            return a + b;
        }
        static double subtracao(double a, double b){
            return a - b;
        }
        static double divisao(double a, double b){
            return a / b;
        }
        static double multiplicacao(double a, double b){
            return a * b;
        }
        static double potenciacao(double a, double b){
            return Math.Pow(a, b);
        }
    }
}

