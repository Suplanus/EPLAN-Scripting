<img src="https://eep8a.de/v3/img/cover.jpg" alt="EPLAN Electric P8 automatisieren - Cover" style="width: 100%; max-width: 300px;"/>

**EPLAN Electric P8 automatisieren**

_Grundlagen und Beispiele zum Erstellen von Scripten in C#_

[Website zum Buch: eep8a.de](https://eep8a.de)


### Klappentext

Kennst du die wiederkehrenden Aufgaben, die viel Zeit bei der Projektierung benötigen? Es gibt gute Nachrichten. Viele dieser Aufgaben kannst du per Script automatisieren. Dieses Buch richtet sich an EPLAN-Anwender und -Administratoren, die mithilfe von Scripting ihren Workflow beschleunigen möchten, um mehr Zeit für wesentliche Aufgaben zu gewinnen.

Zu Beginn erfährst du, wie du das Menüband ohne Programmierung individuell anpasst. Im Folgenden wirst du in die Erstellung von Scripten mit C# eingeführt. Die Komplexität der Programmierung wird niedrig gehalten, sodass auch Einsteiger folgen können.

Im Buch werden u. a. folgende Scriptfunktionen behandelt:

- Ribbons erzeugen
- Einzelne oder mehrere Einstellungen gleichzeitig per Knopfdruck verändern
- User Interfaces mit individuellen Steuerelementen (Checkboxen, Ladebalken, Buttons) erstellen
- Programmsteuerung über Benutzer-Interaktionen u. v. m.
- Austausch von Daten mit Fremdsystemen
- Artikel verändern

Diese Auflage berücksichtigt die Neuerungen in Version 2022 von EPLAN Electric P8 sowie in Visual Studio 2022. Zu den überarbeiteten Themen zählen die Erstellung von Menübändern mit selbst gewählten EPLAN-Aktionen sowie die Erstellung von Ribbons mit individualisierten Befehlen.

Darüber hinaus erlernst du das automatisierte Erzeugen von Beschriftungen und PDFs sowie den Import/Export von Stücklisten und Projekteigenschaften. Zudem erfährst du, wie Daten über gängige Austauschformate (CSV, XML) in andere Programme exportiert werden. Das Kapitel „Praxisbeispiele“, das sofort einsetzbare Scripte enthält, rundet den Inhalt ab. Auf [plus.hanser-fachbuch.de](https://plus.hanser-fachbuch.de/) und [eep8.de](https://eep8a.de/) findest du kostenloses digitales Zusatzmaterial: Das komplette Projekt mit allen Beispielen und Scripten, die du direkt in EPLAN verwenden kannst, steht dort zur Verwendung bereit.



### Vorwort

Liebe Leserin, lieber Leser,

mit diesem Buch möchte ich dir einen einfachen Einstieg in die Erstellung von Scripten für EPLAN Electric P8 ermöglichen. Das Buch richtet sich an alle EPLAN-Anwender:innen, ganz gleich, ob es sich dabei um regelmäßige oder sporadische Konstrukteur:innen handelt, die mithilfe von Scripting ihre Aufgaben automatisieren wollen. Programmierkenntnisse werden nicht vorausgesetzt. Du wirst erstaunt sein, wie schnell dabei ein Resultat zustande kommt, das dich begeistert. Schon mit einem kleinen Script, das aus nur ein paar Zeilen besteht, kannst du viel Zeit bei der Projektierung sparen. Auf Grundlage der im Buch vermittelten Informationen wirst du rasch imstande sein, EPLAN-Aktionen zu verwenden und gegebenenfalls zu erweitern. Darüber hinaus lernst du auch, eigene Erweiterungen zu programmieren. Scripte können ab der Lizenz EPLAN Electric P8 Compact genutzt werden. Das API-Modul ist dafür nicht erforderlich.

Im Script, wie in der Programmierung selbst, ist vieles, wenn nicht sogar alles, möglich. Deshalb stellt sich die Frage, in welchem Umfang dieses Buch das Themenfeld abdecken kann. Die Sprache C#, die zum Erstellen der Scripte verwendet wird, ist sehr komplex, und mit ihrer Beschreibung allein könnte man mehrere Tausend Seiten füllen, ohne irgendeine EPLAN-Funktion zu erklären. Aus diesem Grund beschränke ich mich darauf, die Grundlagen von C# zu vermitteln, die notwendig sind, um neue Scripte zu erstellen oder bestehende zu erweitern bzw. zu verändern. Auch auf die wichtigsten Erweiterungen durch eigenen Programmcode gehe ich ein.

Alle EPLAN-Aktionen werden anhand von praxisnahen Beispielen beschrieben und erklärt. Viele der Beispiele werden deinen Workflow beschleunigen. Hinzu kommt, dass mehr Zeit für die wesentlichen Aufgaben der Konstruktion bleibt. Jeder kennt die wiederkehrenden, monotonen Aufgaben, die z. B. beim Projektabschluss anstehen. Es müssen viele Auswertungen und Beschriftungen erzeugt werden. Zusätzlich muss der Plan als PDF erstellt werden. All dies kannst du per Knopfdruck erledigen. Wie? Das wird Schritt für Schritt im Buch erklärt.

An dieser Stelle möchte ich mich recht herzlich bei allen bedanken, die mir geholfen haben, dieses Buch zu schreiben.

Allen voran danke ich meiner Frau Daniela für die Motivation, das Buch zu schreiben, und die Unterstützung, genügend Zeit dafür zu finden. Vielen Dank auch an meine wundervollen Töchter Leni & Fina für die erfreulichen Unterbrechungen und Ablenkungen beim Schreiben.

Großer Dank geht an meinen Chef, Kollegen und Freund Michael Kastl für die Freiheit, dieses Buch zu schreiben. Ich danke auch meinen Kollegen Daniel Papp und Stefan Gorbach für die grandiose Zusammenarbeit.

Ein besonderer Dank gilt Herrn Andreas Krämer für seine sehr guten Hilfestellungen.

Zu guter Letzt möchte ich mich bei den Mädels vom Carl Hanser Verlag, Julia Stepp und Rebecca Wehrmann, für die Unterstützung bedanken.

<img src="https://eep8a.de/v3/img/Bild.png" alt="Johann Weiher" width=300/>
<img src="https://eep8a.de/v3/img/Unterschrift.png" alt="Unterschrift" width=280/>



### Autorenvita

Johann Weiher arbeitet als Consultant bei der Firma [ibKastl](https://ibkastl.de) und betreut Kunden rund um das Thema EPLAN.
Zusätzlich programmiert er kundenindividuelle Software im Enterprise-Bereich.

Der EPLAN-Community ist er aufgrund seines Blogs [Suplanus.de](https://suplanus.de) zum Thema "Scripting in EPLAN" bekannt.


### Auflagen
Es handelt sich hier um die Dokumentation zur dritten Auflage (2022). Dokumentation der vorherigen Auflagen:

- [Auflage 1 (2011)](https://github.com/Suplanus/EPLAN-Electric-P8-automatisieren/archive/refs/tags/v1.0.zip)
- [Auflage 2 (2018)](https://eep8a.de/v2)
