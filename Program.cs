

using System;
namespace ControleDeClientes
{
    class Program
    {
        static void Main (string []args)
        {
            float val_Pag;
            Console.WriteLine(" Informe o seu nome: ");
            string var_Nome = Console.ReadLine();
            Console.WriteLine(" Informe o seu endereço: ");
            string var_Endereco = Console.ReadLine();
            Console.WriteLine(" Pessoa física (f) ou pessoa juridica (j)? ");
            string var_Tipo = Console.ReadLine();
            if (var_Tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.Nome = var_Nome;
                pf.Endereco = var_Endereco;
                Console.WriteLine(" Informe seu CPF: ");
                pf.CPF = Console.ReadLine();
                Console.WriteLine(" Informe seu RG: ");
                pf.RG = Console.ReadLine();
                Console.WriteLine(" Informar o valor da compra: ");
                val_Pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_Pag);
                Console.WriteLine("-------Pessoa Fisica------");
                Console.WriteLine("-Nome: " + pf.Nome);
                Console.WriteLine("-Endereço: " + pf.Endereco);
                Console.WriteLine("-CPF: " + pf.CPF);
                Console.WriteLine("-RG: " + pf.RG);
                Console.WriteLine("-Valor da compra: " + pf.Valor.ToString("C"));
                Console.WriteLine("-Valor do imposto: " + pf.Valor_Imposto.ToString("C"));
                Console.WriteLine("-Valor toatl: " + pf.Total.ToString("C"));
            }
            if (var_Tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica(); 
                pj.Nome = var_Nome;
                pj.Endereco = var_Endereco;
                Console.WriteLine(" Informe seu CNPJ: ");
                pj.CNPJ = Console.ReadLine();
                Console.WriteLine(" Informe seu IE: ");
                pj.IE = Console.ReadLine();
                Console.WriteLine(" Informe o valor da compra: ");
                val_Pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_Pag);
                Console.WriteLine(" --------Pessoa Juridica-------");
                Console.WriteLine("-Nome: " + pj.Nome);
                Console.WriteLine("-Endereço:" + pj.Endereco);
                Console.WriteLine("-CNPJ: " + pj.CNPJ);
                Console.WriteLine("-IE: " + pj.IE);
                Console.WriteLine("-Valor da compra: " + pj.Valor.ToString("C"));
                Console.WriteLine("-Valor do imposto: " + pj.Valor_Imposto.ToString("C"));
                Console.WriteLine("-Valor total: " + pj.Total.ToString("C"));
            }
        }
    }
}
