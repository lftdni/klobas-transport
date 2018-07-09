using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KlobasTransport.AppCode
{
    public class Banner : DbObjekt
    {

        #region Constructors

        public Banner()
        {
            
        }

        #endregion

        #region Properties

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

        public string Link
        {
            get;
            set;
        }

        public string PutanjaSlike
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