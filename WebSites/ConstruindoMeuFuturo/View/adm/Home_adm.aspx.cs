using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_adm_Home_adm : System.Web.UI.Page
{
    private UsuarioController usuario;
    private UsuarioController usucont;
    protected void Page_Load(object sender, EventArgs e)
    {
        usucont = new UsuarioController();
        ChartUsuarios.Titles.Add("Usuarios Cadastrado no ano de 2017");
        for (int cont = 1; cont <= 12; cont++)
        {
            int valor = usucont.UsuarioCadastradoMes(cont, 2017);
            string nomemes = ConverterMesNome(cont);
       

            ChartUsuarios.Series["Series1"].Points.AddXY(nomemes, valor);
            ChartUsuarios.Series["Series1"].Color = System.Drawing.Color.RoyalBlue;
          
              
        }
        usucont = new UsuarioController();
        Chart1.Titles.Add("Usuarios Cadastrado no ano de 2017");
        for (int cont = 1; cont <= 12; cont++)
        {
            int valor = usucont.UsuarioCadastradoMes(cont, 2017);
            string nomemes = ConverterMesNome(cont);
          
            Chart1.Series["Series1"].Points.AddXY(nomemes, valor);
            Chart1.Series["Series1"].Color = System.Drawing.Color.RoyalBlue;


        }
    }


    private string ConverterMesNome(int numeromes)
    {
        if (numeromes == 1)
        {
            return "Janeiro";
        }else
             if (numeromes == 2)
        {
            return "Fevereiro";
        }else
             if (numeromes == 3)
        {
            return "Março";
        }
        else if (numeromes == 4)
        {
            return "Abril";
        }
        else if (numeromes == 5)
        {
            return "Maio";
        }
        else if (numeromes == 6)
        {
            return "Junho";
        }
        else if (numeromes == 7)
        {
            return "Julho";
        }
        else if (numeromes == 8)
        {
            return "Agosto";
        }
        else if (numeromes == 9)
        {
            return "Setembro";
        }
        else if (numeromes == 10)
        {
            return "Outubro";
        }
        else if (numeromes == 11)
        {
            return "Novembro";
        }
        else if (numeromes == 12)
        {
            return "Dezembro";
        }else
        return "A";
    }

}

