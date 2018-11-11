using System;

namespace TemplateWorldSpeakers.Domain
{
    public class SpanishSpeakingHuman : LanguageSpeakingHuman
    {
        public SpanishSpeakingHuman(string name) : base(name)
        { }

        protected override string PrepareNativeGreet()
        {
            return "Hola, mi nombre es";
        }
    }
}