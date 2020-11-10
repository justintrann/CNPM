﻿CREATE DATABASE CNPM_NHOM_1

USE CNPM_NHOM_1

CREATE TABLE STAFF
(
	id INT NOT NULL UNIQUE IDENTITY(1,1),
	staff_name NVARCHAR(50),
	phone_number VARCHAR(12),
	date_of_birth DATE,
	home_address NVARCHAR(100),
	citizen_id VARCHAR(12),

	CONSTRAINT pk_staff_id PRIMARY KEY(id)
);
GO

CREATE TABLE CUSTOMER
(
	id INT NOT NULL UNIQUE IDENTITY(1,1),
	customer_name NVARCHAR(50),
	phone_number VARCHAR(12),
	date_of_birth DATE,
	home_address NVARCHAR(100),

	CONSTRAINT pk_customer_id PRIMARY KEY(id)
);
GO

CREATE TABLE ACCOUNT
(
	id INT NOT NULL UNIQUE IDENTITY(1,1),
	id_staff INT UNIQUE,
	username VARCHAR(20) UNIQUE,
	pass VARCHAR(20),
	is_admin TINYINT,

	CONSTRAINT pk_account_id PRIMARY KEY(id),
	CONSTRAINT fk_account_id_staff FOREIGN KEY(id_staff) REFERENCES STAFF(id)
);
GO

--id này nên tự nhập tay để đỡ lỗi
CREATE TABLE PRODUCT_TYPE
(
	id INT NOT NULL UNIQUE, 
	product_type_name NVARCHAR(50),
	product_type_desc NVARCHAR(100) ,

	CONSTRAINT pk_product_type_id PRIMARY KEY(id)
);
GO

--gender: 0 = male, 1 = female
--age_range:
-- 0: 1-2 tuổi
-- 1: 3-5 tuổi
-- 2: 6-8 tuổi
-- 3: 9-11 tuổi
-- 4: trên 12 tuổi
CREATE TABLE PRODUCT
(

	id_type INT NOT NULL,
	gender INT,
	age_range INT,
	product_name NVARCHAR(50),
	price FLOAT,
	img_path VARCHAR(100),
	product_desc NVARCHAR(100),

	CONSTRAINT fk_product_id_type FOREIGN KEY(id_type) REFERENCES PRODUCT_TYPE(id)
);
GO

CREATE TABLE STORAGE
(
	id_type INT NOT NULL,
	id_product INT NOT NULL,
	quantity INT,
	price FLOAT,
	input_date DATE,

	CONSTRAINT fk_storage_id_type FOREIGN KEY(id_type) REFERENCES PRODUCT_TYPE(id),
	CONSTRAINT pk_storage_id PRIMARY KEY(id_product) 
	
);
GO

CREATE TABLE PURCHASE_BILL
(
	id INT NOT NULL UNIQUE IDENTITY(1,1),
	id_staff INT NOT NULL,
	id_customer INT NOT NULL,
	date_of_purchase DATETIME,
	purchase_bill_desc NVARCHAR(100),
	total_cost FLOAT,

	CONSTRAINT pk_purchase_bill_id PRIMARY KEY(id),
	CONSTRAINT fk_purchase_bill_id_staff FOREIGN KEY(id_staff) REFERENCES STAFF(id),
	CONSTRAINT fk_purchase_bill_id_customer FOREIGN KEY(id_customer) REFERENCES CUSTOMER(id)
);
GO

CREATE TABLE PURCHASE_BILL_DETAIL
(
	id_bill INT NOT NULL,
	id_product INT NOT NULL,
	quantity INT,
	cost FLOAT,

	CONSTRAINT fk_purchase_bill_detail_id_bill FOREIGN KEY(id_bill) REFERENCES PURCHASE_BILL(id),
	CONSTRAINT fk_purchase_bill_detail_id_product FOREIGN KEY(id_product) REFERENCES STORAGE(id_product),
);
GO


/*
DROP TABLE STORAGE
DROP TABLE PURCHASE_BILL
DROP TABLE PURCHASE_BILL_DETAIL
DROP TABLE PRODUCT_TYPE
DROP TABLE PRODUCT
DROP TABLE ACCOUNT
DROP TABLE CUSTOMER
DROP TABLE STAFF
*/