CREATE DATABASE CNPM_NHOM_1

USE CNPM_NHOM_1

CREATE TABLE STAFF
(
	id INT NOT NULL UNIQUE IDENTITY,
	staff_name TEXT,
	phone_number VARCHAR(12),
	date_of_birth DATE,
	home_address TEXT,
	citizen_id varchar(12),

	CONSTRAINT pk_staff_id PRIMARY KEY(id)
);
GO

CREATE TABLE CUSTOMER
(
	id INT NOT NULL UNIQUE IDENTITY,
	customer_name TEXT,
	phone_number VARCHAR(12),
	date_of_birth DATE,
	home_address TEXT,

	CONSTRAINT pk_customer_id PRIMARY KEY(id)
);
GO

CREATE TABLE ACCOUNT
(
	id INT NOT NULL UNIQUE IDENTITY,
	id_staff INT UNIQUE,
	username VARCHAR(20) UNIQUE,
	pass VARCHAR(20),
	is_admin TINYINT,

	CONSTRAINT pk_account_id PRIMARY KEY(id),
	CONSTRAINT fk_account_id_staff FOREIGN KEY(id_staff) REFERENCES STAFF(id)
);
GO

CREATE TABLE PRODUCT_TYPE
(
	id INT NOT NULL UNIQUE IDENTITY,
	product_type_name TEXT,
	product_type_desc TEXT,

	CONSTRAINT pk_product_type_id PRIMARY KEY(id)
);
GO

CREATE TABLE PRODUCT
(
	id INT NOT NULL UNIQUE IDENTITY,
	id_type INT,
	product_name TEXT,
	price FLOAT,
	product_desc TEXT,

	CONSTRAINT pk_product_id PRIMARY KEY(id),
	CONSTRAINT fk_product_id_type FOREIGN KEY(id_type) REFERENCES PRODUCT_TYPE(ID)
);
GO

CREATE TABLE STORAGE
(
	id_product INT,
	quantity INT,
	input_date DATE,

	CONSTRAINT pk_storage_id_product FOREIGN KEY(id_product) REFERENCES PRODUCT(id)
);
GO

CREATE TABLE PURCHASE_BILL
(
	id INT NOT NULL UNIQUE IDENTITY,
	id_staff INT,
	id_customer INT,
	date_of_purchase DATETIME,
	purchase_bill_desc TEXT,
	total_cost FLOAT,

	CONSTRAINT pk_purchase_bill_id PRIMARY KEY(id),
	CONSTRAINT fk_purchase_bill_id_staff FOREIGN KEY(id_staff) REFERENCES STAFF(id),
	CONSTRAINT fk_purchase_bill_id_customer FOREIGN KEY(id_customer) REFERENCES CUSTOMER(id)
);
GO

CREATE TABLE PURCHASE_BILL_DETAIL
(
	id_bill INT,
	id_product INT,
	quantity INT,
	cost FLOAT,

	CONSTRAINT fk_purchase_bill_detail_id_bill FOREIGN KEY(id_bill) REFERENCES PURCHASE_BILL(id),
	CONSTRAINT fk_purchase_bill_detail_id_product FOREIGN KEY(id_product) REFERENCES PRODUCT(id),
);
GO