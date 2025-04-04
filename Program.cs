using System;
using System.Globalization;
using System.Collections.Generic;
using ProjetoTrabalho.Entities;
using ProjetoTrabalho.Entities.Enums;

namespace ProjetoTrabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = null;
            Produto p2 = null;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Olá, seja bem vindo(a)!");
            Console.WriteLine("Dia: " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss" + ":"));
            Console.WriteLine();
            Console.WriteLine("Você gostaria de dar entrada em uma Ordem de Serviço ou Nova peça para o Estoque? ");
            Console.WriteLine("1 - Nova Ordem de Serviço;");
            Console.WriteLine("2 - Nova Peça para Estoque;");
            Console.Write("Digite o número correspondente ao tipo de Entrada: ");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {
                Console.WriteLine("Entre com os dados da Ordem de Serviço: ");
                Console.Write("Nome do Cliente: ");
                string nome = Console.ReadLine();
                Console.Write("CPF do Cliente: ");
                string cpf = Console.ReadLine();
                Console.Write("Email do Cliente: ");
                string email = Console.ReadLine();
                Cliente c1 = new Cliente(nome, cpf, email);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados do Funcionário do Atendimento: ");
                Console.Write("Nome: ");
                string nomeFunc = Console.ReadLine();
                Console.Write("ID de Funcionário (4 Dígitos): ");
                int matricula = int.Parse(Console.ReadLine());
                Funcionario f1 = new Funcionario(nomeFunc, matricula);

                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine();
                TipoProduto tipoAparelho = default;
                Console.WriteLine("Insira os dados do Aparelho para Reparo: ");
                Console.WriteLine("Tipos disponíveis:");
                Console.WriteLine("0 - TV");
                Console.WriteLine("1 - Monitor");
                Console.WriteLine("2 - Controle Remoto");
                bool entradaValida = false;
                while (!entradaValida)
                {
                    Console.Write("Digite o número correspondente ao tipo do aparelho: ");

                    if (int.TryParse(Console.ReadLine(), out int tipoSelecionado) &&
                         Enum.IsDefined(typeof(TipoProduto), tipoSelecionado))
                    {
                        tipoAparelho = (TipoProduto)tipoSelecionado;
                        entradaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida! Por favor, digite um número entre 0 e 2.");
                    }
                }
                Console.Write("Descrição do Aparelho: ");
                string desc = Console.ReadLine();
                Console.Write("Defeito do Aparelho: ");
                string defeito = Console.ReadLine();
                Console.Write("Insira o Valor do Reparo em questão: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Insira o ID de Identificação do Aparelho em Estoque: ");
                int idproduto = int.Parse(Console.ReadLine());
                p1 = new Produto(idproduto, tipoAparelho, desc, valor);
                Estoque estoque = new Estoque();
                estoque.AddProduto(p1);
                Console.WriteLine();
                Console.Write($"Adicionar novo Aparelho ao Cliente {c1.Nome}? (sim / não): ");
                string resp = Console.ReadLine();
                if (resp == "sim")
                {
                    TipoProduto tipoAparelho2 = default;
                    Console.WriteLine();
                    Console.WriteLine("Insira os dados do Segundo Aparelho para Reparo: ");
                    Console.WriteLine("Tipos disponíveis:");
                    Console.WriteLine("0 - TV");
                    Console.WriteLine("1 - Monitor");
                    Console.WriteLine("2 - Controle Remoto");
                    bool entradaValida2 = false;
                    while (!entradaValida2)
                    {
                        Console.WriteLine();
                        Console.Write("Digite o número correspondente ao tipo do segundo aparelho: ");

                        if (int.TryParse(Console.ReadLine(), out int tipoSelecionado2) &&
                             Enum.IsDefined(typeof(TipoProduto), tipoSelecionado2))
                        {
                            tipoAparelho = (TipoProduto)tipoSelecionado2;
                            entradaValida2 = true;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida! Por favor, digite um número entre 0 e 2.");
                        }
                    }
                    Console.Write("Descrição do Aparelho: ");
                    string desc2 = Console.ReadLine();
                    Console.Write("Defeito do Aparelho: ");
                    string defeito2 = Console.ReadLine();
                    Console.Write("Insira o Valor do Reparo em questão: ");
                    double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Insira o ID de Identificação do Aparelho em Estoque: ");
                    int idproduto2 = int.Parse(Console.ReadLine());
                    p2 = new Produto(idproduto2, tipoAparelho2, desc2, valor2);
                    estoque.AddProduto(p2);
                }
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine();
                Console.Write("Digite a ID da Ordem de Serviço: ");
                int idOrdem = int.Parse(Console.ReadLine());
                OrdemDeServico os1 = new OrdemDeServico(c1, p1, f1, idOrdem);
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine(os1);
                Console.WriteLine(c1);
                Console.WriteLine(f1);
                Console.WriteLine(p1);
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine(estoque);
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Alterar Status do Serviço;");
                Console.WriteLine("2 - Remover um Aparelho de Cliente do Estoque;");
                Console.WriteLine("3 - Sair;");
                Console.Write("Digite o número correspondente a opção: ");

                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    if (opcao == 1)
                    {
                        Console.Write("Insira o ID da ordem de serviço: ");
                        if (int.TryParse(Console.ReadLine(), out int idOrdemAlteracao))
                        {
                            if (os1 != null && os1.IdOrdem == idOrdemAlteracao)
                            {
                                Console.WriteLine("Status válidos disponíveis:");
                                Console.WriteLine("1 - Em Andamento");
                                Console.WriteLine("2 - Concluído");
                                Console.WriteLine("3 - Retirado");

                                Console.Write("Digite o número do novo status: ");
                                if (int.TryParse(Console.ReadLine(), out int novoStatus) && Enum.IsDefined(typeof(Status), novoStatus))
                                {
                                    os1.AlterarStatus((Status)novoStatus);
                                    Console.WriteLine("Status da Ordem de Serviço Alterada!");
                                    Console.WriteLine();
                                    Console.WriteLine(c1);
                                }
                                else
                                {
                                    Console.WriteLine("Status inválido!");
                                }
                            }
                        }
                    }
                    else if (opcao == 2)
                    {
                        Console.Write("Insira o ID do Aparelho em Estoque: ");
                        if (int.TryParse(Console.ReadLine(), out int idAparelhoAlteracao))
                        {
                            if (p1 != null && p1.IdProduto == idAparelhoAlteracao)
                            {
                                estoque.RemoveProduto(p1);
                                Console.WriteLine("Aparelho Removido!");
                                Console.WriteLine();
                                Console.WriteLine(estoque);
                            }
                            else if (p2 != null && p2.IdProduto == idAparelhoAlteracao)
                            {
                                estoque.RemoveProduto(p2);
                                Console.WriteLine("Aparelho Removido!");
                                Console.WriteLine();
                                Console.WriteLine(estoque);
                            }
                            else
                            {
                                Console.WriteLine("Aparelho inválido!");
                            }
                        }
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Até mais!");
                        Console.WriteLine("----------------------------------------------------");
                    }
                }
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Entre com os dados do Fornecedor:");
                Console.Write("Razão Social: ");
                string razaoSocial = Console.ReadLine();
                Console.Write("CNPJ: ");
                string cnpj = Console.ReadLine();
                Fornecedor f1 = new Fornecedor(razaoSocial, cnpj);
                Console.WriteLine();
                Console.WriteLine("Selecione uma operação para o Estoque: ");
                Console.WriteLine("1 - Adicionar nova Peça;");
                Console.WriteLine("2 - Remover Peça;");
                Console.Write("Digite o número correspondente a opção: ");
                int opcaoEstoque = int.Parse(Console.ReadLine());

                if (opcaoEstoque == 1)
                {
                    Console.Write("Digite o nome da Peça a ser Adicionada ao Estoque: ");
                    string peca = Console.ReadLine();
                    Estoque estoque = new Estoque();
                    estoque.AddPeça(peca);
                    Console.WriteLine("Peça Adicionada com Sucesso!");
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine(f1);
                    Console.WriteLine(estoque);
                    Console.WriteLine();
                }
                else if (opcaoEstoque == 2)
                {
                    Console.Write("Digite o nome da Peça a ser Removida do Estoque: ");
                    string peca = Console.ReadLine();
                    Estoque estoque = new Estoque();
                    if (estoque != null && estoque.Peças.Contains(peca)) {
                        estoque.RemovePeça(peca);
                        Console.WriteLine("Peça Removida com Sucesso!");
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine(f1);
                        Console.WriteLine(estoque);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
        }
    }
}
