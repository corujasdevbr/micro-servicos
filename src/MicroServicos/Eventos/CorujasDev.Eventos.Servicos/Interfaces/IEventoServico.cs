using CorujasDev.Eventos.Dominio.Entidades;
using CorujasDev.Eventos.Servicos.ViewModels.Evento;
using System;
using System.Linq.Expressions;

namespace CorujasDev.Eventos.Servicos.Interfaces
{
    public interface IEventoServico
    {
        EventoHomeViewModel Listar();

        EventoViewModel BuscarPorId(Guid id);

        EventoHomeViewModel Filtrar(Expression<Func<EventoEntidade, bool>> filtro);

        void Inserir(EventoViewModel Evento);

        void Alterar(EventoViewModel Evento);
    }
}
