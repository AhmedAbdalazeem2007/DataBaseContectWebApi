using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataBaseContectWebApi.Models;

public class DataAnnotation
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Base64String]
    public int Number { get; set; }
    [AllowedValues(1, 2, 3, 4, 5, 6, 7, 8, 9)]
    public int Grade { get; set; }
    [DeniedValues(1, 2, 3, 4, 5, 6)]
    public int Age { get; set; }
    [Length(minimumLength: 10, maximumLength: 200)]
    public string Name { get; set; }
    [Length(minimumLength: 1, maximumLength: 20)]
    public ICollection<int> Ints { get; set; }
    public DataAnnotation()
    {
        
    }
}
