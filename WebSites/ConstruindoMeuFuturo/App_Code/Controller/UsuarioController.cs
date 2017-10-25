using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de UsuarioController
/// </summary>
public class UsuarioController
{

    private UsuarioDao usuariodao;
    public UsuarioBean ConsultarUsuario(string email, string senha)
    {
        usuariodao = new UsuarioDao();
        var usuario = usuariodao.ConsultarUsuario(email,senha);

        if (usuario == null)
        {
            throw new UsuarioNaoCadastradoException();
        }
        else
        {
            //retorna normal   
            return usuario;
        }
    }

    public UsuarioBean ConsultarUsuarioPorID(int id)
    {
        usuariodao = new UsuarioDao();
        var usuario = usuariodao.ConsultarUsuarioPorID(id);

        if (usuario == null)
        {
            throw new UsuarioNaoCadastradoException();
        }
        else
        {
            //retorna normal   
            return usuario;
        }
    }
    public void InserirNovoUsuario(UsuarioBean usuario)
    {
        ValidarSenhaUsuario(usuario);
        ValidarUsuario(usuario);
        usuariodao = new UsuarioDao();
        var linhasafetadas = usuariodao.InserirUsuario(usuario);
        //verifica se retornou nenhuma linha afetada
        if (linhasafetadas == 0)
        {
            throw new UsuarioNaoCadastradoException();
        }
    }
    public void ValidarSenhaUsuario(UsuarioBean usuario)
    {
        if (usuario.Senha != usuario.Confirmarsenha)
        {
            throw new SenhaUsuarioInvalidaException();
        }
    }
    public void ValidarUsuario(UsuarioBean usuario)
    {
        //Verifica se as varias estão nulas
        if (string.IsNullOrWhiteSpace(usuario.Email) || string.IsNullOrWhiteSpace(usuario.Senha))
        {
            throw new UsuarioInvalidoException();
        }
    }
}