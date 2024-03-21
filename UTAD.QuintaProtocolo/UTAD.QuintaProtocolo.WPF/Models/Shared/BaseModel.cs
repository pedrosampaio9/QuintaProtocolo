
namespace UTAD.QuintaProtocolo.WPF.Models.Shared
{
    public abstract class BaseModel
    {
     protected BaseModel() {
        
        if(string.IsNullOrEmpty(ID)) 
                ID = Guid.NewGuid().ToString();
        
        }

        
        
        
        public string ID { get; set; }
    }
}
