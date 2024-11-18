using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {

        public List<Pessoa> Hospedes {get; set;}
        public Suite Suite {get; set;}
        public int DiasReservados {get; set;}
        
        public Reserva(int diasReservados)
        {
           DiasReservados = diasReservados;
        }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if(Suite.Capacidade >= hospedes.Count)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Quantidade de hospedes maior do que a capacidade!!");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
        
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;

        if(DiasReservados >= 10)
        {   
            valor *= 0.90M;

        }
        
        return valor;
    }

    }


}