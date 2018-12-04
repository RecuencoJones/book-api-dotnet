using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Models;
using BookApi.Repositories;
using BookApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookApi
{
  public class Startup
  {
    public void ConfigureServices(IServiceCollection services)
    {
      services
          .AddScoped<IBookService, BookService>()
          .AddScoped<IBookRepository, BookRepository>()
          .AddDbContext<BookContext>(opt => opt.UseInMemoryDatabase("books"))
          .AddMvcCore()
          .AddFormatterMappings()
          .AddJsonFormatters()
          .AddCors();
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      app.UseMvc();
    }
  }
}
