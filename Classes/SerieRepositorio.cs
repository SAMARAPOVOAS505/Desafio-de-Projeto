using System;
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = IRepositorio<Serie>;
        public void Atualizar(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }
        public List<Serie> lista()
        {
            return listaSerie;
        }

        public int ProximoId(int id)
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
           return listaSerie(id);
        }
    }
}