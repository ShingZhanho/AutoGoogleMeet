using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
[assembly:AssemblyVersion("0.0.1")]

namespace AutoGoogleMeet.Settings {
    public static class Constants {
        /// <summary>
        /// This is the default MeetBehavior settings
        /// </summary>
        public static readonly MeetBehavior DefaultMeetBehavior = new MeetBehavior{
            Join = new Join {
                AutoRefreshInterval = 5000,
                DisableCamera = true,
                DisableMicrophone = true,
                JoinAutomatically = true
            },
            Leave = new Leave {
                LeaveAutomatically = true,
                LeaveAlert = new LeaveAlert {
                    SkipAlert = false,
                    AlertTime = 5
                }
            },
            Load = new Load {
                WaitForMS = 3000
            }
        };

        /// <summary>
        /// The path of the exe of this app, backslash is not included in the end
        /// </summary>
        public static readonly string ExePath = Application.StartupPath;

        public const string Version = "v0.0.1_beta";
    }
}
