using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComproveCompre
{
    class PessoaFisica
    {
        protected string Nome;
        protected string Cpf;
        protected string Rg;
        protected string Endereco;
        protected int Telefone;
        protected double PoderCompra;
       

        public void setNome(string nome)
        {
            Nome = nome;
        }
        public string getNome()
        {
            return Nome;
        }
        public void setCpf(string cpf)
        {
            Cpf = cpf;
        }
        public string getCpf()
        {
            return Cpf;
        }
        public void setRg(string rg)
        {
            Rg = rg;
        }
        public string getRg()
        {
            return Rg;
        }
        public void setEndereco(string end)
        {
            Endereco = end;
        }
        public string getEndereco()
        {
            return Endereco;
        }
        public void setTelefone(int tel)
        {
            Telefone = tel;
        }
        public int getTelefone()
        {
            return Telefone;
        }
        public  void setPoderCompra(double moeda)
        {
            PoderCompra = moeda;
        }
        public double getPoderCompra()
        {
            return PoderCompra;
        }
    }
}
