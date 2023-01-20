namespace WebAppNet.Domain;

public abstract class Entity
{   //LEMBRE-SE QUE UMA CLASSE ABSTRATA NÃO PODE SER ISTANCIADA APENAS HERDADA
    // PODEMOS CHAMAR A NOSSA CLASSE ABSTRATA ENTITY ASSIM "public class xname : Entity

    public Entity() 
    {
        Id= Guid.NewGuid(); //aqui estamos uma coisa inteligente, pois quando gerarmos um produto ou categoria  ele vai gerar um id automaticamente 
        
    }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public string EditedBy { get; set; }

    public DateTime EditedOn { get; set; }
}
