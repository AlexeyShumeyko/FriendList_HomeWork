using FriendList_DAL;
using FriendList_DomainModel.Models;
using FriendList_DomainModel.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList_Service
{
    public class FriendService : IFriendService
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger<FriendService> _logger;

        public FriendService(IUnitOfWork unitOfWork, ILogger<FriendService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task Create (CreateFriendViewModel model)
        {
            try
            {
                _logger.LogInformation($"Запрос на создание - {model.Name} {model.Place} {model.Id}");

                var repo = _unitOfWork.GetRepository<Friend>();

                var friend = new Friend()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Place = model.Place
                };

                repo.Create(friend);

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[FriendService.Create]: {ex.Message}");
            }
        }

        public IQueryable<IEntity> GetFriends()
        {
            var friendList = _unitOfWork.GetRepository<Friend>().AsQueryable();

            return friendList;
        }
    }
}
