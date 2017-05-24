using Nancy;
using PlacesBeen.Objects;
using System.Collections.Generic;

namespace PlacesBeen
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/places"] = _ => {
        List<Places> allPlaces = Places.GetAll();
        return View["places.cshtml", allPlaces];
      };

      Get["/places/new"] = _ => {
        return View["places_form.cshtml"];
      };

      Post["/places"] = _ => {
        Places newPlaces = new Places (Request.Form["new-place"], Request.Form["new-season"]);
        List<Places> allPlaces = Places.GetAll();
        return View["/places.cshtml", allPlaces];
      };

      Get["/places/{id}"] = parameters => {
        Places place = Places.Find(parameters.id);
        return View["/place.cshtml", place];
      };

    }
  }
}
