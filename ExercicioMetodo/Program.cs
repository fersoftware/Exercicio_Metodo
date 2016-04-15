using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodo
{
    /* Exercício feito durante a aula - 11/04/16
     * Elaborar um método que solicita para o usuário digitar
     * a nota continuada e a nota semestral de um aluno.
     * Este método deve calcular e devolver a média desse aluno.
     * 
     * Elaborar o Main que chama o método acima para calcular 
     * a média de 5 alunos.
     * Depois, o Main deve exibir a média das médias, a maior
     * e a menor média */

    class Program
    {
        static float CalculaMedia()
        {
            float continuada, semestral, media;

            /* Solicita e lê a nota da continuada */
            Console.WriteLine("Digite a nota da continuada");
            continuada = float.Parse(Console.ReadLine());
 
            /* Solicita e lê a nota da semestral */
            Console.WriteLine("Digite a nota da semestral");
            semestral = float.Parse(Console.ReadLine());

            /* Calcula a média ponderada */
            media = continuada * 0.4f + semestral * 0.6f;
            
            /* Retorna a média */
            return media;
        }

        static void Main(string[] args)
        {
            float media, soma = 0;

            /* variável menor representa a menor média obtida até o momento
             * que é inicializada com 10 (maior valor possível de média) */
            float menor = 10f;

            /* variável maior representa a maior média obtida até o momento
             * que é inicializada com 0 (menor valor possível de média) */
            float maior = 0f;

            /* loop para calcular 5 médias */
            for (int i = 0; i < 5; i++)
            {
                /* chama o método para obter uma média */
                media = CalculaMedia();

                /* soma média obtida à soma */
                soma += media;

                /* verifica se média obtida é maior do que a maior média */
                if (media > maior)
                    maior = media;    /* se for, média obtida passa a ser a maior média */

                /* verifica se média obtida é menor do que a menor média */
                if (media < menor)
                    menor = media;    /* se for, média obtida passa a ser a menor média */

                /* Exibe a média obtida */
                Console.WriteLine("Média = " + media);
            }

            /* Exibe a média das médias */
            Console.WriteLine("A média das médias é " + soma / 5);

            /* Exibe a menor média e a maior média */
            Console.WriteLine("A menor média é " + menor);
            Console.WriteLine("A maior média é " + maior);

            Console.ReadKey();
        }
 
     }
}
