using System;

namespace DIO.Series
{
  public class Series : EntidadeBase
  {
    //atributos
    Genero Genero { get; set; }
    string Titulo { get; set; }
    string Descricao { get; set; }
    int Ano { get; set; }

    //metodos construtores
    public void Serie(int id, Genero genero, string titulo, string descricao, int ano)
    {
      this.Id = id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
    }

    public override string ToString()
    {

      string retorno = "";
      retorno += "Gênero: " + this.Genero + Environment.NewLine;
      retorno += "Titulo: " + this.Titulo + Environment.NewLine;
      retorno += "Descrição: " + this.Descricao + Environment.NewLine;
      retorno += "Ano de inicio: " + this.Ano;

      return retorno;

    }

    //metodos de encapsulamento
    public string retornaTitulo()
    {

      return this.Titulo;

    }

    public int retornaId()
    {

      return this.Id;

    }

  }
}