using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPC_WebAPI.Models;

namespace OPC_WebAPI.Interfaces
{
    interface IOPCRepository
    {
        int Add(OPCBindingModel opc);
        int AddTail(OPCBindingModel opc);
        
        // Add IEnumerable to return a list of OPC records for a ProRpt
    }
}
