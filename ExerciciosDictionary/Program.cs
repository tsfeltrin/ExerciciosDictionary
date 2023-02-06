using System;

namespace ExerciciosDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Marca = "Volks";
            carro.Ano = 2020;
            carro.Portas = 4;
            Carro carro1 = new Carro();
            carro1.Marca = "Volks";
            carro1.Ano = 2020;
            carro1.Portas = 4;
            Carro carro2 = new Carro();
            carro2.Marca = "Volks";
            carro2.Ano = 2020;
            carro2.Portas = 4;

            Moto moto = new Moto();
            moto.Marca = "Honda";
            moto.Ano = 2020;
            Moto moto1 = new Moto();
            moto1.Marca = "Honda";
            moto1.Ano = 2020;
          
            Moto moto2 = new Moto();
            moto2.Marca = "Honda";
            moto2.Ano = 2020;
            

            Concessionaria concessionaria = new Concessionaria();
            concessionaria.Adicionar(carro);
            concessionaria.Adicionar(carro1);
            concessionaria.Adicionar(carro2);
            concessionaria.Adicionar(moto);
            concessionaria.Adicionar(moto1);
            concessionaria.Adicionar(moto2);

            concessionaria.Ler();



        }
    }
}
