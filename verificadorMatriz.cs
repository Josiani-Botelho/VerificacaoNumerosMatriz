namespace TopCoders
{
    public class verificadorMatriz
    {

        public static void Main(string[] args)
        {
           int[,] matriz = 
               {{5, 10, 62, 45, 84},
               {96, 26, 23, 54, 95}, 
               {50, 18, 58, 41, 63}, 
               {60, 98, 4, 1, 9}, 
               {31, 75, 3, 6, 7}};


            bool verificador = false;
            int valor; 
           
            do
           {
                Console.WriteLine("Digite um valor para realizar a busca: "); 

                verificador = int.TryParse(Console.ReadLine(), out valor);

                if(!verificador || valor <0)
                {
                   Console.WriteLine("Valor digitado inválido! Por favor, digitar apenas números");
                } 
            } 
            
            while(!verificador || valor <0);

            bool encontrou = false;

            for(int linha = 0; linha < 5; linha++)
            {    
               for(int coluna = 0; coluna < 5; coluna++)
               {
                   if(matriz[linha, coluna] == valor)
                   {
                       Console.WriteLine($"O número digitrado encontra-se na linha: {linha} e coluna: {coluna} ");
                       encontrou = true;
                   }
                   
               }
            }

            if(!encontrou)
            {
                Console.WriteLine("Número não encontrado!");
            }


        }
    }
}