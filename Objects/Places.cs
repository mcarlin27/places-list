using System.Collections.Generic;

namespace PlacesBeen.Objects
{
  public class Places
  {
    private string _location;
    private string _season;
    private int _id;
    private static List<Places> _instances = new List<Places> {};

    public Places (string city, string season)
    {
      _location = city;
      _season = season;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetCity()
    {
      return _location;
    }
    public void SetCity(string newCity)
    {
      _location = newCity;
    }
    public string GetSeason()
    {
      return _season;
    }
    public void SetSeason(string newSeason)
    {
      _season = newSeason;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Places> GetAll()
    {
      return _instances;
    }
    public static Places Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
