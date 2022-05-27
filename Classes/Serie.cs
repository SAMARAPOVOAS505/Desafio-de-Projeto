using System;

namespace Dio.Series
{
     public class Serie : EntidadeBase
     {
       //Atributos
               private Genero Genero{ get; set; }
               private string Titulo { get; set; }
               private string Descricao {get; set; }
               private int Ano {get; set; }

               private bool Excluido {get; set;} 
        private bool Excluido {get; set;} 
     }

        //Métodos
               public Serie(int id, Genero genero, string Titulo, string Descricao, int Ano)
               {
                      this.Id = id;
                      this.Genero = genero;
                      this.Titulo = Titulo;
                      this.Descricao = Descricao;
                      this.Ano = Ano;
                      this.Excluido = false;
                }

        public override string ToString()
        {
          // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
             string retorno = "";
             retorno += "Gênero: " + this.Genero + Environment.NewLine;
             retorno += "Título: " + this.Titulo + Environment.NewLine;
             retorno += "Descrição: " + this.Descricao + Environment.NewLine;
             retorno += "Ano de Início: " + this.Ano;
             return retorno; 
        }

        public static retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir() {
            this.Excluido = true;
        }
    }   
  
