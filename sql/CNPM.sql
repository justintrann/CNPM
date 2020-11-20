--CREATE DATABASE CNPM_NHOM_1

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
	id_staff INT,
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
	id TINYINT NOT NULL UNIQUE IDENTITY(1,1), 
	product_type_name NVARCHAR(50) UNIQUE,
	product_type_desc NVARCHAR(100),

	CONSTRAINT pk_product_type_id PRIMARY KEY(id)
);
GO

CREATE TABLE AGE_RANGE
(
	id TINYINT NOT NULL UNIQUE IDENTITY(1,1), 
	age_range_name NVARCHAR(50) UNIQUE,

	CONSTRAINT pk_age_range_id PRIMARY KEY(id)
);

--gender: 0 = male, 1 = female
--age_range:
-- 1: 1-2 tuổi
-- 2: 3-5 tuổi
-- 3: 6-8 tuổi
-- 4: 9-11 tuổi
-- 5: trên 12 tuổi
CREATE TABLE PRODUCT
(
	id INT NOT NULL UNIQUE IDENTITY(1,1),
	id_type TINYINT,
	gender TINYINT DEFAULT(0),
	id_age_range TINYINT,
	product_name NVARCHAR(50) UNIQUE,
	price FLOAT,
	quantity INT CHECK (quantity >= 0),
	img_path VARCHAR(100),
	product_desc NVARCHAR(100),

	CONSTRAINT pk_product_id PRIMARY KEY(id),
	CONSTRAINT fk_product_id_type FOREIGN KEY(id_type) REFERENCES PRODUCT_TYPE(id),
	CONSTRAINT fk_product_id_age_range FOREIGN KEY(id_age_range) REFERENCES AGE_RANGE(id)
);
GO

CREATE TABLE STORAGE_HISTORY
(
	id_product INT NOT NULL,
	input_date SMALLDATETIME,
	quantity INT,

	CONSTRAINT fk_storage_history_id_product FOREIGN KEY(id_product) REFERENCES PRODUCT(id)
);
GO

/*
CREATE TABLE EXPORT_HISTORY
(
	id_product INT,
	input_date DATE,
	quantity INT,

	CONSTRAINT fk_storage_id_product FOREIGN KEY(id_product) REFERENCES PRODUCT(id)
);
GO
*/


CREATE TABLE PURCHASE_BILL
(
	id INT NOT NULL UNIQUE IDENTITY(1,1),
	id_staff INT,
	id_customer INT,
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
	id_bill INT,
	id_product INT NOT NULL,
	cost FLOAT,
	quantity INT,
	tt_cost float,

	CONSTRAINT fk_purchase_bill_detail_id_bill FOREIGN KEY(id_bill) REFERENCES PURCHASE_BILL(id),
	CONSTRAINT fk_purchase_bill_detail_id_product FOREIGN KEY(id_product) REFERENCES PRODUCT(id),
);
GO


/*
USE CNPM_NHOM_1
DROP TABLE STORAGE_HISTORY
DROP TABLE PURCHASE_BILL
DROP TABLE PURCHASE_BILL_DETAIL
DROP TABLE PRODUCT_TYPE
DROP TABLE AGE_RANGE
DROP TABLE PRODUCT
DROP TABLE ACCOUNT
DROP TABLE CUSTOMER
DROP TABLE STAFF
*/
