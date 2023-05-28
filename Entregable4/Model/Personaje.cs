namespace ServicioAPI.Model;

public class Personaje{
    public int id { get; set; }
    public string name {get;set;}="";
    public string status{get;set;}="";
    public string  species{get;set;}="";
    public Location  location{get;set;}
    public string  gender{get;set;}="";
    public string  image{get;set;}="";
     public class Location
    {
        public string name { get; set; }
        // Otros campos de ubicación si los hay
    }
}
