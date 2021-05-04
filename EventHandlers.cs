using Qurre.API;
using Qurre.API.Events;

namespace Anti079
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public static void RoleChange(RoleChangeEvent ev)
        {
            
            if (Config.IsEnabled)
            {
                if (ev.NewRole == RoleType.Scp079)
                {
                    ev.NewRole = (RoleType)Config.ANTI079ChangeTo;
                    ev.Player.ShowHint(Config.ANTI079ChangeHint, Config.ANTI079ChangeHintTime);
                }
            }
            else if (!(Config.IsEnabled))
            {
                return;
            }
        }
    }
}
