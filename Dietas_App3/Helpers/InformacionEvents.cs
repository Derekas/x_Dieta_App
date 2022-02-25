using System;
using System.Collections.Generic;
using System.Text;

namespace Dietas_App3.Helpers
{
    public class InformacionEvents<T>
    {
        public Action<object, T> HandlerAdd { get; set; }
        public Action<object, T> HandlerDel { get; set; }
        public Action<object, T> HandlerMod { get; set; }
        
        public void TriggerHandlerAdd(T tipus)
        {
            if (HandlerAdd != null) HandlerAdd(this, tipus);
        }

        public void TriggerHandlerDel(T tipus)
        {
            if (HandlerDel != null) HandlerDel(this, tipus);
        }
        public void TriggerHandlerMod(T tipus)
        {
            if (HandlerMod != null) HandlerMod(this, tipus);
        }

    }
}
