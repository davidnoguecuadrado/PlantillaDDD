using Context;
using DataLayer.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Service
{
    public class DataComprador : IDataComprador
    {
        private IContextDb _context;
        
        public DataComprador(IContextDb context)
        {
            _context = context;
        }
        
        public Comprador GetComprador(int id)
        {
            return _context.Comprador.Where(x => x.ID == id).Single();
        }

        public List<Comprador> GetComprador()
        {
            return _context.Comprador.ToList();
        }


        public Comprador DeleteComprador(Comprador Comprador)
        {
            _context.Comprador.Remove(Comprador);
            _context.SaveChanges();
            return Comprador;
        }

        public Comprador UpdateComprador(Comprador Comprador)
        {
            _context.Comprador.Update(Comprador);
            _context.SaveChanges();
            return Comprador;
        }

        public Comprador AddComprador(Comprador Comprador)
        {
            _context.Comprador.Add(Comprador);
            _context.SaveChanges();
            return Comprador;
        }
    }
}
