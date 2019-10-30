using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using  CorujasDev.Vagas.Dominio.Entidades;
using  CorujasDev.Vagas.Dominio.Interfaces.Repositorios;
using  CorujasDev.Vagas.Servicos.Interfaces;
using  CorujasDev.Vagas.Servicos.ViewModels.Vaga;

namespace CorujasDev.Vagas.Servicos.Servicos
{
    public class VagaServico : IVagaServico
    {
        private readonly IMapper _mapper;
        private readonly IVagaRepositorio _vagaRepositorio;

        public VagaServico(IVagaRepositorio vagaRepositorio, IMapper mapper)
        {
            _vagaRepositorio = vagaRepositorio;
            _mapper = mapper;
        }

        public void Alterar(VagaViewModel vaga)
        {
            var vagaRetorna = _mapper.Map<VagaViewModel>(_vagaRepositorio.BuscarPorId(vaga.Id));

            if (vagaRetorna == null)
                throw new Exception("Id não encontrada");

            _vagaRepositorio.Alterar(_mapper.Map<VagaEntidade>(vaga));
        }

        public void Ativar(Guid id)
        {
            try
            {
                var vaga = _mapper.Map<VagaViewModel>(_vagaRepositorio.BuscarPorId(id));

                if (vaga == null)
                    throw new Exception("Id não encontrada");

                vaga.Ativa = true;
                _vagaRepositorio.Alterar(_mapper.Map<VagaEntidade>(vaga));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VagaViewModel BuscarPorId(Guid id)
        {
            try
            {
                return _mapper.Map<VagaViewModel>(_vagaRepositorio.BuscarPorId(id));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Desativar(Guid id)
        {
            try
            {
                var vaga = _mapper.Map<VagaViewModel>(_vagaRepositorio.BuscarPorId(id));

                if (vaga == null)
                    throw new Exception("Id não encontrada");

                vaga.Ativa = false;
                _vagaRepositorio.Alterar(_mapper.Map<VagaEntidade>(vaga));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public VagaHomeViewModel Filtrar(Expression<Func<VagaEntidade, bool>> filtro)
        {
            try
            {
                VagaHomeViewModel viewModel = new VagaHomeViewModel();
                viewModel.Vagas = _mapper.Map<List<VagaViewModel>>(_vagaRepositorio.Pesquisar(filtro));
                viewModel.quantidade = viewModel.Vagas.Count;

                return viewModel;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Inserir(VagaViewModel vaga)
        {
            try
            {
                _vagaRepositorio.Inserir(_mapper.Map<VagaEntidade>(vaga));
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public VagaHomeViewModel Listar()
        {
            try
            {
                VagaHomeViewModel viewModel = new VagaHomeViewModel();
                viewModel.Vagas = _mapper.Map<List<VagaViewModel>>(_vagaRepositorio.Listar());
                viewModel.quantidade = viewModel.Vagas.Count;

                return viewModel;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
