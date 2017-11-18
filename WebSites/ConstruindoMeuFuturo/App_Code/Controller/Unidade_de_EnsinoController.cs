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

    public List<UnidadeEnsinoBean> ListarUnidades()
    {
        try
        {
            unidadedao = new Unidade_de_EnsinoDao();
            var unidades = unidadedao.ListarUnidades();
            return unidades;
        }
        catch
        {
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

    public void InserirNovaUnidade(UnidadeEnsinoBean unidade)
    {
        //Verifica se unidade está sem nome
        ValidarUnidade(unidade);
   
        unidadedao = new Unidade_de_EnsinoDao();
        var linhasafetadas = unidadedao.InserirUnidade(unidade);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new UsuarioNaoCadastradoException();
        }
    }

    public void ValidarUnidade(UnidadeEnsinoBean unidade)
    {
        //Verifica se as variaveis estão nulas
        if (string.IsNullOrWhiteSpace(unidade.Nome_unidade))
        {
            throw new UnidadeInvalidaException();
        }
    }
}