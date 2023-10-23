using System.ComponentModel.DataAnnotations;

namespace EfDemo.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
