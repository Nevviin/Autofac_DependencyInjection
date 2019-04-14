using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacABasicConsole
{
    class PrintingService
    {
        IPrinter _iPrinter;

        public PrintingService( IPrinter iPrinter)
        {
            _iPrinter = iPrinter;
            
        }


        public void PrintDoc(string message)
        {

            _iPrinter.Print(message);
        }



    }
}
