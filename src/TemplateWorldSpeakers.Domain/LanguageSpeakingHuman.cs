namespace TemplateWorldSpeakers.Domain
{
    public abstract class LanguageSpeakingHuman
    {
        private readonly string name;

        public LanguageSpeakingHuman(string name)
        {
            this.name = name;
        }

        public string Greet()
        {
            var nativeGreet = this.PrepareNativeGreet();

            return $"{nativeGreet} {this.name}!";
        }

        protected abstract string PrepareNativeGreet();
    }
}