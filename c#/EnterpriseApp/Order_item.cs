using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjs
{
    public struct Order_item : CRUD
    {
        public int idProd { get; set; }
        public int quantity { get; set; }
        public int idOrder { get; set; }
        public int idOrder_item { get; set; }

        public void getQuantity()
        {
            throw new System.NotImplementedException();
        }

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
