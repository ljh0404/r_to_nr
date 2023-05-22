using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RtoNR.Models;

namespace RtoNR.DataService
{
    public class RegistroNRDataService
    {
        private Context _context; 

        public RegistroNRDataService(Context context){
            _context = context;
        }      

        public List<RegistroNR> GetRegistrosNRDS(){
            return _context.RegistrosNR.ToList();
        }
        

        public RegistroNR CreateRegistroNRDS(RegistroNR registroNR){
            _context.RegistrosNR.Add(registroNR);
            _context.SaveChanges();
            return registroNR;
        }

        public List<RegistroNR> CreateRegistrosNRDS(List<RegistroNR> registrosNR){
            _context.RegistrosNR.AddRange(registrosNR);
            _context.SaveChanges();
            return registrosNR;
        }
    }
}