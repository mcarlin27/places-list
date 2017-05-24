using System.Collections.Generic;

namespace PlacesBeen.Objects
{
  public class Places
  {
    private string _location;
    private int _id;
    private static List<Places> _instances = new List<Places> {};

    public Places (string city)
    {
      _location = city;
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
