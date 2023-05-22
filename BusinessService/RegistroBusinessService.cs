using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RtoNR.DataService;
using RtoNR.Models;


namespace RtoNR.BusinessService
{
    public class RegistroBusinessService
    {
        private RegistroDataService _registroDataService;


        public RegistroBusinessService(RegistroDataService registroDataService){
            _registroDataService = registroDataService;

        }       
        public List<Registro> GetRegistrosBS(){
            return _registroDataService.GetRegistrosDS();
        }


        public Registro CreateRegistroBS(Registro registro){
            return _registroDataService.CreateRegistroDS(registro);
        }


        //--------
        
        

    }
}