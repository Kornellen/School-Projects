using _02_konsolowe;

namespace _02_konsolowe_tests;

[TestClass]
public sealed class Test1
{
    private PESELService peselService = new();
    private string[] MOCK_PESELS =
    {
        "44051401458", // valid XX centaury
        "02270803624", // valid XXI centaury
        "44051401459", // invalid checksum
        "4405140145", // invalid lenght
        "44051401A58", // contains letter
    };

    [TestMethod]
    public void ValidPESELXXc()
    {
        Assert.IsTrue(peselService.ValidatePESEL(MOCK_PESELS[0]));
        Assert.AreEqual("14.05.1944", peselService.GetDoB(MOCK_PESELS[0]));
    }

    [TestMethod]
    public void ValidPESELXXIc()
    {
        Assert.IsTrue(peselService.ValidatePESEL(MOCK_PESELS[1]));
        Assert.AreEqual("08.07.2002", peselService.GetDoB(MOCK_PESELS[1]));
    }

    [TestMethod]
    public void InvalidPESELCheckSum()
    {
        Assert.IsFalse(peselService.ValidatePESEL(MOCK_PESELS[2]));
    }

    [TestMethod]
    public void InvalidLenght()
    {
        Assert.IsFalse(peselService.ValidatePESEL(MOCK_PESELS[3]));
    }

    [TestMethod]
    public void ContainsLetter()
    {
        Assert.IsFalse(peselService.ValidatePESEL(MOCK_PESELS[4]));
    }
}
