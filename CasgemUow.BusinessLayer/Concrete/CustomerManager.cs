using CasgemUow.BusinessLayer.Abstract;
using CasgemUow.DataAccessLayer.Abstract;
using CasgemUow.DataAccessLayer.UnitOfWork.Abstract;
using CasgemUow.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUow.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        readonly ICustomerDal _customorDal;
        readonly IUowDal _uowDal;

        public CustomerManager(ICustomerDal customorDal, IUowDal uowDal)
        {
            _customorDal = customorDal;
            _uowDal = uowDal;
        }

        public void TDelete(Customer t)
        {
            _customorDal.Delete(t);
            _uowDal.Save();
        }

        public Customer TGetById(Customer t)
        {
            return _customorDal.GetById(t);
        }

        public List<Customer> TGetList(Customer t)
        {
            return _customorDal.GetList(t);
        }

        public void TInsert(Customer t)
        {
            _customorDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Customer> t)
        {
            _customorDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(Customer t)
        {
            _customorDal.Update(t);
            _uowDal.Save();
        }
    }
}
