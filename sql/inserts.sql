INSERT INTO address
(street, number, complement, zip_code, city, state, country, created_at, updated_at)
VALUES
('Street', '123', NULL, '000000', 'Los Angeles', 'California', 'United States Of America', datetime('now'), datetime('now'));

INSERT INTO provider
(name, identification, address_id, created_at, updated_at)
VALUES
('Bill Store', 'BILSTO', 3, datetime('now'), datetime('now'));

INSERT INTO "product"
("code", "name", "brand", "description", "price", "is_used", "stock_quantity", "provider_id", "created_at", "updated_at")
VALUES 
('ACC0000000001', 'Red Pick', 'Renzik', 'A red pick', 0.99, 0, 1000, 2, datetime('now'), datetime('now'));

INSERT INTO "main"."accessory"
("instrument_type", "product_id")
VALUES ('Guitar', 1);