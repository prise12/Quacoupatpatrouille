Gestion d’une Caserne de Pompiers
1. Aperçu du Projet

Cette application desktop développée en C# avec Windows Forms (sous .NET), a pour vocation de simuler et d’optimiser la gestion quotidienne d’une caserne de pompiers.
Elle met à disposition une interface complète permettant d’administrer le personnel, les véhicules ainsi que les interventions, tout en s’appuyant sur une architecture propre et structurée séparant l’IHM, la logique métier et l’accès aux données.

2. Principales Fonctionnalités

Gestion du personnel : Création, édition et suppression des fiches pompiers, avec prise en compte des habilitations.

Gestion des véhicules : Suivi de la flotte (état, disponibilité, affectation).

Gestion des interventions : Enregistrement des incidents (type, lieu, description) et gestion des ressources affectées.

Attribution intelligente des ressources : Sélection automatique des pompiers et véhicules selon les compétences nécessaires et la nature de l’intervention.

Persistance des données :

Mode connecté : stockage via une base locale au format .db

Mode déconnecté : DataSet / XML

Génération de rapports : Création de comptes rendus d’interventions exportés en PDF dans le dossier comptes_rendus.

3. Technologies Employées

Langage : C#

Framework : .NET (Windows Forms)

Environnement conseillé : Visual Studio

Stockage des données : Base .db + gestion hors-ligne via DataSet

4. Équipe du Projet

Ce projet a été conçu et développé par :

Fabio GIORGI PANAZZOLO

Ferencz ROUDET

5. Licence

Ce projet est distribué sous licence MIT.

6. Structure du Projet

```text
.
├── README.md
├── SAE24
│   ├── App.config
│   ├── bin
│   ├── Connexion.cs
│   ├── GP1.cs
│   ├── GP1.Designer.cs
│   ├── GP1.resx
│   ├── login.cs
│   ├── login.Designer.cs
│   ├── login.resx
│   ├── mesDatas.cs
│   ├── NM.cs
│   ├── NM.Designer.cs
│   ├── NM.resx
│   ├── obj
│   ├── packages
│   ├── packages.config
│   ├── Program.cs
│   ├── Properties
│   ├── Resources
│   ├── SAE24.csproj
│   ├── SAE24.sln
│   ├── ST.cs
│   ├── ST.Designer.cs
│   ├── ST.resx
│   ├── TB.cs
│   ├── TB.Designer.cs
│   ├── TB.resx
│   ├── ucNav.cs
│   ├── ucNav.Designer.cs
│   ├── ucNav.resx
│   ├── VE.cs
│   ├── VE.Designer.cs
│   └── VE.resx
└── tree.txt
