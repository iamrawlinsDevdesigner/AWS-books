using AmazonBooks.Models;
using Microsoft.EntityFrameworkCore;

namespace AmazonBooks.Data;

public class ApplicationDbCOntext :DbContext
 {
    public ApplicationDbCOntext(DbContextOptions<ApplicationDbCOntext> options):base(options){


    }

    public DbSet<BooksEntity> Books { get;set;}


}