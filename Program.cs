// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;
/* Senteças para acessar os enumeradores */
int id = (int)Genero.Acao;
Console.WriteLine(id);

var filmeParaFamilia = new Filme();
filmeParaFamilia.Titulo = "Drácula";
filmeParaFamilia.GeneroFilme = Genero.Comedia;

Console.WriteLine(" {0} é {1}!", filmeParaFamilia.Titulo,
filmeParaFamilia.GeneroFilme);
