using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTO;
using API.Entities;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<IEnumerable<LikeDto>> GetUserLikes(string pricate, int userId);

    }
}