using System;
using Xunit;
using TemplateWorldSpeakers.Domain;

namespace TemplateWorldSpeakers.Domain.Tests
{
    public class TemplateWorldSpeakerTests
    {
        // Nunit style SetUp's are achieved through the constructor (no explicit [Setup] method needed!)
        public TemplateWorldSpeakerTests()
        {
        }

        [Fact] //The [Fact] attribute indicates a test method that is run by the test runner
        public void ShouldReturnCompleteEnglishTranslationHelloSentanceGivenNameAde()
        {
            //arrange
            var sut = new EnglishSpeakingHuman("Ade");

            //act
            var result = sut.Greet();

            //assert
            Assert.Equal("Hello, my name is Ade!", result);
        }

        [Fact]
        public void ShouldReturnCompleteSpanishTranslationHelloSentanceGivenNameAde()
        {
            //arrange
            var sut = new TemplateWorldSpeakers.Domain.SpanishSpeakingHuman("Ade");

            //act
            var result = sut.Greet();

            //assert
            Assert.Equal("Hola, mi nombre es Ade!", result);
        }
    }
}
