CREATE TABLE "Products" (
	"Id"	INTEGER,
	"Name"	TEXT NOT NULL,
	"Description"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
);


-- SQLite
CREATE TABLE "Categories" (
	"Id"	TEXT,
	"Name"	TEXT NOT NULL,
	"Description"	TEXT,
	PRIMARY KEY("Id")
);

insert into Categories (Id, Name, Description)
Values ("27f9f112-1b4c-44b9-8ed9-2abdc351d005", "Cat gp", "Desc gp")