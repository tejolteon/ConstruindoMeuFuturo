﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de AreaController
/// </summary>
public class RespostaController
{
    private RespostaBean resposta;
    private RespostaDao respostadao;

    public void InserirNovaResposta(RespostaBean resposta)
    {
        //Verifica se as Variaveis obrigatórias estão null
        ValidarResposta(resposta);
        respostadao = new RespostaDao();
        respostadao.InserirResposta(resposta);
    }
    


    public void ValidarResposta(RespostaBean resposta)
    {
        //Verifica se as variaveis estão nulas
        if (string.IsNullOrWhiteSpace(resposta.Texto_resposta))
        {
            throw new RespostaInvalidaException();
        }
    }
    public List<RespostaBean> ListarResposta()
    {
        respostadao = new RespostaDao();
        var questoes = new List<RespostaBean>();
        questoes = respostadao.ListarResposta();

        return questoes;
    }

    public List<RespostaBean> ListarRespostaTexto(String texto)
    {
        respostadao = new RespostaDao();
        var questoes = new List<RespostaBean>();
        questoes = respostadao.ListarRespostaTexto(texto);

        return questoes;
    }

    public List<RespostaBean> ListarRespostaQuestao(int idquestao)
    {
        respostadao = new RespostaDao();
        var respostas = new List<RespostaBean>();
        respostas = respostadao.ListarRespostaQuestao(idquestao);
        return respostas;

    }

    public RespostaBean ConsultarRespostaPorId(int idresposta)
    {
        resposta = respostadao.ConsultarRespostaPorId(idresposta);
        return resposta;
    }
    

}