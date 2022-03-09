using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Board : IBoard
{
    List<Card> cards = new List<Card>();
    Dictionary<string, Card> check = new Dictionary<string, Card>();
    public bool Contains(string name)
    {
        return check.ContainsKey(name);
        //foreach (var item in cards)
        //{
        //    if (item.Name == name)
        //    {
        //        return true;
        //    }
        //}
        //return false;
    }

    public int Count()
    {
        return cards.Count;
    }

    public void Draw(Card card)
    {
        if (this.Contains(card.Name))
        {
            throw new ArgumentException();
        }

        cards.Add(card);
        check.Add(card.Name, card);
    }

    public IEnumerable<Card> GetBestInRange(int start, int end)
    {
        return cards.Where(x => x.Score >= start && x.Score <= end).OrderByDescending(x => x.Level) ;

    }

    public void Heal(int health)
    {
        var card = cards.IndexOf(cards.OrderBy(x => x.Health).First());
        cards[card].Health += health;
    }

    public IEnumerable<Card> ListCardsByPrefix(string prefix)
    {
        return cards.Where(x => x.Name.StartsWith(prefix)).OrderBy(x => x.Name.Reverse()).ThenBy(x => x.Level);
    }

    public void Play(string attackerCardName, string attackedCardName)
    {
        var attacker = cards.FirstOrDefault(x => x.Name == attackerCardName);
        var deffender = cards.FirstOrDefault(x => x.Name == attackedCardName);
        if (attacker == null || deffender == null || attacker.Level != deffender.Level)
        {
            throw new ArgumentException();
        }

        int index = cards.IndexOf(deffender);
        int indexAtt = cards.IndexOf(attacker);

        if (cards[index].Health > 0)
        {
            cards[index].Health -= attacker.Damage;
            if (cards[index].Health <= 0)
            {

                cards[indexAtt].Score += deffender.Level;
            }
        }


    }

    public void Remove(string name)
    {
        if (!this.Contains(name))
        {
            throw new ArgumentException();
        }

        cards.RemoveAll(x => x.Name == name);
        
    }

    public void RemoveDeath()
    {
        
        cards.RemoveAll(x => x.Health <= 0);
    }

    public IEnumerable<Card> SearchByLevel(int level)
    {
        return cards.Where(x => x.Level == level).OrderByDescending(x => x.Score);
    }
}