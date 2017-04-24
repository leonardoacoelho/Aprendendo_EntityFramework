using AprendendoEF.BLL.Base;
using AprendendoEF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AprendendoEF.BLL
{
    public class VendaBO : BaseBO<Venda, VendaDAO>
    {
        public override void Salvar(Venda entidade)
        {
            try
            {
                if (entidade.Cliente_Id <= 0 || entidade.Data == null)
                    throw new ArgumentOutOfRangeException();

                if ((entidade.Itens?.Count ?? 0) == 0)
                    throw new ArgumentNullException();
                else
                {
                    base.Salvar(entidade);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected override void Inserir(Venda entidade)
        {
            //Fazer backup dos itens
            var itens = entidade.Itens;

            //Anular os itens
            entidade.Itens = null;

            //Inserir a venda
            base.Inserir(entidade);

            //Instanciar itemBO
            var itemBO = new ItemVendaBO();

            //Adicionar os itens
            foreach (var item in itens)
            {
                item.Venda_Id = entidade.Id;
                itemBO.Salvar(item);
            }
        }

        protected override void Editar(Venda entidade)
        {
            //Fazer backup dos itens
            var itens = entidade.Itens;

            //Anular os itens
            entidade.Itens = null;

            //Alterar a venda
            base.Editar(entidade);

            //Obter itens mantidos
            var idsMantidos = itens.Where(x => x.Id > 0)
                                .Select(x => x.Id)
                                .ToList();

            //Instanciar itemBO
            var itemBO = new ItemVendaBO();

            //Encontrar os itens do banco
            var itensBD = itemBO.Listar().Where(x => x.Venda_Id == entidade.Id);

            //Obter itens removidos
            var idsParaRemover = itensBD.Where(x => !idsMantidos.Contains(x.Id))
                                    .Select(x => x.Id)
                                    .ToList();

            //Remover os itens
            foreach (var id in idsParaRemover)
            {
                itemBO.Remover(id);
            }

            //Adicionar ou editar os itens
            foreach (var item in itens)
            {
                item.Venda_Id = entidade.Id;
                itemBO.Salvar(item);
            }
        }
    }
}
