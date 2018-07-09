using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KlobasTransport.AppCode
{
    public class Novost : DbObjekt 
    {

        #region Constructors

        public Novost()
        {
            
        }

        #endregion

        #region Properties

        public DateTime Datum
        {
            get;
            set;
        }

        public string Naslov
        {
            get;
            set;
        }

        public string KratkiOpis
        {
            get;
            set;
        }

        public string DugiOpis
        {
            get;
            set;
        }

        public int IdAdmin
        {
            get;
            set;
        }

        #endregion


    }
}