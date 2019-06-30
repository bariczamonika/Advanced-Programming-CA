USE StudentDB;
INSERT INTO Student (StudentID, FirstName, LastName, Country, County, City, AddressLine1, AddressLine2, Level, PhoneNumber, Email)
VALUES 
('10000010','Mickey', 'Mouse', 'Ireland', 'Dublin','Dublin','1 Disneyland Row', ' ', 'Undergraduate', '0894551515','mickey@mouse.com')
INSERT INTO Student (StudentID, FirstName, LastName, Country, County, City, AddressLine1, AddressLine2, Level, PhoneNumber, Email)
VALUES 
('10000011','Snow', 'White', 'Ireland', 'Cork', 'Cork', '15 Dwarf Square', ' ', 'Postgraduate', '0851245454', 'snow@white.com')
INSERT INTO Student (StudentID, FirstName, LastName, Country, County, City, AddressLine1, AddressLine2, Level, PhoneNumber, Email)
VALUES 
('10000012','Cinder', 'Ella', 'Ireland', 'Dublin', 'Dublin', '40 Orphan Street',' ', 'Undergraduate', '0874414411', 'cinder@ella.com')

INSERT INTO Teacher (TeacherID, FirstName, LastName, PhoneNumber, Email)
VALUES
('5', 'Marlon', 'Brando','0874451111','marlon@dbs.ie')
INSERT INTO Teacher (TeacherID, FirstName, LastName, PhoneNumber, Email)
VALUES
('6', 'Whitney', 'Houston', '0834445154', 'whitney@dbs.ie')
INSERT INTO Teacher (TeacherID, FirstName, LastName, PhoneNumber, Email)
VALUES
('7', 'Charles', 'Xavier', '0874451245', 'charles@dbs.ie')

INSERT INTO Course (CourseID, CourseName, CourseDescription, StartDate, EndDate, TeacherID)
VALUES
('110', 'Acting class', 'Superior acting class', '2019-10-10', '2019-12-20', '5')
INSERT INTO Course (CourseID, CourseName, CourseDescription, StartDate, EndDate, TeacherID)
VALUES
('111', 'Super abilities', 'Embrace your inner superhero', '2019-08-07', '2020-01-04', '7')
INSERT INTO Course (CourseID, CourseName, CourseDescription, StartDate, EndDate, TeacherID)
VALUES
('112', 'How to be a Godfather', 'All you need to know about connections', '2019-12-16', '2020-03-07', '5')

INSERT INTO CourseManagement(CourseID, StudentID, Cost)
VALUES
('110', '10000011', '300')
INSERT INTO CourseManagement(CourseID, StudentID, Cost)
VALUES
('110', '10000012', '300')
INSERT INTO CourseManagement(CourseID, StudentID, Cost)
VALUES
('112', '10000010', '500')
INSERT INTO CourseManagement(CourseID, StudentID, Cost)
VALUES
('111', '10000010', '200')