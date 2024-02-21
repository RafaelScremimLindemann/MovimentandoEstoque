using Estudo;
using System.Globalization;

/*Programa onde inserimos os dados do produto, chamando a classe pelo objeto.
  Temos a opção de adicionar um produto e remover, atualizando o estoque.*/

class principal
{
    static void Main(string[] args) {

        
        Console.WriteLine("Dados do produto.");
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Class1 p = new Class1(nome, preco, quantidade);

        Console.WriteLine("Estoque atualizado: " + p);

        Console.WriteLine();
        Console.WriteLine("Digite o numero de produtos a ser adicionado: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);
        Console.WriteLine("Estoque Atualizado: " + p);

        Console.WriteLine();
        Console.WriteLine("Digite o numero de produtos a ser removido: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qte);
        Console.WriteLine("Estoque Atualizado após remoção: " + p);

    }
}