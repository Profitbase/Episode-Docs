# Profitbase – Kontantstrøm med Planner

**Dokument:** Kontantstrøm med Planner  
**Dato:** 10.10.2022  
**Språk:** Norsk  
**Produkt:** Profitbase Planner  

---

## Hvordan bruke dokumentet

Dette er ikke et les-og-nikk-dokument.

Riktig måte å bruke det på:
- Sitt med **en aktiv modell**
- Kjør **én motor av gangen**
- Start med *alt avslått*, og aktiver funksjoner stegvis
- Følg **én sourcetrans** og les tilhørende **target-transaksjoner**

Alle eksempler forutsetter at du faktisk ser på dataene i SQL eller Designer.

---

## Felles prinsipper i Planner

Alle target-transaksjoner er beriket med tekniske metadata for sporbarhet:

- **SYS_TransGeneratorID**  
  Viser hvilken motor som har generert transaksjonen (Sales, Purchase, Payroll osv.)

- **AccTypeID**  
  - `pl` = Resultat  
  - `bal` = Balanse  

- **SimItemID**  
  Forteller *hva slags hendelse* transaksjonen representerer  
  Eksempler: Sales, SalesDue, VATDue, Payroll, LoanPrincipal

- **AccountKeyID**  
  Systemteknisk kontonavn som gjør rapporter uavhengige av kontoplan

---

## Kassekreditt som systemkonto

All kontantstrøm posteres mot én felles systemkonto:

**CashLineOfCredit**

Denne representerer:
- Kasse/bank (eiendel) **og**
- Kassakreditt (gjeld)

Derfor brukes aldri begrepene øke/redusere konsekvent her, kun:
- Penger inn (+)
- Penger ut (−)

---

## Tre sentrale datoer

Planner opererer alltid med tre datoer:

- **TransDate** – når kostnad/inntekt oppstår
- **BillingDate** – når faktura bokføres
- **DueDate** – når betaling skjer

Forskjellen mellom disse er kjernen i kontantstrømlogikken.

---

## Salg (Sales)

### Grunnflyt uten tidsavgrensing

1. **TransDate**
   - Inntekt øker (−)
   - Kundefordring øker (+)

2. **DueDate**
   - Penger inn (+) på CashLineOfCredit
   - Kundefordring reduseres (−)

---

### Accrued (tidsavgrensing)

Når fakturadato ≠ transdato:
- Inntekt bokføres på TransDate
- Midlertidig motkonto: *Påløpt ikke fakturert*
- Fakturering og forfall skjer senere

---

### Merverdiavgift (MVA)

- Styres av **BillingDate**
- Avsettes i balanse
- Forfaller etter definerte terminer

SimItemID:
- SalesVAT
- VATEnd
- VATDue

---

### Kreditt, kontantandel og spredning

Støttede mekanismer:
- Kontantandel (%)
- Antall dager kreditt
- Spread over flere dager
- Månedlig kredittfordeling (IsCreditByMonth)

**Overstyringer på Trans-nivå trumfer alt.**

---

## Varekjøp (Purchase)

Samme struktur som salg, men med motsatt fortegn.

- Lagerkjøp → balanse
- Kjøp til forbruk → resultat

MVA, toll, frakt og kreditt følger samme terminlogikk.

---

## Lønn (Payroll)

Hovedprinsipp:
- Lønn bokføres normalt etter **kontantprinsippet**

Inkluderer:
- Lønn
- Skattetrekk
- Feriepenger
- Arbeidsgiveravgift
- Pensjon

Alle avgifter styres av egne terminoppsett.

---

## Andre driftskostnader (Expense)

- Resultatføres på TransDate
- Betaling skjer på DueDate
- Kan tidsavgrenses med Accrued
- Kan ha MVA og arbeidsgiveravgift

---

## Anleggsmidler (FixedAssets)

Støtter:
- Lineær og saldoavskrivning
- Overstyring av akkumulerte avskrivninger
- Avhendelse med gevinst/tap
- MVA på salg

---

## Investeringer (Investment)

Håndterer:
- Kjøp og aktivering
- Import med toll og MVA
- Avskrivninger
- Finansiering via lån

---

## Lån (Loan)

Støtter:
- Serie- og annuitetslån
- Ballonglån
- Inn- og utlån
- Renter, avdrag og gebyrer

Alle poster gir kontantstrøm via CashLineOfCredit.

---

## Inngående balanse med forfall (OBDue)

Brukes når IB-poster skal få fremtidige betalinger.

Støtter:
- Avgifter (MVA, AGA, skattetrekk)
- Fordringer
- Gjeld
- Spredning over flere datoer
- Årlige forfall

---

## Kort finans (ShortTermCash)

Beregner renter på daglig saldo basert på:
- Inngående balanse
- All kontantstrøm fra øvrige motorer

Støtter:
- Renteinntekt
- Rentekostnad
- Kredittrammer
- Overutnyttelse
- Kapitalisering

---

## Misc – manuelle posteringer

Gir full frihet, ingen sikkerhetsnett.

Brukes til:
- Korrigeringer
- Omgrupperinger
- Egenkapitalbevegelser

**Bruker er 100% ansvarlig for korrekt bokføring.**

---

## Kort sagt

- Kontantstrøm i Planner er deterministisk, ikke magisk
- Alt styres av datoer, fortegn og terminer
- Overstyringer på Trans-nivå vinner alltid
- CashLineOfCredit er navet i hele modellen

Dette dokumentet er referansen for å forstå *hvorfor* tallene beveger seg slik de gjør.
