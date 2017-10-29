using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PerfilController
/// </summary>
public class PerfilController
{ 
    //**!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!ATENÇÃO ALTERAR O ALTERAR AREA E INSERIR AREA, POQUE ESTÁ N * N no MER

    private PerfilDao perfildao;
    private PerfilBean perfil;
    public void InserirNovoPerfil(UsuarioBean usuario, PerfilBean perfil,AreaBean area, CidadeBean cidade)
    {
       //Verifica se as Variaveis obrigatórias estão null
        ValidarPerfil(usuario);
        perfil.Id = usuario.Id;
        perfildao = new PerfilDao();
        var id_perfil = perfildao.InserirPerfilRetornandoId(perfil);
        //Recebe o id do perfil inserido
        perfil.Id_perfil = id_perfil;

        //verifica se retornou nenhum id
        if (id_perfil == null)
        {
            throw new PerfilNaoCadastradoException();
        }

        //?????? fazer mensagens de erros para inser area e cidade depois
        perfildao.InserirPerfilArea(perfil, area);

        perfildao.InserirPerfilCidade(perfil, cidade);
    }

    public void ValidarPerfil(UsuarioBean usu)
    {
        //Verifica se as variaveis estão nulas
        if (string.IsNullOrWhiteSpace(usu.Nome))
        {
            throw new UsuarioInvalidoException();
        }
    }

    public void AlterarPerfil(UsuarioBean usuario, PerfilBean perfil, AreaBean area, CidadeBean cidade, int idcidadeantiga)
    {
        //Verifica se as Variaveis obrigatórias estão null
        ValidarPerfil(usuario);
        perfildao = new PerfilDao();
        //Altera o perfil
        perfildao.AlterarPerfil(perfil);
        //Altera a cidade do perfil
        perfildao.AlterarPerfilCidade(perfil, cidade, idcidadeantiga);

        //Altera a area do perfil
        perfildao.AlterarPerfilArea(perfil, area);
      
    }

    public PerfilBean ConsultarPerfilPorIdUsuario(int idusuario) {
        try
        {
            perfildao = new PerfilDao();
            var perfil = perfildao.ConsultarPerfilPorIdUsuario(idusuario);
            //retorna normal   
            return perfil;
        }
        catch {
            return null;
        }
    }
}