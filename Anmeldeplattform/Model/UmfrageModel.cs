namespace Anmeldeplattform.Model
{
    public class Umfrage
    {
        public int ID { get; set; }
        public string? Frage { get; set; }
    }

    public class NummerUmfrage : Umfrage
    {
        public int? Next { get; set; }
        public int Bewertung { get; set; }
    }

    public class TextUmfrage : Umfrage
    {
        public int? NextStartup_Or_Ja { get; set; }
        public int? NextKlassisch_Or_Nein { get; set; }
        public string Bewertung { get; set; }
    }

    public class TextUmfrageStudent : TextUmfrage
    {
        public bool Arbeitgeber { get; set; }
    }

    public class TextUmfrageVortragende : TextUmfrage
    {
        public bool Wünsche { get; set; }
        public bool Beschäftigungsart { get; set; }
    }


    public class UmfrageListStudent
    {
        public List<NummerUmfrage> NummerListStudent { get; set; }

        public List<TextUmfrageStudent> TextListStudent { get; set; }
        public UmfrageListStudent()
        {
            NummerListStudent = new List<NummerUmfrage>();
            TextListStudent = new List<TextUmfrageStudent>();

            NummerListStudent.Add(new NummerUmfrage
            {
                ID = 1,
                Next = 2,
                Frage = "Wie gut hat dir die Veranstaltung gefallen?",
                Bewertung = 4
            });
            NummerListStudent.Add(new NummerUmfrage
            {
                ID = 2,
                Next = 3,
                Frage = "Wie wahrscheinlich ist es, dass du die Veranstaltung weiter empfiehlst?",
                Bewertung = 4
            });
            NummerListStudent.Add(new NummerUmfrage
            {
                ID = 3,
                Next = 4,
                Frage = "Wie wahrscheinlich ist es, dass du die Veranstaltung wieder besuchen würdest?",
                Bewertung = 4
            });


            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 4,
                NextStartup_Or_Ja = 5,
                NextKlassisch_Or_Nein = 6,
                Frage = "Arbeitest du aktuell bei einem Start-Up?",
                Bewertung = ""
            });

            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 5,
                NextStartup_Or_Ja = 9,
                NextKlassisch_Or_Nein = 9,
                Frage = "Kannst du dir auch weiterhin vorstellen für ein StartUp tätig zu sein?",
                Bewertung = ""
            });

            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 6,
                NextStartup_Or_Ja = 9,
                NextKlassisch_Or_Nein = 7,
                Frage = "Hattest du die Möglichkeit, seit Beginn deines Studiums zu irgendeinem Zeitpunkt für ein StratUp tätig zu sein?",
                Bewertung = ""
            });


            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 7,
                NextStartup_Or_Ja = 9,
                NextKlassisch_Or_Nein = 8,
                Frage = "Hast du vor dem Besuch dieser Veranstaltung StartUps bereits als potentiellen Arbeitgeber betrachtet?",
                Bewertung = ""
            });

            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 8,
                NextStartup_Or_Ja = 9,
                NextKlassisch_Or_Nein = 9,
                Frage = "Hat diese Veranstaltung deine Sichtweise auf die Wahl deines zukünftigen Arbeitgebers verändert?",
                Bewertung = ""
            });

            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 9,
                NextStartup_Or_Ja = 10,
                NextKlassisch_Or_Nein = 10,
                Frage = "Hast du die Veranstaltung genutzt, um dich mit den StartUps auszutauschen?",
                Bewertung = ""
            });

            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 10,
                NextStartup_Or_Ja = 11,
                NextKlassisch_Or_Nein = 11,
                Frage = "Bist du mit einem der Vortragenden StartUps im Gespräch über konkrete Einstiegsmöglichkeiten?",
                Bewertung = ""
            });

            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 11,
                NextStartup_Or_Ja = 12,
                NextKlassisch_Or_Nein = 12,
                Frage = "Bist du unabhängig von den vortragenden StartUps generell im Gespräch mit einem StartUp über Einstiegsmöglichkeiten?",
                Bewertung = ""
            });

            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 12,
                NextKlassisch_Or_Nein = 13,
                NextStartup_Or_Ja = 14,
                Frage = "Wo würdest du als Berufseinsteiger direkt nach dem Studium lieber arbeiten?",
                Bewertung = "",
                Arbeitgeber = true
            });

            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 13,
                NextStartup_Or_Ja = 14,
                NextKlassisch_Or_Nein = 14,
                Frage = "Kansst du dir nach 3 - 5 Jahren Berufserfahrung vorstellen in einem StartUp zu arbeiten?",
                Bewertung = "",
            });


            TextListStudent.Add(new TextUmfrageStudent
            {
                ID = 14,
                NextKlassisch_Or_Nein = null,
                NextStartup_Or_Ja = null,
                Frage = "Anmerkungen",
                Bewertung = "",
            });
        }
    }


    public class UmfrageListVortragende
    {
        public List<NummerUmfrage> NummerListVortragende { get; set; }

        public List<TextUmfrageVortragende> TextListVortragende { get; set; }
        public UmfrageListVortragende()
        {
            NummerListVortragende = new List<NummerUmfrage>();
            TextListVortragende = new List<TextUmfrageVortragende>();

            TextListVortragende.Add(new TextUmfrageVortragende
            {
                ID = 1,
                NextStartup_Or_Ja = 3,
                NextKlassisch_Or_Nein = 2,
                Frage = "Hat die Veranstalltung Ihre Erwartungen erfüllt?",
                Bewertung = ""
            });

            TextListVortragende.Add(new TextUmfrageVortragende
            {
                ID = 2,
                NextKlassisch_Or_Nein = 3,
                NextStartup_Or_Ja = 3,
                Frage = "Welche Wünsche blieben von Ihrer Seite aus offen?",
                Bewertung = "",
                Wünsche = true
            });


            NummerListVortragende.Add(new NummerUmfrage
            {
                ID = 3,
                Next = 4,
                Frage = "Wie gut konnten Sie sich mit der Veranstaltung identifizieren?",
                Bewertung = 5
            });

            NummerListVortragende.Add(new NummerUmfrage
            {
                ID = 4,
                Next = 5,
                Frage = "Wie gut konnten Sie sich mit den anderen Vorträgen identifizieren?",
                Bewertung = 5
            });


            TextListVortragende.Add(new TextUmfrageVortragende
            {
                ID = 5,
                NextKlassisch_Or_Nein = 8,
                NextStartup_Or_Ja = 6,
                Frage = "Hat während der Veranstaltung ein Austausch mit den Studierenden stattgefunden?",
                Bewertung = "",
            });

            TextListVortragende.Add(new TextUmfrageVortragende
            {
                ID = 6,
                NextKlassisch_Or_Nein = 8,
                NextStartup_Or_Ja = 7,
                Frage = "Haben Sie Gespräche mit einem der Studierenden über eine Stelle bei Ihnen geführt?",
                Bewertung = "",
            });

            TextListVortragende.Add(new TextUmfrageVortragende
            {
                ID = 7,
                NextKlassisch_Or_Nein = 8,
                NextStartup_Or_Ja = 8,
                Frage = "Zu welchen Arten der Beschäftigung wurden Gespräche geführt?",
                Bewertung = "",
                Beschäftigungsart = true
            });

            TextListVortragende.Add(new TextUmfrageVortragende
            {
                ID = 8,
                NextKlassisch_Or_Nein = 9,
                NextStartup_Or_Ja = 9,
                Frage = "Hat ein Austausch mit anderen Vortragenden stattgefunden?",
                Bewertung = "",
            });


            NummerListVortragende.Add(new NummerUmfrage
            {
                ID = 9,
                Next = 10,
                Frage = "Wie wertgeschätzt haben Sie sich bei der Kommunikation mit dem Projekt-Team vor, während und nach der Veranstaltung gefühlt?",
                Bewertung = 5
            });

            NummerListVortragende.Add(new NummerUmfrage
            {
                ID = 10,
                Next = 11,
                Frage = "Wie vorbereitet hat das Projekt-Team auf Sie gewirkt?",
                Bewertung = 5
            });

            NummerListVortragende.Add(new NummerUmfrage
            {
                ID = 11,
                Next = 12,
                Frage = "Bewerten Sie, wie angenehm und passend Sie die Moderation des Projekt-Teams empfunden haben.",
                Bewertung = 5
            });

            NummerListVortragende.Add(new NummerUmfrage
            {
                ID = 12,
                Next = 13,
                Frage = "Wie wahrschenlich ist es, dass Sie die Veranstaltung weiter empfehlen würden?",
                Bewertung = 5
            });

            TextListVortragende.Add(new TextUmfrageVortragende
            {
                ID = 13,
                NextKlassisch_Or_Nein = null,
                NextStartup_Or_Ja = null,
                Frage = "Anmerkungen",
                Bewertung = "",
            });

        }
    }
}
