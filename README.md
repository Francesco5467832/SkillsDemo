Verbesserungsvorschläge:

Warum nicht auf die branches geachtet (Git) ?

Warum nicht Entity Framework? DatabaseConnections-Klasse hat ~850 Zeilen code

View-Komponenten in xaml definieren

Beispiel: Datagrid oder Listview an die List<skill> binden (siehe Beispielprojekt)

Enum benutzen für Skilllevel -> kein switch nötig (Vorteil: Umwandlung in int möglich)

Mehrere Funktionen in ein Fenster bringen -> sonst sehr viele Fenster

List mit Typ skill benutzen. warum list int für skills?

Objekte benutzen (Employee, Skill)

Skills wiederholen sich (Bsp. C# ist mehrfach drin) -> Datanbankmodell evtl überarbeiten

Evtl eigene Klasse, die DatabaseConnections-Klassen aufruft

Ordnerstruktur Bsp:

Views

  - Window1
   
  - Window2
   
  - Window3
   
Models

   - Skill
   
   - Employee
   
DataBase

   - ...
