using System;
using System.Collections.Generic;
using NUnit.Framework;


[TestFixture]
public class HeroRepositoryTests
{
    private HeroRepository heroes;
    private Hero hero;

    [SetUp]

    public void SetUp()
    {
        heroes = new HeroRepository();
        hero = new Hero("Pesho", 5);
    }


    [Test]

    public void Should_Add_A_Hero_If_The_Name_Is_Not_In_The_List()
    {
        heroes.Create(hero);
        Assert.That(heroes.Heroes.Count, Is.EqualTo(1));
    }

    [Test]

    public void Should_Throw_If_The_Name_Is_In_The_List()
    {
        heroes.Create(hero);
        Assert.Throws<InvalidOperationException>(() =>
        {
            heroes.Create(hero);
        });
    }

    [Test]

    public void Should_Throw_If_The_Name_Is_Null()
    {
        hero = null;
        Assert.Throws<ArgumentNullException>(() =>
        {
            heroes.Create(hero);
        });
    }

    [Test]

    public void Should_Remove_A_Hero_With_The_Name_In_The_List()
    {
        heroes.Create(hero);
        Assert.That(heroes.Remove("Pesho"), Is.True);
    }

    [Test]

    public void Should_Not_Remove_A_Hero_With_The_Name_In_The_List()
    {
        heroes.Create(hero);
        Assert.That(heroes.Remove("Gesho"), Is.False);
    }

    [Test]
    public void Should_Throw_If_The_Name_For_Removing_Is_Null()
    {
        
        Assert.Throws<ArgumentNullException>(() =>    
        {
            heroes.Remove(null);
        });
    }

    [Test]
    public void Should_Throw_If_The_Name_For_Removing_Is_Blank()
    {

        Assert.Throws<ArgumentNullException>(() =>
        {
            heroes.Remove(" ");
        });
    }

    [Test]
    public void Should_Return_Hero_With_The_Highest_Level()
    {
        Hero misho = new Hero("Misho", 15);
        Hero pizza = new Hero("Pizza", -1);
        heroes.Create(misho);
        heroes.Create(hero);
        heroes.Create(pizza);

        Assert.That(heroes.GetHeroWithHighestLevel, Is.EqualTo(misho));
    }

    [Test]
    public void Should_Return_Hero_With_The_Given_Name()
    {
        Hero misho = new Hero("Misho", 15);
        Hero pizza = new Hero("Pizza", -1);
        heroes.Create(misho);
        heroes.Create(hero);
        heroes.Create(pizza);

        Assert.That(heroes.GetHero("Pizza"), Is.EqualTo(pizza));
    }
}