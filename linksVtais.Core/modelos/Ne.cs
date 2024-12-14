using System;
using System.Runtime.Intrinsics.X86;

namespace linksVtais.Core.modelos;

public class Ne : Printavel
{
    public String  Nome { get; set; } = string.Empty;

    public List<int> Shelf { get; set; } = new List<int>([0]);
    public List<int>? Slot { get; set; }
    public List<(int,Sinal)>? Porta { get; set; }

}

public class Sinal
{
    public TIPO Tipo { get; set; }
    public CAPACIDADE Capacidade { get; set; }
    public ESTRUTURA Estrutura { get; set; }
    public enum TIPO{
        SDH,SONET,
        ETHERNET,
        OPU,ODU,OTU
    
    }

    public enum CAPACIDADE {
        VC12,STM0,STM1,STM4,STM16,STM64,
        FE10,FE100,GE,GE10,GE100,
        L0,L1,L2,L4,L4PLUS,L5,FLEX,

    }

    public enum ESTRUTURA {
        TS30,TS32,K64,VC12,VC3,VC4,VC3_3,VC12_63,VC3_1_VC12_42,VC3_2_VC12_21,
        NULL,VLAN,Q_IN_Q,L3,
        FULL,FRACIONADO
    }
}
