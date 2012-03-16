using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjs
{
    public struct BuildSheet_item : CRUD
    {
        public int idPart { get; set; }
        public int quantity { get; set; }
        public int idProduct { get; set; }
        public int idBuildSheet_item { get; set; }

        #region CRUD Members

        void CRUD.insert()
        {
            throw new NotImplementedException();
        }

        void CRUD.update()
        {
            throw new NotImplementedException();
        }

        void CRUD.delete()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
