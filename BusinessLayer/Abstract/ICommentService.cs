using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CoomentAdd(Comment comment);
        // void CoomentDelete(Comment comment);
        // void CoomentUpdate(Category category);
        List<Comment> GetList(int id);
        // Comment GetById(int id);
    }
}
