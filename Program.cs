using System.Text;
using DesafioProjetoHospedagem.Models;


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "h1", sobrenome:"hh");
Pessoa p2 = new Pessoa(nome: "h2", sobrenome: "hh");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

Reserva reserva = new Reserva (diasReservados: 2);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor hospedagem: R$ {reserva.CalcularValorDiaria()}");
