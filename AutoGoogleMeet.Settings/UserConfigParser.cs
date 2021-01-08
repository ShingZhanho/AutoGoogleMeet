using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AutoGoogleMeet.Settings {
    internal static class UserConfigParser {
        internal static int Parse(UserConfiguration ucObject, string jsonData) {
            JObject jo;
            // Creates jObject
            try {
                jo = JObject.Parse(jsonData);
            }
            catch  {
                return 2; // 2 is returned if json could not be parsed
            }

            try {
                ucObject.MeetBehavior = JsonConvert.DeserializeObject<MeetBehavior>(jo["MeetBehavior"].ToString());
                ucObject.AppManifest = JsonConvert.DeserializeObject<AppManifest>(jo["AppManifest"].ToString());
            }
            catch {
                return 3; // 3 is returned if null reference error
            }
            
            return 0; // 0 is returned if all operations are successful
        }
    }
}