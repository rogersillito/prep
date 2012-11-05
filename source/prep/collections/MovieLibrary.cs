using System;
using System.Collections.Generic;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
        foreach (var movie1 in ToEnumerable()) yield return movie1;
    }

      private IEnumerable<Movie> ToEnumerable()
      {
          foreach (var movie in movies)
          {
              yield return movie;
          }
      }

      public void add(Movie movie)
    {
        foreach (var movie1 in movies)
        {
            if (movie1.GetHashCode() == movie.GetHashCode())
                return;
            if (movie1.title == movie.title)
                return;
        }
        movies.Add(movie);
    }

    public IEnumerable<Movie> SortBy(IComparer<Movie> comparer)
    {
        var outlist = ConvertListToArray();
        Array.Sort(outlist, comparer);
        foreach (var movie in outlist)
        {
            yield return movie;
        }
    }

    private Movie[] ConvertListToArray()
    {
        var outArray = new Movie[] { };
        for (int index = 0; index < movies.Count; index++)
        {
            outArray[index] = movies[index];
        }
        return outArray;
    }

    public IEnumerable<Movie> FindAll(Predicate<Movie> satisfies)
    {
        foreach (var movie in movies)
        {
            if (satisfies(movie))
                yield return movie;
        }
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
        throw new NotImplementedException();
    }

      public IEnumerable<Movie> all_movies_published_by_pixar()
      {
          return FindAll(x => x.production_studio == ProductionStudio.Pixar);
      }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
      {
          return FindAll(x => x.production_studio == ProductionStudio.Pixar || x.production_studio == ProductionStudio.Disney);
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
        return FindAll(x => x.production_studio != ProductionStudio.Pixar);
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
        return FindAll(x => x.date_published.Year > year);
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
        return FindAll(x => x.date_published.Year > startingYear && x.date_published.Year < endingYear);
    }

    public IEnumerable<Movie> all_kid_movies()
    {
        return FindAll(x => x.genre == Genre.kids);
    }

    public IEnumerable<Movie> all_action_movies()
    {
        return FindAll(x => x.genre == Genre.action);
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }

    public abstract class Specification
    {
        
    }
}