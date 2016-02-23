CREATE TABLE Person
(	ssid VARCHAR(20),
	name VARCHAR(35) NOT NULL,
	CONSTRAINT pk_PersonID PRIMARY KEY (ssid)
);

CREATE TABLE Student
(	ssid VARCHAR(20),
	studentid VARCHAR(20),
	CONSTRAINT pk_StudentID PRIMARY KEY (ssid)
);

CREATE TABLE Teacher
(	ssid VARCHAR(20),
	teacherid VARCHAR(20),
	CONSTRAINT pk_TeacherID PRIMARY KEY (ssid)
);

CREATE TABLE Course
(	cid VARCHAR(20),
	name VARCHAR(35) NOT NULL,
	CONSTRAINT pk_CourseID PRIMARY KEY (cid)
);

CREATE TABLE takes
(	studentid VARCHAR(20),
	cid VARCHAR(20),
	grade VARCHAR(2),
	CONSTRAINT pk_takesIDs PRIMARY KEY (studentid, cid),
	--FOREIGN KEY (cid) REFERENCES Course(cid)
);

CREATE TABLE Recitation
(	cid VARCHAR(20),
	name VARCHAR(35),
	CONSTRAINT pk_RecitationID PRIMARY KEY (cid, name),
	--FOREIGN KEY (cid) REFERENCES Course(cid)
);

CREATE TABLE SetProblems
(	cid VARCHAR(20),
	rName VARCHAR(35),
	name VARCHAR(35),
	noReq SMALLINT,
	description_ VARCHAR(256),
	CONSTRAINT pk_SetProblemID PRIMARY KEY (cid, rName, name),
	--FOREIGN KEY (rName) REFERENCES Recitation(name),
	--FOREIGN KEY (cid) REFERENCES Course(cid)
);

CREATE TABLE Problem
(	cid VARCHAR(20),
	rName VARCHAR(35),
	setName VARCHAR(35),
	name VARCHAR(35),
	description_ VARCHAR(256),
	CONSTRAINT pk_ProblemID PRIMARY KEY (cid, rName, setName, name),
	--FOREIGN KEY (rName) REFERENCES Recitation(name),
	--FOREIGN KEY (setName) REFERENCES setProblems(name),
	--FOREIGN KEY (cid) REFERENCES Course(cid)
);

CREATE TABLE Group_
(	cid VARCHAR(20),
	rName VARCHAR(35),
	name VARCHAR(35),
	location VARCHAR(64),
	date_ DATETIME,
	teacherid VARCHAR(20),
	CONSTRAINT pk_GroupID PRIMARY KEY (cid, rName, name),
	--FOREIGN KEY (rName) REFERENCES Recitation(name),
	--FOREIGN KEY (teacherid) REFERENCES Teacher(teacherid),
	--FOREIGN KEY (cid) REFERENCES Course(cid)
);

CREATE TABLE Score
(	cid VARCHAR(20),
	rName VARCHAR(35),
	gName VARCHAR(35),
	studentid VARCHAR(20),
	description_ VARCHAR(256),
	CONSTRAINT pk_ScoreID PRIMARY KEY (cid, rName, gName, studentid),
	--FOREIGN KEY (cid) REFERENCES Course(cid),
	--FOREIGN KEY (rName) REFERENCES Recitation(name),
	--FOREIGN KEY (gName) REFERENCES Group_(name),
	--FOREIGN KEY (studentid) REFERENCES Student(studentid)
);

BEGIN;
	INSERT INTO Person VALUES ('1', 'Fredrik H.');
	INSERT INTO Person VALUES ('2', 'Jonathan R.');
	INSERT INTO Person VALUES ('3', 'M. Minock');
	INSERT INTO Person VALUES ('4', 'Some Dude');
	INSERT INTO Person VALUES ('5', 'Göran A.');
	INSERT INTO Student VALUES ('1', 's1');
	INSERT INTO Student VALUES ('2', 's2');
	INSERT INTO Student VALUES ('4', 's3');
	INSERT INTO Teacher VALUES ('3', 't1');
	INSERT INTO Teacher VALUES ('5', 't2');

	INSERT INTO Course VALUES ('c1', 'data');
	INSERT INTO Course VALUES ('c2', 'base');

	INSERT INTO takes VALUES ('s1', 'c1', NULL);
	INSERT INTO takes VALUES ('s1', 'c2', NULL);
	INSERT INTO takes VALUES ('s2', 'c1', NULL);
	INSERT INTO takes VALUES ('s2', 'c2', NULL);
	INSERT INTO takes VALUES ('s3', 'c1', NULL);
	INSERT INTO takes VALUES ('s3', 'c2', NULL);

	---------------------------------------------

	INSERT INTO Recitation VALUES ('c1', 'Recitation 1');
	INSERT INTO Recitation VALUES ('c2', 'Recitation 1');
	INSERT INTO Recitation VALUES ('c1', 'Recitation 2');
	INSERT INTO Recitation VALUES ('c2', 'Recitation 2');
	INSERT INTO Recitation VALUES ('c2', 'Recitation 3');

	INSERT INTO SetProblems VALUES ('c1', 'Recitation 1', 'Problem 1', 2, 'answer at least 2 of the following queries in relational algebra:');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 1', 'a', 'Names of all the students');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 1', 'b', 'Names of the teachers teaching the course with id DD1368');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 1', 'c', 'Names of the student taking the course with id DD1368');

	INSERT INTO SetProblems VALUES ('c1', 'Recitation 1', 'Problem 2', 2, 'answer at least 2 of the following in relational algebra:');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 2', 'a', 'Names of students that have never scored an E in any course');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 2', 'b', 'Names of teachers who teach more than 1 course');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 2', 'c', 'Highest grade achieved in DD2471 (Note that ''>'' can compare grades (e.g. A > D) and that it is possible that no one got an A in the course');

	INSERT INTO SetProblems VALUES ('c1', 'Recitation 1', 'Problem 3', 3, 'answer at least 3 of 1a,1b,2a,2b,2c in tuple calculus:');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 3', '1a', '');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 3', '1b', '');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 3', '2a', '');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 3', '2b', '');
	INSERT INTO Problem VALUES ('c1', 'Recitation 1', 'Problem 3', '2c', '');

	
	INSERT INTO SetProblems VALUES ('c2', 'Recitation 2', 'Problem 1', 2, 'answer at least 2 of the following queries in relational algebra:');
	INSERT INTO Problem VALUES ('c2', 'Recitation 2', 'Problem 1', 'a', 'Names of all the students');
	INSERT INTO Problem VALUES ('c2', 'Recitation 2', 'Problem 1', 'b', 'Names of the teachers teaching the course with id DD1368');
	INSERT INTO Problem VALUES ('c2', 'Recitation 2', 'Problem 1', 'c', 'Names of the student taking the course with id DD1368');

	INSERT INTO SetProblems VALUES ('c2', 'Recitation 2', 'Problem 2', 2, 'answer at least 2 of the following in relational algebra:');
	INSERT INTO Problem VALUES ('c2', 'Recitation 2', 'Problem 2', 'a', 'Names of students that have never scored an E in any course');
	INSERT INTO Problem VALUES ('c2', 'Recitation 2', 'Problem 2', 'b', 'Names of teachers who teach more than 1 course');
	INSERT INTO Problem VALUES ('c2', 'Recitation 2', 'Problem 2', 'c', 'Highest grade achieved in DD2471 (Note that ''>'' can compare grades (e.g. A > D) and that it is possible that no one got an A in the course');


	INSERT INTO SetProblems VALUES ('c2', 'Recitation 1', 'Problem 1', 1, 'Fixa');
	INSERT INTO Problem VALUES ('c2', 'Recitation 1', 'Problem 1', 'a', 'Vad sa kycklingen när hen gick över vägen?');

	-----------------------------

	INSERT INTO Group_ VALUES ('c1', 'Recitation 1', 'A', 'I E nånstans', '2003-09-11 13:37:00', 't1');
	INSERT INTO Group_ VALUES ('c1', 'Recitation 1', 'B', 'I D nånstans', '2003-09-11 13:37:02', 't2');
	INSERT INTO Group_ VALUES ('c2', 'Recitation 1', 'A', 'I E nånstans', '2103-09-11 13:37:00', 't1');
	INSERT INTO Group_ VALUES ('c2', 'Recitation 1', 'B', 'I D nånstans', '2103-09-11 13:37:02', 't2');
	INSERT INTO Group_ VALUES ('c2', 'Recitation 1', 'C', 'I D nånstans', '2013-09-12 13:37:02', 't2');
	INSERT INTO Group_ VALUES ('c2', 'Recitation 2', 'A', 'I tyskland', '2103-09-17 13:37:00', 't1');
	INSERT INTO Group_ VALUES ('c2', 'Recitation 2', 'B', 'I D nånstans', '2303-09-17 13:37:02', 't2');
	INSERT INTO Group_ VALUES ('c2', 'Recitation 2', 'C', 'Var ni vill', '2103-09-17 15:37:02', 't2');
END;