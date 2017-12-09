using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CursoConstroller
/// </summary>
public class CursoController
{
    UnidadeController unidadecont;
    QuestionarioController questionariocont;
    CursoDao cursodao;
    AreaController areacont;
    PerfilController perfilcont;




    public List<CursoBean> ListaCurso()
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCurso();
            return cursos;
        }
        catch
        {
            return null;
        }
    }
    public List<CursoBean> ListaCursoPorArea(int idarea)
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoArea(idarea);
            return cursos;
        }
        catch
        {
            return null;
        }
    }

    public List<CursoBean> ListaCursoPorNome(string nomecurso)
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoNome(nomecurso);
            return cursos;
        }
        catch
        {
            return null;
        }
    }
    public List<CursoBean> ListaCursoUnidade(int idunidade)
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoUnidade(idunidade);
            return cursos;
        }
        catch
        {
            return null;
        }
    }

    public List<CursoBean> ListaCursoRespostaQuestao(int idquestao, int idresposta)
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoQuestionario(idquestao, idresposta);
            return cursos;
        }
        catch
        {
            return null;
        }
    }

    public CursoBean ConsultarCursoId(int idcurso)
    {
        try
        {
            cursodao = new CursoDao();
            var curso = cursodao.ConsultarCursoID(idcurso);
            return curso;
        }
        catch
        {
            return null;
        }
    }

    public void InserirNovoCurso(CursoBean curso)
    {
        //Verifica se unidade está sem nome
        ValidarCurso(curso);

        cursodao = new CursoDao();
        var linhasafetadas = cursodao.InserirCurso(curso);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new UsuarioNaoCadastradoException();
        }
    }
    public void InserirCursoRespostaQuestao(int idresposta, int idquestao, int idcurso)
    {
        cursodao = new CursoDao();
        var linhasafetadas = cursodao.InserirCursoRespostaQuestao(idresposta, idquestao, idcurso);
        if (linhasafetadas == 0)
        {
            throw new CursoNaoExcluidoException();
        }
    }
    public void ExcluirCurso(int idunidade, int idcurso)
    {

        cursodao = new CursoDao();
        var linhasafetadas = cursodao.ExcluirCursoUnidade(idunidade, idcurso);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new CursoNaoExcluidoException();
        }
    }

    public void ExcluirCursoRespostaQuestao(int idresposta, int idquestao, int idcurso)
    {
        cursodao = new CursoDao();
        var linhasafetadas = cursodao.ExcluirRespostaQuestaoCurso(idresposta, idquestao, idcurso);
        if (linhasafetadas == 0)
        {
            throw new CursoNaoExcluidoException();
        }
    }
    public void InserirCursoUnidade(int idcurso, int idunidade)
    {

        cursodao = new CursoDao();
        var linhasafetadas = cursodao.InserirCursoUnidade(idcurso, idunidade);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new UsuarioNaoCadastradoException();
        }
    }

    public void AlterarCurso(CursoBean curso)
    {
        //Verifica se unidade está sem nome
        ValidarCurso(curso);

        cursodao = new CursoDao();
        var linhasafetadas = cursodao.AlterarCurso(curso);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new NaoCadastradoException();
        }
    }


    public void ValidarCurso(CursoBean curso)
    {
        //Verifica se as variaveis estão nulas
        if (string.IsNullOrWhiteSpace(curso.Nome) || string.IsNullOrWhiteSpace(curso.Tipo))
        {
            throw new UnidadeInvalidaException();
        }
    }

    public void InserirCursoIndicado(int idcurso, int idperfil, int ponto)
    {

        cursodao = new CursoDao();
        var linhasafetadas = cursodao.InserirCursoIndicado(idcurso, idperfil, ponto);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new NaoCadastradoException();
        }
    }

    public void ExcluirCursoIndicado(int idcurso, int idperfil)
    {
        cursodao = new CursoDao();
        var linhasafetadas = cursodao.ExcluirCursoIndicado(idcurso, idperfil);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new NaoCadastradoException();
        }
    }

    public void ExcluirCursosIndicado(int idperfil)
    {
        cursodao = new CursoDao();
        var linhasafetadas = cursodao.ExcluirCursosIndicado(idperfil);
        //verifica se retornou nenhuma linha afetada
    }
    public void InserirPontoCursoIndicado(int idcurso, int idperfil, int ponto)
    {

        cursodao = new CursoDao();
        var linhasafetadas = cursodao.InserirPontoCursoIndicado(idcurso, idperfil, ponto);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new NaoCadastradoException();
        }
    }

    public int ConsultarPontoCursoIndicado(int idcurso, int idperfil)
    {

        int ponto = 0;
        cursodao = new CursoDao();
        try
        {
            ponto = cursodao.ConsultarPontoCursoIndicado(idcurso, idperfil);
        }
        catch
        {
            //erro ao consultar
        }
        return ponto;
    }

    public List<CursoBean> ListarCursosIndicado(int idperfil)
    {
        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoIndicadoPerfil(idperfil);
            return cursos;
        }
        catch
        {
            return null;
        }

    }

    public List<CursoBean> ListarCursoUnidade(int idunidade)
    {

        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoUnidade(idunidade);
            return cursos;
        }
        catch
        {
            return null;
        }
    }

    public List<CursoBean> ListarCursoCidade(int idcidade)
    {

        try
        {
            cursodao = new CursoDao();
            var cursos = cursodao.ListarCursoCidade(idcidade);
            return cursos;
        }
        catch
        {
            return null;
        }
    }

    public CursoBean ConsultarCursoCidade(int idcidade, int idcurso)
    {

        try
        {
            var curso = cursodao.ConsultarCursoCidade(idcidade, idcurso);
            return curso;
        }
        catch
        {
            return null;
        }
    }

    public void InserirCursoIndicadoQuestionarios(int idperfil, int idcidade)
    {
        unidadecont = new UnidadeController();
        questionariocont = new QuestionarioController();


        //Pesquisa os cursos cadastrados na cidade
        foreach (CursoBean curso in this.ListarCursoCidade(idcidade))
        {
            //Pesquisa os cursos que correspondem ao questionario
            foreach (QuestionarioBean questionario in this.questionariocont.ListarQuestionarioCurso(curso.Id))
            {
                //Pesquisa o questionario do perfil
                foreach (QuestionarioBean questionarioperfil in this.questionariocont.ListarQuestionarioPerfil(idperfil, questionario.Id_questao, questionario.Id_resposta))
                {
                    //consulta se esse curso já estava cadastrado na tabela curso indicado, retonando a pontuação
                    int ponto = 0;
                    ponto = this.ConsultarPontoCursoIndicado(curso.Id, idperfil);
                    //Se a pontuação é igual 0, ele não está cadastrado ainda
                    if (ponto == 0)
                    {
                        //Cadastra o curso na table Curso Indicado e da 1 ponto
                        this.InserirCursoIndicado(curso.Id, idperfil, 1);
                    }
                    else
                    {
                        //Senão ele Acrescenta mais 1 ponto no curso indicado
                        this.InserirPontoCursoIndicado(curso.Id, idperfil, ponto + 1);
                    }

                }
            }
        }


    }


    public void InserirCursoIndicadoArea(int idperfil, int idcidade)
    {

        areacont = new AreaController();
        //Pesquisa a area que o perfil está cadastrado
        foreach (AreaBean area in this.areacont.ListarAreaPerfil(idperfil))
        {
            //Lista os cursos que estão cadastrados na area
            foreach (CursoBean curso in this.ListaCursoPorArea(area.Id))
            {
                //Ve se o curso é cadastrado em são Paulo
                if (this.ConsultarCursoCidade(idcidade, curso.Id) != null)
                {
                    //consulta se esse curso já estava cadastrado na tabela curso indicado, retonando a pontuação
                    int ponto = 0;
                    ponto = this.ConsultarPontoCursoIndicado(curso.Id, idperfil);
                    //Se a pontuação é igual 0, ele não está cadastrado ainda
                    if (ponto == 0)
                    {
                        //Cadastra o curso na table Curso Indicado e da 1 ponto
                        this.InserirCursoIndicado(curso.Id, idperfil, 1);
                    }
                    else
                    {
                        //Senão ele Acrescenta mais 1 ponto no curso indicado
                        this.InserirPontoCursoIndicado(curso.Id, idperfil, ponto + 1);
                    }
                }
            }
        }


    }

    //Tira os pontos do perfil que foram ganhos pela area
    public void RetirarCursoIndicadoArea(int idperfil)
    {
        areacont = new AreaController();

        
        foreach (AreaBean area in this.areacont.ListarAreaPerfil(idperfil))
        {
            foreach (CursoBean curso in this.ListaCursoPorArea(area.Id))
            {
                if (this.ConsultarCursoCidade(5270, curso.Id) != null)
                {
                    //consulta se esse curso já estava cadastrado na tabela curso indicado, retonando a pontuação
                    int ponto = 0;
                    ponto = this.ConsultarPontoCursoIndicado(curso.Id, idperfil);
                    //Se a pontuação é igual 0, ele não está cadastrado ainda
                    if (ponto == 1)
                    {
                        //Cadastra o curso na table Curso Indicado e da 1 ponto
                        this.ExcluirCursoIndicado(curso.Id, idperfil);
                    }
                    if(ponto > 1)
                    {
                        //Senão ele Tira 1 ponto no curso indicado
                        this.InserirPontoCursoIndicado(curso.Id, idperfil, ponto - 1);
                    }
                }
            }
        }
    }
}