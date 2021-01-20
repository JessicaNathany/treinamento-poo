using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadoObjetos.Herança
{
    public interface IBaseService <TEntity>
    {
        void Salvar(TEntity entity);
        void Update(int id);
        void Delete(int id);
        List<TEntity> ObterTodos();
    }
}
