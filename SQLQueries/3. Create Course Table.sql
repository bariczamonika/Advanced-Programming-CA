USE StudentDB;
CREATE TABLE [dbo].[Course]
(
	[CourseID] INT NOT NULL PRIMARY KEY, 
    [CourseName] VARCHAR(50) NOT NULL, 
    [CourseDescription] VARCHAR(150) NULL,
	[StartDate] Date NOT NULL,
	[EndDate] Date NOT NULL,
	[TeacherID] INT,
	FOREIGN KEY ([TeacherID]) REFERENCES Teacher(TeacherID)
);
