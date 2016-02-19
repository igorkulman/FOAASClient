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

        [TestMethod]
        public async Task FuckingOutsideShouldWork()
        {
            var res = await _foaasClient.Outside("BigBrother", "TheWorld");
            Assert.IsNotNull(res);
            Assert.AreEqual("BigBrother, why don't you go outside and play hide-and-go-fuck-yourself?", res.Message);
            Assert.AreEqual("- TheWorld",res.Subtitle);
        }

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

        [TestMethod]
        public async Task FuckingCoolShouldWork()
        {
            var res = await _foaasClient.Cool("Luke");
            Assert.IsNotNull(res);
            Assert.AreEqual("Cool story, bro.", res.Message);
            Assert.AreEqual("- Luke", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingFieldShouldWork()
        {
            var res = await _foaasClient.Field("Yo Momma", "John", "A Book, Chapter 2.");
            Assert.IsNotNull(res);
            Assert.AreEqual("And Yo Momma said unto John, 'Verily, cast thine eyes upon the field in which I grow my fucks', and John gave witness unto the field, and saw that it was barren.", res.Message);
            Assert.AreEqual("- A Book, Chapter 2.", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingNuggetShouldWork()
        {
            var res = await _foaasClient.Nugget("Bill", "Ben");
            Assert.IsNotNull(res);
            Assert.AreEqual("Well Bill, aren't you a shining example of a rancid fuck-nugget.", res.Message);
            Assert.AreEqual("- Ben", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingYodaShouldWork()
        {
            var res = await _foaasClient.Yoda("Luke", "Yoda");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck off, you must, Luke.", res.Message);
            Assert.AreEqual("- Yoda", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBallmerShouldWork()
        {
            var res = await _foaasClient.Ballmer("Someone", "Something", "Ballmer");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fucking Someone is a fucking pussy. I'm going to fucking bury that guy, I have done it before, and I will do it again. I'm going to fucking kill Something.",res.Message);
            Assert.AreEqual("- Ballmer", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingWhatShouldWork()
        {
            var res = await _foaasClient.What("Frank");
            Assert.IsNotNull(res);
            Assert.AreEqual("What the fuck‽", res.Message);
            Assert.AreEqual("- Frank", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBecauseShouldWork()
        {
            var res = await _foaasClient.Because("Tina");
            Assert.IsNotNull(res);
            Assert.AreEqual("Why? Because Fuck you, that's why.", res.Message);
            Assert.AreEqual("- Tina", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingCaniuseShouldWork()
        {
            var res = await _foaasClient.Caniuse("Hammer", "Bob the Builder");
            Assert.IsNotNull(res);
            Assert.AreEqual("Can you use Hammer? Fuck no!", res.Message);
            Assert.AreEqual("- Bob the Builder", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingByeShouldWork()
        {
            var res = await _foaasClient.Bye("Claire");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuckity bye!", res.Message);
            Assert.AreEqual("- Claire", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingDiabetesShouldWork()
        {
            var res = await _foaasClient.Diabetes("Charley");
            Assert.IsNotNull(res);
            Assert.AreEqual("I'd love to stop and chat to you but I'd rather have type 2 diabetes.", res.Message);
            Assert.AreEqual("- Charley", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBusShouldWork()
        {
            var res = await _foaasClient.Bus("Laura", "James");
            Assert.IsNotNull(res);
            Assert.AreEqual("Christ on a bendy-bus, Laura, don't be such a fucking faff-arse.",res.Message);
            Assert.AreEqual("- James", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingXmasShouldWork()
        {
            var res = await _foaasClient.Xmas("Clive", "Your Mother");
            Assert.IsNotNull(res);
            Assert.AreEqual("Merry Fucking Christmas, Clive.", res.Message);
            Assert.AreEqual("- Your Mother", res.Subtitle);
        }

        [TestMethod]
        public async Task FuckingBdayShouldWork()
        {
            var res = await _foaasClient.Bday("Grant", "The Crew");
            Assert.IsNotNull(res);
            Assert.AreEqual("Happy Fucking Birthday, Grant.", res.Message);
            Assert.AreEqual("- The Crew", res.Subtitle);
        }

        //TODO: Add FuckingAwesomeShouldWork() Test.
        [TestMethod]
        public async Task FuckingAwesomeShouldWork()
        {
            var res = await _foaasClient.Awesome("Macklemore");
            Assert.IsNotNull(res);
            Assert.AreEqual("This is Fucking Awesome.", res.Message);
            Assert.AreEqual("- Macklemore", res.Subtitle);
        }

        //TODO: Add FuckingTuckerShouldWork() Test.
        [TestMethod]
        public async Task FuckingTuckerShouldWork()
        {
            var res = await _foaasClient.Tucker("Malcolm Tucker");
            Assert.IsNotNull(res);
            Assert.AreEqual("Come the fuck in or fuck the fuck off.", res.Message);
            Assert.AreEqual("- Malcolm Tucker", res.Subtitle);
        }

        //TODO: Add FuckingBucketShouldWork() Test.
        [TestMethod]
        public async Task FuckingBucketShouldWork()
        {
            var res = await _foaasClient.Bucket("Richard Dickson");
            Assert.IsNotNull(res);
            Assert.AreEqual("Please choke on a bucket of cocks.",res.Message);
            Assert.AreEqual("- Richard Dickson", res.Subtitle);
        }

        //TODO: Add FuckingFamilyShouldWork() Test.
        [TestMethod]
        public async Task FuckingFamilyShouldWork()
        {
            var res = await _foaasClient.Family("Jezza");
            Assert.IsNotNull(res);
            Assert.AreEqual("Fuck you, your whole family, your pets, and your feces.", res.Message);
            Assert.AreEqual("- Jezza", res.Subtitle);
        }

        //TODO: Add FuckingShutupShouldWork() Test.

        //TODO: Add FuckingZaynShouldWork() Test.

        //TODO: Add FuckingKeepCalmShouldWork() Test.

        //TODO: Add FuckingDoSomethingShouldWork() Test.

        //TODO: Add FuckingRetardShouldWork() Test.
    }
}
