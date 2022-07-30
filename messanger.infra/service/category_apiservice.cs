using messanger.core.Data;
using messanger.core.Repoisitory;
using messanger.core.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.infra.service
{
    public class category_apiservice : Icategory_apiservice
    {
        private readonly Icategory_apiRepoisitory icategory_ApiRepoisitory;
        public category_apiservice(Icategory_apiRepoisitory icategory_ApiRepoisitory)
        {
            this.icategory_ApiRepoisitory = icategory_ApiRepoisitory;
        }
        public string CreateCategory(category_api ins)
        {
            return icategory_ApiRepoisitory.CreateCategory(ins);
        }

        public string DeleteCategory(int id)
        {
            return icategory_ApiRepoisitory.DeleteCategory(id);
        }

        public List<category_api> GetAllCategory()
        {
            return icategory_ApiRepoisitory.GetAllCategory();
        }

        public category_api GetCategoryById(int id)
        {
            return icategory_ApiRepoisitory.GetCategoryById(id);
        }

        public string UpDateCategory(category_api upd)
        {
            return icategory_ApiRepoisitory.UpDateCategory(upd);
        }
    }
}
