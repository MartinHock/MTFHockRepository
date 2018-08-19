using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kap2Erweitert.Models;
using Kap2Erweitert.Infrastructure;

    Stephan, Uwe.Grundlagen ASP.NET MVC 5: An Beispielen mit C#, HTML5, und CSS erklärt (German Edition) (Kindle-Positionen634-640). Kindle-Version. 

namespace Kap2Erweitert.Controllers
{

    [SessionState( System .Web .SessionState .SessionStateBehavior .Default)]
    // GET: Home 
    public ActionResult Index() { Info info = new Info { ControllerName = "Home", ActionName = "Index", Aufrufe = "nicht gefunden" }; // wenn erster Aufruf, dann Initialisieren if(Session != null && Session["Aufrufe"] == null) { Session["Aufrufe"] = 0; } // Aufrufanzahl in Session erhöhen if(Session != null && Session["Aufrufe"] != null) { Session[ "Aufrufe"] = (int)Session[ "Aufrufe"] + 1;

     {



    }
}