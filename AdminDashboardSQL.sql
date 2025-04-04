/*
CREATE TABLE members (
    registration_date DATE NOT NULL,
    membership_id VARCHAR(8) PRIMARY KEY,
    title VARCHAR(5) NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    gender VARCHAR(6) NOT NULL,
    race VARCHAR(15) NOT NULL,
    birth_date DATE NOT NULL,
    phone_number VARCHAR(10),
    work_number VARCHAR(10),
    email_address VARCHAR(100),
    address_line1 VARCHAR(50),
    address_line2 VARCHAR (50),
    zone_area VARCHAR(50),
    postal_code VARCHAR(4),
    employment_status VARCHAR(50),
    occupation VARCHAR(100),
    marital_status VARCHAR(10),
    membership_status VARCHAR(10)
);
*/

/*
CREATE TABLE spouses (
    spouse_id int identity(1,1) PRIMARY KEY NOT NULL,
    membership_id VARCHAR(8) NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    maiden_name VARCHAR(50),
    last_name VARCHAR(50) NOT NULL,
    phone VARCHAR(10),
    email VARCHAR(100),
    gender VARCHAR(6) NOT NULL,
    race VARCHAR(15) NOT NULL,
    employment_status VARCHAR(20),
    occupation VARCHAR(100),
    spouse_religion VARCHAR(50),
    FOREIGN KEY (membership_id) REFERENCES members(membership_id)
);
*/
/*
create table dependents(
dependent_id int identity (1,1) primary key,
membership_id VARCHAR(8) NOT NULL,
first_name varchar(40),
last_name varchar (40),
gender varchar(6),
birth_date date,
school_grade varchar(12),
in_sunday_school varchar(3),
relationship varchar(20),
 FOREIGN KEY (membership_id) REFERENCES members(membership_id)
)
*/

/*
ALTER TABLE dependents
ADD CONSTRAINT uc_Dependents UNIQUE (first_name, last_name, birth_date);
*/

/*
CREATE TABLE departments (
    department_id INT identity(1,1) PRIMARY KEY not null,
    department_name VARCHAR(100) NOT NULL UNIQUE
);
*/

/*
INSERT INTO departments (department_name) VALUES 
('Administrator'), 
('Formation'), 
('Liturgical'), 
('Maintenance'), 
('Other'), 
('Pastoral'), 
('Social'), 
('Sodalities');
*/
/*
Create table sacramental_life (
sacramental_id int identity(1,1) primary key not null,
membership_id VARCHAR(8) NOT NULL,
is_baptised VARCHAR(3),
baptismal_number VARCHAR(20),
baptism_place VARCHAR(80),
baptism_year DATE,
father_name VARCHAR(60),
mother_name VARCHAR(60),
sponsor_name VARCHAR(60),
baptism_clergy_name VARCHAR(60),
communion_eucharist VARCHAR(3),
communion_place VARCHAR (80),
commuion_year DATE,
is_confirmed VARCHAR(3),
place_confirmed VARCHAR(80),
confirmation_clergy_name VARCHAR(60),
is_married VARCHAR(3),
place_married VARCHAR(80),
year_married DATE,
catholic_marriage VARCHAR(3),
marriage_clergy_name VARCHAR(60)
FOREIGN KEY (membership_id) REFERENCES members(membership_id)
);
*/

/*
CREATE TABLE activities (
    activity_id INT IDENTITY(1,1) PRIMARY KEY,
    membership_id VARCHAR(8) NOT NULL,
    department_name1 VARCHAR(60),
    activity_name1 VARCHAR(60),
    activity1_year_joined DATE,
    activity1_role VARCHAR(60),
    department_name2 VARCHAR(60),
    activity_name2 VARCHAR(60),
    activity2_year_joined DATE,
    activity2_role VARCHAR(60),
    department_name3 VARCHAR(60),
    activity_name3 VARCHAR(60),
    activity3_year_joined DATE,
    activity3_role VARCHAR(60),
    previous_exco_role VARCHAR(60),
    previous_role VARCHAR(60),
    year_of_previous_role DATE,
    FOREIGN KEY (membership_id) REFERENCES members(membership_id)
);
*/
/*
Create Table end_of_file (
eof_id int identity (1,1) Primary key,
membership_id VARCHAR(8) NOT NULL,
date_of_death DATE,
burial_date DATE,
burial_place VARCHAR(80),
recieved_viaticum VARCHAR(3),
next_of_kin VARCHAR(60),
phone_number VARCHAR(10),
burial_clergy_name VARCHAR(60),
FOREIGN KEY (membership_id) REFERENCES members(membership_id)
);
*/

/*
create table inventory (
    inventory_id int identity(1,1) primary key not null,
    item_name varchar(100) not null,
    item_quantity int not null,
    item_category varchar(50) not null,
    logged_date date not null
);
*/

/*
create table payment (
    payment_id int identity(1,1) primary key not null,
    membership_id varchar(8) not null,
    payment_date date not null,
    account_type varchar(50) not null,
    amount_total decimal(10,2) not null,
    amount_tendered varchar(50) not null,
    payment_method varchar(20),
    change_given decimal(10,2),
    FOREIGN KEY (membership_id) REFERENCES members(membership_id)
);
*/
/*
create table academic_history (
    academic_id int identity(1,1) primary key not null,
    membership_id varchar(8) not null,
    highest_qualification varchar(50) not null,
    year_obtained date not null,
    subjects_passed varchar(250) not null,
    field_of_study varchar(65) not null,
    FOREIGN KEY (membership_id) REFERENCES members(membership_id)
);*/

/*
create table bookings (
    booking_id int identity(1,1) primary key not null,
	first_name varchar(50),
    last_name varchar(50) not null,
	phone_number varchar(10) not null,
	email_address varchar(80),
    event_date date not null,
	event_venue varchar(250) not null,
    booking_type varchar(250) not null,
);

*/
/*
ALTER TABLE sacramental_life
ADD date_confirmed date;
*/




EXEC sp_rename 'activities.previous_exco_role', 'previous_role_is_exco', 'COLUMN';


