using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using CorujasDev.Eventos.Dominio.Entidades;
using CorujasDev.Eventos.Dominio.Interfaces.Repositorios;
using CorujasDev.Eventos.Servicos.Interfaces;
using CorujasDev.Eventos.Servicos.ViewModels.Evento;

namespace CorujasDev.Eventos.Servicos.Servicos
{
    public class EventoServico : IEventoServico
    {
        private readonly IMapper _mapper;
        private readonly IEventoRepositorio _eventoRepositorio;

        public EventoServico(IEventoRepositorio eventoRepositorio, IMapper mapper)
        {
            _eventoRepositorio = eventoRepositorio;
            _mapper = mapper;
        }

        public void Alterar(EventoViewModel Evento)
        {
            var EventoRetorna = _mapper.Map<EventoViewModel>(_eventoRepositorio.BuscarPorId(Evento.Id));

            if (EventoRetorna == null)
                throw new Exception("Id não encontrada");

            _eventoRepositorio.Alterar(_mapper.Map<EventoEntidade>(Evento));
        }

        public EventoViewModel BuscarPorId(Guid id)
        {
            try
            {
                return _mapper.Map<EventoViewModel>(_eventoRepositorio.BuscarPorId(id));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        

        public EventoHomeViewModel Filtrar(Expression<Func<EventoEntidade, bool>> filtro)
        {
            try
            {
                EventoHomeViewModel viewModel = new EventoHomeViewModel();
                viewModel.Eventos = _mapper.Map<List<EventoViewModel>>(_eventoRepositorio.Pesquisar(filtro));
                viewModel.quantidade = viewModel.Eventos.Count;

                return viewModel;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Inserir(EventoViewModel Evento)
        {
            try
            {
                _eventoRepositorio.Inserir(_mapper.Map<EventoEntidade>(Evento));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public EventoHomeViewModel Listar()
        {
            try
            {
                EventoHomeViewModel viewModel = new EventoHomeViewModel();
                viewModel.Eventos = _mapper.Map<List<EventoViewModel>>(_eventoRepositorio.Listar());
                viewModel.quantidade = viewModel.Eventos.Count;

                return viewModel;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
