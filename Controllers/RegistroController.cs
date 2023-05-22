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
    public class RegistroController : ControllerBase
    {
        private RegistroBusinessService _registroBusinessService;

        public RegistroController(RegistroBusinessService registroBusinessService){
            _registroBusinessService = registroBusinessService;
    
        }

        [HttpGet("[action]")]
        public List<Registro> GetRegistrosBS(){
            Console.WriteLine("hola");
            return _registroBusinessService.GetRegistrosBS();
        }

        [HttpPost("[action]")]
        public Registro CreateRegistroBS(Registro registro){
            return _registroBusinessService.CreateRegistroBS(registro);
        }
        [HttpGet("[action]")]
        public List<Registro> GetRegistrosReferenciados()
        {
            int idPadre = 1; // El ID del padre al que deseas hacer referencia

            return _registroBusinessService.GetRegistrosBS().Where(r => r.PadreId == idPadre).ToList();
        }
        
        
    }
}