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
    public void InserirNovoPerfil(PerfilBean perfil)
    {
       //Verifica se as Variaveis obrigatórias estão null
        ValidarPerfil(perfil);
        perfildao = new PerfilDao();
        var linhasafetadas = perfildao.InserirPerfil(perfil);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new PerfilNaoCadastradoException();
        }
    }
    public void ValidarPerfil(PerfilBean perfil)
    {
        //Verifica se as varias estão nulas
        if (string.IsNullOrWhiteSpace(perfil.Nome))
        {
            throw new UsuarioInvalidoException();
        }
    }
}