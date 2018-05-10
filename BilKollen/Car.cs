using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BilKollen
{
    public partial class Welcome
    {
        [JsonProperty("data")]
        public WelcomeData Data { get; set; }
    }

    public partial class WelcomeData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("basic")]
        public Basic Basic { get; set; }

        [JsonProperty("technical")]
        public Technical Technical { get; set; }
    }

    public partial class Attributes
    {
        [JsonProperty("regno")]
        public string Regno { get; set; }

        [JsonProperty("vin")]
        public string Vin { get; set; }
    }

    public partial class Basic
    {
        [JsonProperty("data")]
        public BasicData Data { get; set; }
    }

    public partial class BasicData
    {
        [JsonProperty("make")]
        public string Make { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("vehicle_year")]
        public long VehicleYear { get; set; }

        [JsonProperty("model_year")]
        public long ModelYear { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public partial class Technical
    {
        [JsonProperty("data")]
        public TechnicalData Data { get; set; }
    }

    public partial class TechnicalData
    {
        [JsonProperty("power_hp_1")]
        public long? PowerHp1 { get; set; }

        [JsonProperty("power_hp_2")]
        public object PowerHp2 { get; set; }

        [JsonProperty("power_hp_3")]
        public object PowerHp3 { get; set; }

        [JsonProperty("power_kw_1")]
        public long? PowerKw1 { get; set; }

        [JsonProperty("power_kw_2")]
        public object PowerKw2 { get; set; }

        [JsonProperty("power_kw_3")]
        public object PowerKw3 { get; set; }

        [JsonProperty("cylinder_volume")]
        public long? CylinderVolume { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long TopSpeed { get; set; }

        [JsonProperty("fuel_1")]
        public long Fuel1 { get; set; }

        [JsonProperty("fuel_2")]
        public object Fuel2 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long Consumption1 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Consumption2 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Consumption3 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long Co21 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Co22 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Co23 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long Transmission { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool FourWheelDrive { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? SoundLevel1 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object SoundLevel2 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object SoundLevel3 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? NumberOfPassengers { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool PassengerAirbag { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Hitch { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Hitch2 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? ChassiCode1 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object ChassiCode2 { get; set; }

        [JsonProperty("chassi")]
        public string Chassi { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("length")]
        public long? Length { get; set; }

        [JsonProperty("width")]
        public long? Width { get; set; }

        [JsonProperty("height")]
        public long? Height { get; set; }

        [JsonProperty("kerb_weight")]
        public long? KerbWeight { get; set; }

        [JsonProperty("total_weight")]
        public long? TotalWeight { get; set; }

        [JsonProperty("load_weight")]
        public long? LoadWeight { get; set; }

        [JsonProperty("trailer_weight")]
        public long? TrailerWeight { get; set; }

        [JsonProperty("unbraked_trailer_weight")]
        public long? UnbrakedTrailerWeight { get; set; }

        [JsonProperty("trailer_weight_b")]
        public long? TrailerWeightB { get; set; }

        [JsonProperty("trailer_weight_be")]
        public long? TrailerWeightBe { get; set; }

        [JsonProperty("carriage_weight")]
        public object CarriageWeight { get; set; }

        [JsonProperty("tire_front")]
        public string TireFront { get; set; }

        [JsonProperty("tire_back")]
        public string TireBack { get; set; }

        [JsonProperty("rim_front")]
        public string RimFront { get; set; }

        [JsonProperty("rim_back")]
        public string RimBack { get; set; }

        [JsonProperty("axel_width")]
        public long? AxelWidth { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("eeg")]
        public string Eeg { get; set; }

        [JsonProperty("nox_1")]
        public double? Nox1 { get; set; }

        [JsonProperty("nox_2")]
        public object Nox2 { get; set; }

        [JsonProperty("nox_3")]
        public object Nox3 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double ThcNox1 { get; set; }

        [JsonProperty("thc_nox_2")]
        public object ThcNox2 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object ThcNox3 { get; set; }

        [JsonProperty("eco_class")]
        public object EcoClass { get; set; }

        [JsonProperty("emission_class")]
        public object EmissionClass { get; set; }

        [JsonProperty("euro_ncap")]
        public long? EuroNcap { get; set; }
    }

    //En metod för att konvertera från JSON
    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, BilKollen.Converter.Settings);
    }

    //En metod för att konvertera till JSON
    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, BilKollen.Converter.Settings);
    }

    //En konverterare som innehåller inställningar för hantering av JSON-data
    internal class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = { 
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
