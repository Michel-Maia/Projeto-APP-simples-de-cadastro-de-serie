using System;
using  System.Collections.Generic;
using DIO.Series.Irterface;


namespace  DIO.Series
{
    

	public class SerieRepositorio : IRepositorio<Serie>
	{
        
        private list<Série> listaSerie  = new List <Série> ();
		
        public void Atualiza (int id, Serie objeto)
		{
			listaSerie [id] = objeto;
		}

		public void Exclui (int  id)
		{
			listaSerie [id].Excluir();
		}

		public void Insere (Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		 public List<Série> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int  id)
		{
			return listaSerie [id];
		}
	}
}
