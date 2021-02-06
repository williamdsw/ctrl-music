
CREATE TABLE "address" (
	"id"	INTEGER NOT NULL,
	"street"	TEXT NOT NULL,
	"number"	TEXT NOT NULL,
	"complement"	TEXT,
	"zip_code"	TEXT NOT NULL,
	"city"	TEXT NOT NULL,
	"state"	TEXT NOT NULL,
	"country"	TEXT NOT NULL,
	"created_at"	REAL NOT NULL,
	"updated_at"	REAL NOT NULL,
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "provider" (
	"id"	INTEGER NOT NULL,
	"name"	TEXT NOT NULL,
	"identification"	TEXT NOT NULL,
	"address_id"	INTEGER,
	"created_at"	REAL NOT NULL,
	"updated_at"	REAL NOT NULL,
	PRIMARY KEY("id" AUTOINCREMENT),
	FOREIGN KEY("address_id") REFERENCES "address"("id")
);

CREATE TABLE "product" 
(
	"id"	INTEGER NOT NULL,
	"code"	TEXT NOT NULL,
	"name"	TEXT NOT NULL,
	"brand"	TEXT NOT NULL,
	"description"	TEXT,
	"price"	NUMERIC NOT NULL,
	"is_used"	INTEGER NOT NULL,
	"stock_quantity"	NUMERIC,
	"release_year"	INTEGER,
	"provider_id"	INTEGER NOT NULL,
	"created_at"	REAL NOT NULL,
	"updated_at"	REAL NOT NULL,
	PRIMARY KEY("id" AUTOINCREMENT),
	FOREIGN KEY("provider_id") REFERENCES "provider"("id")
);

CREATE TABLE "measures"
(
	"id"	INTEGER NOT NULL,
	"height"	NUMERIC NOT NULL,
	"width"	NUMERIC NOT NULL,
	"weight"	NUMERIC NOT NULL,
	"created_at"	REAL NOT NULL,
	"updated_at"	REAL,
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "accessory" 
(
	"id"	INTEGER NOT NULL,
	"instrument_type"	TEXT NOT NULL,
	"measures_id"	INTEGER,
	"product_id"	INTEGER NOT NULL,
	FOREIGN KEY("product_id") REFERENCES "product"("id"),
	FOREIGN KEY("measures_id") REFERENCES "measures"("id"),
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "instrument" 
(
	"id"	INTEGER NOT NULL,
	"type"	TEXT NOT NULL,
	"measures_id"	INTEGER,
	"product_id"	INTEGER NOT NULL,
	FOREIGN KEY("product_id") REFERENCES "product"("id"),
	FOREIGN KEY("measures_id") REFERENCES "measures"("id"),
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "media" 
(
	"id"	INTEGER NOT NULL,
	"genres"	TEXT NOT NULL,
	"artist"	TEXT NOT NULL,
	"duration"	TEXT NOT NULL,
	"languages"	TEXT,
	"measures_id"	INTEGER,
	"product_id"	INTEGER NOT NULL,
	FOREIGN KEY("product_id") REFERENCES "product"("id"),
	FOREIGN KEY("measures_id") REFERENCES "measures"("id"),
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "employee"
(
	"id"	INTEGER NOT NULL,
	"name"	TEXT NOT NULL,
	"identification"	TEXT NOT NULL,
	"phone_number"	TEXT,
	"email"	TEXT,
	"birth_date"	REAL NOT NULL,
	"created_at"	REAL NOT NULL,
	"updated_at"	REAL NOT NULL,
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "user"
(
	"id"	INTEGER NOT NULL,
	"name"	TEXT NOT NULL,
	"password"	TEXT NOT NULL,
	"role"	TEXT NOT NULL,
	"employee_id"	INTEGER NOT NULL,
	"birth_date"	REAL NOT NULL,
	"created_at"	REAL NOT NULL,
	"updated_at"	REAL NOT NULL,
	FOREIGN KEY("employee_id") REFERENCES "employee"("id"),
	PRIMARY KEY("id" AUTOINCREMENT)
);