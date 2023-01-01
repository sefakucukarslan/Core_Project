using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
