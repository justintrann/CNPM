USE CNPM_NHOM_1

--format MM/dd/YYYY
INSERT INTO STAFF VALUES
	(N'Dick Thunder', 123456789, '01/01/1991', N'11/11 Something ST., blablahblah, district 9', '111111111'),
	(N'Nguyễn Văn A', 9876543211, '06/09/1996', N'42/01/25/300/21 Đường Chân Trời, Phường 9, Quận 7', '111111112'),
	(N'Trần Văn B', 2135656849, '12/21/2001', N'11/11 Something St., blablahblah, district 9', '111111113'),
	(N'Captain Obvious', 2847591222, '06/15/1995', N'11/11 Something St., blablahblah, district 9', '111111114'),
	(N'Chad ThunderCock', 4206977713, '06/09/1990', N'11/11 LMAO St., too chad, district 6', '111111115');
GO

INSERT INTO CUSTOMER VALUES
	(N'Nguyễn Đức Tài', 0674584643, '01/31/1980', N'581 Annadale Ave.Lorain, OH 44052'),  
	(N'Santiago Rosario', 0887554322, '04/24/1967', N'8189 Alderwood Road Woodstock, GA 30188'),
	(N'Abbey Roy', 0777555432, '07/13/1990', N'971 Bridge Drive North Haven, CT 06473'),
	(N'John Doe', 066546432, '11/21/1979', N'8309 Mountainview Ave.Niles, MI 49120');
GO

INSERT INTO ACCOUNT VALUES
	(1, 'dickthunder', 'dickthunder', 0),
	(2, 'test', '123', 0),
	(3, 'helloworld', 'helloworld', 0),
	(null, 'admin', 'admin', 1);
GO

INSERT INTO PRODUCT_TYPE VALUES
	(N'Architecture', N'LEGO® Architecture presents some of the iconic buildings of world architecture.'),
	(N'City', N'LEGO® City is a realistic LEGO world for your child to explore.'),
	(N'Classic', N'Develop children’s creativity with LEGO® Classic.'),
	(N'Technic™', N'LEGO® Technic provides a real challenge for experienced LEGO builders.');
GO

INSERT INTO AGE_RANGE VALUES
	(N'1-2 tuổi'),
	(N'3-5 tuổi'),
	(N'6-8 tuổi'),
	(N'9-11 tuổi'),
	(N'trên 12 tuổi');
GO


-- template: (1,0,0,N'product_name', 0, 'resource/lego_placeholder.png', N'desc'),
INSERT INTO PRODUCT VALUES
	(1,1,3,N'Paris', 44.99, 100, 'resource/paris.png', N'Paris'),
	(1,0,3,N'London', 44.99, 100, 'resource/london.png', N'London'),
	(1,0,3,N'The White House', 89.99, 1, 'resource/whitehouse.png', N'This LEGO® Architecture display model of The White House.'),
	(1,0,3,N'Burj Khalifa', 44.99, 2, 'resource/burjkhalifa.png', N'Enjoy some quality time recreating a famous Dubai landmark.'),
	(2,1,1,N'Ocean Exploration Ship', 124.99, 3, 'resource/oceanexplorationship.png', 'Ocean Exploration Ship'),
	(2,1,2,N'Passenger Train', 119.99, 200,'resource/passengertrain.png', N'Passenger Train'),
	(2,0,2,N'Police Station', 89.99, 200,'resource/policestation.png', N'Police Station'),
	(2,0,2,N'Tuning Workshop', 89.99, 200,'resource/tuningworkshop.png', N'Tuning Workshop'),
	(3,1,1,N'LEGO® Large Creative Brick Box', 39.99, 200,'resource/legolargecreativebrickbox.png', N'LEGO® Large Creative Brick Box'),
	(3,1,4,N'Bricks and Lights', 24.99, 200,'resource/bricksandlights.png', N'Bricks and Lights'),
	(3,1,4,N'Bricks and Houses', 17.99, 200,'resource/bricksandhouses.png', N'Bricks and Houses'),
	(3,1,4,N'B6 ricks and Animals', 54.99, 200,'resource/bricksandanimals.png', N'Bricks and Animals'),
	(4,0,5,N'Land Rover Defender', 154.99, 200,'resource/landroverdefender.png', N'Land Rover Defender'),
	(4,0,5,N'Porsche 911 RSR', 89.99, 200,'resource/porsche911rsr.png', N'Porsche 911 RSR'),
	(4,0,5,N'Dom''s Dodge Charger', 89.99, 200,'resource/domsdodgecharger.png', N'Dom''s Dodge Charger'),
	(4,0,5,N'Ducati Panigale V4 R', 54.99, 200,'resource/ducatipanigalev4r.png', N'Ducati Panigale V4 R');
GO

INSERT INTO STORAGE_HISTORY VALUES
	(1, '11/10/2019 12:00:00', 10),
	(1, '12/10/2019 12:01:00', 10),
	(2, '9/10/2019 21:00:00', 10),
	(2, '11/11/2019 12:00:00', 10),
	(3, '12/11/2019 12:01:00', 10),
	(3, '9/11/2019 21:00:00', 10),
	(4, '11/12/2019 12:00:00', 10),
	(4, '12/21/2019 12:01:00', 10),
	(5, '9/30/2019 21:00:00', 10),
	(5, '11/22/2019 12:00:00', 10),
	(6, '12/1/2019 12:01:00', 10),
	(6, '9/1/2019 21:00:00', 10)
GO

INSERT INTO PURCHASE_BILL VALUES
	(2,1,N'2020-10-21 10:55:00','LEGO',100.0),
	(2,1,N'2020-10-22 10:55:00','LEGO',99.9),
	(2,1,N'2020-10-23 10:55:00','LEGO',54.99),
	(2,1,N'2020-9-10 10:55:00','LEGO',29.99),
	(2,1,N'2020-9-10 10:55:00','LEGO',29.99),
	(2,1,N'2020-8-10 10:55:00','LEGO',29.99),
	(2,1,N'2020-7-10 10:55:00','LEGO',29.99),
	(2,1,N'2019-10-10 10:55:00','LEGO',29.99),
	(2,1,N'2019-10-10 10:55:00','LEGO',29.99),
	(2,1,N'2019-10-10 10:55:00','LEGO',29.99),
	(2,1,N'2019-11-10 10:55:00','LEGO',29.99),
	(2,1,N'2019-11-10 10:55:00','LEGO',29.99),
	(2,1,N'2019-11-10 10:55:00','LEGO',29.99),
	(2,1,N'2019-12-10 10:55:00','LEGO',29.99),
	(2,1,N'2019-12-10 10:55:00','LEGO',29.99),
	(2,1,N'2020-12-10 10:55:00','LEGO',29.99),
	(2,1,N'2018-1-10 10:55:00','LEGO',69.99),
	(2,1,N'2018-1-10 10:55:00','LEGO',100.0),
	(2,1,N'2018-2-10 10:55:00','LEGO',229.99),
	(2,1,N'2018-2-10 10:55:00','LEGO',329.99),
	(2,1,N'2018-3-10 10:55:00','LEGO',459.99),
	(2,1,N'2018-3-10 10:55:00','LEGO',699.99),
	(2,1,N'2018-3-10 10:55:00','LEGO',339.99),
	(2,1,N'2018-3-10 10:55:00','LEGO',59.99)
GO


/* SELECT for debugging
SELECT * FROM STAFF
SELECT * FROM ACCOUNT
SELECT * FROM CUSTOMER
SELECT * FROM PRODUCT
SELECT * FROM PRODUCT_TYPE
SELECT * FROM AGE_RANGE
SELECT * FROM PURCHASE_BILL
SELECT * FROM PURCHASE_BILL_DETAIL
*/

/* DELETE for debugging
DELETE FROM ACCOUNT
DBCC CHECKIDENT (ACCOUNT, RESEED, 0)

DELETE FROM PRODUCT
DBCC CHECKIDENT (PRODUCT, RESEED, 0)

DELETE FROM PRODUCT_TYPE
DBCC CHECKIDENT (PRODUCT_TYPE, RESEED, 0)

DELETE FROM AGE_RANGE
DBCC CHECKIDENT (AGE_RANGE, RESEED, 0)

DELETE FROM STAFF
DBCC CHECKIDENT (STAFF, RESEED, 0)

DELETE FROM CUSTOMER
DBCC CHECKIDENT (CUSTOMER, RESEED, 0)

DELETE FROM STORAGE_HISTORY
*/
/*
delete 
from [STORAGE_HISTORY]
where id_product = 1
*/