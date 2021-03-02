using Context;
using DataLayer.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Service
{
    public class DataCasa : IDataCasa
    {
        private IContextDb _context;

        public DataCasa(IContextDb context)
        {
            _context = context;
        }

        public Casa GetCasa(int id)
        {
            return _context.Casa.Where(x => x.CompradorID == id).Single();
        }

        public List<Casa> GetCasa()
        {   
            return _context.Casa.ToList();
        }


        public Casa DeleteCasa(Casa casa)
        {
            _context.Casa.Remove(casa);
            _context.SaveChanges();
            return casa;
        }

        public Casa UpdateCasa(Casa casa)
         {
            _context.Casa.Update(casa);
            _context.SaveChanges();
            return casa;
        }

        public Casa AddCasa(Casa casa)
        {
            _context.Casa.Add(casa);
            _context.SaveChanges();
            return casa;
        }
    }
}
