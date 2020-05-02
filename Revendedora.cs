using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComproveCompre
{
    class Revendedora
    {
        protected string Motor;
        protected double Potencia;
        protected double Desempenho;
        protected string Aceleracao = "0-100Km/h";
        protected double Consumo;
        protected double Autonomia;
        protected string Modelo;
        protected string Marca;
        protected string Cor;
        protected string Cambio;
        protected string Tracao;
        protected string EstiloVeiculo;
        protected double ValorVeiculo;


        public void setMotor(string motor)
        {
            Motor = motor;
        }
        public string getMotor()
        {
            return Motor;
        }
        public void setPetencia(double cv)
        {
            Potencia = cv;
        }
        public double getPotencia()
        {
            return Potencia;
        }
        public void setDesempenho(double velocidade)
        {
            Desempenho = velocidade;
        }
        public double getDesempenho()
        {
            return Desempenho;
        }
        public void setAceleracao(string tempo)
        {
            Aceleracao = tempo;
        }
        public string getAceleracao()
        {
            return Aceleracao;
        }
        public void setConsumo(double consumo)
        {
            Consumo = consumo;

        }
        public double getConsumo()
        {
            return Consumo;
        }
        public void setAtonomia(double autonomia)
        {
            Autonomia = autonomia;
        }
        public double getAutonomia()
        {
            return Autonomia;
        }
        public void setModelo(string modelo)
        {
            Modelo = modelo;
        }
        public string getModelo()
        {
            return Modelo;
        }
        public void setMarca(string marca)
        {
            Marca = marca;
        }
        public string getMarca()
        {
            return Marca;
        }
        public void setCor(string cor)
        {
            Cor = cor;
        }
        public string getCor()
        {
            return Cor;
        }
        public void setCambio(string marcha)
        {
            Cambio = marcha;
        }
        public string getCambio()
        {
            return Cambio;
        }
        public void setTracao(string tracao)
        {
            Tracao = tracao;
        }
        public string getTracao()
        {
            return Tracao;
        }
        public void setEstiloVeiculo(string estilo)
        {
            EstiloVeiculo = estilo;
        }
        public string getEstiloVeiculo()
        {
            return EstiloVeiculo;
        }
        public void setValorVeiculo(double valor)
        {
            ValorVeiculo = valor;
        }
        public double getValorVeiculo()
        {
            return ValorVeiculo;
        }
    }
}
