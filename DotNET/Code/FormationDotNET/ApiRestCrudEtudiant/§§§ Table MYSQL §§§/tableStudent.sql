CREATE TABLE students
( 
	id INT NOT NULL AUTO_INCREMENT ,
	gender VARCHAR(50) NOT NULL ,
	firstName VARCHAR(250) NOT NULL ,
	lastName VARCHAR(250) NOT NULL ,
	email VARCHAR(250) NOT NULL ,
	student_number INT NOT NULL ,
	PRIMARY KEY (id)
);