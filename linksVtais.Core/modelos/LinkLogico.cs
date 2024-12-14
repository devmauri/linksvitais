using System;

namespace linksVtais.Core.modelos;

public class LinkLogico
{
    public List<LinkFisico> LinksFisicos { get; set; }
    public List<LinkLogico> LinksLogicos { get; set; }
    public Sinal Sinal { get; set; }
    public int Posicao { get; set; }
}
