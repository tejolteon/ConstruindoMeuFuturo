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
        var usuario = usuariodao.ConsultarUsuario(email, senha);

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

    public UsuarioBean ConfirmarSenha(UsuarioBean usuario)
    {
        //String para armazenar o confirmar senha, pois ela será apagada depois da consulta
        String confirmarsenha;
        confirmarsenha = usuario.Confirmarsenha;
        //Consulta o usuario no banco para ver se a senha bate
        usuariodao = new UsuarioDao();

        usuario = usuariodao.ConfirmarSenha(usuario.Id, usuario.Senha);
        //Verifica se está null
        ValidarUsuario(usuario);
        return usuario;
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
        //verifica se as senhas convergem
        ValidarSenhaUsuario(usuario);
        //Verifica se as variaveis estão nulas
        ValidarUsuario(usuario);
        //Valida o email, verificando se já tem um cadastrado
        ValidarEmailUsuario(usuario);
        //insere valores no BD
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
        //Verifica se as variaveis estão nulas
        if (usuario == null || string.IsNullOrWhiteSpace(usuario.Email) || string.IsNullOrWhiteSpace(usuario.Senha))
        {
            throw new UsuarioInvalidoException();
        }
    }

    public void ValidarEmailUsuario(UsuarioBean usuario)
    {
        usuariodao = new UsuarioDao();
        usuario = usuariodao.ConsultarUsuarioEmail(usuario.Email);
        if (usuario != null)
        {
            throw new EmailJaCadastradoException();
        }
    }

    public void AlterarSenha(UsuarioBean usuario)
    {
        //verifica se as senhas convergem
        ValidarSenhaUsuario(usuario);

        usuariodao = new UsuarioDao();
        var linhasafetadas = usuariodao.AlterarSenha(usuario);

        if (linhasafetadas == 0)
        {
            throw new UsuarioNaoCadastradoException();
        }


    }

    public int UsuarioCadastradoMes(int mes, int ano)
    {
        usuariodao = new UsuarioDao();
        var usuarios = usuariodao.UsuariosCadastradosMes(mes, ano);
        return usuarios;
    }
}