using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de CidadeController
/// </summary>
public class CidadeController
{
    private CidadeDao cidadedao;
    private CidadeBean cidade;
    public List<CidadeBean> ListarCidadesPorEstado(int id_estado)
    {
        cidadedao = new CidadeDao();
        var cidades = new List<CidadeBean>();
        cidades = cidadedao.ListarCidadePorEstado(id_estado);

        return cidades;
    }

    public CidadeBean ConsultarCidadePorId(int idcidade) {
        cidade = cidadedao.ConsultarCidadePorId(idcidade);
        return cidade;
    }

    public CidadeBean ConsultaCidadePerfil(int idperfil)
    {
        cidadedao = new CidadeDao();
        //consulta o id_estado da cidade que está cadastrado no perfil
        cidade = cidadedao.ConsultarIdCidadePerfil(idperfil);

        //consulta o nome da cidade
        try
        {
            cidade = cidadedao.ConsultarCidadePorId(cidade.Id_cidade);
            return cidade;
        }
        catch
        {
            cidade.Id_cidade = 0;
            cidade.Id_estado = 0;
            return cidade;
        }
        
    }
    /*Teste com list por ser N * N no MER
    public List<CidadeBean> ListarIdCidadePerfil(int id_estado) {
        cidadedao = new CidadeDao();
        var cidades = new List<CidadeBean>();
        cidades = cidadedao.ListarIdCidadePerfil(id_estado);
        return cidades;
    }*/
}