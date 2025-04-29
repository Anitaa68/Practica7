using MongoDB.Bson.Serialization.Attributes;

public class Vuelos {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set;}
    [BsonElement("pais_origen")]
    public string PaisOrigen { get; set;} = string.Empty;
    [BsonElement("ciudad_origen")]
    public string CiudadOrigen { get; set;} = string.Empty;
    [BsonElement("aeropuerto_origen")]
      public string AeropuertoOrigen { get; set;} = string.Empty;
      [BsonElement("pais_destino")]
        public string PaisDestino { get; set;} = string.Empty;
        [BsonElement("ciudad_destino")]
          public string CiudadDestino { get; set;} = string.Empty;
          [BsonElement("aeropuerto_destino")]
            public string AeropuertoDestino { get; set;} = string.Empty;
            [BsonElement("tipo_avion")]
              public string TipoAvion { get; set;} = string.Empty;
              [BsonElement("cupo_avion")]
              public decimal CupoAvion { get; set;} 
              
              public decimal pasajeros_actuales { get; set;}
              public DateTime fecha_hora_salida { get; set;} 
               public DateTime fecha_hora_llegada_aproximada { get; set;}
               public string nombre_piloto { get; set; } = string.Empty;
               public string estatus_vuelo { get; set; } = string.Empty;
}