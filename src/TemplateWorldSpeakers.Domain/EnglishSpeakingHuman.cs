namespace TemplateWorldSpeakers.Domain
{
    public class EnglishSpeakingHuman : LanguageSpeakingHuman
    {
        public EnglishSpeakingHuman(string name) : base(name)
        { }

        protected override string PrepareNativeGreet()
        {
            return "Hello, my name is";
        }
    }
}