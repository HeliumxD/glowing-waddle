# Lern-Bericht

Nicola Karrer

## Einleitung

Ich habe ein Spiel mit C# programmiert, wo das Programm eine zufällige Zahl generiert und man diese Zahl erraten muss.

## Was habe ich gelernt?

Ich habe gelernt, wie man die Zeit überprüfen kann und so die verbrauchte Zeit bei einem Spiel herausfinden kann.

## Beschreibung

Ich habe ein Spiel programmiert, wo das Programm eine zufällige Zahl zwischen 1 und einer selbst gewählten Zahl generiert
und man diese dann erraten muss. Dazu kamen dann noch ein paar features, doch eines war mir besonders wichtig. Die Zeit stellt erst
das Gefühl dar, eine Herausforderung zuhaben. Die Anzahl versuche sind eher auf Glück basiert, wobei man bei der Zeit Schnelligkeit und
Geschicklichkeit unter Beweis stellen muss.

Doch ich wusste nicht wie man die Zeit einliest und vergleichen kann oder sonst irgendetwas. Deshalb habe ich im Internet viele Seiten
angeschaut, aber keine konnte wirklich weiter helfen. Aus diesem Grund habe ich das Hilfsystem benutzt, um vielleicht etwas zufinden was
ich benutzen könnte und es half wirklich. Das Hilfsystem, wie ich es nenne, zeigt mögliche Anwendungen an, die man benutzen kann. Als
ich da nach Zeit-Anwendungen suchte, fand ich die Variable DateTime.

<img width="316" alt="Screenshot 2022-09-22 095302" src="https://user-images.githubusercontent.com/111045844/191698139-b3a82cf1-cc11-4bda-822b-be096a3c83b1.png">


Mit dieser Variable konnte ich die jetztige Zeit abfragen, womit ich auch meine Lösung kreierte. Ich las die Zeit am Anfang ab, wenn der
Spieler seine erste Zahl eingab und am Schluss, wenn er die zufällig generierte Zahl herausfand. Dann musste ich diese zwei Zeiten nur noch
subtrahieren und schon hatte ich die Zeit, die er verbraucht hatte. Zu dem habe ich es noch so konstruiert, dass es die schnellste Zeit speichert.

```Csharp
if (DateTime ende < DateTime rekord) {
  rekord = ende };
```

Am Ende wird diese Zeit auch angezeigt, dass dann so aussieht.

https://cdn.discordapp.com/attachments/1014560355931922463/1022440295771668571/ezgif.com-gif-maker.gif


## Verifikation

Im ersten Bild oben sieht man, wie ich herausgefunden habe, wie man die Zeit ablesen kann, da ich nichts im Internet finden konnte.
Im Gif sieht man dann, wie es angezeigt wird, wenn man die Zahl erraten hat.

# Reflexion zum Arbeitsprozess

Das Arbeiten ging bei mir gut. Ich hatte keine technischen Probleme und da ich nicht nach Baden musste, konnte ich auch länger schlafen, die meine
Motivation steigerte.

Dafür wurde ich immer sehr schnell abgelenkt, da ich direkt neben meinem PC arbeite.

**VBV**: Solange ich meinen PC ausgeschaltet lasse, sollte eigentlich auch nichts passieren können.
