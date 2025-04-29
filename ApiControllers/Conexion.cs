using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    [HttpGet("mongo")]
    public IActionResult ListarVuelosMongoDb(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client. GetDatabase("Aeropuerto");
        var collection = db.GetCollection<Vuelos>("Vuelos");

        var list = collection.Find(FilterDefinition<Vuelos>.Empty).ToList(); 
        return Ok (list);
    }
}