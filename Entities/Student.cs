using System;

namespace Exercise_set.Entities {
    class Student {
        public int StudentNumber { get; set; }

        public Student(int studentNumber) {
            StudentNumber = studentNumber;
        }

        public override int GetHashCode() {
            return StudentNumber.GetHashCode();
        }

        public override bool Equals(object obj) {
            if(!(obj is Student)) {
                return false;
            }
            Student other = obj as Student;
            return StudentNumber.Equals(other.StudentNumber);
        }


    }
}
