using static System.Console;
using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Contextos;

using var context = new BancoContext();

//Veric se o db existe e cria se necessario
//cria as tabelas baseada nas entidades configuradas
context.Database.EnsureCreated();

//menu no programa
WriteLine("===Sistema Bancario===");
WriteLine("\n---MENU PRINCIPAL---");
WriteLine("1 - Cadastrar nova conta ");
WriteLine("2 - Consultar conta existente");
WriteLine("3 - Sair\n");
Write("Escolha uma opção : ");



