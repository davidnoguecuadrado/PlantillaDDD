using AplicationLayer.Inteface;
using DataLayer.Interface;
using Domain;
using System.Collections.Generic;

namespace AplicationLayer.Service
{
    public class CasaAplication : ICasaAplication
    {
         public IDataCasa _casaData;

      
        public CasaAplication(IDataCasa casaData) {
            _casaData = casaData;
        }

        public Casa AddCasa(Casa casa)
        {
           return _casaData.AddCasa(casa);
        }

        public Casa DeleteCasa(Casa casa)
        {
            return _casaData.DeleteCasa(casa);
        }

        public Casa GetCasa(int id)
        {
            return _casaData.GetCasa(id);
        }

        public List<Casa> GetCasa()
        {
            return _casaData.GetCasa();
        }

        public Casa UpdateCasa(Casa casa)
        {
            return _casaData.UpdateCasa(casa);
        }
    }
}
