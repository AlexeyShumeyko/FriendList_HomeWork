using FriendList_DomainModel.ViewModel;
using FriendList_Service;
using Microsoft.AspNetCore.Mvc;

namespace FriendList.Controllers
{
    public class FriendController : Controller
    {
        private readonly IFriendService _friendService;

        public FriendController(IFriendService friendService)
        {
            _friendService = friendService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var friendsTable = _friendService.GetFriends();

            return View(friendsTable);
        }

        [HttpGet]
        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateFriendViewModel model)
        {
            await _friendService.Create(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
