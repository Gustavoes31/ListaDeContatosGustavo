﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosT6Gustavo
{
    internal class Contato
    {
        // Declaração de variáveis.
        private string nome;
        private string sobrenome;
        private string telefone;

        // Propriedades. São os métodos "get" e "set".
        // get = leitura.
        // set = definição.
        // é possível ser somente leitura, ou somente definição...
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "00000000000";
                }
            }
        }

        // Construtor da classe.
        public Contato()
        {
            Nome = "Cláudio";
            Sobrenome = "Genésio II";
            Telefone = "11988887777";
        }
        
        // Sobrecarga do método construtor da classe Contato.
        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        // ToString() pertence a classe object.
        // Todas as classes são filhas de object (Herança).
        // "override" sobrescreve o método da classe pai (polimorfismo).
        public override string ToString()
        {
            // inicializa a variável como vazia.
            string saida = string.Empty;
            saida += String.Format("{0} {1} ", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}", 
                Telefone.Substring(0,2), 
                Telefone.Substring(2,5),
                Telefone.Substring(7,4));
            
            return saida;
        }
    }
}
