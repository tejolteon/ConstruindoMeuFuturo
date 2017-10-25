using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de PerfilController
/// </summary>
public class PerfilController
{
    private PerfilDao perfildao;
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
        //???? id da cidade de São Paulo(5270) Está fixo
        cidade.Id = 5270;

        //?????? fazer mensagens de erros para inser area e cidade depois
        perfildao.InserirPerfilArea(perfil, area);

        perfildao.InserirPerfilCidade(perfil, cidade);
    }
    public void ValidarPerfil(UsuarioBean usu)
    {
        //Verifica se as varias estão nulas
        if (string.IsNullOrWhiteSpace(usu.Nome))
        {
            throw new UsuarioInvalidoException();
        }
    }
}