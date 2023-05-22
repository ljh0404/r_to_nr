using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RtoNR.DataService;
using RtoNR.Models;

namespace RtoNR.BusinessService
{
    public class RegistroNRBusinessService
    {
        private RegistroNRDataService _registroNRDataService;
        private RegistroDataService _registroDataService;

        public RegistroNRBusinessService(RegistroNRDataService registroNRDataService){
            _registroNRDataService = registroNRDataService;
        }       
        public List<RegistroNR> GetRegistrosNRBS(){
            return _registroNRDataService.GetRegistrosNRDS();
        }

        public RegistroNR CreateRegistroNRBS(RegistroNR registroNR){
            return _registroNRDataService.CreateRegistroNRDS(registroNR);
        }

        public List<RegistroNR> CreateRegistrosNRBS(List<RegistroNR> registrosNR)
        {
            return _registroNRDataService.CreateRegistrosNRDS(registrosNR);
        }
    }
}