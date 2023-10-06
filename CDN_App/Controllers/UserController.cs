using CDN_App.Context;
using CDN_App.DAL;
using CDN_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace CDN_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserInfoRepository UserInfoRepository;
        private CDNContext _CDNContext;
        public UserController(IUserInfoRepository UserInfoRepository, CDNContext _CDNContext)
        {
            this.UserInfoRepository = UserInfoRepository;
            this._CDNContext = _CDNContext;
        }

        [HttpGet]
        public IActionResult getUser()
        {
            var user = UserInfoRepository.getUser().OrderBy(x => x.ID);
            return Ok(user);
        }
        [HttpGet("{userid}")]
        public IActionResult getUserById(int userid)
        {
            var user = UserInfoRepository.getUserById(userid);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult addUser(UserInfos user)
        {
            UserInfoRepository.insertUser(user);
            UserInfoRepository.save();
            return Ok(user);
        }
        [HttpPut]
        public IActionResult updateUser(UserInfos user)
        {
            UserInfoRepository.updateUser(user);
            UserInfoRepository.save();
            return Ok(user);
        }
        [HttpDelete("{userid}")]
        public IActionResult deleteEmployee(int userid)
        {
            UserInfoRepository.deleteUser(userid);
            UserInfoRepository.save();
            return Ok();
        }
    }
}
