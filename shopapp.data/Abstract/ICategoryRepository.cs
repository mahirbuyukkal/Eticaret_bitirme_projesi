using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    // IRepository'e Categori türünde nesneler göndereceğiz
    public interface ICategoryRepository: IRepository<Category>
    {
        // gönderilen nesneler listelenecek
        List<Category> GetPopularCategories();
    }
}