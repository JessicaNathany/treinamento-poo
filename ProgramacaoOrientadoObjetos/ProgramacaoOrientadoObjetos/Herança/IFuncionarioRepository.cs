using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadoObjetos.Herança
{
    public interface IFuncionarioRepository
    {
        void Save(Funcionario funcionario);
        void Update(int id);
        List<Funcionario> ListarFuncionarios();
    }
}
