using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RtoNR.Models;
using RtoNR.BusinessService;

namespace RtoNR.Controllers
{
    [Route("[controller]")]
    public class RegistroNRController : ControllerBase
    {
        private RegistroNRBusinessService _registroNRBusinessService;
        private RegistroBusinessService _registroBusinessService;

        public RegistroNRController(RegistroNRBusinessService registroNRBusinessService,
                                    RegistroBusinessService registroBusinessService){
            _registroNRBusinessService = registroNRBusinessService;
            _registroBusinessService = registroBusinessService;
        }

        [HttpGet("[action]")]
        public List<RegistroNR> GetRegistrosNRC(){
            return _registroNRBusinessService.GetRegistrosNRBS();
        }

        [HttpPost("[action]")]
        public RegistroNR CreateRegistroNRC(RegistroNR registroNR){
            return _registroNRBusinessService.CreateRegistroNRBS(registroNR);
        }

        [HttpPost("[action]")]
        public List<RegistroNR> CreateRegistrosNRC()
        {
            List<RegistroNR> registrosNR = new List<RegistroNR>();

            List<Registro> registros = _registroBusinessService.GetRegistrosBS();
            foreach (var registro in registros){
                RegistroNR toAdd = new RegistroNR();
                List<Registro> resultsTemp = new List<Registro>();
                List<String> hijos = new List<String>();
                resultsTemp = _registroBusinessService.GetRegistrosBS().Where(r => r.PadreId == registro.Id).ToList();
                foreach (var reg in resultsTemp) {
                    hijos.Add(reg.Id.ToString());
                }
                toAdd.Id = registro.Id;
                toAdd.Nombre = registro.Nombre;
                toAdd.Hijos = string.Join(",", hijos);
                
                registrosNR.Add(toAdd);
            }
            return _registroNRBusinessService.CreateRegistrosNRBS(registrosNR);
        }
    }
}