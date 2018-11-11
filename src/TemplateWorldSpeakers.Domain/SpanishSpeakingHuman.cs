using System;

namespace TemplateWorldSpeakers.Domain
{
    public class SpanishSpeakingHuman
    {
        private string name;

        public SpanishSpeakingHuman(string name)
        {
            this.name = name;
        }

        public string Greet()
        {
            return $"Hola, mi nombre es {this.name}!";
        }
    }
}