## MovieAPIContext

```mermaid
erDiagram
  MovieDetails {
    MovieDetailsId int PK
    Budget int 
    Synopsis nvarchar(max) 
    Language nvarchar(max) 
    MoviesId int 
  }
  Movies {
    MoviesId int PK
    Year int 
    Title nvarchar(max) 
    Genre nvarchar(max) 
    Duration time 
    MovieDetailsID int 
  }
```
