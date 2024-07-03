// ArticleService.cs

using sarel.Models; // Ensure this namespace matches where your Article class is defined
using System.Collections.Generic;

public class ArticleService
{
    private List<Article> _articles; // Simulated data store; replace with actual database access

    public ArticleService()
    {
        _articles = new List<Article> {


            new Article
{
    Id = 1,
    Title = "Obudowy SAREL - SPACIAL 3D",
    Date = DateTime.Now.AddDays(-5),
    Text = @"Firma SAREL posiada w swojej ofercie obudowy typu SAREL Spacial 3D:<br>
             - z drzwiami pełnymi, bez płyty montażowej,<br>
             - z drzwiami pełnymi i płyta pełną,<br>
             - z drzwiami przezroczystymi, bez płyty montażowej,<br><br>
             w 41 rozmiarach. Stopień ochrony wynosi IP66 (IP55 dla obudów z drzwiami podwójnymi), zgodność ze standardem EN 50298.<br><br>
             Obudowy SAREL Spacial 3D mogą być dostarczane na życzenie:<br>
             - w innych kolorach,<br>
             - z zamontowanymi akcesoriami,<br>
             - specjalnie obronione maszynowo,<br>
             - w innych wymiarach,<br>
             - z innym wykończeniem (pokryte chromianem cynku, metalizowane, itp.),<br>
             - w konfiguracjach na życzenie.<br>",
    ImageUrl = "/images/logo mh.png"
} };

    }

    public List<Article> GetAllArticles()
    {
        return _articles;
    }

    public Article GetArticleById(int id)
    {
        return _articles.FirstOrDefault(a => a.Id == id);
    }
}

