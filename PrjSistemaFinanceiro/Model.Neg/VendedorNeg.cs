using Model.Dao;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Neg
{
    public class VendedorNeg
    {
        private VendedorDao objVendedorDao;

        public VendedorNeg()
        {
            objVendedorDao = new VendedorDao();
        }

        public List<Vendedor> findAll()
        {
            return objVendedorDao.findAll();
        }
    }
}
