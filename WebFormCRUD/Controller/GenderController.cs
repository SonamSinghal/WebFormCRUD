using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormCRUD.Model;
using WebFormCRUD.Repository;

namespace WebFormCRUD.Controller
{
    public class GenderController
    {
        private readonly ApplicationRepository _repository = new ApplicationRepository(new Data.ApplicationDbContext());

        public List<Gender> GetAllGenders()
        {
            return _repository.GetAllGenders();
        }

        public Guid GetGenderId(string gender)
        {
            return _repository.ReturnGenderId(gender);
        }
    }
}