# Grupa4-Reservations

## Aplikacija za rezervaciju događaja u noćnom klubu - *Night algorithm*

### Opis teme:
Aplikacija za rezervaciju aktuelnih događaja u ugostiteljskom objektu. Omogućava kako zakazivanje događaja tako i obavještavanje korisnika o istim i njihovu rezervaciju. 
Olakšava organizaciju događaja, njihovo promovisanje i komunikaciju između organizatora i klijenta.

### Procesi:
#### Registracija korisnika:
Pri upotrebi aplikacije korisnik se treba registrovat unošenjem svojih ličnih podataka nakon čega dobiva mogućnost korištenja aplikacije ili odabire opciju da poveže svoj račun sa nekom od postojećih društvenih mreža (google, facebook) čime se preskače proces unošenja ličnih podataka. Korisnik je obavezan navesti starosnu dob i spol. Korisnik također ima opciju upload-a profilne fotografije koju može i naknadno promijeniti nakon čega će doći notifikacija ostalim korisnicima s njegove liste prijatelja da je to učinio. Nakon toga, navodi se lista interesovanja u vidu hashtag-a (koja se naknadno može i modifikovati) na osnovu kojih se filtriraju događaji koji se prikazuju. 
Korisnik bez registracije ima samo uvid u aktuelne događaje, bez mogućnosti rezervisanja stola ili uvida koje osobe idu na taj događaj.

#### Interakcija s drugim korisnicima:
Mogućnost dodavanja drugih korisnika aplikacije na listu prijatelja pomoću njihovog username-a/e-mail čime se dobiva mogućnost pozivanja prijatelja s liste na događaje te pregled događaja na koji su prijatelji prijavljeni. Korisnik također dobiva notifikaciju kada se prijatelj s njegove liste prijavi na neki događaj.
Registracija organizatora događaja/vlasnika objekta:
Vlasnik objekta dobiva posebne login podatke i ulogu administratora čime postaje ovlašten za kreiranje događaja i njihovo brisanje. Vlasnik objekta ima uvid u broj prijavljenih osoba i rezervacije stolova  za svaki događaj. 

#### Registracija događaja / Otkazivanje događaja:
Registraciju događaja ima pravo izvršiti samo admin. Potrebno je popuniti podatke o događaju (naziv, tip događaja, vrijeme održavanja, detaljan opis događaja), posebne napomene ako ih ima, te opcionalno postaviti dobno ograničenje korisnika koji mogu prisustvovati događaju. Kreiranje novog događaja podrazumijeva navođenje specifikatora na osnovu kojih se odlučuje kojim korisnicima će događaj biti prikazan na dijelu za preporučene događaje. Specifikatori podrazumijevaju hashtag-e, dob korisnika i spol. Na osnovu ovoga korisnici dobivaju notifikacije o nadolazećim događajima iz njihove grupe interesovanja. Notifikacije se isključivo mogu slati do 1h prije početka događaja.

#### Prijava na događaj / Otkazivanje rezervacije za događaj:
Korisnik se prijavljuje na događaj na način da odabere događaj koji želi, a zatim odabere za koliko osoba rezerviše događaj te opcionalno navede neku napomenu ako je ima. Korisnik također može vidjeti i sve njegove prijatelje koji idu na isti događaj. Zatim se prikazuje tlocrt prostora gdje su crvenom bojom označeni već zauzeti stolovi, a zelenom bojom označeni slobodni. Korisnik odabire sto koji želi. Ukoliko korisnik ne ispunjava uslov dobnog ograničenja, dobit će upozorenje, te mu rezervacija neće biti prihvaćena. Nakon uspješne rezervacije korisnik dobiva notifikaciju da je rezervacija prihvaćena i QR kod koji se skenira drugim uređajem prilikom dolaska na događaj te se šalje potvrda dolaska na server što predstavlja validaciju njegovog dolaska. Također korisnik u bilo kojem trenutku može otkazati rezervaciju.

### Funkcionalnosti:
* Mogućnost prijave na aplikaciju sa različitim ulogama
* Lista prijatelja: korisnik može dodati ostale korisnike na svoju listu pomoću njihovog username-a; dodani korisnici mogu prihvatiti ili odbiti taj zahtjev; prihvatanjem zahtjeva međusobno postaju prijatelji
* Korisnik dobiva “recommended” dio koji se filtrira na osnovu hashtag-a (korisnikovih interesovanja)
* Korisnik na profilu prijatelja vidi sve događaje na koje je taj prijatelj prijavljen
* Upload profilne fotografije korisnika
* Dobivanje notifikacija: korisnik dobiva obavještenje kada ga neko doda na listu prijatelja; obavještenje o skorom početku događaja na koji se prijavio; obavještenje za događaje na osnovu njegovih interesovanja; obavještenje kada prijatelj promijeni profilnu fotografiju; obavještenje kada se prijatelj prijavi na neki događaj
* Ograničenje o dolasku notifikacije do 1h prije početka događaja
* Uvid u slobodne stolove prilikom rezervacije
* Ne prihvatanje rezervacije korisnika ukoliko se prijavio na događaj za koji ne ispunjava uslove dobnog ograničenja
* Registracija na događaj
* CRUD mogućnost nad korisničkom i administratorskom ulogom
* Registracija događaja s administratorskom ulogom
* Skener koji potvrđuje dolazak korisnika (mušterije)
* Filtriranje aktivnosti po hashtag-u
* Ažuriranje/brisanje događaja kao administrator
* Uvid u interesovanje prijatelja za događaj (koji prijatelji idu na koji događaj)
* Neregistrovani korisnik ima mogućnost uvida u aktuelne događaje
* Ograničenje za neregistrovane korisnike da ne mogu rezervisati stol ili vidjeti koliko i koje osobe idu na neki događaj


### Akteri:
**Administrator/vlasnik objekta** - osoba koja ima mogućnost kreiranja eventa, njegovog modifikovanja, promocije i otkazivanja. Ima uvid u broj registrovanih korisnika na aplikaciji, broj rezervacija, broj otkazanih rezervacija i broj osoba koji je prisustvovao događaju. 

**Korisnik** - ima uvid u nadolazeće događaje, postavlja kriterije na osnovu kojih se događaji filtriraju i prikazuju u recommended sekciji, dobiva notifikacije koje mu omogućavaju lakše praćenje događaja, uvid u nerezervisana mjesta, te mogućnost rezervacije mjesta po želji, kao i otkazivanje rezervacije u bilo kojem trenutku,mogućnost praćenja aktivnosti drugog korisnika njegovim dodavanjem na friend-listu.

**Neregistrovani korisnik** - ima uvid u aktuelne događaje u objektu.

**Uređaj za skeniranje** - skenira QR kod prilikom dolaska korisnika (mušterije) na događaj, a zatim šalje odgovarajuću informaciju bazi.


### *Članovi tima:*
*Adna Nuspahić, Emin Šarak, Amna Trčalo*







