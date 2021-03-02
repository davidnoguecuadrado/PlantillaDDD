using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicationLayer.Inteface
{
    public interface ICasaAplication
    {
        Casa GetCasa(int id);

        List<Casa> GetCasa();

        Casa DeleteCasa(Casa casa);

        Casa UpdateCasa(Casa casa);

        Casa AddCasa(Casa casa);
    }
}
