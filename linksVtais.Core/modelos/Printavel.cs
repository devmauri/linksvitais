using System;

namespace linksVtais.Core.modelos;

public class Printavel
{
    public TIPO Tipo { get; set; }
    private SUBTIPO subtipo;
    public SUBTIPO Subtipo
    {
        get { return subtipo;  }
        set {
            if (Tipo == null){
                return;
            }
            switch (value)
            {
                case SUBTIPO.PREDIO:
                case SUBTIPO.ARMARIO:
                    if (Tipo == TIPO.ESTAÇÃO)
                        subtipo = value;
                    break;
                case SUBTIPO.SDH:
                case SUBTIPO.PTN:
                case SUBTIPO.DWDM:
                case SUBTIPO.POTN:
                case SUBTIPO.FTTH:
                case SUBTIPO.CGA:
                case SUBTIPO.SINGLE_EDGE:
                case SUBTIPO.ROTD:
                case SUBTIPO.ROTN:
                case SUBTIPO.EDD:
                    if (Tipo == TIPO.NE)
                        subtipo = value;
                    break;
                case SUBTIPO.FISICO:
                case SUBTIPO.LOGICO:
                    if (Tipo == TIPO.LINK)
                        subtipo = value;
                    break;
                default:
                    subtipo = value;
                    break;
            }
        }
    }
    public List<Posicao> Posicoes { get; set; } = null!;

}

public class Posicao{
    public float Latitude;
    public float Longitude;
}


public enum TIPO
{
    ESTAÇÃO,
    NE,
    LINK
}

public enum SUBTIPO 
{
    PREDIO,
    ARMARIO,
    SDH,
    PTN,
    DWDM,
    POTN,
    FTTH,
    CGA,
    SINGLE_EDGE,
    ROTD,
    ROTN,
    EDD,
    FISICO,
    LOGICO
}
