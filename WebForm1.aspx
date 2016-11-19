<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Independencia.WebForm1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Import Namespace="Independencia.Model" %>
<%@ Import Namespace="System.Collections.Generic" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
 
        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public static AjaxControlToolkit.Slide[] GetSlides()
        {
            GerenciadorImagensImovel gerImagensImovel = new GerenciadorImagensImovel();
            int idImovel = 2;
            List<ImagensImovelObject> listImgObj = gerImagensImovel.getListaByImovel(idImovel);
            List<AjaxControlToolkit.Slide> lsSlide = new List<AjaxControlToolkit.Slide>();

            foreach (ImagensImovelObject it in listImgObj)
            {
                AjaxControlToolkit.Slide slide = new AjaxControlToolkit.Slide();
                slide.ImagePath = it.descImagem;
                slide.Name = "Nome";
                slide.ImagePath = it.urlImagemOriginal;
                lsSlide.Add(slide);
            }

            return lsSlide.ToArray();
          
     }
 
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
 
    <title>Ajax Control - Slide Show</title>
 
    <style>
 
    /* SlideShow styles */
 
 
 
.slideTitle
 
{
 
      font-weight:bold;
 
      font-size:small;
 
      font-style:italic;
 
}
 
 
 
.slideDescription
 
{
 
      font-size:small;
 
      font-weight:bold;
 
}
 
    </style>
 
</head>
 
<body>
 
    <form id="form1" runat="server">
 
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1"   runat="server">
 
        </asp:ToolkitScriptManager>
 
      <div style="text-align:center"> <b>
 
            SlideShow Demonstration</b><br /><br /></div>
 
                  <div style="text-align:center">
 
            <asp:Label runat="Server" ID="imageTitle" CssClass="slideTitle"/><br />
 
            <asp:Image ID="Image1" runat="server" Height="900" Width="1024"
                Style="border: 1px solid black;width:auto" 
                ImageUrl="/imagens/upload/predios/Candido Mendes.jpg"
                AlternateText="Blue Hills image" />
 
            <asp:Label runat="server" ID="imageDescription" CssClass="slideDescription"></asp:Label><br /><br />
 
            <asp:Button runat="Server" ID="prevButton" Text="Prev" Font-Size="Larger" />
 
            <asp:Button runat="Server" ID="playButton" Text="Play" Font-Size="Larger" />
 
            <asp:Button runat="Server" ID="nextButton" Text="Next" Font-Size="Larger" />
 
            <asp:SlideShowExtender ID="slideshowextend1" runat="server" 

                TargetControlID="Image1"
 
                SlideShowServiceMethod="GetSlides" 

                AutoPlay="true" 

                ImageTitleLabelID="imageTitle"
 
                ImageDescriptionLabelID="imageDescription"
 
                NextButtonID="nextButton" 

                PlayButtonText="Play" 

                StopButtonText="Stop"
 
                PreviousButtonID="prevButton" 

                PlayButtonID="playButton" 

                Loop="true" />
 
        </div>
 
 
 
    </form>
 
</body>
 
</html>