using System;
using System.Collections.Generic;
using System.Linq;

public class Olympics : IOlympics
{
    Dictionary<int, Competition> competitions = new Dictionary<int, Competition>();
    Dictionary<int, Competitor> competitors = new Dictionary<int, Competitor>();

    public void AddCompetition(int id, string name, int participantsLimit)
    {
        Competition comp = new Competition(name, id, participantsLimit);

        if (competitions.ContainsKey(id))
        {
            throw new ArgumentException();
        }

        competitions.Add(id, comp);
    }

    public void AddCompetitor(int id, string name)
    {
        Competitor comp = new Competitor(id, name);

        if (competitors.ContainsKey(id))
        {
            throw new ArgumentException();
        }

        competitors.Add(id, comp);
    }

    public void Compete(int competitorId, int competitionId)
    {
        if (competitions.ContainsKey(competitionId) || competitors.ContainsKey(competitorId))
        {
            competitions[competitionId].Competitors.Add(competitors[competitorId]);
            competitions[competitionId].Score += (int)competitors[competitorId].TotalScore;
        }
        else
        {
            throw new ArgumentException();
        }
    }

    public int CompetitionsCount()
    {
        return competitions.Count; ;
    }

    public int CompetitorsCount()
    {
         
        return competitors.Count;
    }

    public bool Contains(int competitionId, Competitor comp)
    {
        return competitions[competitionId].Competitors.Contains(comp);
    }

    public void Disqualify(int competitionId, int competitorId)
    {
        if (!competitions.ContainsKey(competitorId) || !competitors.ContainsKey(competitorId))
        {
            throw new ArgumentException();
        }
        var competitor = competitors[competitorId];
        competitions[competitionId].Competitors.Remove(competitor);
        competitions[competitionId].Score -= (int)competitor.TotalScore;

    }

    public IEnumerable<Competitor> FindCompetitorsInRange(long min, long max)
    {
        List<Competitor> comp = new List<Competitor>();
        foreach (var item in competitors.Values)
        {
            if (item.TotalScore >= min && item.TotalScore >= max)
            {
                comp.Add(item);
            }
        }
            return comp;
    }

    public IEnumerable<Competitor> GetByName(string name)
    {
        List<Competitor> comp = new List< Competitor>();

        foreach (var item in competitors.Values)
        {
            if (item.Name==name)
            {
                comp.Add(item);
            }

            if (comp.Count== 0)
            {
                throw new ArgumentException();
            }

        }
            return comp;

    }

    public Competition GetCompetition(int id)
    {
        if (!competitions.ContainsKey(id))
        {
            throw new ArgumentException();
        }

        return new Competition (competitions[id].Name, competitions[id].Id, competitions[id].Score);
    }

    public IEnumerable<Competitor> SearchWithNameLength(int min, int max)
    {
        List<Competitor> comp = new List<Competitor>();

        foreach (var item in competitors.Values)
        {
            if (item.Name.Length >= min && item.Name.Length <= max)
            {
                comp.Add(item);
            }

        }
        return comp;
    }
}