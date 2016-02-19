using System.Threading.Tasks;
using FOAASClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FOASSClient.Tests
{
    [TestClass]
    public class FoassClientTests
    {
        private readonly IFoaasClient _foaasClient;

        public FoassClientTests()
        {
            _foaasClient = new FoaasClient();
        }

        [TestMethod]
        public async Task FuckingOffShouldWork()
        {
            var res = await _foaasClient.Off("Joker", "Batman");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck off, Joker.", res.Message);
            Assert.AreEqual("- Batman", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingYouShouldWork()
        {
            var res = await _foaasClient.You("Harpo", "Groucho");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck you, Harpo.", res.Message);
            Assert.AreEqual("- Groucho", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingThatShouldWork()
        {
            var res = await _foaasClient.That("Moses");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck that.", res.Message);
            Assert.AreEqual("- Moses", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingThisShouldWork()
        {
            var res = await _foaasClient.This("Jesus H. Christ");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck this.", res.Message);
            Assert.AreEqual("- Jesus H. Christ", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingEverythingShouldWork()
        {
            var res = await _foaasClient.Everything("John F. Kennedy");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck everything.", res.Message);
            Assert.AreEqual("- John F. Kennedy", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingEveryoneShouldWork()
        {
            var res = await _foaasClient.Everyone("Bumblebee");
            Assert.IsNotNull(res);
            Assert.AreEqual("Everyone can go and fuck off.", res.Message);
            Assert.AreEqual("- Bumblebee", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingDonutShouldWork()
        {
            var res = await _foaasClient.Donut("Hillary", "Bill");
            Assert.IsNotNull(res);
            Assert.AreEqual("Hillary, go and take a flying fuck at a rolling donut.", res.Message);
            Assert.AreEqual("- Bill", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingShakespeareShouldWork()
        {
            var res = await _foaasClient.Shakespeare("Wolverine", "Professor X");
            Assert.IsNotNull(res);
            Assert.AreEqual("Wolverine, Thou clay-brained guts, thou knotty-pated fool, thou whoreson obscene greasy tallow-catch!", res.Message);
            Assert.AreEqual("- Professor X", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingLinusShouldWork()
        {
            var res = await _foaasClient.Linus("Lucy", "Charlie Brown");
            Assert.IsNotNull(res);
            Assert.AreEqual("Lucy, there aren't enough swear-words in the English language, so now I'll have to call you perkeleen vittupää just to express my disgust and frustration with this crap.", res.Message);
            Assert.AreEqual("- Charlie Brown", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingKingShouldWork()
        {
            var res = await _foaasClient.King("Lucy", "Ricki");
            Assert.IsNotNull(res);
            Assert.AreEqual("Oh fuck off, just really fuck off you total dickface. Christ Lucy, you are fucking thick.", res.Message);
            Assert.AreEqual("- Ricki", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingPinkShouldWork()
        {
            var res = await _foaasClient.Pink("Simba");
            Assert.IsNotNull(res);
            Assert.AreEqual("Well, Fuck me pink.", res.Message);
            Assert.AreEqual("- Simba", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingLifeShouldWork()
        {
            var res = await _foaasClient.Life("Gandhi");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck my life.", res.Message);
            Assert.AreEqual("- Gandhi", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingChainsawShouldWork()
        {
            var res = await _foaasClient.Chainsaw("Jim", "Dr. McCoy");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck me gently with a chainsaw, Jim. Do I look like Mother Teresa?", res.Message);
            Assert.AreEqual("- Dr. McCoy", res.Subtitle);
        }

        //TODO: Add FuckingOutsideShouldWork() Test
        [TestMethod]
        public async Task FuckingOutsideShouldWork()
        {
            var res = await _foaasClient.Outside("BigBrother", "TheWorld");
            Assert.IsNotNull(res);
            Assert.AreEqual("BigBrother, why don't you go outside and play hide-and-go-fuck-yourself?", res.Message);
            Assert.AreEqual("- TheWorld",res.Subtitle);
        }

        //TODO: Add FuckingThingShouldWork() Test.
        [TestMethod]
        public async Task FuckingThingShouldWork()
        {
            var res = await _foaasClient.Thing("pineapples", "Chris");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck pineapples.",res.Message);
            Assert.AreEqual("- Chris", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingThanksShouldWork()
        {
            var res = await _foaasClient.Thanks("Abraham Lincoln");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck you very much.", res.Message);
            Assert.AreEqual("- Abraham Lincoln", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingFlyingShouldWork()
        {
            var res = await _foaasClient.Flying("Barack Obama");
            Assert.IsNotNull(res);
            Assert.AreEqual("I don't give a flying fuck.", res.Message);
            Assert.AreEqual("- Barack Obama", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingFascinatingShouldWork()
        {
            var res = await _foaasClient.Fascinating("Marie Curie");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fascinating story, in what chapter do you shut the fuck up?", res.Message);
            Assert.AreEqual("- Marie Curie", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingMadisonShouldWork()
        {
            var res = await _foaasClient.Madison("Doctor", "Rose");
            Assert.IsNotNull(res);
            Assert.AreEqual("What you've just said is one of the most insanely idiotic things I have ever heard, Doctor. At no point in your rambling, incoherent response were you even close to anything that could be considered a rational thought. Everyone in this room is now dumber for having listened to it. I award you no points Doctor, and may God have mercy on your soul.", res.Message);
            Assert.AreEqual("- Rose", res.Subtitle);
        }

        //TODO: Add FuckingCoolShouldWork() Test.

        //TODO: Add FuckingFieldShouldWork() Test.

        //TODO: Add FuckingNuggetShouldWork() Test.

        //TODO: Add FuckingYodaShouldWork() Test.

        //TODO: Add FuckingBallmerShouldWork() Test.

        //TODO: Add FuckingWhatShouldWork() Test.

        //TODO: Add FuckingBecauseShouldWork() Test.

        //TODO: Add FuckingCaniuseShouldWork() Test.

        //TODO: Add FuckingByeShouldWork() Test.

        //TODO: Add FuckingDiabetesShouldWork() Test.

        //TODO: Add FuckingBusShouldWork() Test.

        //TODO: Add FuckingXmasShouldWork() Test.

        //TODO: Add FuckingBdayShouldWork() Test.

        //TODO: Add FuckingAwesomeShouldWork() Test.

        //TODO: Add FuckingTuckerShouldWork() Test.

        //TODO: Add FuckingBucketShouldWork() Test.

        //TODO: Add FuckingFamilyShouldWork() Test.

        //TODO: Add FuckingShutupShouldWork() Test.

        //TODO: Add FuckingZaynShouldWork() Test.

        //TODO: Add FuckingKeepCalmShouldWork() Test.

        //TODO: Add FuckingDoSomethingShouldWork() Test.

        //TODO: Add FuckingRetardShouldWork() Test.
    }
}
