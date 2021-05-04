using Qurre.Events;

namespace Anti079
{
    public class Plugin : Qurre.Plugin
    {
        public EventHandlers EventHandlers;
        public override string Developer { get; } = "nekto";
        public override string Name { get; } = "Anti079";
        public override System.Version Version { get; } = new System.Version(0, 1, 0);
        public override System.Version NeededQurreVersion { get; } = new System.Version(1, 3, 9);

        public override void Reload() => base.Reload();
        public override void Enable() => RegEvents();
        public override void Disable() => UnregEvents();

        public void RegEvents()
        {
            EventHandlers = new EventHandlers(this);
            Player.RoleChange += EventHandlers.RoleChange;
        }

        public void UnregEvents()
        {
            Player.RoleChange -= EventHandlers.RoleChange;
            EventHandlers = null;
        }
    }
}
