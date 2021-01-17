using Nancy;
using System;
using System.Text.Json;

namespace NancyFx
{
	public class UserModule : Nancy.NancyModule
	{
        public UserModule()
        {
            Get[" / "] = _ => " Hello World from nancy";
        }

        public String ReturnUserData(int userId)
        {
            User user = new User();

            user.UserId = userId;
            string jsonString = JsonSerializer.Serialize(user);
            // Fetch user from the database then return its attributes
            // in the JSON format
            // ...
            return jsonString;
        }

    }
}
