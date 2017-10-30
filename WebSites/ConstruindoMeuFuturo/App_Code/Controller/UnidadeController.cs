using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de UnidadeController
/// </summary>
public class UnidadeController
{
    Unidade_de_EnsinoDao unidadedao;
    public List<UnidadeEnsinoBean> ListarUnidadeCurso(int idcurso){
        try
        {
            unidadedao = new Unidade_de_EnsinoDao();
            var unidades = unidadedao.ListarUnidadeCurso(idcurso);
            return unidades;
        }
        catch {
            //Erro ao listar unidade curso
            return null;
        }
    }

    public UnidadeEnsinoBean ConsultarUnidadeId(int idunidade)
    {
        try
        {
            unidadedao = new Unidade_de_EnsinoDao();
            var unidade = unidadedao.ConsultarUnidadeID(idunidade);
            return unidade;
        }
        catch
        {
            return null;
        }
    }
}