using AplicationLayer.Inteface;
using DataLayer.Interface;
using Domain;
using System.Collections.Generic;

namespace AplicationLayer.Service
{
    public class ComparadorAplication : IComparadorAplication
    {
        private readonly IDataComprador _compradorData;


        public ComparadorAplication(IDataComprador compradorData)
        {
            _compradorData = compradorData;
        }
        
        public Comprador AddComprador(Comprador Comprador)
        {
            return _compradorData.AddComprador(Comprador);
        }

        public Comprador DeleteComprador(Comprador Comprador)
        {
            return _compradorData.DeleteComprador(Comprador);
        }

        public Comprador GetComprador(int id)
        {
            return _compradorData.GetComprador(id);
        }

        public List<Comprador> GetComprador()
        {
            return _compradorData.GetComprador();
        }

        public Comprador UpdateComprador(Comprador Comprador)
        {
            return _compradorData.UpdateComprador(Comprador);
        }
    }
}
