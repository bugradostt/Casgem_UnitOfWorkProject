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
    public class CustomerProcessManager : ICustomerProcessService
    {
        readonly ICustemorProcessDal _custemorProcessDal;
        readonly IUowDal _uowDal;

        public CustomerProcessManager(ICustemorProcessDal custemorProcessDal, IUowDal uowDal)
        {
            _custemorProcessDal = custemorProcessDal;
            _uowDal = uowDal;
        }

        public void TDelete(CustomerProcess t)
        {
           _custemorProcessDal.Delete(t);
            _uowDal.Save();
        }

        public CustomerProcess TGetById(CustomerProcess t)
        {
           return _custemorProcessDal.GetById(t);
        }

        public List<CustomerProcess> TGetList(CustomerProcess t)
        {
           return _custemorProcessDal.GetList(t);
        }

        public void TInsert(CustomerProcess t)
        {
           _custemorProcessDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<CustomerProcess> t)
        {
            _custemorProcessDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(CustomerProcess t)
        {
            _custemorProcessDal.Update(t);
            _uowDal.Save();
        }
    }
}
