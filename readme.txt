Hanna Bojadzic

Implementirani tipovi interakcija:
1.raycast (skripte RayProjekcija i Interakcija)
Detektovanje prilaza FirstPersonController-a krstu te smanjivanje osvjetljenja flashlight-a i eventualno izvlačenje šiljaka iz krsta.
2.trigger (skripte TriggerScripta1)
Prilikom ulaska u trigger opasno polje iz poda se dize celicna kugla sa iglicama i vrsi rotaciju.
Prilikom izlaska iz opasnog podrucja triggera rotacija se zaustavlja.
3.click (sve skripte za meni, ClickKamen )
ClickKamen: prilikom pritiska na pravi kamen ostvaraju se vrata(resetke) te nestaje collider i moze se proci u drugi dio sobe.
4.Promjena transform-a objekta (skoro sve skripte )
Rotacija celicne kugle sa siljcima, dizanje vrata, pomjeranje siljaka, rotacija i translacija novih objekata.
5.Korištenje lerpa (skripta SvjetloLerp)
Korištenje linearne interpolacije za lagano paljenje svijeca.
6.Instanciranje objekta kroz skriptu (skripta ScriptInstantiateObjectClick )
Klikom na odredjeni kamen pojavljuju se lubanje razlicitih pozicija na podu.
7.Reproduciranje i stopiranje video teksture (skripta VideoTexScript)
Unutar drvene kutije pojavljuje se video tekstura kao mala vatrena eksplozija

U igru je dodan i audio fajl te igra ima odgovarajuci zvuk. (Audio je skripanje, zatvaranje otvaranje vrata i sl)

Prva scena koja se pojavljuje je glavni meni. 
Za glavni meni odabrane su malo drugacije boje kako bi se naglasila razlika Glavnog menija i ostalog.

Opcije unutar menija:
play- pokretanje igre
exit- gasenje aplikacije
help- mala uputa za korisnika
highscore- daje najbolji highscore

Nakon istrazivanja sobe potrebno je uspjeti otvoriti vrata te naći kamen na zadnjem zidu ispod slike. 
Slika je osvjetljena, ovim je stavljen fokus na nju te igrac treba da obrati paznju na ovo, ona je fokalna tacka.
Nakon sto klikne na kamen, dobija pitanje vezano za tacku fokusa, tj sliku.
Ukoliko odgovori ispravno dobija poruku da je uspjesno zavrsio igricu, ukoliko ne odgovori dobija poruku "GameOver"

Implemetirano je vracanje na glavni meni esc tipkom.


