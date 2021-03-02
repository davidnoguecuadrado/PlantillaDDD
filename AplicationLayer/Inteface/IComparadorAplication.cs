using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplicationLayer.Inteface
{
    public interface IComparadorAplication
    {
        Comprador GetComprador(int id);

        List<Comprador> GetComprador();

        Comprador DeleteComprador(Comprador Comprador);

        Comprador UpdateComprador(Comprador Comprador);

        Comprador AddComprador(Comprador Comprador);
    }
}
