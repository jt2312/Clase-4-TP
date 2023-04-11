using Clase4.Models;


namespace Clase4.Services;

public static class MovieService{
static List<Movie> Movies{get;set;}

static MovieService(){
Movies = new List<Movie>{
  new Movie {Name = "Batman", Code="BTM",Category="Sci Fi", Minutes=120, Review="4.5 Estrellas"},
  new Movie {Name = "Avengers", Code="AVG",Category="Sci Fi", Minutes=140, Review="5 Estrellas"},
  new Movie {Name = "Superman", Code="SPM",Category="Sci Fi", Minutes=160, Review="muy mala.."},
  new Movie {Name = "Toy Story", Code="TS",Category="Dysney", Minutes=90, Review="Me encanto!!"},
  new Movie {Name = "Cars", Code="CRS",Category="Disney", Minutes=100, Review="No me sorprendio.. "},
  new Movie {Name = "EL Conjuro", Code="666",Category="Terror", Minutes=145, Review="La recomiendo"},
  new Movie {Name = "Como si fuera la primera vez", Code="CSF",Category="Comedia", Minutes=180, Review="Muy graciosa!."},
  new Movie {Name = "Avatar", Code="AVT",Category="Sci Fi", Minutes=220,Review="Buenos efectos, pero muy larga..."},
  new Movie {Name = "Hannibal", Code="HNL",Category="Terror", Minutes=100,Review="Muy buena pelicula de terror"
} 
};

}

public static List<Movie> GetAll() => Movies;

  public static void Add(Movie obj){
    if(obj == null){
    return;
}
  Movies.Add(obj);
  }
  public static void Delete(string code){
      var movieToDelete = Get(code);
      if (movieToDelete != null){
        Movies.Remove(movieToDelete);
      }
    }
  
public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());


}
