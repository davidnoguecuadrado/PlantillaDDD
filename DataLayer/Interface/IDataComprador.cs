using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interface
{
    public interface IDataComprador
    {
        Comprador GetComprador(int id);

        List<Comprador> GetComprador();

        Comprador DeleteComprador(Comprador Comprador);

        Comprador UpdateComprador(Comprador Comprador);

        Comprador AddComprador(Comprador Comprador);
    }
}
