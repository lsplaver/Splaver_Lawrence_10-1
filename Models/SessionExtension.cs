using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TicTacToe.Models
{
    public static class SessionExtension
    {
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            if (string.IsNullOrEmpty(value))
            {
                return default(T);
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
        }
    }
}
