using System.ComponentModel.DataAnnotations;

namespace Anmeldeplattform.Model
{
    public class AnmeldeModel
    {
        public string ID { get; set; }
        public string Datum { get; set; }
        [Required(ErrorMessage = "Bitte Interesse an der Veranstaltung angeben!")]
        public string Interesse { get; set; }


        [Range(1, 7, ErrorMessage = "Bitte momentanes Fachsemester angeben!")]
        public int Fachsemester { get; set; }


        [Required(ErrorMessage = "Bitte angestrebten Abschluss angeben!")]
        public string Abschluss { get; set; }


        public string Anregungen { get; set; }


        public bool CVSend { get; set; }


        [Required(ErrorMessage = "Wir benötigen eine Email-Adresse um dich zu kontaktieren!")]
        [EmailAddress(ErrorMessage = "Ungültige Email-Adresse!")]
        public string? Email { get; set; }


        [Range(typeof(bool), "true", "true", ErrorMessage = "Bitte der Datenschutzerklärung zustimmen!")]
        public bool DatenschutzOk { get; set; }
        public bool CV { get; set; }
    }
}
