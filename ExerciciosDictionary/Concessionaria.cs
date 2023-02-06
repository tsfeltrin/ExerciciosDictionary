using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDictionary
{
    public class Concessionaria
    {
        public List<Veiculo> Veiculos {get; set;}

        public string Adicionar(Veiculo veiculo)
        {
            if (Veiculos == null)
            {
                Veiculos = new List<Veiculo>();
            }
            Veiculos.Add(veiculo);
            return "VEICULO ADICIONADO COM SUCESSO!";
        }
        public void Ler()
        {
            foreach (Veiculo item in Veiculos)
            {
                Console.WriteLine(item.Marca);
                
            }
        }
    }
}
