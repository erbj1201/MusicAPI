//include
using MusicAPI.Models;
using Microsoft.EntityFrameworkCore;
//namespace
namespace MusicAPI.Data;

//class
public class MusicContext : DbContext
{ 
//constructor
public MusicContext(DbContextOptions<MusicContext> options) : base (options) {}

public DbSet<Music> Musics {get; set;} = null!;

}