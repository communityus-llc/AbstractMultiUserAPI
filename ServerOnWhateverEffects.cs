using *;
namespace *
{
    // Configuration
    public class ServerOnWhateverEffects : ServerEffectType
    {
        public new string effectType = "OnWhatever";
        public new string[] effectTypeOptions = new string[] { "OnWhateverEffect" };

        // Initialization
        public ServerOnWhateverEffects() {}

        public override void LoadOptions(EffectsData editingDisplay, bool newItem) {}
            
        // Editor related
        public override Rect DrawEditor(Rect pos, bool newItem, EffectsData editingDisplay, out bool showTimeFields) {}
       
        public override string EffectType {
            get { return effectType; }
        }

        public override string[] EffectTypeOptions {
            get { return effectTypeOptions; }
        }

        // GetOptionPosition - optional
    }
}