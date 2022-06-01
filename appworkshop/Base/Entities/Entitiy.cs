using System.Dynamic;

namespace appworkshop.Base.Entities;

public abstract class Entitiy
{ 
    public string Id { get; set; }
    public  DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}