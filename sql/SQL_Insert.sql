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
	(1, N'Architecture', N'LEGO® Architecture presents some of the iconic buildings of world architecture.'),
	(2, N'City', N'LEGO® City is a realistic LEGO world for your child to explore.'),
	(3, N'Classic', N'Develop children’s creativity with LEGO® Classic.'),
	(4, N'Technic™', N'LEGO® Technic provides a real challenge for experienced LEGO builders.');
GO

-- template: (1,0,0,N'product_name', 0, '../resouce/lego_placeholder.png', N'desc'),
INSERT INTO PRODUCT VALUES
	(1,1,2,N'Paris', 44.99, 100, '../resouce/lego_placeholder.png', N'Paris'),
	(1,0,2,N'London', 44.99, 100, '../resouce/lego_placeholder.png', N'London'),
	(1,0,2,N'The White House', 89.99, 1, '../resouce/lego_placeholder.png', N'This LEGO® Architecture display model of The White House.'),
	(1,0,2,N'Burj Khalifa', 44.99, 2, '../resouce/lego_placeholder.png', N'Enjoy some quality time recreating a famous Dubai landmark.'),
	(2,1,0,N'Ocean Exploration Ship', 124.99, 3, '../resouce/lego_placeholder.png', 'Ocean Exploration Ship'),
	(2,1,1,N'Passenger Train', 119.99, 200,'../resouce/lego_placeholder.png', N'Passenger Train'),
	(2,0,1,N'Police Station', 89.99, 200,'../resouce/lego_placeholder.png', N'Police Station'),
	(2,0,1,N'Tuning Workshop', 89.99, 200,'../resouce/lego_placeholder.png', N'Tuning Workshop'),
	(3,1,0,N'LEGO® Large Creative Brick Box', 39.99, 200,'../resouce/lego_placeholder.png', N'LEGO® Large Creative Brick Box'),
	(3,1,3,N'Bricks and Lights', 24.99, 200,'../resouce/lego_placeholder.png', N'Bricks and Lights'),
	(3,1,3,N'Bricks and Houses', 17.99, 200,'../resouce/lego_placeholder.png', N'Bricks and Houses'),
	(3,1,3,N'B6 ricks and Animals', 54.99, 200,'../resouce/lego_placeholder.png', N'Bricks and Animals'),
	(4,0,4,N'Land Rover Defender', 154.99, 200,'../resouce/lego_placeholder.png', N'Land Rover Defender'),
	(4,0,4,N'Porsche 911 RSR', 89.99, 200,'../resouce/lego_placeholder.png', N'Porsche 911 RSR'),
	(4,0,4,N'Dom''s Dodge Charger', 89.99, 200,'../resouce/lego_placeholder.png', N'Dom''s Dodge Charger'),
	(4,0,4,N'Ducati Panigale V4 R', 54.99, 200,'../resouce/lego_placeholder.png', N'Ducati Panigale V4 R');
GO
/* SELECT for debugging
SELECT * FROM STAFF
SELECT * FROM ACCOUNT
SELECT * FROM CUSTOMER
SELECT * FROM PRODUCT
SELECT * FROM PRODUCT_TYPE
*/

/* DELETE for debugging
DELETE FROM ACCOUNT
DELETE FROM PRODUCT
DELETE FROM PRODUCT_TYPE
DELETE FROM STAFF
DELETE FROM CUSTOMER
*/