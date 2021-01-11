using System.Net;

namespace AutoGoogleMeet.WebDrv {
    public static class NetworkUtil {
        public static bool NetworkIsConnected() {
            try {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://github.com")) {
                    return true;
                }
            } catch {
                return false;
            }
        }
    }
}