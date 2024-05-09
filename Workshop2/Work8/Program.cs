// See https://aka.ms/new-console-template for more information

using Work8;

IStudent student = new Student();
student.Name = "Gülsüm";
student.StudentNumber = 1232;
student.AddGrade("Math", 90);
student.AddGrade("Physics", 85);
student.AddGrade("Chemistry", 88);


student.PrintTranscript();
