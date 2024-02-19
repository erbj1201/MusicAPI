//include
using System.ComponentModel.DataAnnotations;
//namespace
namespace MusicAPI.Models;
//Class Music
public class Music
{ //properties, all required except id
    public int Id { get; set; }
    [Required]
    public string? Artist { get; set; }
    [Required]
    public string? SongTitle { get; set; }
    [Required]
    public string? SongLenght { get; set; }
    [Required]
    public string? Category { get; set; }
}