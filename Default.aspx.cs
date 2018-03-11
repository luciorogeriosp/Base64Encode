using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// https://gallery.technet.microsoft.com/Exibir-imagens-diretamente-534c9ced
/// </summary>
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strBase64Encode = CreateBase64String(Server.MapPath("./Violão.jpg"));

        ImageBase64.ImageUrl = "data:image/jpeg;base64," + strBase64Encode;
    }

    private string CreateBase64String(String strCaminho)
    {
        // Leitura dos Bytes do Arquivo Imagem
        byte[] imgByteArray = System.IO.File.ReadAllBytes(strCaminho);

        // Conversão para Base64
        return Convert.ToBase64String(imgByteArray);
    }
}
