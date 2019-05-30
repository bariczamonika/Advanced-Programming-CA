USE StudentDB;
CREATE TABLE [dbo].[CourseManagement]
(
	[CourseID] INT NOT NULL, 
    [StudentID] INT NOT NULL, 
    [Cost] DECIMAL NULL,
	FOREIGN KEY ([CourseID]) REFERENCES Course(CourseID),
	FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
	CONSTRAINT pkCourseManagement PRIMARY KEY (CourseID, StudentID)
);