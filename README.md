# cergar-projects

Aplikacija je zamišljena kao jednostavna aplikacija koja korisniku omogućava unos studenata,
predmeta te vezanje studenta uz predmet.
Svi podaci kojima se barata u aplikaciji su spremljeni u database datoteku koja je sastavni dio
projekta. Baza se sastoji od tri tablice: Students, Predmets i StudentPredmets. Tablice su kreirane i
uređene (kreiranje primarnog i stranih ključeva, definiranje Identityja i tipova polja) kroz sučelje za
rad s bazama podataka unutar Visual Studio razvojnog alata. Sama aplikacija koristi Entity Framework
za baratanje podacima (čitanje, pisanje).
Aplikacija se sastoji od glavne forme koja korisnika dalje usmjerava na dvije zasebne forme –
Studente i Predmete. Unutar segmenta za studente, korisnik ima mogućnost pokretanja unosa
studenta ili pregleda studenta. Pregled studenata je kreiran kao DataGridView kako bi bio lako
promjenjiv u slučaju potrebe za proširenjem DataSeta koji je vezan uz njega.
Unutar segmenta za predmete, korisnik ima mogućnost pokretanja unosa predmeta, pregleda
predmeta ili povezivanja studenata s predmetom. Pregled predmeta je također kreiran kao
DataGridView. Povezivanje studenata s predmetima je napravljeno na način da se koriste dva
ListBoxa (po jedan za popis studenata i predmeta) iz kojih korisnik odabire predmet i studena koje
želi vezati.
