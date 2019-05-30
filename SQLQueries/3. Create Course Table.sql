USE StudentDB;
CREATE TABLE [dbo].[Course]
(
	[CourseID] INT NOT NULL PRIMARY KEY, 
    [CourseName] VARCHAR(50) NOT NULL, 
    [CourseDescription] VARCHAR(150) NULL,
	[TeacherID] INT,
	FOREIGN KEY ([TeacherID]) REFERENCES Teacher(TeacherID)
);
