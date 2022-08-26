using System;

namespace StudentEnrollment
{
    record Enrollment(int StudentID, string CourseName, DateOnly DateEnrolled);
}
