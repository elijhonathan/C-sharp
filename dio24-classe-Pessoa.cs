using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        private string _sobrenome;

        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
            }


            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome
        { 
            get            
            {
                return _sobrenome.ToUpper();
            }
            
            set             
            {
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }

                _sobrenome = value;
            }
        }

        public int Idade 
        { 
           get => _idade;


           set
           {
            if (value < 0)
            {
                throw new ArgumentException("A idade não pode ser menor que zero");
            }
            _idade = value;
           } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Sobrenome {Sobrenome}, Idade: {Idade}");
        }
    }
}
