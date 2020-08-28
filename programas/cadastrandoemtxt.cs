using System;
using System.Text;
using System.IO;


namespace Atividade_c_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao de variaveis
            int CodCadastro = 0;
            string nome, cpf, endereco, bairro, cidade, estado, cep, fone;
            //inicio do laço de repetiçao "do" faça para todo o progama 
            do
            {
                Console.WriteLine("Informe o codigo do seu cadastro ou 0 para sair do programa");
                CodCadastro = Convert.ToInt32(Console.ReadLine());
                //ler a variavel "codigo" para saber se é igual ou diferente de 0 para iniciar ou fechar o progama
                //"if"="se" ou seja se o codigo for igual a 0 aparecera a mensagem para sair 
                if (CodCadastro == 0)
                {
                    Console.WriteLine("Para sair digite qualquer tecla");
                    Console.ReadKey();
                }
                //"else"="se não"ou seja se for diferente de 0 continuar o programa
                else
                {
                    Console.WriteLine("informe o nome");
                    nome = Console.ReadLine();
                    Console.WriteLine("informe o cpf");
                    cpf = Console.ReadLine();
                    // o TRIM remove espaço em branco do inico e do fim do cpf
                    cpf = cpf.Trim();
                    //remove .(ponto), (barra) e (virgula) de cpf, poderia ir alem, remove todos esses caracteres !@#$$%¨¨&*()_+ e etc
                    cpf = cpf.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
                    //enquanto cpf n tenha 11 caracteres entra em outro laço de repetiçao até q o usuario digite 11 caracteres
                    while (cpf.Length != 11)
                    {
                        Console.WriteLine("cpf invalido, digite cpf com 11 digitos!");
                        cpf = Console.ReadLine();
                    }
                    Console.WriteLine("informe o endereço");
                    endereco = Console.ReadLine();
                    Console.WriteLine("informe o bairro");
                    bairro = Console.ReadLine();
                    Console.WriteLine("informe a cidade");
                    cidade = Console.ReadLine();
                    Console.WriteLine("informe o estado apenas 2 letras Ex.:SP");
                    estado = Console.ReadLine();
                    //remove o espaço em branco no inicio e no fim
                    estado = estado.Trim();
                    //enquanto o estado n possuir 2 caracteres entra em um laço de repetiçao até ter 2 caracteres
                    estado = estado.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
                    while (estado.Length != 2)
                    {
                        Console.WriteLine("estado invalido informe estado com 2 digitos;");
                        estado = Console.ReadLine();
                    }
                    Console.WriteLine("informe o cep com 8 digitos");
                    cep = Console.ReadLine();
                    //removendo o espaço em branco no inicio e no fim
                    cep = cep.Trim();
                    //remove outros caracteres
                    cep = cep.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
                    //enquanto cep n tiver 8 digitos entra em outro laço até o usuario digitar 8 digitos
                    while (cep.Length != 8)
                    {
                        Console.WriteLine("cep invalido digite um cep com 8 digitos!");
                        cep = Console.ReadLine();
                    }
                    Console.WriteLine("informe o numero de telefone");
                    fone = Console.ReadLine();

                    //criando um diretorio (pasta) para armazenar os arquivos com os dados
                    //instanciando
                    DirectoryInfo dir = new DirectoryInfo(@"c:\ATIVIDADEC#");
                    //verificando se a pasta ja existe
                    if (!dir.Exists)
                        try
                        {
                            //caso não exista cria a pasta ATIVIDADEC# em c:\
                            dir.Create();
                            Console.WriteLine("Diretorio criado com sucesso.");
                        }
                        //caso ocorra erro
                        catch (Exception e)
                        {
                            Console.WriteLine("Não foi possivel criar diretorio: {0}", e.ToString());
                        }
                        finally { }
                    //instanciando, caso o arquivo não exista é criado, caso exista é adicionado as nosva informaçoes no final do arquivo
                    FileStream CriaArquivo = new FileStream(@"c:\ATIVIDADEC#\atividade.txt", FileMode.Append);
                    //chamando a classe q cria arquivo e escreve dentro do arquivo
                    StreamWriter Arquivo = new StreamWriter(CriaArquivo, Encoding.ASCII);
                    Arquivo.WriteLine("");
                    Arquivo.WriteLine("---------------NOVO REGISTRO---------------");
                    Arquivo.WriteLine("");
                    Arquivo.WriteLine(Convert.ToString(CodCadastro));
                    Arquivo.WriteLine(nome);
                    Arquivo.WriteLine(cpf);
                    Arquivo.WriteLine(endereco);
                    Arquivo.WriteLine(bairro);
                    Arquivo.WriteLine(cidade);
                    Arquivo.WriteLine(estado);
                    Arquivo.WriteLine(cep);
                    Arquivo.WriteLine(fone);
                    //fechando
                    Arquivo.Flush();
                    Arquivo.Close();
                    CriaArquivo.Close();
                    Console.Clear();
                }
            }
            while (CodCadastro != 99999);
        }
    }
}
