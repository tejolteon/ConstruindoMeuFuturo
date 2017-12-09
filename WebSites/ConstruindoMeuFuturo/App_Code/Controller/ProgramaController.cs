using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de ProgramaController
/// </summary>


public class ProgramaController
{
    ProgramaDao programadao;

    public void InserirProgramaUnidade(ProgramaBean programa, int idunidade)
    {
        programadao = new ProgramaDao();
        int linhasafetas = programadao.InserirProgramaUnidade(programa, idunidade);
        if(linhasafetas == 0)
        {
            throw new NaoCadastradoException();
        }
    }

    public List<ProgramaBean> ListarProgramas()
    {
       programadao = new ProgramaDao();
        var programas = new List<ProgramaBean>();
        programas = programadao.ListarProgramas();

        return programas;
    }

    public List<ProgramaBean> ListarProgramasUnidade(int idunidade)
    {
        programadao = new ProgramaDao();
        var programas = new List<ProgramaBean>();
        programas = programadao.ListarProgramasUnidade(idunidade);
        return programas;
    }
}