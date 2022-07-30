using messanger.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace messanger.core.Repoisitory
{
    public interface Icategory_apiRepoisitory
    {
        public List<category_api> GetAllCategory();
        public category_api GetCategoryById(int id);
        public string CreateCategory(category_api ins);
        public string UpDateCategory(category_api upd);
        public string DeleteCategory(int id);

     
    }
}
