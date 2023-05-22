using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RtoNR.Models;



namespace RtoNR.DataService
{
    public class RegistroDataService
    {
        private Context _context; 

        public RegistroDataService(Context context){
            _context = context;
        }      

        public List<Registro> GetRegistrosDS(){
            return _context.Registros.ToList();
        }


        public Registro CreateRegistroDS(Registro registro){
            _context.Registros.Add(registro);
            _context.SaveChanges();
            return registro;
        }

        
    }
}