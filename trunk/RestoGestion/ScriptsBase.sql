CREATE TABLE "Plats" (
"PlatCode" VARCHAR PRIMARY KEY  NOT NULL , 
"PlatNom" VARCHAR NOT NULL , 
"PlatPrix" NUMERIC NOT NULL  DEFAULT 0, 
"PlatTva" NUMERIC NOT NULL  DEFAULT 0
);

CREATE TABLE "Clients" (
"ClientId" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 
"ClientNom" VARCHAR NOT NULL , 
"ClientPrenom" VARCHAR NOT NULL , 
"ClientAdresse" VARCHAR NOT NULL , 
"ClientCP" VARCHAR NOT NULL , 
"ClientVille" VARCHAR NOT NULL , 
"ClientTelephone" VARCHAR NOT NULL , 
"ClientRemarque" VARCHAR NOT NULL 
);

CREATE TABLE "Commandes" (
"TableId" INTEGER NOT NULL , 
"PlatCode" VARCHAR NOT NULL , 
"CmdeQte" INTEGER NOT NULL , 
PRIMARY KEY ("TableId", "PlatCode")
);

CREATE TABLE "Configuration" (
"Parameter" VARCHAR PRIMARY KEY  NOT NULL , 
"Value" VARCHAR NOT NULL 
);

CREATE TABLE "HistoTables" (
"HistoTableDate" DATETIME PRIMARY KEY  NOT NULL  DEFAULT CURRENT_TIMESTAMP, 
"HistoTableName" VARCHAR NOT NULL , 
"HistoTableCouvert" VARCHAR NOT NULL , 
"HistoTableRemise" NUMERIC NOT NULL  DEFAULT 0
);

CREATE TABLE "HistoCommandes" (
"HistoTableDate" DATETIME NOT NULL ,
"HistoPlatCode" VARCHAR NOT NULL ,
"HistoPlatNom" VARCHAR NOT NULL , 
"HistoPlatPrix" NUMERIC NOT NULL  DEFAULT 0, 
"HistoPlatTva" NUMERIC NOT NULL  DEFAULT 0,
"HistoCmdeQte" INTEGER NOT NULL , 
PRIMARY KEY ("HistoTableDate", "HistoPlatCode")
);

CREATE TABLE "Tables" (
"TableId" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 
"TableLeft" INTEGER NOT NULL , 
"TableTop" INTEGER NOT NULL , 
"TableWidth" INTEGER NOT NULL , 
"TableHeight" INTEGER NOT NULL , 
"TableName" VARCHAR NOT NULL , 
"TableEnable" INTEGER NOT NULL , 
"TableCouvert" VARCHAR NOT NULL , 
"TableRemise" NUMERIC NOT NULL DEFAULT 0
);