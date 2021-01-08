using System;
using System.IO;
using Newtonsoft.Json;

namespace AutoGoogleMeet.Settings {
    public class UserConfiguration {
        public UserConfiguration(string filename) {
            if (!File.Exists(filename)) throw new FileNotFoundException();
            MeetBehavior = Constants.DefaultMeetBehavior;
            Status = UserConfigParser.Parse(this, File.ReadAllText(filename));
        }
        
        // Fields
        [JsonIgnore]
        public int Status = 1; // 1 = never parsed

        public MeetBehavior MeetBehavior;

        public AppManifest AppManifest;

    }

    #region Region_MeetBehavior

    // Classes for deserialization
    public class MeetBehavior {
        public Join Join;
        public Leave Leave;
        public Load Load;
    }

    public class Join {
        public int AutoRefreshInterval;
        public bool DisableMicrophone;
        public bool DisableCamera;
        public bool JoinAutomatically;
    }

    public class Leave {
        public bool LeaveAutomatically;
        public LeaveAlert LeaveAlert;
    }

    public class Load {
        public int WaitForMS;
    }

    public class LeaveAlert {
        public bool SkipAlert;
        public int AlertTime;
    }

    #endregion

    #region Region_AppManifest

    public class AppManifest {
        public bool SetupCompleted;
    }

    #endregion
}