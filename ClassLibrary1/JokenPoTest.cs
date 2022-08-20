using NUnit.Framework;
using Teste;

namespace ClassLibrary1
{
    [TestFixture]
    public class JokenPoTest
    {
        [SetUp]
        public void Init()
        {
            jokenpo = new JokenPo();
        }

        [Test]
        public void When_Play_Rock_and_Scissor_Then_Rock_Wins()
        {
            var result = jokenpo.Play(JokenPoEnum.Rock, JokenPoEnum.Scissor);
            Assert.AreEqual(JokenPoEnum.Rock.ToString(), result);
        }

        [Test]
        public void When_Play_Rock_and_Paper_Then_Paper_Wins()
        {
            var result = jokenpo.Play(JokenPoEnum.Rock, JokenPoEnum.Paper);
            Assert.AreEqual(JokenPoEnum.Paper.ToString(), result);
        }

        [Test]
        public void When_Play_Rock_and_Rock_Then_Draw()
        {
            var result = jokenpo.Play(JokenPoEnum.Rock, JokenPoEnum.Rock);
            Assert.AreEqual("Draw", result);
        }

        [Test]
        public void When_Play_Scissor_and_Rock_Then_Rock_Wins()
        {
            var result = jokenpo.Play(JokenPoEnum.Scissor, JokenPoEnum.Rock);
            Assert.AreEqual(JokenPoEnum.Rock.ToString(), result);
        }

        [Test]
        public void When_Play_Scissor_and_Paper_Then_Scissor_Wins()
        {
            var result = jokenpo.Play(JokenPoEnum.Scissor, JokenPoEnum.Paper);
            Assert.AreEqual(JokenPoEnum.Scissor.ToString(), result);
        }

        [Test]
        public void When_Play_Scissor_and_Scissor_Then_Draw()
        {
            var result = jokenpo.Play(JokenPoEnum.Scissor, JokenPoEnum.Scissor);
            Assert.AreEqual("Draw", result);
        }

        [Test]
        public void When_Play_Paper_and_Paper_Then_Draw()
        {
            var result = jokenpo.Play(JokenPoEnum.Paper, JokenPoEnum.Paper);
            Assert.AreEqual("Draw", result);
        }

        [Test]
        public void When_Play_Paper_and_Scissor_Then_Scissor_Wins()
        {
            var result = jokenpo.Play(JokenPoEnum.Paper, JokenPoEnum.Scissor);
            Assert.AreEqual(JokenPoEnum.Scissor.ToString(), result);
        }

        [Test]
        public void When_Play_Paper_and_Rock_Then_Paper_Wins()
        {
            var result = jokenpo.Play(JokenPoEnum.Paper, JokenPoEnum.Rock);
            Assert.AreEqual(JokenPoEnum.Paper.ToString(), result);
        }

        [Test]
        public void When_Play_Paper_and_Pencil_Then_Pencil_Wins()
        {
            var result = jokenpo.Play(JokenPoEnum.Paper, JokenPoEnum.Pencil);
            Assert.AreEqual(JokenPoEnum.Pencil.ToString(), result);
        }

        [Test]
        public void When_Play_Pencil_and_Rock_Then_Pencil_Wins()
        {
            var result = jokenpo.Play(JokenPoEnum.Pencil, JokenPoEnum.Rock);
            Assert.AreEqual(JokenPoEnum.Pencil.ToString(), result);
        }

        private JokenPo jokenpo;
    }
}
